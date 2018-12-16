using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.Math;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Linear;
using ZedGraph;

namespace MachineLearning
{
    public partial class LinearRegressionModelForm : Form
    {
        //Field
        private DataTable inputData;
        private string[] inputColumnNames;

        private double[] outputColumn;
        private string outputColumnName;
        private double[] computedOutputs;

        private MultipleLinearRegression multipleLinearRegression;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public LinearRegressionModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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

        private void learnButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            multipleLinearRegression = null;
            try
            {
                OrdinaryLeastSquares ordinaryLeastSquares = new OrdinaryLeastSquares()
                {
                    UseIntercept = !interceptEqualToZeroCheckBox.Checked
                };
                multipleLinearRegression = ordinaryLeastSquares.Learn(inputColumns, outputColumn);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            if (inputData.Columns.Count == 1)
                ShowFitCurve();

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "Intercept (b0)");
            double[] weights = multipleLinearRegression.Weights;
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), inputColumnNames[columnIndex] + " (b" + (columnIndex + 1).ToString() + ")");
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = multipleLinearRegression.Intercept.ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = weights[columnIndex].ToString();
            fittingDataGridView.Rows.Add(coefficents);

            testButton.Enabled = true;
            predictButton.Enabled = true;
            
            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;

            machineTrained = true;
        }

        private void ShowFitCurve()
        {
            double[] xAxis = inputData.Columns[0].ToArray();
            double[] yAxis = outputColumn;

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = inputColumnNames[0];
            graphPane.YAxis.Title.Text = outputColumnName;

            //Classification problem
            PointPairList list1 = new PointPairList();
            for (int rowIndex = 0; rowIndex < xAxis.Length; rowIndex++)
                list1.Add(xAxis[rowIndex], yAxis[rowIndex]);
            double[] xData = xAxis.GetRange().Range(0.05);
            double[] yData = multipleLinearRegression.Transform(xData.ToJagged());
            PointPairList list2 = new PointPairList();
            for (int rowIndex = 0; rowIndex < xData.Length; rowIndex++)
                list2.Add(xData[rowIndex], yData[rowIndex]);

            //Add the curve
            LineItem myCurve = graphPane.AddCurve("Input Data", list1, Color.Blue, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = graphPane.AddCurve("Fit curve", list2, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);

            //Fill the background of the chart rect and pane
            graphPane.Fill = new Fill(Color.WhiteSmoke);

            learningZedGraphControl.AxisChange();
            learningZedGraphControl.Invalidate();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            double[][] inputColumns = inputData.ToMatrix().ToJagged();

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            computedOutputs = null;
            try
            {
                computedOutputs = multipleLinearRegression.Transform(inputColumns);
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

            double output = 0;
            try
            {
                output = multipleLinearRegression.Transform(inputValues);
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
