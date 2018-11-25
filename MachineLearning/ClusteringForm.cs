using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Distributions.DensityKernels;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Kernels;

namespace MachineLearning
{
    public partial class ClusteringForm : Form
    {
        //Enum
        private enum Model { KMeans, BalancedKMeans, BinarySplit, KMedoids, KModes, MeanShift, GaussianMixture}

        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private Model model;
        private object clusters;

        private bool dataLoaded = false;

        //Constructor
        public ClusteringForm(string model, DataTable inputData, string[] inputColumnNames)
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
            inputDataGridView.DataSource = this.inputData;

            if (inputColumnNames.Length < 2)
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
            switch (model)
            {
                case "k-Means":
                    kMeansRadioButton.Checked = true;
                    break;
                case "Balanced k-Means":
                    kMeansRadioButton.Checked = true;
                    kMeansBalancedCheckBox.Checked = true;
                    break;
                case "Binary Split":
                    binarySplitRadioButton.Checked = true;
                    break;
                case "k-Medoids":
                    kMedoidsRadioButton.Checked = true;
                    break;
                case "k-Modes":
                    kModesRadioButton.Checked = true;
                    break;
                case "Mean-Shift":
                    meanShiftRadioButton.Checked = true;
                    break;
                case "Gaussian Mixture":
                    gaussianMixtureRadioButton.Checked = true;
                    break;
            }
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

        private void modelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            kMeansKNumericUpDown.Enabled = kMeansRadioButton.Checked;
            kMeansBalancedCheckBox.Enabled = kMeansRadioButton.Checked;
            binarySplitKNumericUpDown.Enabled = binarySplitRadioButton.Checked;
            kMedoidsKNumericUpDown.Enabled = kMedoidsRadioButton.Checked;
            kModesKNumericUpDown.Enabled = kModesRadioButton.Checked;
            meanShiftRadiusNumericUpDown.Enabled = meanShiftRadioButton.Checked;
            gaussianNumericUpDown.Enabled = gaussianMixtureRadioButton.Checked;
        }

        private void createClustersButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Creating clusters...";

            object clusterer = null;
            if (kMeansRadioButton.Checked)
            {
                if (kMeansBalancedCheckBox.Checked)
                {
                    clusterer = new BalancedKMeans((int)kMeansKNumericUpDown.Value)
                    {
                        MaxIterations = 1000,
                    };
                    clusters = ((BalancedKMeans)clusterer).Learn(inputData.ToMatrix().ToJagged());
                    model = Model.BalancedKMeans;
                }
                else
                {
                    clusterer = new KMeans((int)kMeansKNumericUpDown.Value);
                    clusters = ((KMeans)clusterer).Learn(inputData.ToMatrix().ToJagged());
                    model = Model.KMeans;
                }
            }
            else if (binarySplitRadioButton.Checked)
            {
                clusterer = new BinarySplit((int)binarySplitKNumericUpDown.Value);
                clusters = ((BinarySplit)clusterer).Learn(inputData.ToMatrix().ToJagged());
                model = Model.BinarySplit;
            }
            else if (kMedoidsRadioButton.Checked)
            {
                clusterer = new KMedoids((int)kMeansKNumericUpDown.Value);
                clusters = ((KMedoids)clusterer).Learn(inputData.ToMatrix().ToJagged());
                model = Model.KMedoids;
            }
            else if (kModesRadioButton.Checked)
            {
                clusterer = new KModes((int)kModesKNumericUpDown.Value);
                clusters = ((KModes)clusterer).Learn(inputData.ToMatrix().ToJagged().ToInt32());
                model = Model.KModes;
            }
            else if (meanShiftRadioButton.Checked)
            {
                GaussianKernel kernel = new GaussianKernel(2);
                clusterer = new MeanShift()
                {
                    Kernel = kernel,
                    Bandwidth = (double)meanShiftRadiusNumericUpDown.Value
                };
                clusters = ((MeanShift)clusterer).Learn(inputData.ToMatrix().ToJagged());
                model = Model.MeanShift;
            }
            else if (gaussianMixtureRadioButton.Checked)
            {
                clusterer = new GaussianMixtureModel((int)gaussianNumericUpDown.Value)
                {
                    Options = new NormalOptions()
                    {
                        Regularization = 1e-10
                    }
                };
                clusters = ((GaussianMixtureModel)clusterer).Learn(inputData.ToMatrix().ToJagged());
                model = Model.GaussianMixture;
            }

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

            Cursor = Cursors.Arrow;
            toolStripStatusLabel.Text = "Clusters created!";
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
            int[] outputColumn = null;

            // Compute cluster decisions for each point
            switch (model)
            {
                case Model.KMeans:
                case Model.BalancedKMeans:
                    outputColumn = ((KMeansClusterCollection)clusters).Decide(inputData.ToMatrix().ToJagged());
                    break;
                case Model.BinarySplit:
                    outputColumn = ((KMeansClusterCollection)clusters).Decide(inputData.ToMatrix().ToJagged());
                    break;
                case Model.KMedoids:
                    outputColumn = ((KMedoidsClusterCollection<double>)clusters).Decide(inputData.ToMatrix().ToJagged());
                    break;
                case Model.KModes:
                    outputColumn = ((KModesClusterCollection<int>)clusters).Decide(inputData.ToMatrix().ToJagged().ToInt32());
                    break;
                case Model.MeanShift:
                    outputColumn = ((MeanShiftClusterCollection)clusters).Decide(inputData.ToMatrix().ToJagged());
                    break;
                case Model.GaussianMixture:
                    outputColumn = ((GaussianClusterCollection)clusters).Decide(inputData.ToMatrix().ToJagged());
                    break;
            }

            string[] groupColumn = new string[outputColumn.Length];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
                groupColumn[rowIndex] = (outputColumn[rowIndex]).ToString();

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
            double[] result = null;
            switch (model)
            {
                case Model.KMeans:
                case Model.BalancedKMeans:
                    result = ((KMeansClusterCollection)clusters).Decide(map).ToDouble();
                    break;
                case Model.BinarySplit:
                    result = ((KMeansClusterCollection)clusters).Decide(map).ToDouble();
                    break;
                case Model.KMedoids:
                    result = ((KMedoidsClusterCollection<double>)clusters).Decide(map).ToDouble();
                    break;
                case Model.KModes:
                    clustersScatterplotView.Graph.GraphPane.CurveList.Clear();
                    clustersScatterplotView.Graph.GraphPane.GraphObjList.Clear();
                    clustersScatterplotView.Invalidate();
                    return;
                case Model.MeanShift:
                    result = ((MeanShiftClusterCollection)clusters).Decide(map).ToDouble();
                    break;
                case Model.GaussianMixture:
                    result = ((GaussianClusterCollection)clusters).Decide(map).ToDouble();
                    break;
            }
            
            double[,] surface = map.ToMatrix().InsertColumn(result);
            clustersScatterplotView.DataSource = surface;
        }
    }
}
