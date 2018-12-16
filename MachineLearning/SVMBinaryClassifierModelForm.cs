using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord;
using Accord.Controls;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;
using ZedGraph;

namespace MachineLearning
{
    public partial class SVMBinaryClassifierModelForm : Form
    {
        //Enum
        private enum LearningMethod { SequentialMinimalOptimization, LeastSquares, LinearCoordinateDescent, LinearDualCoordinateDescent,
            LinearNewton, ProbabilisticCoordinateDescent, ProbabilisticDualCoordinateDescent, ProbabilisticNewton,
            StochasticGradientDescent, AveragedStochasticGradientDescent }

        //Field
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private bool[] outputBooleanColumn;
        private string outputColumnName;
        private string[] outputValues;
        private string[] computedOutputs;

        private LearningMethod learningMethod;
        private object svm;
        private int[] learningIndexes;
        private int[] testingIndexes;
        private double[][] supportVectors;
        private int[] supportVectorsIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public SVMBinaryClassifierModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            outputColumn = inputData.Columns[outputColumnName].ToArray<string>();
            outputValues = outputColumn.Distinct().OrderBy(x => x).ToArray();
            outputBooleanColumn = new bool[outputColumn.Length];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
                if (outputColumn[rowIndex] == outputValues[0])
                    outputBooleanColumn[rowIndex] = true;
                else
                    outputBooleanColumn[rowIndex] = false;

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
            if (numberOfInputFields < 2)
                inputDataVisualizationGroupBox.Enabled = false;
            else
                inputDataVisualizationGroupBox.Enabled = true;
            foreach (string inputColumnName in inputColumnNames)
            {
                inputDataXComboBox.Items.Add(inputColumnName);
                inputDataYComboBox.Items.Add(inputColumnName);
            }
            inputDataXComboBox.SelectedIndex = 0;
            if (inputDataYComboBox.Items.Count > 1)
                inputDataYComboBox.SelectedIndex = 1;
            else
                inputDataYComboBox.SelectedIndex = 0;
            ShowInputDataScatterPlot();

            //Tab learning
            methodComboBox.SelectedIndex = 0;
            learningFromNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Value = inputData.Rows.Count;
            foreach (string inputColumnName in inputColumnNames)
            {
                learningXComboBox.Items.Add(inputColumnName);
                learningYComboBox.Items.Add(inputColumnName);
            }
            learningXComboBox.SelectedIndex = 0;
            if (learningYComboBox.Items.Count > 1)
                learningYComboBox.SelectedIndex = 1;
            else
                learningYComboBox.SelectedIndex = 0;

            //Tab support vectors
            foreach (string inputColumnName in inputColumnNames)
            {
                supportVectorsXComboBox.Items.Add(inputColumnName);
                supportVectorsYComboBox.Items.Add(inputColumnName);
            }
            supportVectorsXComboBox.SelectedIndex = 0;
            if (supportVectorsYComboBox.Items.Count > 1)
                supportVectorsYComboBox.SelectedIndex = 1;
            else
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
            testingFromNumericUpDown.Maximum = inputData.Rows.Count;
            testingToNumericUpDown.Maximum = inputData.Rows.Count;
            testingToNumericUpDown.Value = inputData.Rows.Count;

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
            {
                testingXComboBox.Items.Add(inputColumnName);
                testingYComboBox.Items.Add(inputColumnName);
            }
            testingXComboBox.SelectedIndex = 0;
            if (testingYComboBox.Items.Count > 1)
                testingYComboBox.SelectedIndex = 1;
            else
                testingYComboBox.SelectedIndex = 0;
            
            dataLoaded = true;
        }

