using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord;
using Accord.Controls;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;

namespace MachineLearning
{
    public partial class SVMRegressionModelForm : Form
    {
        //Enum
        private enum LearningMethod { SequentialMinimalOptimizationRegression, LinearRegressionCoordinateDescent, LinearRegressionNewton }

        //Field
        private DataTable inputData;
        private string[] inputColumnNames;

        private double[] outputColumn;
        private string outputColumnName;
        private double[] computedOutputs;

        private LearningMethod learningMethod;
        private object svm;
        private double[][] supportVectors;
        private int[] supportVectorsIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public SVMRegressionModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
        {
            InitializeComponent();

            //Load data
            this.inputData = inputData.Clone();
            this.inputColumnNames = inputColumnNames;
            foreach (DataRow row in inputData.Rows)
                this.inputData.ImportRow(row);
            for (int columnIndex = this.inputData.Columns.Count - 1; columnIndex >= 0; columnIndex--)
            {
                string columnName = this.inputData.Columns[columnIndex].ColumnName;
                if (!inputColumnNames.Contains(columnName))
                    this.inputData.Columns.RemoveAt(columnIndex);
            }

            this.outputColumnName = outputColumnName;
            outputColumn = inputData.Columns[outputColumnName].ToArray<double>();

            //Tab input data
            int numberOfInputFields = inputColumnNames.Length;
            foreach (string inputColumnName in inputColumnNames)
                inputDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            inputDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            string[] cells = new string[inputColumnNames.Length + 1];
            foreach (DataRow row in this.inputData.Rows)
            {
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                inputDataGridView.Rows.Add(cells);
            }
            if (inputColumnNames.Length == 1)
                inputDataXComboBox.Enabled = false;
            foreach (string inputColumnName in inputColumnNames)
                inputDataXComboBox.Items.Add(inputColumnName);
            inputDataXComboBox.SelectedIndex = 0;
            inputDataYComboBox.Items.Add(outputColumnName);
            inputDataYComboBox.SelectedIndex = 0;
            ShowInputDataScatterPlot();

            //Tab learning
            methodComboBox.SelectedIndex = 0;
            learningXComboBox.Items.Add(inputColumnNames[0]);
            learningXComboBox.SelectedIndex = 0;
            learningYComboBox.Items.Add(outputColumnName);
            learningYComboBox.SelectedIndex = 0;

            //Tab support vectors
            foreach (string inputColumnName in inputColumnNames)
                supportVectorsXComboBox.Items.Add(inputColumnName);
            supportVectorsXComboBox.SelectedIndex = 0;
            supportVectorsYComboBox.Items.Add(outputColumnName);
            supportVectorsYComboBox.SelectedIndex = 0;

            //Tab testing
            foreach (string inputColumnName in inputColumnNames)
                testingDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Expected Output)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            cells = new string[inputColumnNames.Length + 2];
            foreach (DataRow row in this.inputData.Rows)
            {
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                cells[numberOfInputFields + 1] = "(...)";
                testingDataGridView.Rows.Add(cells);
            }

            foreach (string inputColumnName in inputColumnNames)
                predictionDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            predictionDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            predictionDataGridView.Columns[inputColumnNames.Length].ReadOnly = true;
            cells = new string[inputColumnNames.Length + 1];
            for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                cells[columnIndex] = "";
            cells[inputColumnNames.Length] = "(...)";
            predictionDataGridView.Rows.Add(cells);

            foreach (string inputColumnName in inputColumnNames)
                testingXComboBox.Items.Add(inputColumnName);
            testingXComboBox.SelectedIndex = 0;
            testingYComboBox.Items.Add(outputColumnName);
            testingYComboBox.SelectedIndex = 0;
            
            dataLoaded = true;
        }

