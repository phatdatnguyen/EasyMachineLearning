using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Accord;
using Accord.Math;
using Accord.Neuro;
using Accord.Neuro.ActivationFunctions;
using Accord.Neuro.Layers;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using Accord.Neuro.Neurons;
using Accord.Statistics.Kernels;

namespace MachineLearning
{
    public partial class DBNClassifierModelForm : Form
    {
        //Enum
        private enum LearningMethod { LevenbergMarquardt, Backpropagation, ResilientBackpropagation, ParallelResilientBackpropagation }

        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private string[] outputGroupValues;
        private int[][] outputIntegerColumns;
        private string[] computedOutputs;

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
        private DeepBeliefNetwork dbn;
        private int[] learningIndexes;
        private int[] testingIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;
        
        //Delegates to enable async calls for setting controls properties
        private delegate void EnableCallback(bool enable);

        //Constructor
        public DBNClassifierModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            outputGroupValues = outputColumn.Distinct().OrderBy(x => x).ToArray();
            outputIntegerColumns = new int[outputColumn.Length][];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
            {
                outputIntegerColumns[rowIndex] = new int[outputGroupValues.Length];
                for (int columnIndex = 0; columnIndex < outputGroupValues.Length; columnIndex++)
                    if (outputColumn[rowIndex] == outputGroupValues[columnIndex])
                        outputIntegerColumns[rowIndex][columnIndex] = 1;
                    else
                        outputIntegerColumns[rowIndex][columnIndex] = -1;
            }

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
            activationFunctionComboBox.SelectedIndex = 0;

            int inputLayerRowIndex = networkStructureDataGridView.Rows.Add(new string[] { "Input", inputColumnNames.Length.ToString() });
            networkStructureDataGridView.Rows[inputLayerRowIndex].ReadOnly = true;
            int outputLayerRowIndex = networkStructureDataGridView.Rows.Add(new string[] { "Output", outputGroupValues.Length.ToString() });
            networkStructureDataGridView.Rows[outputLayerRowIndex].ReadOnly = true;
            networkStructureDataGridView.Rows.Add(new string[] { "Hidden 1", "10" });

            learningMethodComboBox.SelectedIndex = 0;
            learningFromNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Value = inputData.Rows.Count;

            //Tab testing
            foreach (string inputColumnName in inputColumnNames)
                testingDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Expected Output)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            testingDataGridView.Columns.Add("OutputVector", "Output Vector\n[" + String.Join("; ", outputGroupValues) + "]");
            testingDataGridView.Columns[testingDataGridView.Columns.Count - 1].Width = 300;
            cells = new string[inputColumnNames.Length + 3];
            foreach (DataRow row in this.inputData.Rows)
            {
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                cells[numberOfInputFields + 1] = "(...)";
                cells[numberOfInputFields + 2] = "(...)";
                testingDataGridView.Rows.Add(cells);
            }
            testingFromNumericUpDown.Maximum = inputData.Rows.Count;
            testingToNumericUpDown.Maximum = inputData.Rows.Count;
            testingToNumericUpDown.Value = inputData.Rows.Count;

            foreach (string inputColumnName in inputColumnNames)
                predictionDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            predictionDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            predictionDataGridView.Columns[inputColumnNames.Length].ReadOnly = true;
            predictionDataGridView.Columns.Add("OutputVector", "Output Vector\n[" + String.Join("; ", outputGroupValues) + "]");
            predictionDataGridView.Columns[inputColumnNames.Length + 1].Width = 300;
            predictionDataGridView.Columns[inputColumnNames.Length + 1].ReadOnly = true;
            cells = new string[inputColumnNames.Length + 2];
            for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                cells[columnIndex] = "";
            cells[inputColumnNames.Length] = "(...)";
            cells[inputColumnNames.Length + 1] = "(...)";
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