        private void inputDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !dataLoaded)
                return;

            ShowInputDataScatterPlot();
        }

        private void ShowInputDataScatterPlot()
        {
            double[] xAxis = inputData.Columns[inputDataXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis = inputData.Columns[inputDataYComboBox.SelectedItem.ToString()].ToArray();
            Program.ShowScatterPlot(inputDataZedGraphControl, xAxis, yAxis, outputColumn,
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
            int fromRowIndex = Convert.ToInt16(learningFromNumericUpDown.Value) - 1;
            int toRowIndex = Convert.ToInt16(learningToNumericUpDown.Value) - 1;
            if (fromRowIndex > toRowIndex)
            {
                MessageBox.Show(this, "Invalid data range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            learningIndexes = new int[toRowIndex - fromRowIndex + 1];
            for (int i = 0; i < toRowIndex - fromRowIndex + 1; i++)
                learningIndexes[i] = fromRowIndex + i;

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            svm = null;
            IKernel kernel = CreateKernel();
            try
            {
                switch (methodComboBox.SelectedItem.ToString())
                {
                    case "Sequential Minimal Optimization":
                        SequentialMinimalOptimization<IKernel> sequentialMinimalOptimization = new SequentialMinimalOptimization<IKernel>()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = kernel
                        };
                        svm = sequentialMinimalOptimization.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.SequentialMinimalOptimization;
                        break;
                    case "Least Squares":
                        LeastSquaresLearning leastSquaresLearning = new LeastSquaresLearning()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = kernel
                        };
                        svm = leastSquaresLearning.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.LeastSquares;
                        break;
                    case "Linear Coordinate Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearCoordinateDescent linearCoordinateDescent = new LinearCoordinateDescent()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = linearCoordinateDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.LinearCoordinateDescent;
                        break;
                    case "Linear Dual Coordinate Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Dual Coordinate Descent method can only use linear kernel!");
                        LinearDualCoordinateDescent linearDualCoordinateDescent = new LinearDualCoordinateDescent()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = linearDualCoordinateDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.LinearDualCoordinateDescent;
                        break;
                    case "Linear Newton":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearNewtonMethod linearNewtonMethod = new LinearNewtonMethod()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = linearNewtonMethod.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.LinearNewton;
                        break;
                    case "Probabilistic Coordinate Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                        ProbabilisticCoordinateDescent probabilisticCoordinateDescent = new ProbabilisticCoordinateDescent()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = probabilisticCoordinateDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.ProbabilisticCoordinateDescent;
                        break;
                    case "Probabilistic Dual Coordinate Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                        ProbabilisticDualCoordinateDescent probabilisticDualCoordinateDescent = new ProbabilisticDualCoordinateDescent()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = probabilisticDualCoordinateDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.ProbabilisticDualCoordinateDescent;
                        break;
                    case "Probabilistic Newton":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Newton method can only use linear kernel!");
                        ProbabilisticNewtonMethod probabilisticNewtonMethod = new ProbabilisticNewtonMethod()
                        {
                            Complexity = (double)complexityNumericUpDown.Value,
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                            NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = probabilisticNewtonMethod.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.ProbabilisticNewton;
                        break;
                    case "Stochastic Gradient Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Stochastic Gradient Descent method can only use linear kernel!");
                        StochasticGradientDescent stochasticGradientDescent = new StochasticGradientDescent()
                        {
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = stochasticGradientDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.StochasticGradientDescent;
                        break;
                    case "Averaged Stochastic Gradient Descent":
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Averaged Stochastic Gradient Descent method can only use linear kernel!");
                        AveragedStochasticGradientDescent averagedStochasticGradientDescent = new AveragedStochasticGradientDescent()
                        {
                            Tolerance = (double)toleranceNumericUpDown.Value,
                            Kernel = (Linear)kernel
                        };
                        svm = averagedStochasticGradientDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                        learningMethod = LearningMethod.AveragedStochasticGradientDescent;
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

            if (inputData.Columns.Count == 2)
                CreateSurface(learningXComboBox.SelectedItem.ToString(), learningYComboBox.SelectedItem.ToString());

            supportVectorsDataGridView.DataSource = null;
            supportVectorsZedGraphControl.GraphPane.CurveList.Clear();
            supportVectorsXComboBox.Enabled = false;
            supportVectorsYComboBox.Enabled = false;
            //Visualize for SMO and Least Squares learning
            if (learningMethod == LearningMethod.SequentialMinimalOptimization || learningMethod == LearningMethod.LeastSquares)
            {
                // Check if we got support vectors
                supportVectors = null;
                double[] weights = null;
                if (learningMethod == LearningMethod.SequentialMinimalOptimization)
                {
                    if (((SupportVectorMachine<IKernel>)svm).SupportVectors != null)
                    {
                        supportVectors = ((SupportVectorMachine<IKernel>)svm).SupportVectors;
                        weights = ((SupportVectorMachine<IKernel>)svm).Weights;
                    }
                }
                else //learningMethod == LearningMethod.LeastSquares
                {
                    if (((SupportVectorMachine<IKernel<double[]>, double[]>)svm).SupportVectors != null)
                    {
                        supportVectors = ((SupportVectorMachine<IKernel<double[]>, double[]>)svm).SupportVectors;
                        weights = ((SupportVectorMachine<IKernel<double[]>, double[]>)svm).Weights;
                    }
                }

                if (supportVectors != null && supportVectors.Length > 0)
                {
                    supportVectorsIndexes = new int[supportVectors.Length];
                    for (int i = 0; i < supportVectors.Length; i++)
                        supportVectorsIndexes[i] = inputColumns.Find(supportVector => supportVector == supportVectors[i])[0];

                    //Show support vectors on the Support Vectors tab page
                    string[][] supportVectorsWithWeights = new string[supportVectors.Length][];
                    for (int rowIndex = 0; rowIndex < supportVectorsWithWeights.Length; rowIndex++)
                    {
                        string[] supportVector = new string[inputColumnNames.Length];
                        supportVector = supportVectors[rowIndex].ToString(supportVector);
                        supportVectorsWithWeights[rowIndex] = supportVector.Concatenate(outputColumn[supportVectorsIndexes[rowIndex]]).Concatenate(weights[rowIndex].ToString());
                    }
                    string[] inputColumnNamesWithWeight = inputColumnNames.Concatenate(outputColumnName).Concatenate("Weight");
                    supportVectorsDataGridView.DataSource = new ArrayDataView(supportVectorsWithWeights, inputColumnNamesWithWeight);

                    //Show support vectors scatter plot
                    supportVectorsXComboBox.Enabled = true;
                    supportVectorsYComboBox.Enabled = true;
                    ShowSupportVectorsScatterPlot();
                }
            }

            testButton.Enabled = true;
            predictButton.Enabled = true;

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

        private void CreateSurface(string xAxisColumnName, string yAxisColumnName)
        {
            //Get the ranges for each variable (X and Y)
            double[] xAxis = inputData.Columns[xAxisColumnName].ToArray();
            double[] yAxis = inputData.Columns[yAxisColumnName].ToArray();

            //Generate a Cartesian coordinate system
            double[][] map = Matrix.Mesh(xAxis.Get(learningIndexes).GetRange(), 200, yAxis.Get(learningIndexes).GetRange(), 200);

            //Classify each point in the Cartesian coordinate system
            bool[] result = null;
            switch (learningMethod)
            {
                case LearningMethod.SequentialMinimalOptimization:
                    result = ((SupportVectorMachine<IKernel>)svm).Decide(map);
                    break;
                case LearningMethod.LeastSquares:
                    result = ((SupportVectorMachine<IKernel<double[]>, double[]>)svm).Decide(map);
                    break;
                case LearningMethod.LinearCoordinateDescent:
                case LearningMethod.LinearDualCoordinateDescent:
                case LearningMethod.LinearNewton:
                case LearningMethod.ProbabilisticCoordinateDescent:
                case LearningMethod.ProbabilisticDualCoordinateDescent:
                case LearningMethod.ProbabilisticNewton:
                case LearningMethod.StochasticGradientDescent:
                case LearningMethod.AveragedStochasticGradientDescent:
                    result = ((SupportVectorMachine)svm).Decide(map);
                    break;
            }

            double[,] surface = map.ToMatrix();

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = xAxisColumnName;
            graphPane.YAxis.Title.Text = yAxisColumnName;

            //Classification problem
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (int rowIndex = 0; rowIndex < result.Length; rowIndex++)
            {
                if (result[rowIndex])
                    list1.Add(surface[rowIndex, 0], surface[rowIndex, 1]);
                else
                    list2.Add(surface[rowIndex, 0], surface[rowIndex, 1]);
            }

            //Add the curve
            LineItem myCurve = graphPane.AddCurve(outputValues[0], list1, Color.Blue, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = graphPane.AddCurve(outputValues[1], list2, Color.Green, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);
            
            //Fill the background of the chart rect and pane
            graphPane.Fill = new Fill(Color.WhiteSmoke);

            learningZedGraphControl.AxisChange();
            learningZedGraphControl.Invalidate();
        }

        private void supportVectorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                yAxis[i] = supportVectors[i][inputColumnNames.IndexOf(supportVectorsYComboBox.SelectedItem.ToString())];
                groupColumn[i] = outputColumn[supportVectorsIndexes[i]];
            }
            Program.ShowScatterPlot(supportVectorsZedGraphControl, xAxis, yAxis, groupColumn,
                supportVectorsXComboBox.SelectedItem.ToString(), supportVectorsYComboBox.SelectedItem.ToString());
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int fromRowIndex = Convert.ToInt16(testingFromNumericUpDown.Value) - 1;
            int toRowIndex = Convert.ToInt16(testingToNumericUpDown.Value) - 1;
            if (fromRowIndex > toRowIndex)
            {
                MessageBox.Show(this, "Invalid data range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            testingIndexes = new int[toRowIndex - fromRowIndex + 1];
            for (int rowIndex = 0; rowIndex < toRowIndex - fromRowIndex + 1; rowIndex++)
                testingIndexes[rowIndex] = fromRowIndex + rowIndex;

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            bool[] computedBooleanOutputs = null;
            try
            {

                switch (learningMethod)
                {
                    case LearningMethod.SequentialMinimalOptimization:
                        computedBooleanOutputs = ((SupportVectorMachine<IKernel>)svm).Decide(inputColumns.Get(testingIndexes));
                        break;
                    case LearningMethod.LeastSquares:
                        computedBooleanOutputs = ((SupportVectorMachine<IKernel<double[]>, double[]>)svm).Decide(inputColumns.Get(testingIndexes));
                        break;
                    case LearningMethod.LinearCoordinateDescent:
                    case LearningMethod.LinearDualCoordinateDescent:
                    case LearningMethod.LinearNewton:
                    case LearningMethod.ProbabilisticCoordinateDescent:
                    case LearningMethod.ProbabilisticDualCoordinateDescent:
                    case LearningMethod.ProbabilisticNewton:
                    case LearningMethod.StochasticGradientDescent:
                    case LearningMethod.AveragedStochasticGradientDescent:
                        computedBooleanOutputs = ((SupportVectorMachine)svm).Decide(inputColumns.Get(testingIndexes));
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

            bool[] expectedOutputColumn = outputBooleanColumn;

            computedOutputs = new string[testingIndexes.Length];
            for (int rowIndex = 0; rowIndex < computedBooleanOutputs.Length; rowIndex++)
                if (computedBooleanOutputs[rowIndex])
                    computedOutputs[rowIndex] = outputValues[0];
                else
                    computedOutputs[rowIndex] = outputValues[1];

            testingDataGridView.Rows.Clear();
            int numberOfMatches = 0;
            foreach (DataRow row in this.inputData.Rows)
            {
                string[] cells = new string[inputColumnNames.Length + 2];
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                int rowIndex = this.inputData.Rows.IndexOf(row);
                if (testingIndexes.Contains(rowIndex))
                    cells[numberOfInputFields + 1] = computedOutputs[rowIndex - fromRowIndex].ToString();
                else
                    cells[numberOfInputFields + 1] = "(...)";
                testingDataGridView.Rows.Add(cells);

                if (cells[numberOfInputFields].ToString() == cells[numberOfInputFields + 1].ToString())
                    numberOfMatches++;
            }

            numberOfMatchesLabel.Text = "Number of matches: " + numberOfMatches.ToString() + "/" + testingIndexes.Length.ToString() +
                " (" + Math.Round(((double)numberOfMatches) * 100 / testingIndexes.Length, 2) + "%)";

            testingXComboBox.Enabled = true;
            testingYComboBox.Enabled = true;
            ShowTestingScatterPlot();

            toolStripStatusLabel.Text = "Test completed!";
            Cursor = Cursors.Arrow;
        }

        private void testingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !machineTrained)
                return;

            ShowTestingScatterPlot();
        }

        private void ShowTestingScatterPlot()
        {
            double[] xAxis = inputData.Columns[testingXComboBox.SelectedItem.ToString()].ToArray().Get(testingIndexes);
            double[] yAxis = inputData.Columns[testingYComboBox.SelectedItem.ToString()].ToArray().Get(testingIndexes);
            string[] groupColumn = outputColumn.Get(testingIndexes);
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                if (groupColumn[rowIndex] != computedOutputs[rowIndex])
                    groupColumn[rowIndex] = "Missed";
            Program.ShowScatterPlot(testingZedGraphControl, xAxis, yAxis, groupColumn,
                testingXComboBox.SelectedItem.ToString(), testingYComboBox.SelectedItem.ToString());
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            double[] inputValues = new double[predictionDataGridView.Columns.Count - 1];
            try
            {
                for (int columnIndex = 0; columnIndex < predictionDataGridView.Columns.Count - 1; columnIndex++)
                    inputValues[columnIndex] = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[columnIndex].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            bool output = false;
            try
            {
                switch (learningMethod)
                {
                    case LearningMethod.SequentialMinimalOptimization:
                        output = ((SupportVectorMachine<IKernel>)svm).Decide(inputValues);
                        break;
                    case LearningMethod.LeastSquares:
                        output = ((SupportVectorMachine<IKernel<double[]>, double[]>)svm).Decide(inputValues);
                        break;
                    case LearningMethod.LinearCoordinateDescent:
                    case LearningMethod.LinearDualCoordinateDescent:
                    case LearningMethod.LinearNewton:
                    case LearningMethod.ProbabilisticCoordinateDescent:
                    case LearningMethod.ProbabilisticDualCoordinateDescent:
                    case LearningMethod.ProbabilisticNewton:
                    case LearningMethod.StochasticGradientDescent:
                    case LearningMethod.AveragedStochasticGradientDescent:
                        output = ((SupportVectorMachine)svm).Decide(inputValues);
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

            if (output)
                predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = outputValues[0];
            else
                predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = outputValues[1];

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }

    }
}
