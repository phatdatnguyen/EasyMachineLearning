using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Accord;
using Accord.Math;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Statistics.Kernels;

namespace MachineLearning
{
    public partial class ANNRegressionModelForm : Form
    {
        //Enum
        private enum LearningMethod { LevenbergMarquardt, Backpropagation, ResilientBackpropagation, ParallelResilientBackpropagation,
            Perceptron, DeltaRule }
        
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private double[] outputColumn;
        private double[] computedOutputs;

        private double learningRate;
        private int iterations;
        private bool useRegularization;
        private bool useNguyenWidrow;
        private bool useSameWeights;

        private Thread workerThread = null;
        private int iteration;
        private double error;
        private TimeSpan elapsed = TimeSpan.Zero;
        private volatile bool needToStop = false;

        private IActivationFunction activationFunction;
        private LearningMethod learningMethod;
        private ActivationNetwork ann;
        DoubleRange unitRange = new DoubleRange(-1, 1);
        DoubleRange[] inputRanges;
        DoubleRange outputRange;

        private bool dataLoaded = false;
        private bool machineTrained = false;
        
        //Delegates to enable async calls for setting controls properties
        private delegate void EnableCallback(bool enable);

        //Constructor
        public ANNRegressionModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            inputRanges = new DoubleRange[inputColumnNames.Length];
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                inputRanges[columnIndex] = this.inputData.Columns[inputColumnNames[columnIndex]].ToArray().GetRange();
            
            outputColumn = inputData.Columns[outputColumnName].ToArray<double>();
            outputRange = outputColumn.GetRange();

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
            activationFunctionComboBox.SelectedIndex = 0;

            int inputLayerRowIndex = networkStructureDataGridView.Rows.Add(new string[] { "Input", inputColumnNames.Length.ToString() });
            networkStructureDataGridView.Rows[inputLayerRowIndex].ReadOnly = true;
            int outputLayerRowIndex = networkStructureDataGridView.Rows.Add(new string[] { "Output", "1" });
            networkStructureDataGridView.Rows[outputLayerRowIndex].ReadOnly = true;
            networkStructureDataGridView.Rows.Add(new string[] { "Hidden 1", "10" });

            learningMethodComboBox.SelectedIndex = 0;

            if (inputColumnNames.Length == 1)
            {
                learningChart.AddDataSeries("data", Color.Red, Accord.Controls.Chart.SeriesType.Dots, 5);
                learningChart.AddDataSeries("solution", Color.Blue, Accord.Controls.Chart.SeriesType.Line, 1);

                learningChart.RangeX = new Range((float)inputRanges[0].Min, (float)inputRanges[0].Max);
                learningChart.UpdateDataSeries("data", this.inputData.ToMatrix().Concatenate(outputColumn));
                learningChart.UpdateDataSeries("solution", null);
            }

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

        private void activationFunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activationFunctionComboBox.SelectedIndex < 0)
                return;

