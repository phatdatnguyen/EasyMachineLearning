﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.Math;
using Accord.Controls;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using ZedGraph;

namespace MachineLearning
{
    public partial class LogisticRegressionModelForm : Form
    {
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private bool[] outputBooleanColumn;
        private string[] outputValues;
        private string[] computedOutputs;

        private LogisticRegression logisticRegression;
        private int[] learningIndexes;
        private int[] testingIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public LogisticRegressionModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            learningFromNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Value = inputData.Rows.Count;
            if (inputColumnNames.Length == 1)
            {
                learningXComboBox.Items.Add(inputColumnNames[0]);
                learningYComboBox.Items.Add(outputColumnName);
                learningXComboBox.SelectedIndex = 0;
                learningYComboBox.SelectedIndex = 0;
            }
            else //inputColumnNames.Length == 2
            {
                learningXComboBox.Items.Add(inputColumnNames[0]);
                learningYComboBox.Items.Add(inputColumnNames[1]);
                learningXComboBox.SelectedIndex = 0;
                learningYComboBox.SelectedIndex = 0;
            }

            //Tab testing
            foreach (string inputColumnName in inputColumnNames)
                testingDataGridView.Columns.Add(inputColumnName, inputColumnName + "\n(Input)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Expected Output)");
            testingDataGridView.Columns.Add(outputColumnName, outputColumnName + "\n(Output)");
            testingDataGridView.Columns.Add("probabilities", "Probabilities\n[" + outputValues[0] + "; " + outputValues[1] + "]");
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
            predictionDataGridView.Columns.Add("probabilities", "Probabilities\n[" + outputValues[0] + "; " + outputValues[1] + "]");
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

        private void methodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            regulationNumericUpDown.Enabled = iterativeReweightedLeastSquaresRadioButton.Checked;
            learningRateNumericUpDown.Enabled = logisticGradientDescentRadioButton.Checked;
            stochasticCheckBox.Enabled = logisticGradientDescentRadioButton.Checked;
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
                if (iterativeReweightedLeastSquaresRadioButton.Checked)
                {
                    IterativeReweightedLeastSquares<LogisticRegression> iterativeReweightedLeastSquares = new IterativeReweightedLeastSquares<LogisticRegression>()
                    {
                        Tolerance = (double)toleranceNumericUpDown.Value,
                        MaxIterations = (int)maxIterationNumericUpDown.Value,
                        Regularization = (double)regulationNumericUpDown.Value
                    };
                    logisticRegression = iterativeReweightedLeastSquares.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                }
                else //logisticGradientDescentRadioButton.Checked
                {
                    LogisticGradientDescent logisticGradientDescent = new LogisticGradientDescent()
                    {
                        Tolerance = (double)toleranceNumericUpDown.Value,
                        MaxIterations = (int)maxIterationNumericUpDown.Value,
                        LearningRate = (double)regulationNumericUpDown.Value,
                        Stochastic = stochasticCheckBox.Checked
                    };
                    logisticRegression = logisticGradientDescent.Learn(inputColumns.Get(learningIndexes), outputBooleanColumn.Get(learningIndexes));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            fittingDataGridView.Columns.Clear();
            fittingDataGridView.Columns.Add("b0", "Intercept (b0)");
            double[] weights = logisticRegression.Weights;
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                fittingDataGridView.Columns.Add("b" + (columnIndex + 1).ToString(), inputColumnNames[columnIndex] + " (b" + (columnIndex + 1).ToString() + ")");
            string[] coefficents = new string[weights.Length + 1];
            coefficents[0] = logisticRegression.Intercept.ToString();
            for (int columnIndex = 0; columnIndex < weights.Length; columnIndex++)
                coefficents[columnIndex + 1] = weights[columnIndex].ToString();
            fittingDataGridView.Rows.Add(coefficents);

            if (inputData.Columns.Count == 1)
                ShowFitCurve(learningXComboBox.SelectedItem.ToString(), learningYComboBox.SelectedItem.ToString());

            if (inputData.Columns.Count == 2)
                CreateSurface(learningXComboBox.SelectedItem.ToString(), learningYComboBox.SelectedItem.ToString());

            testButton.Enabled = true;
            predictButton.Enabled = true;

            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;

            machineTrained = true;
        }