        private void activationFunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activationFunctionComboBox.SelectedIndex < 0)
                return;

            string function = activationFunctionComboBox.SelectedItem.ToString();
            lowerLimitNumericUpDown.Enabled = function == "Gaussian";
            upperLimitNumericUpDown.Enabled = function == "Gaussian";
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

        private void nguyenWidrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sameWeightsCheckBox.Enabled = nguyenWidrowCheckBox.Checked;
        }

        private void startButton_Click(object sender, EventArgs e)
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

            learningRate = (double)learningRateNumericUpDown.Value;
            useRegularization = bayesianRegularizationCheckBox.Checked;
            useNguyenWidrow = nguyenWidrowCheckBox.Checked;
            useSameWeights = sameWeightsCheckBox.Checked;
            iterations = (int)iterationsNumericUpDown.Value;
            activationFunction = GetActivationFunction();

            //Create Deep Belief Network
            int[] listOfNumberOfNeurons = new int[networkStructureDataGridView.Rows.Count - 1]; //Except input layer
            for (int layerIndex = 2; layerIndex < networkStructureDataGridView.Rows.Count; layerIndex++)
                listOfNumberOfNeurons[layerIndex - 2] = Convert.ToInt32(networkStructureDataGridView.Rows[layerIndex].Cells[1].Value); //Hidden layer
            listOfNumberOfNeurons[networkStructureDataGridView.Rows.Count - 2] = Convert.ToInt32(networkStructureDataGridView.Rows[1].Cells[1].Value); //Output layer
            dbn = new DeepBeliefNetwork(GetActivationFunction(), inputData.Columns.Count, listOfNumberOfNeurons);

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
            }

            if (useNguyenWidrow)
            {
                if (useSameWeights)
                    Accord.Math.Random.Generator.Seed = 1;

                NguyenWidrow initializer = new NguyenWidrow(dbn);
                initializer.Randomize();
            }

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
            int numberOfEntries = learningIndexes.Length;

            //Prepare learning data
            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            //Create teacher
            DeepNeuralNetworkLearning dnnLearning = null;
            switch (learningMethod)
            {
                case LearningMethod.LevenbergMarquardt:
                    dnnLearning = new DeepNeuralNetworkLearning(dbn)
                    {
                        Algorithm = (ann, i) => new LevenbergMarquardtLearning(ann, useRegularization),
                        LayerCount = dbn.Layers.Length,
                        LayerIndex = 0
                    };
                    break;
                case LearningMethod.Backpropagation:
                    dnnLearning = new DeepNeuralNetworkLearning(dbn)
                    {
                        Algorithm = (ann, i) => new BackPropagationLearning(ann),
                        LayerCount = dbn.Layers.Length,
                        LayerIndex = 0
                    };
                    break;
                case LearningMethod.ResilientBackpropagation:
                    dnnLearning = new DeepNeuralNetworkLearning(dbn)
                    {
                        Algorithm = (ann, i) => new ResilientBackpropagationLearning(ann),
                        LayerCount = dbn.Layers.Length,
                        LayerIndex = 0
                    };
                    break;
                case LearningMethod.ParallelResilientBackpropagation:
                    dnnLearning = new DeepNeuralNetworkLearning(dbn)
                    {
                        Algorithm = (ann, i) => new ParallelResilientBackpropagationLearning(ann),
                        LayerCount = dbn.Layers.Length,
                        LayerIndex = 0
                    };
                    break;
            }
            
            //Iterations
            iteration = 1;
            Stopwatch stopwatch = Stopwatch.StartNew();

            DoubleRange[] ranges = inputData.ToMatrix().GetRange(0);
            double[][] map = null;
            if (numberOfInputs == 2 && outputGroupValues.Length == 2)
            {
                map = Matrix.Mesh(ranges[0], 200, ranges[1], 200);
            }

            //Loop
            while (!needToStop)
            {
                //Run epoch of learning procedure
                double[][] a = inputColumns.Get(learningIndexes);
                double[][] b = outputIntegerColumns.Get(learningIndexes).ToDouble();
                error = dnnLearning.RunEpoch(a, b) / numberOfEntries;

                //2D visualization
                if (numberOfInputs == 2 && outputGroupValues.Length == 2)
                {
                    int[] result = map.Apply(((ActivationNetwork)dbn).Compute).GetColumn(0).Apply(Math.Sign);
                    double[,] graph = map.ToMatrix().InsertColumn(result.ToDouble());
                    Invoke((Action)(() =>
                    {
                        learningScatterplotView.DataSource = graph;
                    }));
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

        private IStochasticFunction GetActivationFunction()
        {
            switch (activationFunctionComboBox.SelectedItem.ToString())
            {
                case "Gaussian":
                    return new GaussianFunction((double)alphaNumericUpDown.Value, new DoubleRange((double)lowerLimitNumericUpDown.Value, (double)upperLimitNumericUpDown.Value));
                case "Bernoulli":
                    return new BernoulliFunction((double)alphaNumericUpDown.Value);
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

                for (int hiddenLayerIndex = 0; hiddenLayerIndex < dbn.Layers.Length - 1; hiddenLayerIndex++)
                {
                    Layer hiddenLayer = dbn.Layers[hiddenLayerIndex];
                    TreeNode layerNode = root.Nodes.Add("Hidden Layer " + (hiddenLayerIndex + 1).ToString());
                    layerNode.Tag = hiddenLayer;
                    for (int neuronIndex = 0; neuronIndex < hiddenLayer.Neurons.Length; neuronIndex++)
                    {
                        TreeNode hiddenNeuronNode = layerNode.Nodes.Add("Neuron " + (neuronIndex + 1).ToString());
                        hiddenNeuronNode.Tag = hiddenLayer.Neurons[neuronIndex];
                    }
                }

                Layer outputLayer = dbn.Layers[dbn.Layers.Length - 1];
                TreeNode outputLayerNode = root.Nodes.Add("Output Layer");
                outputLayerNode.Tag = outputLayer;
                for (int neuronIndex = 0; neuronIndex < outputLayer.Neurons.Length; neuronIndex++)
                {
                    TreeNode outputNeuronNode = outputLayerNode.Nodes.Add(outputGroupValues[neuronIndex].ToString());
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

            if (e.Node.Tag.GetType() == typeof(StochasticLayer))
            {
                Layer layer = (Layer)e.Node.Tag;
                layerNameTextBox.Text = e.Node.Text;
                numberOfNeuronsTextBox.Text = layer.Neurons.Length.ToString();
                numberOfInputsTextBox.Text = layer.InputsCount.ToString();
            }
            if (e.Node.Tag.GetType() == typeof(StochasticNeuron))
            {
                layerTextBox.Text = e.Node.Parent.Text;
                neuronTextBox.Text = e.Node.Text;
                StochasticNeuron neuron = (StochasticNeuron)e.Node.Tag;
                weightsListBox.Items.Clear();
                foreach (double weight in neuron.Weights)
                    weightsListBox.Items.Add(weight.ToString());
                biasTextBox.Text = neuron.Threshold.ToString();
                outputTextBox.Text = neuron.Output.ToString();
            }
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

            double[][] outputs = new double[inputColumns.Get(testingIndexes).Length][];
            int[] computedGroupIndexes = new int[inputColumns.Get(testingIndexes).Length];
            try
            {
                for (int rowIndex = 0; rowIndex < inputColumns.Get(testingIndexes).Length; rowIndex++)
                {
                    outputs[rowIndex] = dbn.Compute(inputColumns.Get(testingIndexes)[rowIndex]);
                    computedGroupIndexes[rowIndex] = outputs[rowIndex].IndexOf(outputs[rowIndex].Max());
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

            string[] expectedOutputColumn = outputColumn;

            computedOutputs = new string[testingIndexes.Length];
            for (int rowIndex = 0; rowIndex < computedOutputs.Length; rowIndex++)
                computedOutputs[rowIndex] = outputGroupValues[computedGroupIndexes[rowIndex]];

            testingDataGridView.Rows.Clear();
            int numberOfMatches = 0;
            foreach (DataRow row in this.inputData.Rows)
            {
                string[] cells = new string[inputColumnNames.Length + 3];
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                int rowIndex = this.inputData.Rows.IndexOf(row);
                if (testingIndexes.Contains(rowIndex))
                {
                    cells[numberOfInputFields + 1] = computedOutputs[rowIndex - fromRowIndex].ToString();
                    string[] roundedOutputs = new string[outputs[rowIndex - fromRowIndex].Length];
                    for (int groupIndex = 0; groupIndex < roundedOutputs.Length; groupIndex++)
                        roundedOutputs[groupIndex] = Math.Round(outputs[rowIndex - fromRowIndex][groupIndex], 4).ToString();
                    cells[numberOfInputFields + 2] = "[" + String.Join("; ", roundedOutputs) + "]";
                }
                else
                {
                    cells[numberOfInputFields + 1] = "(...)";
                    cells[numberOfInputFields + 2] = "(...)";
                }
                
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
            double[] inputValues = new double[predictionDataGridView.Columns.Count - 2];
            try
            {
                for (int columnIndex = 0; columnIndex < predictionDataGridView.Columns.Count - 2; columnIndex++)
                    inputValues[columnIndex] = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[columnIndex].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double[] outputs = null;
            int computedGroupIndex;
            try
            {
                outputs = dbn.Compute(inputValues);
                computedGroupIndex = outputs.IndexOf(outputs.Max());
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 2].Value = outputGroupValues[computedGroupIndex];
            string[] roundedOutputs = new string[outputGroupValues.Length];
            for (int groupIndex = 0; groupIndex < roundedOutputs.Length; groupIndex++)
                roundedOutputs[groupIndex] = Math.Round(outputs[groupIndex], 4).ToString();
            predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = "[" + String.Join("; ", roundedOutputs) + "]";

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }

        private void DNNBinaryClassifierModelForm_FormClosing(object sender, FormClosingEventArgs e)
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