        private void inputDataXComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !dataLoaded)
                return;

            ShowInputDataScatterPlot();
        }

        private void ShowInputDataScatterPlot()
        {
            double[] xAxis = inputData.Columns[inputDataXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis = outputColumn;
            string[] groupColumn = new string[xAxis.Length];
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                groupColumn[rowIndex] = "Data";
            Program.ShowScatterPlot(inputDataZedGraphControl, xAxis, outputColumn, groupColumn,
                inputDataXComboBox.SelectedItem.ToString(), inputDataYComboBox.SelectedItem.ToString());
        }

        private void kernelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gaussianSigmaNumericUpDown.Enabled = gaussianKernelRadioButton.Checked;
            gaussianEstimateButton.Enabled = gaussianKernelRadioButton.Checked;
            polynomialDegreeNumericUpDown.Enabled = polynomialKernelRadioButton.Checked;
            polynomialConstantNumericUpDown.Enabled = polynomialKernelRadioButton.Checked;
            laplacianSigmaNumericUpDown.Enabled = laplacianKernelRadioButton.Checked;
            laplacianEstimateButton.Enabled = laplacianKernelRadioButton.Checked;
            sigmoidAlphaNumericUpDown.Enabled = sigmoidKernelRadioButton.Checked;
            sigmoidEstimateButton.Enabled = sigmoidKernelRadioButton.Checked;
            sigmoidConstantNumericUpDown.Enabled = sigmoidKernelRadioButton.Checked;
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            DoubleRange range;
            Gaussian gaussian = Gaussian.Estimate(inputColumns, inputColumns.Length, out range);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            DoubleRange range;
            Laplacian laplacian = Laplacian.Estimate(inputColumns, inputColumns.Length, out range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            DoubleRange range;
            Sigmoid sigmoid = Sigmoid.Estimate(inputColumns, inputColumns.Length, out range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }

        private void complexityEstimateButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            IKernel kernel = CreateKernel();
            complexityNumericUpDown.Value = (decimal)kernel.EstimateComplexity(inputColumns);
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            svm = null;
            IKernel kernel = CreateKernel();
            try
            {
                switch (methodComboBox.SelectedItem.ToString())
                {
                    case "Sequential Minimal Optimization Regression":
                        SequentialMinimalOptimizationRegression<IKernel> sequentialMinimalOptimizationRegression = new SequentialMinimalOptimizationRegression<IKernel>()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            Epsilon = (double)epsilonNumericUpDown.Value,
                            Kernel = kernel
                        };
                        svm = sequentialMinimalOptimizationRegression.Learn(inputColumns, outputColumn);
                        learningMethod = LearningMethod.SequentialMinimalOptimizationRegression;
                        break;
                    case "Linear Regression Coordinate Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearRegressionCoordinateDescent linearRegressionCoordinateDescent = new LinearRegressionCoordinateDescent()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            Epsilon = (double)epsilonNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = linearRegressionCoordinateDescent.Learn(inputColumns, outputColumn);
                        learningMethod = LearningMethod.LinearRegressionCoordinateDescent;
                        break;
                    case "Linear Regression Newton":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearRegressionNewtonMethod linearRegressionNewtonMethod = new LinearRegressionNewtonMethod()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            Epsilon = (double)epsilonNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = linearRegressionNewtonMethod.Learn(inputColumns, outputColumn);
                        learningMethod = LearningMethod.LinearRegressionNewton;
                        break;
                }
            }
            catch (ConvergenceException)
            {
                toolStripStatusLabel.Text = "Convergence could not be attained! The learned machine might still be usable.";
                Cursor = Cursors.Arrow;
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            testButton.Enabled = true;
            predictButton.Enabled = true;

            if (inputColumnNames.Length == 1)
                ShowFitCurve();

            supportVectorsDataGridView.DataSource = null;
            supportVectorsZedGraphControl.GraphPane.CurveList.Clear();
            supportVectorsXComboBox.Enabled = false;
            //Visualize for SMO regression
            if (learningMethod == LearningMethod.SequentialMinimalOptimizationRegression)
            {
                // Check if we got support vectors
                supportVectors = ((SupportVectorMachine<IKernel>)svm).SupportVectors;
                double[] weights = ((SupportVectorMachine<IKernel>)svm).Weights;

                if (supportVectors != null && supportVectors.Length > 0)
                {
                    supportVectorsIndexes = new int[supportVectors.Length];
                    for (int i = 0; i < supportVectors.Length; i++)
                        supportVectorsIndexes[i] = inputColumns.Find(supportVector => supportVector == supportVectors[i])[0];

                    // Show support vectors on the Support Vectors tab page
                    string[][] supportVectorsWithWeights = new string[supportVectors.Length][];
                    for (int rowIndex = 0; rowIndex < supportVectorsWithWeights.Length; rowIndex++)
                    {
                        string[] supportVector = new string[inputColumnNames.Length];
                        supportVector = supportVectors[rowIndex].ToString(supportVector);
                        supportVectorsWithWeights[rowIndex] = supportVector.Concatenate(outputColumn[supportVectorsIndexes[rowIndex]].ToString()).Concatenate(weights[rowIndex].ToString());
                    }
                    string[] inputColumnNamesWithWeight = inputColumnNames.Concatenate(outputColumnName).Concatenate("Weight");
                    supportVectorsDataGridView.DataSource = new ArrayDataView(supportVectorsWithWeights, inputColumnNamesWithWeight);

                    //Show support vectors scatter plot
                    supportVectorsXComboBox.Enabled = true;
                    ShowSupportVectorsScatterPlot();
                }
            }

            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;

            machineTrained = true;
        }

        private IKernel CreateKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);

            if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }

            if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);

            if (sigmoidKernelRadioButton.Checked)
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);

            else throw new Exception();
        }

        private void ShowFitCurve()
        {
            // Get the ranges for each variable (X and Y)
            DoubleRange range = inputData.Columns[learningXComboBox.SelectedItem.ToString()].ToArray().GetRange();
            double[][] map = Vector.Range(range, stepSize: 0.05).ToJagged();
            double[][] surface = null;
            switch (learningMethod)
            {
                case LearningMethod.SequentialMinimalOptimizationRegression:
                    surface = map.InsertColumn(((SupportVectorMachine<IKernel>)svm).Score(map));
                    break;
                case LearningMethod.LinearRegressionCoordinateDescent:
                case LearningMethod.LinearRegressionNewton:
                    surface = map.InsertColumn(((SupportVectorMachine)svm).Score(map));
                    break;
            }
            double[] xAxis = surface.GetColumn(0);
            double[] yAxis = surface.GetColumn(1);
            string[] groupColumn = new string[xAxis.Length];
            for (int i = 0; i < groupColumn.Length; i++)
                groupColumn[i] = "Fit curve";
            Program.ShowScatterPlot(learningZedGraphControl, xAxis, yAxis, groupColumn,
            supportVectorsXComboBox.SelectedItem.ToString(), supportVectorsYComboBox.SelectedItem.ToString());
        }

        private void supportVectorsXComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !machineTrained)
                return;

            ShowSupportVectorsScatterPlot();
        }

        private void ShowSupportVectorsScatterPlot()
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            int numberOfSupportVectors = supportVectors.Length;
            double[] xAxis = new double[numberOfSupportVectors];
            double[] yAxis = new double[numberOfSupportVectors];
            string[] groupColumn = new string[numberOfSupportVectors];
            for (int i = 0; i < numberOfSupportVectors; i++)
            {
                xAxis[i] = supportVectors[i][inputColumnNames.IndexOf(supportVectorsXComboBox.SelectedItem.ToString())];
                yAxis[i] = outputColumn[supportVectorsIndexes[i]];
                groupColumn[i] = "Support Vectors";
            }
            Program.ShowScatterPlot(supportVectorsZedGraphControl, xAxis, yAxis, groupColumn,
                supportVectorsXComboBox.SelectedItem.ToString(), supportVectorsYComboBox.SelectedItem.ToString());
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            computedOutputs = null;
            try
            {

                switch (learningMethod)
                {
                    case LearningMethod.SequentialMinimalOptimizationRegression:
                        computedOutputs = ((SupportVectorMachine<IKernel>)svm).Score(inputColumns);
                        break;
                    case LearningMethod.LinearRegressionCoordinateDescent:
                    case LearningMethod.LinearRegressionNewton:
                        computedOutputs = ((SupportVectorMachine)svm).Score(inputColumns);
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            int numberOfInputFields = inputColumnNames.Length;

            double[] expectedOutputColumn = outputColumn;

            testingDataGridView.Rows.Clear();
            foreach (DataRow row in this.inputData.Rows)
            {
                string[] cells = new string[inputColumnNames.Length + 2];
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                int rowIndex = this.inputData.Rows.IndexOf(row);
                cells[numberOfInputFields + 1] = Math.Round(computedOutputs[rowIndex], 4).ToString();
                testingDataGridView.Rows.Add(cells);
            }

            rSquareLabel.Text = "R² = " + Accord.Statistics.Tools.Determination(expectedOutputColumn, computedOutputs).ToString();

            if (inputColumnNames.Length > 1)
                testingXComboBox.Enabled = true;
            ShowTestingScatterPlot();

            toolStripStatusLabel.Text = "Test completed!";
            Cursor = Cursors.Arrow;
        }

        private void testingXComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !machineTrained)
                return;

            ShowTestingScatterPlot();
        }

        private void ShowTestingScatterPlot()
        {
            double[] xAxis = inputData.Columns[testingXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis1 = outputColumn;
            double[] yAxis2 = computedOutputs;
            string[] groupColumn = new string[xAxis.Length * 2];
            for (int rowIndex = 0; rowIndex < xAxis.Length; rowIndex++)
            {
                groupColumn[rowIndex] = "Expected";
                groupColumn[rowIndex + xAxis.Length] = "Computed";
            }
            Program.ShowScatterPlot(testingZedGraphControl, xAxis.Concatenate(xAxis), yAxis1.Concatenate(yAxis2), groupColumn,
                testingXComboBox.SelectedItem.ToString(), testingYComboBox.SelectedItem.ToString());
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            double[] inputValues = new double[predictionDataGridView.Columns.Count - 1];
            for (int columnIndex = 0; columnIndex < predictionDataGridView.Columns.Count - 1; columnIndex++)
                inputValues[columnIndex] = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[columnIndex].Value);

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double output = 0;
            try
            {
                switch (learningMethod)
                {
                    case LearningMethod.SequentialMinimalOptimizationRegression:
                        output = ((SupportVectorMachine<IKernel>)svm).Score(inputValues);
                        break;
                    case LearningMethod.LinearRegressionCoordinateDescent:
                    case LearningMethod.LinearRegressionNewton:
                        output = ((SupportVectorMachine)svm).Score(inputValues);
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = output.ToString();

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }
    }
}
