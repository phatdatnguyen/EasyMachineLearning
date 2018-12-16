using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.Math;
using Accord.Statistics.Models.Regression.Linear;
using ZedGraph;

namespace MachineLearning
{
    public partial class PolynomialRegressionModelForm : Form
    {
        //Field
        private double[] inputColumn;
        private string inputColumnName;

        private double[] outputColumn;
        private string outputColumnName;
        private double[] computedOutputs;

        private PolynomialRegression polynomialRegression;

        //Constructor
        public PolynomialRegressionModelForm(DataTable inputData, string inputColumnName, string outputColumnName)
        {
            InitializeComponent();

            //Load data
            this.inputColumnName = inputColumnName;
            inputColumn = inputData.Columns[inputColumnName].ToArray<double>();

            this.outputColumnName = outputColumnName;
            outputColumn = inputData.Columns[outputColumnName].ToArray<double>();

            //Tab input data
            inputDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            inputDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            string[] cells = new string[2];
            foreach (DataRow row in inputData.Rows)
            {
                cells[0] = row[inputColumnName].ToString();
                cells[1] = row[outputColumnName].ToString();
                inputDataGridView.Rows.Add(cells);
            }
            inputDataXComboBox.Items.Add(inputColumnName);
            inputDataXComboBox.SelectedIndex = 0;
            inputDataYComboBox.Items.Add(outputColumnName);
            inputDataYComboBox.SelectedIndex = 0;
            ShowInputDataScatterPlot();

            //Tab learning
            methodComboBox.SelectedIndex = 0;
            learningXComboBox.Items.Add(inputColumnName);
            learningXComboBox.SelectedIndex = 0;
            learningYComboBox.Items.Add(outputColumnName);
            learningYComboBox.SelectedIndex = 0;
            
            //Tab testing
            testingDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Expected Output)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            foreach (DataRow row in inputData.Rows)
            {
                cells = new string[3];
                cells[0] = row[inputColumnName].ToString();
                cells[1] = row[outputColumnName].ToString();
                cells[2] = "(...)";
                testingDataGridView.Rows.Add(cells);
            }

            predictionDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            predictionDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            predictionDataGridView.Columns[1].ReadOnly = true;
            cells = new string[2];
            cells[0] = "";
            cells[1] = "(...)";
            predictionDataGridView.Rows.Add(cells);

            testingXComboBox.Items.Add(inputColumnName);
            testingXComboBox.SelectedIndex = 0;
            testingYComboBox.Items.Add(outputColumnName);
            testingYComboBox.SelectedIndex = 0;
        }

        private void ShowInputDataScatterPlot()
        {
            double[] xAxis = inputColumn;
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

            polynomialRegression = null;
            try
            {
                PolynomialLeastSquares polynomialLeastSquares = new PolynomialLeastSquares()
                {
                    Degree = Convert.ToInt32(degreeNumericUpDown.Value)
                };
                polynomialRegression = polynomialLeastSquares.Learn(inputColumn, outputColumn);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            ShowFitCurve();

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "Intercept (b0)");
            double[] weights = polynomialRegression.Weights;
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), "b" + (columnIndex + 1).ToString());
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = polynomialRegression.Intercept.ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = weights[columnIndex].ToString();
            fittingDataGridView.Rows.Add(coefficents);

            testButton.Enabled = true;
            predictButton.Enabled = true;
            
            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;
        }

        private void ShowFitCurve()
        {
            double[] xAxis = inputColumn;
            double[] yAxis = outputColumn;

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = inputColumnName;
            graphPane.YAxis.Title.Text = outputColumnName;

            //Classification problem
            PointPairList list1 = new PointPairList();
            for (int rowIndex = 0; rowIndex < xAxis.Length; rowIndex++)
                list1.Add(xAxis[rowIndex], yAxis[rowIndex]);
            double[] xData = xAxis.GetRange().Range(0.05);
            double[] yData = polynomialRegression.Transform(xData);
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
            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            computedOutputs = null;
            try
            {
                computedOutputs = polynomialRegression.Transform(inputColumn);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            double[] expectedOutputColumn = outputColumn;

            testingDataGridView.Rows.Clear();
            string[] cells = new string[3];
            for (int rowIndex = 0; rowIndex < inputColumn.Length; rowIndex++)
            {
                cells[0] = inputColumn[rowIndex].ToString();
                cells[1] = outputColumn[rowIndex].ToString();
                cells[2] = Math.Round(computedOutputs[rowIndex], 4).ToString();
                testingDataGridView.Rows.Add(cells);
            }

            rSquareLabel.Text = "R² = " + Accord.Statistics.Tools.Determination(expectedOutputColumn, computedOutputs).ToString();

            ShowTestingScatterPlot();

            toolStripStatusLabel.Text = "Test completed!";
            Cursor = Cursors.Arrow;
        }

        private void testingXComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0)
                return;

            ShowTestingScatterPlot();
        }

        private void ShowTestingScatterPlot()
        {
            double[] xAxis = inputColumn;
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
            double inputValue = 0;
            try
            {
                inputValue = Convert.ToDouble(predictionDataGridView.Rows[0].Cells[0].Value);
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
                output = polynomialRegression.Transform(inputValue);
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