        private void ShowFitCurve(string xAxisTitle, string yAxisTitle)
        {
            //Get the ranges for each variable (X and Y)
            double[] xAxis = inputData.Columns[xAxisTitle].ToArray().Get(learningIndexes);
            bool[] yAxis = outputBooleanColumn.Get(learningIndexes);

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = xAxisTitle;
            graphPane.YAxis.Title.Text = yAxisTitle;

            //Classification problem
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (int rowIndex = 0; rowIndex < xAxis.Length; rowIndex++)
            {
                if (yAxis[rowIndex])
                    list1.Add(xAxis[rowIndex], Convert.ToDouble(yAxis[rowIndex]));
                else
                    list2.Add(xAxis[rowIndex], Convert.ToDouble(yAxis[rowIndex]));
            }
            double[] xData = xAxis.Get(learningIndexes).GetRange().Range(0.05);
            double[] yData = logisticRegression.Probabilities(xData.ToJagged()).GetColumn(1);
            PointPairList list3 = new PointPairList();
            for (int rowIndex = 0; rowIndex < xData.Length; rowIndex++)
                list3.Add(xData[rowIndex], yData[rowIndex]);

            //Add the curve
            LineItem myCurve = graphPane.AddCurve(outputValues[0], list1, Color.Blue, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = graphPane.AddCurve(outputValues[1], list2, Color.Green, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);

            myCurve = graphPane.AddCurve("Fit Curve", list3, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            //Fill the background of the chart rect and pane
            graphPane.Fill = new Fill(Color.WhiteSmoke);

            learningZedGraphControl.AxisChange();
            learningZedGraphControl.Invalidate();
        }

        private void CreateSurface(string xAxisTitle, string yAxisTitle)
        {
            //Get the ranges for each variable (X and Y)
            double[] xAxis = inputData.Columns[xAxisTitle].ToArray();
            double[] yAxis = inputData.Columns[yAxisTitle].ToArray();

            //Generate a Cartesian coordinate system
            double[][] map = Matrix.Mesh(xAxis.Get(learningIndexes).GetRange(), 200, yAxis.Get(learningIndexes).GetRange(), 200);

            //Classify each point in the Cartesian coordinate system
            bool[] result = logisticRegression.Decide(map);
            
            double[,] surface = map.ToMatrix();

            GraphPane graphPane = learningZedGraphControl.GraphPane;
            graphPane.CurveList.Clear();

            // Set the titles
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.Text = xAxisTitle;
            graphPane.YAxis.Title.Text = yAxisTitle;

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
            double[][] probabilities = null;
            try
            {
                computedBooleanOutputs = logisticRegression.Decide(inputColumns.Get(testingIndexes));
                probabilities = logisticRegression.Probabilities(inputColumns.Get(testingIndexes));
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
                string[] cells = new string[inputColumnNames.Length + 3];
                for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                    cells[columnIndex] = row[inputColumnNames[columnIndex]].ToString();
                cells[numberOfInputFields] = outputColumn[this.inputData.Rows.IndexOf(row)].ToString();
                int rowIndex = this.inputData.Rows.IndexOf(row);
                if (testingIndexes.Contains(rowIndex))
                {
                    cells[numberOfInputFields + 1] = computedOutputs[rowIndex - fromRowIndex].ToString();
                    cells[numberOfInputFields + 2] = "[" + Math.Round(probabilities[rowIndex][1], 4).ToString() + "; " + Math.Round(probabilities[rowIndex][0], 4).ToString() + "]";
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

            bool output = false;
            double[] probabilities;
            try
            {
                output = logisticRegression.Decide(inputValues);
                probabilities = logisticRegression.Probabilities(inputValues);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            if (output)
                predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 2].Value = outputValues[0];
            else
                predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 2].Value = outputValues[1];
            string[] roundedProbabilities = new string[2];
            roundedProbabilities[0] = Math.Round(probabilities[1], 4).ToString();
            roundedProbabilities[1] = Math.Round(probabilities[0], 4).ToString();
            predictionDataGridView.Rows[0].Cells[predictionDataGridView.Columns.Count - 1].Value = "[" + String.Join("; ", roundedProbabilities) + "]";

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }
    }
}
