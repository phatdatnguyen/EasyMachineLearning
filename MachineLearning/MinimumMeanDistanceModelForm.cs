using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Kernels;
using ZedGraph;

namespace MachineLearning
{
    public partial class MinimumMeanDistanceModelForm : Form
    {
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private string[] outputGroupValues;
        private string[] computedOutputs;

        private MinimumMeanDistanceClassifier minimumMeanDistanceClassifier;
        private int[] learningIndexes;
        private int[] testingIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public MinimumMeanDistanceModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            int[] outputGroupIndexes = new int[outputColumn.Length];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
                outputGroupIndexes[rowIndex] = outputGroupValues.IndexOf(outputColumn[rowIndex]);

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            try
            {
                minimumMeanDistanceClassifier = new MinimumMeanDistanceClassifier();
                minimumMeanDistanceClassifier.Learn(inputColumns.Get(learningIndexes), outputGroupIndexes.Get(learningIndexes));
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

            testButton.Enabled = true;
            predictButton.Enabled = true;

            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;

            machineTrained = true;
        }

        private void CreateSurface(string xAxisColumnName, string yAxisColumnName)
        {
            //Get the ranges for each variable (X and Y)
            double[] xAxis = inputData.Columns[xAxisColumnName].ToArray();
            double[] yAxis = inputData.Columns[yAxisColumnName].ToArray();

            //Generate a Cartesian coordinate system
            double[][] map = Matrix.Mesh(xAxis.Get(learningIndexes).GetRange(), 200, yAxis.Get(learningIndexes).GetRange(), 200);

            //Classify each point in the Cartesian coordinate system
            int[] result = minimumMeanDistanceClassifier.Decide(map);

            double[,] surface = map.ToMatrix();

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            //Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = xAxisColumnName;
            graphPane.YAxis.Title.Text = yAxisColumnName;

            //Classification problem
            PointPairList[] listOfPointPairList = new PointPairList[outputGroupValues.Length];
            for (int groupIndex = 0; groupIndex < outputGroupValues.Length; groupIndex++)
            {
                listOfPointPairList[groupIndex] = new PointPairList();
            }

            for (int rowIndex = 0; rowIndex < result.Length; rowIndex++)
            {
                listOfPointPairList[result[rowIndex]].Add(surface[rowIndex, 0], surface[rowIndex, 1]);
            }

            //Add the curve
            for (int groupIndex = 0; groupIndex < outputGroupValues.Length; groupIndex++)
            {
                Color color;
                if (groupIndex < Program.DefaultColor.Length)
                    color = Program.DefaultColor[groupIndex];
                else
                    color = Program.RandomColor();
                LineItem myCurve = graphPane.AddCurve(outputGroupValues[groupIndex], listOfPointPairList[groupIndex], color, SymbolType.Diamond);
                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Border.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(color);
            }

            //Fill the background of the chart rect and pane
            graphPane.Fill = new Fill(Color.WhiteSmoke);

            learningZedGraphControl.AxisChange();
            learningZedGraphControl.Invalidate();
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

            int[] computedOutputsGroupIndexes;
            try
            {
                computedOutputsGroupIndexes = minimumMeanDistanceClassifier.Decide(inputColumns.Get(testingIndexes));
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            int numberOfInputFields = inputColumnNames.Length;
            int numberOfEntries = outputColumn.Length;

            string[] expectedOutputColumn = outputColumn;
            int[] expectedOutputGroupIndexes = new int[numberOfEntries];
            for (int rowIndex = 0; rowIndex < numberOfEntries; rowIndex++)
                expectedOutputGroupIndexes[rowIndex] = outputGroupValues.IndexOf(expectedOutputColumn[rowIndex]);

            computedOutputs = new string[toRowIndex - fromRowIndex + 1];
            for (int rowIndex = 0; rowIndex < computedOutputs.Length; rowIndex++)
                computedOutputs[rowIndex] = outputGroupValues[computedOutputsGroupIndexes[rowIndex]];

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

            int outputGroupIndex = -1;
            try
            {
                outputGroupIndex = minimumMeanDistanceClassifier.Decide(inputValues);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            string output = outputGroupValues[outputGroupIndex];
            predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = output;

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }
    }
}