            string function = activationFunctionComboBox.SelectedItem.ToString();
            alphaNumericUpDown.Enabled = function == "Bipolar Sigmoid" || function == "Sigmoid";
            lowerLimitNumericUpDown.Enabled = function == "Linear";
            upperLimitNumericUpDown.Enabled = function == "Linear";
        }

        private void nguyenWidrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sameWeightsCheckBox.Enabled = nguyenWidrowCheckBox.Checked;
        }

        private void addLayerButton_Click(object sender, EventArgs e)
        {
            int currentNumberOfLayers = networkStructureDataGridView.Rows.Count;
            networkStructureDataGridView.Rows.Add(new string[] { "Hidden " + (currentNumberOfLayers - 1).ToString(), "10" });
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            int currentNumberOfLayers = networkStructureDataGridView.Rows.Count;
            if (currentNumberOfLayers <= 2)
                return;

            networkStructureDataGridView.Rows.RemoveAt(currentNumberOfLayers - 1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            learningRate = (double)learningRateNumericUpDown.Value;
            useRegularization = bayesianRegularizationCheckBox.Checked;
            useNguyenWidrow = nguyenWidrowCheckBox.Checked;
            useSameWeights = sameWeightsCheckBox.Checked;
            iterations = (int)iterationsNumericUpDown.Value;
            activationFunction = GetActivationFunction();

            //Create multi-layer neural network
            int numberOfInputs = inputData.Columns.Count;
            int numberOfEntries = inputData.Rows.Count;
            int[] listOfNumberOfNeurons = new int[networkStructureDataGridView.Rows.Count - 1]; //Except input layer
            for (int layerIndex = 2; layerIndex < networkStructureDataGridView.Rows.Count; layerIndex++)
                listOfNumberOfNeurons[layerIndex - 2] = Convert.ToInt32(networkStructureDataGridView.Rows[layerIndex].Cells[1].Value); //Hidden layer
            listOfNumberOfNeurons[networkStructureDataGridView.Rows.Count - 2] = 1; //Output layer
            ann = new ActivationNetwork(activationFunction, numberOfInputs, listOfNumberOfNeurons);

            if (useNguyenWidrow)
            {
                if (useSameWeights)
                    Accord.Math.Random.Generator.Seed = 1;

                NguyenWidrow initializer = new NguyenWidrow(ann);
                initializer.Randomize();
            }

            switch (learningMethodComboBox.SelectedItem.ToString())
            {
                case "Levenberg-Marquardt":
                    learningMethod = LearningMethod.LevenbergMarquardt;
                    break;
                case "Backpropagation":
                    learningMethod = LearningMethod.Backpropagation;
                    break;
                case "Resilient Backpropagation":
                    learningMethod = LearningMethod.ResilientBackpropagation;
                    break;
                case "Parallel Resilient Backpropagation":
                    learningMethod = LearningMethod.ParallelResilientBackpropagation;
                    break;
                case "Perceptron":
                    if (listOfNumberOfNeurons.Length >= 2)
                    {
                        MessageBox.Show(this, "Perceptron learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    learningMethod = LearningMethod.Perceptron;
                    break;
                case "Delta Rule":
                    if (listOfNumberOfNeurons.Length >= 2)
                    {
                        MessageBox.Show(this, "Delta Rule learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    learningMethod = LearningMethod.DeltaRule;
                    break;
            }

            if (inputColumnNames.Length == 1)
                learningChart.UpdateDataSeries("solution", null);

            EnableControls(false);

            //Run worker thread
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();
        }

        //Enable/disable controls (safe for threading)
        private void EnableControls(bool enable)
        {
            if (InvokeRequired)
            {
                EnableCallback d = new EnableCallback(EnableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                startButton.Enabled = enable;
                stopButton.Enabled = !enable;

                testButton.Enabled = enable;
                predictButton.Enabled = enable;
            }
        }

        private void SearchSolution()
        {
            int numberOfInputs = inputData.Columns.Count;
            int numberOfEntries = inputData.Rows.Count;

            //Create teacher
            object annLearning = null;
            switch (learningMethod)
            {
                case LearningMethod.LevenbergMarquardt:
                    annLearning = new LevenbergMarquardtLearning(ann, useRegularization)
                    {
                        LearningRate = learningRate
                    };
                    break;
                case LearningMethod.Backpropagation:
                    annLearning = new BackPropagationLearning(ann)
                    {
                        LearningRate = learningRate
                    };
                    break;
                case LearningMethod.ResilientBackpropagation:
                    annLearning = new ResilientBackpropagationLearning(ann)
                    {
                        LearningRate = learningRate
                    };
                    break;
                case LearningMethod.ParallelResilientBackpropagation:
                    annLearning = new ParallelResilientBackpropagationLearning(ann);
                    break;
                case LearningMethod.Perceptron:
                    annLearning = new PerceptronLearning(ann)
                    {
                        LearningRate = learningRate
                    };
                    break;
                case LearningMethod.DeltaRule:
                    annLearning = new DeltaRuleLearning(ann)
                    {
                        LearningRate = learningRate
                    };
                    break;
            }

            //Iterations
            iteration = 1;

            Stopwatch stopwatch = Stopwatch.StartNew();

            //Prepare learning data
            double[][] inputMatrix = inputData.ToMatrix().ToJagged();
            double[][] inputColumns = new double[numberOfEntries][];
            for (int rowIndex = 0; rowIndex < numberOfEntries; rowIndex++)
            {
                inputColumns[rowIndex] = new double[inputColumnNames.Length];
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                    inputColumns[rowIndex][columnIndex] = inputMatrix[rowIndex][columnIndex].Scale(inputRanges[columnIndex], unitRange);
            }

            double[][] outputColumn = this.outputColumn.Scale(outputRange, unitRange).ToJagged();

            //Loop
            while (!needToStop)
            {
                //Run epoch of learning procedure
                switch (learningMethod)
                {
                    case LearningMethod.LevenbergMarquardt:
                        error = ((LevenbergMarquardtLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                    case LearningMethod.Backpropagation:
                        error = ((BackPropagationLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                    case LearningMethod.ResilientBackpropagation:
                        error = ((ResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                    case LearningMethod.ParallelResilientBackpropagation:
                        error = ((ParallelResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                    case LearningMethod.Perceptron:
                        error = ((PerceptronLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                    case LearningMethod.DeltaRule:
                        error = ((DeltaRuleLearning)annLearning).RunEpoch(inputColumns, outputColumn) / numberOfEntries;
                        break;
                }

                //2D Visualization
                double[,] solution = new double[numberOfEntries, 2];
                if (inputColumnNames.Length == 1)
                {
                    for (int rowIndex = 0; rowIndex < numberOfEntries; rowIndex++)
                    {
                        double x = inputColumns[rowIndex][0];
                        double y = ann.Compute(new double[] { x })[0];
                        solution[rowIndex, 0] = x.Scale(unitRange, inputRanges[0]);
                        solution[rowIndex, 1] = y.Scale(unitRange, outputRange);
                    }

                    learningChart.UpdateDataSeries("solution", solution);
                }

                //Increase current iteration
                iteration++;
                elapsed = stopwatch.Elapsed;

                UpdateStatus();

                //Check if we need to stop
                if ((iterations != 0) && (iteration > iterations))
                    break;
            }

            stopwatch.Stop();
            machineTrained = true;

            //Enable settings controls
            EnableControls(true);
            ShowNetwork();
        }

        private IActivationFunction GetActivationFunction()
        {
            switch (activationFunctionComboBox.SelectedItem.ToString())
            {
                case "Bipolar Sigmoid":
                    return new BipolarSigmoidFunction((double)alphaNumericUpDown.Value);
                case "Sigmoid":
                    return new SigmoidFunction((double)alphaNumericUpDown.Value);
                case "Linear":
                    return new LinearFunction(new DoubleRange((double)lowerLimitNumericUpDown.Value, (double)upperLimitNumericUpDown.Value));
                case "Rectified Linear":
                    return new RectifiedLinearFunction();
                case "Threshold":
                    return new ThresholdFunction();
                case "Identity":
                    return new IdentityFunction();
                default:
                    throw new Exception("No function selected!");
            }
        }

        private void UpdateStatus()
        {
            if (!iterationTextBox.InvokeRequired)
            {
                iterationTextBox.Text = iteration.ToString();
                errorTextBox.Text = error.ToString("N10");
                elapsedTextBox.Text = elapsed.ToString();
            }
            else
            {
                iterationTextBox.BeginInvoke(new Action(UpdateStatus));
            }
        }

        private void ShowNetwork()
        {
            if (!machineTrained)
                return;

            if (!networkTreeView.InvokeRequired)
            {
                networkTreeView.Nodes.Clear();
                TreeNode root = networkTreeView.Nodes.Add("Network");

                TreeNode inputLayerNode = root.Nodes.Add("Input Layer");
                for (int neuronIndex = 0; neuronIndex < inputColumnNames.Length; neuronIndex++)
                    inputLayerNode.Nodes.Add(inputColumnNames[neuronIndex]);

                for (int hiddenLayerIndex = 0; hiddenLayerIndex < ann.Layers.Length - 1; hiddenLayerIndex++)
                {
                    Layer hiddenLayer = ann.Layers[hiddenLayerIndex];
                    TreeNode layerNode = root.Nodes.Add("Hidden Layer " + (hiddenLayerIndex + 1).ToString());
                    layerNode.Tag = hiddenLayer;
                    for (int neuronIndex = 0; neuronIndex < hiddenLayer.Neurons.Length; neuronIndex++)
                    {
                        TreeNode hiddenNeuronNode = layerNode.Nodes.Add("Neuron " + (neuronIndex + 1).ToString());
                        hiddenNeuronNode.Tag = hiddenLayer.Neurons[neuronIndex];
                    }
                }

                Layer outputLayer = ann.Layers[ann.Layers.Length - 1];
                TreeNode outputLayerNode = root.Nodes.Add("Output Layer");
                outputLayerNode.Tag = outputLayer;
                for (int neuronIndex = 0; neuronIndex < outputLayer.Neurons.Length; neuronIndex++)
                {
                    TreeNode outputNeuronNode = outputLayerNode.Nodes.Add("Neuron " + (neuronIndex + 1).ToString());
                    outputNeuronNode.Tag = outputLayer.Neurons[neuronIndex];
                }
            }
            else
            {
                networkTreeView.BeginInvoke(new Action(ShowNetwork));
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            needToStop = true;
            while (!workerThread.Join(100))
                Application.DoEvents();
            workerThread = null;
        }

        private void networkTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            layerNameTextBox.Text = "";
            numberOfNeuronsTextBox.Text = "";
            numberOfInputsTextBox.Text = "";

            layerTextBox.Text = "";
            neuronTextBox.Text = "";
            weightsListBox.Items.Clear();
            outputTextBox.Text = "";

            if (e.Node.Text == "Input Layer")
            {
                layerNameTextBox.Text = "Input Layer";
                numberOfNeuronsTextBox.Text = inputColumnNames.Length.ToString();
            }

            if (e.Node.Parent != null && e.Node.Parent.Text == "Input Layer")
            {
                layerTextBox.Text = "Input Layer";
                neuronTextBox.Text = e.Node.Text;
            }

            if (e.Node.Tag == null)
                return;

            if (e.Node.Tag.GetType() == typeof(ActivationLayer))
            {
                Layer layer = (Layer)e.Node.Tag;
                layerNameTextBox.Text = e.Node.Text;
                numberOfNeuronsTextBox.Text = layer.Neurons.Length.ToString();
                numberOfInputsTextBox.Text = layer.InputsCount.ToString();
            }
            if (e.Node.Tag.GetType() == typeof(ActivationNeuron))
            {
                layerTextBox.Text = e.Node.Parent.Text;
                neuronTextBox.Text = e.Node.Text;
                Neuron neuron = (Neuron)e.Node.Tag;
                weightsListBox.Items.Clear();
                foreach (double weight in neuron.Weights)
                    weightsListBox.Items.Add(weight.ToString());
                outputTextBox.Text = neuron.Output.ToString();
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int numberOfEntry = inputData.Rows.Count;
            double[][] inputMatrix = inputData.ToMatrix().ToJagged();
            double[][] inputColumns = new double[numberOfEntry][];
            for (int rowIndex = 0; rowIndex < numberOfEntry; rowIndex++)
            {
                inputColumns[rowIndex] = new double[inputColumnNames.Length];
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                    inputColumns[rowIndex][columnIndex] = inputMatrix[rowIndex][columnIndex].Scale(inputRanges[columnIndex], unitRange);
            }

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            computedOutputs = new double[inputColumns.Length];
            try
            {
                for (int rowIndex = 0; rowIndex < inputColumns.Length; rowIndex++)
                    computedOutputs[rowIndex] = ann.Compute(inputColumns[rowIndex])[0].Scale(unitRange, outputRange);
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
                inputValues[columnIndex] = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[columnIndex].Value).Scale(inputRanges[columnIndex], unitRange);

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double output = 0;
            try
            {
                output = ann.Compute(inputValues)[0].Scale(unitRange, outputRange);
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

        private void ANNRegressionModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((workerThread != null) && (workerThread.IsAlive))
            {
                needToStop = true;
                while (!workerThread.Join(100))
                    Application.DoEvents();
            }
        }
    }
}
