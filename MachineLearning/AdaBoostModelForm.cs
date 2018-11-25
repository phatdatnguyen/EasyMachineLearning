using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord;
using Accord.MachineLearning.Boosting;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;

namespace MachineLearning
{
    public partial class AdaBoostModelForm : Form
    {
        //Enum
        private enum Model { DecisionTree, LogisticRegression, SupportVectorMachine };
        private enum SVMLearningMethod { SequentialMinimalOptimization, LeastSquares, LinearCoordinateDescent, LinearDualCoordinateDescent,
            LinearNewton, ProbabilisticCoordinateDescent, ProbabilisticDualCoordinateDescent, ProbabilisticNewton }

        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private bool[] outputBooleanColumn;
        private string[] outputValues;
        private string[] computedOutputs;

        private Model model;
        private SVMLearningMethod svmLearningMethod;
        private object boost;
        private int[] learningIndexes;
        private int[] testingIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public AdaBoostModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            logisticRegressionMethodComboBox.SelectedIndex = 0;
            svmMethodComboBox.SelectedIndex = 0;

            learningFromNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Value = inputData.Rows.Count;

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

        private void modelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            logisticRegressionMethodComboBox.Enabled = logisticRegressionRadioButton.Checked;
            regulationNumericUpDown.Enabled = logisticRegressionRadioButton.Checked;
            logisticRegressionMaxIterationNumericUpDown.Enabled = logisticRegressionRadioButton.Checked;
            logisticRegressionToleranceNumericUpDown.Enabled = logisticRegressionRadioButton.Checked;
            svmMethodComboBox.Enabled = svmRadioButton.Checked;
            kernelGroupBox.Enabled = svmRadioButton.Checked;
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
            for (int rowIndex = 0; rowIndex < toRowIndex - fromRowIndex + 1; rowIndex++)
                learningIndexes[rowIndex] = fromRowIndex + rowIndex;

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            try
            {
                if (decisionTreeRadioButton.Checked)
                {
                    AdaBoost<DecisionTree> adaBoost = new AdaBoost<DecisionTree>()
                    {
                        Learner = (p) => new C45Learning(),

                        // Train until:
                        MaxIterations = (int)maxIterationNumericUpDown.Value,
                        Tolerance = (double)toleranceNumericUpDown.Value
                    };

                    // Now, we can use the Learn method to learn a boosted classifier
                    boost = adaBoost.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                    model = Model.DecisionTree;
                }
                else if (logisticRegressionRadioButton.Checked)
                {
                    AdaBoost<LogisticRegression> adaBoost = new AdaBoost<LogisticRegression>()
                    {
                        // Train until:
                        MaxIterations = (int)maxIterationNumericUpDown.Value,
                        Tolerance = (double)toleranceNumericUpDown.Value
                    };
                    adaBoost.Learner = (p) => new IterativeReweightedLeastSquares<LogisticRegression>()
                    {
                        Tolerance = (double)toleranceNumericUpDown.Value,
                        MaxIterations = (int)maxIterationNumericUpDown.Value,
                        Regularization = (double)regulationNumericUpDown.Value
                    };

                    // Now, we can use the Learn method to learn a boosted classifier
                    boost = adaBoost.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                    model = Model.LogisticRegression;
                }
                else if (svmRadioButton.Checked)
                {
                    object adaBoost = null;
                    IKernel kernel = CreateKernel();
                    switch (svmMethodComboBox.SelectedItem.ToString())
                    {
                        case "Sequential Minimal Optimization":
                            adaBoost = new AdaBoost<SupportVectorMachine<IKernel>>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine<IKernel>>)adaBoost).Learner = (p) => new SequentialMinimalOptimization<IKernel>()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine<IKernel>>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.SequentialMinimalOptimization;
                            break;
                        case "Least Squares":
                            adaBoost = new AdaBoost<SupportVectorMachine<IKernel<double[]>, double[]>>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine<IKernel<double[]>, double[]>>)adaBoost).Learner = (p) => new LeastSquaresLearning()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine<IKernel<double[]>, double[]>>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.LeastSquares;
                            break;
                        case "Linear Coordinate Descent":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new LinearCoordinateDescent()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.LinearCoordinateDescent;
                            break;
                        case "Linear Dual Coordinate Descent":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Linear Dual Coordinate Descent method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new LinearDualCoordinateDescent()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.LinearDualCoordinateDescent;
                            break;
                        case "Linear Newton":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Linear Newton method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new LinearNewtonMethod()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.LinearNewton;
                            break;
                        case "Probabilistic Coordinate Descent":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new ProbabilisticCoordinateDescent()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.ProbabilisticCoordinateDescent;
                            break;
                        case "Probabilistic Dual Coordinate Descent":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Probabilistic Dual Coordinate Descent method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new ProbabilisticDualCoordinateDescent()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.ProbabilisticDualCoordinateDescent;
                            break;
                        case "Probabilistic Newton":
                            if (kernel.GetType() != typeof(Linear))
                                throw new Exception("Probabilistic Newton method can only use linear kernel!");
                            adaBoost = new AdaBoost<SupportVectorMachine>()
                            {
                                // Train until:
                                MaxIterations = (int)maxIterationNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value
                            };
                            ((AdaBoost<SupportVectorMachine>)adaBoost).Learner = (p) => new ProbabilisticNewtonMethod()
                            {
                                Complexity = (double)complexityNumericUpDown.Value,
                                Tolerance = (double)toleranceNumericUpDown.Value,
                                PositiveWeight = (double)positiveWeightNumericUpDown.Value,
                                NegativeWeight = (double)negativeWeightNumericUpDown.Value,
                                Kernel = (Linear)kernel
                            };
                            boost = ((AdaBoost<SupportVectorMachine>)adaBoost).Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                            svmLearningMethod = SVMLearningMethod.ProbabilisticNewton;
                            break;
                    }
                    model = Model.SupportVectorMachine;
                }
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

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            bool[] computedBooleanOutputs = null;
            try
            {
                switch (model)
                {
                    case Model.DecisionTree:
                        computedBooleanOutputs = ((Boost<DecisionTree>)boost).Decide(inputColumns.Get(testingIndexes));
                        break;
                    case Model.LogisticRegression:
                        computedBooleanOutputs = ((Boost<LogisticRegression>)boost).Decide(inputColumns.Get(testingIndexes));
                        break;
                    case Model.SupportVectorMachine:
                        switch (svmLearningMethod)
                        {
                            case SVMLearningMethod.SequentialMinimalOptimization:
                                computedBooleanOutputs = ((Boost<SupportVectorMachine<IKernel>>)boost).Decide(inputColumns.Get(testingIndexes));
                                break;
                            case SVMLearningMethod.LeastSquares:
                                computedBooleanOutputs = ((Boost<SupportVectorMachine<IKernel<double[]>, double[]>>)boost).Decide(inputColumns.Get(testingIndexes));
                                break;
                            case SVMLearningMethod.LinearCoordinateDescent:
                            case SVMLearningMethod.LinearDualCoordinateDescent:
                            case SVMLearningMethod.LinearNewton:
                            case SVMLearningMethod.ProbabilisticCoordinateDescent:
                            case SVMLearningMethod.ProbabilisticDualCoordinateDescent:
                            case SVMLearningMethod.ProbabilisticNewton:
                                computedBooleanOutputs = ((Boost<SupportVectorMachine>)boost).Decide(inputColumns.Get(testingIndexes));
                                break;
                        }
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
                    cells[numberOfInputFields + 1] = computedOutputs[rowIndex - fromRowIndex];
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
            for (int columnIndex = 0; columnIndex < predictionDataGridView.Columns.Count - 1; columnIndex++)
                inputValues[columnIndex] = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[columnIndex].Value);

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            bool output = false;
            try
            {
                //outputGroupIndex = knn.Decide(inputValues);
                switch (model)
                {
                    case Model.DecisionTree:
                        output = ((Boost<DecisionTree>)boost).Decide(inputValues);
                        break;
                    case Model.LogisticRegression:
                        output = ((Boost<LogisticRegression>)boost).Decide(inputValues);
                        break;
                    case Model.SupportVectorMachine:
                        switch (svmLearningMethod)
                        {
                            case SVMLearningMethod.SequentialMinimalOptimization:
                                output = ((Boost<SupportVectorMachine<IKernel>>)boost).Decide(inputValues);
                                break;
                            case SVMLearningMethod.LeastSquares:
                                output = ((Boost<SupportVectorMachine<IKernel<double[]>, double[]>>)boost).Decide(inputValues);
                                break;
                            case SVMLearningMethod.LinearCoordinateDescent:
                            case SVMLearningMethod.LinearDualCoordinateDescent:
                            case SVMLearningMethod.LinearNewton:
                            case SVMLearningMethod.ProbabilisticCoordinateDescent:
                            case SVMLearningMethod.ProbabilisticDualCoordinateDescent:
                            case SVMLearningMethod.ProbabilisticNewton:
                                output = ((Boost<SupportVectorMachine>)boost).Decide(inputValues);
                                break;
                        }
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