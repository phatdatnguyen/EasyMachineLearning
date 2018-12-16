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
    public partial class RBMModelForm : Form
    {        
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private RestrictedBoltzmannMachine rbm;

        private bool dataLoaded = false;
        
        //Delegates to enable async calls for setting controls properties
        private delegate void EnableCallback(bool enable);

        //Constructor
        public RBMModelForm(DataTable inputData, string[] inputColumnNames)
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

            //Tab input data
            int numberOfInputFields = inputColumnNames.Length;
            foreach (string inputColumnName in inputColumnNames)
                inputDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            string[] cells = new string[inputColumnNames.Length + 1];
            foreach (DataRow row in this.inputData.Rows)
            {
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
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

            //Tab clustering
            activationFunctionComboBox.SelectedIndex = 0;

            learningMethodComboBox.SelectedIndex = 0;

            foreach (string inputColumnName in inputColumnNames)
            {
                clusteringXComboBox.Items.Add(inputColumnName);
                clusteringYComboBox.Items.Add(inputColumnName);
            }
            clusteringXComboBox.SelectedIndex = 0;
            if (clusteringYComboBox.Items.Count > 1)
                clusteringYComboBox.SelectedIndex = 1;
            else
                clusteringYComboBox.SelectedIndex = 0;

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
            string[] groupColumn = new string[xAxis.Length];
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                groupColumn[rowIndex] = "Data";
            Program.ShowScatterPlot(inputDataZedGraphControl, xAxis, yAxis, groupColumn,
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

        private void createClustersButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Creating clusters...";

            //Create Restricted Boltzmann Machine
            int hiddenNeurons = (int)clustersNumericUpDown.Value;
            rbm = new RestrictedBoltzmannMachine(GetActivationFunction(), inputData.Columns.Count, hiddenNeurons);
            
            //Prepare learning data
            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            //Create teacher
            ContrastiveDivergenceLearning contrastiveDivergenceLearning = new ContrastiveDivergenceLearning(rbm)
            {
                Momentum = (double)momentumNumericUpDown.Value,
                LearningRate = (double)learningRateNumericUpDown.Value,
                Decay = (double)decayNumericUpDown.Value
            };

            //Loop
            int iterations = (int)iterationsNumericUpDown.Value;
            for (int iteration = 0; iteration < iterations; iteration++)
                contrastiveDivergenceLearning.RunEpoch(inputColumns);

            if (inputColumnNames.Length > 1)
            {
                clusteringXComboBox.Enabled = true;
                clusteringYComboBox.Enabled = true;
                if (inputColumnNames.Length == 2)
                    ShowClusters();
            }
            else
            {
                clusteringXComboBox.Enabled = false;
                clusteringYComboBox.Enabled = false;
            }
            ShowScatterPlot();

            ShowNetwork();

            Cursor = Cursors.Arrow;
            toolStripStatusLabel.Text = "Clusters created!";
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

        private void clusteringComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !dataLoaded)
                return;

            ShowScatterPlot();
        }

        private void ShowScatterPlot()
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            int[] computedClusterIndexes = new int[inputColumns.Length];
            for (int rowIndex = 0; rowIndex < inputColumns.Length; rowIndex++)
            {
                double[] outputs = rbm.Compute(inputColumns[rowIndex]);
                computedClusterIndexes[rowIndex] = outputs.IndexOf(outputs.Max());
            }

            string[] groupColumn = new string[computedClusterIndexes.Length];
            for (int rowIndex = 0; rowIndex < computedClusterIndexes.Length; rowIndex++)
                groupColumn[rowIndex] = (computedClusterIndexes[rowIndex]).ToString();

            double[] xAxis = inputData.Columns[clusteringXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis = inputData.Columns[clusteringYComboBox.SelectedItem.ToString()].ToArray();
            Program.ShowScatterPlot(outputZedGraphControl, xAxis, yAxis, groupColumn,
                inputDataXComboBox.SelectedItem.ToString(), inputDataYComboBox.SelectedItem.ToString());
        }

        private void ShowClusters()
        {
            // Get the ranges for each variable (X and Y)
            DoubleRange[] ranges = inputData.ToMatrix().GetRange(0);

            // Generate a Cartesian coordinate system
            double[][] map = Matrix.Mesh(ranges[0], 200, ranges[1], 200);

            // Classify each point in the Cartesian coordinate system
            double[] result = new double[map.Length];
            for (int rowIndex = 0; rowIndex < map.Length; rowIndex++)
            {
                double[] outputs = rbm.Compute(map[rowIndex]);
                result[rowIndex] = Convert.ToDouble(outputs.IndexOf(outputs.Max()));
            }

            double[,] surface = map.ToMatrix().InsertColumn(result);
            clustersScatterplotView.DataSource = surface;
        }

        private void ShowNetwork()
        {
            networkTreeView.Nodes.Clear();
            TreeNode root = networkTreeView.Nodes.Add("Network");

            TreeNode inputLayerNode = root.Nodes.Add("Input Layer");
            for (int neuronIndex = 0; neuronIndex < inputColumnNames.Length; neuronIndex++)
                inputLayerNode.Nodes.Add(inputColumnNames[neuronIndex]);

            StochasticLayer hiddenLayer = rbm.Hidden;
            TreeNode layerNode = root.Nodes.Add("Output Layer");
            layerNode.Tag = hiddenLayer;
            for (int neuronIndex = 0; neuronIndex < hiddenLayer.Neurons.Length; neuronIndex++)
            {
                TreeNode hiddenNeuronNode = layerNode.Nodes.Add(neuronIndex.ToString());
                hiddenNeuronNode.Tag = hiddenLayer.Neurons[neuronIndex];
            }
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
    }
}
