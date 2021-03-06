﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using ZedGraph;

namespace MachineLearning
{
    public partial class KDAModelForm : Form
    {
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private string[] outputColumn;
        private string outputColumnName;
        private string[] outputGroupValues;
        private string[] computedOutputs;

        private KernelDiscriminantAnalysis kda;
        private KernelDiscriminantAnalysis.Pipeline kdaPipeline;
        private double[][] projectionResult;
        private int[] learningIndexes;
        private int[] testingIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public KDAModelForm(DataTable inputData, string[] inputColumnNames, string outputColumnName)
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
            numberOfDiscriminantsNumericUpDown.Maximum = numberOfInputFields;
            numberOfDiscriminantsNumericUpDown.Value = numberOfInputFields;

            //Tab projection
            foreach (string inputColumnName in inputColumnNames)
                projectionDataGridView.Columns.Add(inputColumnName, inputColumnName);
            cells = new string[inputColumnNames.Length];
            for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                cells[columnIndex] = "";
            projectionDataGridView.Rows.Add(cells);

            navigateCheckBox.Enabled = inputColumnNames.Length == 2;
            foreach (string inputColumnName in inputColumnNames)
            {
                inputSpaceXComboBox.Items.Add(inputColumnName);
                inputSpaceYComboBox.Items.Add(inputColumnName);
            }
            inputSpaceXComboBox.SelectedIndex = 0;
            if (inputSpaceYComboBox.Items.Count > 1)
                inputSpaceYComboBox.SelectedIndex = 1;
            else
                inputSpaceYComboBox.SelectedIndex = 0;
            ShowInputSpaceScatterPlot();

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

        private void ShowInputSpaceScatterPlot()
        {
            double[] xAxis = inputData.Columns[inputSpaceXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis = inputData.Columns[inputSpaceYComboBox.SelectedItem.ToString()].ToArray();
            Program.ShowScatterPlot(inputSpaceZedGraphControl, xAxis, yAxis, outputColumn,
                inputSpaceXComboBox.SelectedItem.ToString(), inputSpaceYComboBox.SelectedItem.ToString());
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

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Training...";

            double[][] inputColumns = inputData.ToMatrix().ToJagged();
            int[] outputGroupIndexes = new int[outputColumn.Length];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
                outputGroupIndexes[rowIndex] = outputGroupValues.IndexOf(outputColumn[rowIndex]);

            machineTrained = false;
            IKernel kernel = CreateKernel();
            try
            {
                kda = new KernelDiscriminantAnalysis(kernel)
                {
                    NumberOfOutputs = Convert.ToInt32(numberOfDiscriminantsNumericUpDown.Value)
                };
                kdaPipeline = kda.Learn(inputColumns.Get(learningIndexes), outputGroupIndexes.Get(learningIndexes));
                projectionResult = kda.Transform(inputColumns.Get(learningIndexes));
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            projectedDataDataGridView.Rows.Clear();
            projectedDataDataGridView.Columns.Clear();
            foreach (Discriminant discriminant in kda.Discriminants)
                projectedDataDataGridView.Columns.Add("LD" + (discriminant.Index + 1).ToString(), "LD" + (discriminant.Index + 1).ToString());
            projectedDataDataGridView.Columns.Add(outputColumnName, outputColumnName);
            string[] cells = new string[kda.Discriminants.Count + 1];
            for (int rowIndex = 0; rowIndex < projectionResult.Length; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < kda.Discriminants.Count; columnIndex++)
                    cells[columnIndex] = Math.Round(projectionResult[rowIndex][columnIndex], 4).ToString();
                cells[kda.Discriminants.Count] = outputColumn[rowIndex];
                projectedDataDataGridView.Rows.Add(cells);
            }

            discriminantComboBox.Items.Clear();
            foreach (Discriminant discriminant in kda.Discriminants)
                discriminantComboBox.Items.Add("LD" + (discriminant.Index + 1).ToString());
            discriminantComboBox.SelectedIndex = 0;
            proportionComponentView.DataSource = kda.Discriminants;
            cumulativeProportionComponentView.DataSource = kda.Discriminants;

            totalScatterMatrixDataGridView.DataSource = new ArrayDataView(kda.ScatterMatrix);
            betweenClassScatterMatrixDataGridView.DataSource = new ArrayDataView(kda.ScatterBetweenClass);
            withinClassScatterMatrixDataGridView.DataSource = new ArrayDataView(kda.ScatterWithinClass);

            featureSpaceXComboBox.Items.Clear();
            featureSpaceYComboBox.Items.Clear();
            projectionResultDataGridView.Rows.Clear();
            projectionResultDataGridView.Columns.Clear();
            foreach (Discriminant discriminant in kda.Discriminants)
            {
                featureSpaceXComboBox.Items.Add("LD" + (discriminant.Index + 1).ToString());
                featureSpaceYComboBox.Items.Add("LD" + (discriminant.Index + 1).ToString());
                projectionResultDataGridView.Columns.Add("LD" + (discriminant.Index + 1).ToString(), "LD" + (discriminant.Index + 1).ToString());
            }
            featureSpaceXComboBox.SelectedIndex = 0;
            if (featureSpaceYComboBox.Items.Count > 1)
                featureSpaceYComboBox.SelectedIndex = 1;
            else
                featureSpaceYComboBox.SelectedIndex = 0;
            ShowFeatureSpaceScatterPlot();

            cells = new string[kda.Discriminants.Count];
            for (int columnIndex = 0; columnIndex < kda.Discriminants.Count; columnIndex++)
                cells[columnIndex] = "";
            projectionResultDataGridView.Rows.Add(cells);

            projectButton.Enabled = true;

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

        private void ShowFeatureSpaceScatterPlot()
        {
            double[] xAxis = projectionResult.GetColumn(featureSpaceXComboBox.SelectedIndex);
            double[] yAxis = projectionResult.GetColumn(featureSpaceYComboBox.SelectedIndex);
            string[] groupColumn = outputColumn.Get(learningIndexes);
            Program.ShowScatterPlot(featureSpaceZedGraphControl, xAxis, yAxis, groupColumn,
                featureSpaceXComboBox.SelectedItem.ToString(), featureSpaceYComboBox.SelectedItem.ToString());

            LineItem myCurve = featureSpaceZedGraphControl.GraphPane.AddCurve("Navigation", new PointPairList(), Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Black);
        }

        private void discriminantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (discriminantComboBox.SelectedIndex < 0)
                return;

            int discriminantIndex = discriminantComboBox.SelectedIndex;
            foreach (Discriminant discriminant in kda.Discriminants)
                if (discriminantIndex == discriminant.Index)
                {
                    eigenvalueTextBox.Text = Math.Round(discriminant.Eigenvalue, 4).ToString();
                    proportionTextBox.Text = Math.Round(discriminant.Proportion, 4).ToString();
                    cumulativeProportionTextBox.Text = Math.Round(discriminant.CumulativeProportion, 4).ToString();
                    eigenvectorDataGridView.DataSource = new ArrayDataView(discriminant.Eigenvector.ToJagged(), new string[] { "Eigenvector" });
                    return;
                }
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            double[] inputValues = new double[projectionDataGridView.Columns.Count];
            try
            {
                for (int columnIndex = 0; columnIndex < projectionDataGridView.Columns.Count; columnIndex++)
                    inputValues[columnIndex] = Convert.ToDouble(projectionDataGridView.Rows[0].Cells[columnIndex].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double[] projectionResult = null;
            try
            {
                projectionResult = kda.Transform(inputValues);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }
            
            for (int columnIndex = 0; columnIndex < projectionResult.Length; columnIndex++)
                projectionResultDataGridView.Rows[0].Cells[columnIndex].Value = Math.Round(projectionResult[columnIndex], 4).ToString();

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }

        private void inputSpaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !dataLoaded)
                return;

            ShowInputSpaceScatterPlot();
        }

        private void navigateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (navigateCheckBox.Checked)
            {
                inputSpaceXComboBox.SelectedIndex = 0;
                inputSpaceYComboBox.SelectedIndex = 1;
                inputSpaceXComboBox.Enabled = false;
                inputSpaceYComboBox.Enabled = false;
            }
            else
            {
                inputSpaceXComboBox.Enabled = true;
                inputSpaceYComboBox.Enabled = true;
            }
        }

        private void inputSpaceZedGraphControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!navigateCheckBox.Enabled || !navigateCheckBox.Checked || !machineTrained)
                return;

            double x;
            double y;
            inputSpaceZedGraphControl.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out x, out y);

            double[] result;
            try
            {
                result = kda.Transform(new double[] { x, y });
            }
            catch
            {
                return;
            }

            featureSpaceZedGraphControl.GraphPane.CurveList["Navigation"].Clear();
            featureSpaceZedGraphControl.GraphPane.CurveList["Navigation"].AddPoint(result[featureSpaceXComboBox.SelectedIndex], result[featureSpaceYComboBox.SelectedIndex]);
            featureSpaceZedGraphControl.Invalidate();
        }

        private void featureSpaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0 || !machineTrained)
                return;

            ShowFeatureSpaceScatterPlot();
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

            int[] computedOutputsGroupIndexes;
            try
            {
                computedOutputsGroupIndexes = kdaPipeline.Decide(inputColumns.Get(testingIndexes));
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
                outputGroupIndex = kdaPipeline.Decide(inputValues);
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