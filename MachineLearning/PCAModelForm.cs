using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Linear;
using ZedGraph;

namespace MachineLearning
{
    public partial class PCAModelForm : Form
    {
        //Fields
        private DataTable inputData;
        private string[] inputColumnNames;

        private PrincipalComponentAnalysis pca;
        private double[][] projectionResult;
        private int[] learningIndexes;

        private bool dataLoaded = false;
        private bool machineTrained = false;

        //Constructor
        public PCAModelForm(DataTable inputData, string[] inputColumnNames)
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
                inputDataGridView.Columns.Add(inputColumnName, inputColumnName );
            string[] cells = new string[inputColumnNames.Length];
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

            //Tab learning
            learningFromNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Maximum = inputData.Rows.Count;
            learningToNumericUpDown.Value = inputData.Rows.Count;
            numberOfComponentsNumericUpDown.Maximum = numberOfInputFields;
            numberOfComponentsNumericUpDown.Value = numberOfInputFields;
            methodComboBox.SelectedIndex = 0;

            //Tab projection
            foreach (string inputColumnName in inputColumnNames)
                projectionDataGridView.Columns.Add(inputColumnName, inputColumnName);
            cells = new string[inputColumnNames.Length];
            for (int columnIndex = 0; columnIndex < numberOfInputFields; columnIndex++)
                cells[columnIndex] = "";
            projectionDataGridView.Rows.Add(cells);

            inputSpaceNavigateCheckBox.Enabled = inputColumnNames.Length == 2;
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
            string[] groupColumn = new string[inputData.Rows.Count];
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                groupColumn[rowIndex] = "Data";
            Program.ShowScatterPlot(inputDataZedGraphControl, xAxis, yAxis, groupColumn,
                inputDataXComboBox.SelectedItem.ToString(), inputDataYComboBox.SelectedItem.ToString());
        }

        private void ShowInputSpaceScatterPlot()
        {
            double[] xAxis = inputData.Columns[inputSpaceXComboBox.SelectedItem.ToString()].ToArray();
            double[] yAxis = inputData.Columns[inputSpaceYComboBox.SelectedItem.ToString()].ToArray();
            string[] groupColumn = new string[inputData.Rows.Count];
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                groupColumn[rowIndex] = "Data";
            Program.ShowScatterPlot(inputSpaceZedGraphControl, xAxis, yAxis, groupColumn,
                inputSpaceXComboBox.SelectedItem.ToString(), inputSpaceYComboBox.SelectedItem.ToString());

            LineItem myCurve = inputSpaceZedGraphControl.GraphPane.AddCurve("Navigation", new PointPairList(), Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Black);
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

            machineTrained = false;
            featureSpaceNavigateCheckBox.Checked = false;
            featureSpaceNavigateCheckBox.Enabled = false;
            try
            {
                switch (methodComboBox.SelectedItem.ToString())
                {
                    case "Center":
                        pca = new PrincipalComponentAnalysis(PrincipalComponentMethod.Center);
                        break;
                    case "Standardize":
                        pca = new PrincipalComponentAnalysis(PrincipalComponentMethod.Standardize);
                        break;
                }
                pca.NumberOfOutputs = Convert.ToInt32(numberOfComponentsNumericUpDown.Value);
                pca.Learn(inputColumns.Get(learningIndexes));
                projectionResult = pca.Transform(inputColumns.Get(learningIndexes));
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            int numberOfPricipleComponents = Math.Min(Convert.ToInt32(numberOfComponentsNumericUpDown.Value), pca.Components.Count);
            projectedDataDataGridView.Rows.Clear();
            projectedDataDataGridView.Columns.Clear();
            foreach (PrincipalComponent component in pca.Components)
            {
                if (component.Index == numberOfPricipleComponents)
                    break;
                projectedDataDataGridView.Columns.Add("PC" + (component.Index + 1).ToString(), "PC" + (component.Index + 1).ToString());
            }
            string[] cells = new string[pca.Components.Count];
            for (int rowIndex = 0; rowIndex < projectionResult.Length; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < numberOfPricipleComponents; columnIndex++)
                    cells[columnIndex] = Math.Round(projectionResult[rowIndex][columnIndex], 4).ToString();
                projectedDataDataGridView.Rows.Add(cells);
            }

            principleComponentComboBox.Items.Clear();
            foreach (PrincipalComponent component in pca.Components)
            {
                if (component.Index == numberOfPricipleComponents)
                    break;
                principleComponentComboBox.Items.Add("PC" + (component.Index + 1).ToString());
            }
            principleComponentComboBox.SelectedIndex = 0;
            proportionComponentView.DataSource = pca.Components;
            cumulativeProportionComponentView.DataSource = pca.Components;

            featureSpaceXComboBox.Items.Clear();
            featureSpaceYComboBox.Items.Clear();
            projectionResultDataGridView.Rows.Clear();
            projectionResultDataGridView.Columns.Clear();
            foreach (PrincipalComponent component in pca.Components)
            {
                if (component.Index == numberOfPricipleComponents)
                    break;
                featureSpaceXComboBox.Items.Add("PC" + (component.Index + 1).ToString());
                featureSpaceYComboBox.Items.Add("PC" + (component.Index + 1).ToString());
                projectionResultDataGridView.Columns.Add("PC" + (component.Index + 1).ToString(), "PC" + (component.Index + 1).ToString());
            }
            featureSpaceXComboBox.SelectedIndex = 0;
            if (featureSpaceYComboBox.Items.Count > 1)
                featureSpaceYComboBox.SelectedIndex = 1;
            else
                featureSpaceYComboBox.SelectedIndex = 0;
            ShowFeatureSpaceScatterPlot();

            featureSpaceNavigateCheckBox.Enabled = numberOfPricipleComponents == 2;
            
            for (int columnIndex = 0; columnIndex < pca.Components.Count; columnIndex++)
                cells[columnIndex] = "";
            projectionResultDataGridView.Rows.Add(cells);

            projectButton.Enabled = true;
            revertButton.Enabled = true;

            toolStripStatusLabel.Text = "Training completed!";
            Cursor = Cursors.Arrow;

            machineTrained = true;
        }

        private void ShowFeatureSpaceScatterPlot()
        {
            double[] xAxis = projectionResult.GetColumn(featureSpaceXComboBox.SelectedIndex);
            double[] yAxis = projectionResult.GetColumn(featureSpaceYComboBox.SelectedIndex);
            string[] groupColumn = new string[learningIndexes.Length];
            for (int rowIndex = 0; rowIndex < groupColumn.Length; rowIndex++)
                groupColumn[rowIndex] = "Data";
            Program.ShowScatterPlot(featureSpaceZedGraphControl, xAxis, yAxis, groupColumn,
                featureSpaceXComboBox.SelectedItem.ToString(), featureSpaceYComboBox.SelectedItem.ToString());

            LineItem myCurve = featureSpaceZedGraphControl.GraphPane.AddCurve("Navigation", new PointPairList(), Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Black);
        }

        private void pricipleComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (principleComponentComboBox.SelectedIndex < 0)
                return;

            int componentIndex = principleComponentComboBox.SelectedIndex;
            foreach (PrincipalComponent component in pca.Components)
                if (componentIndex == component.Index)
                {
                    eigenvalueTextBox.Text = Math.Round(component.Eigenvalue, 4).ToString();
                    proportionTextBox.Text = Math.Round(component.Proportion, 4).ToString();
                    cumulativeProportionTextBox.Text = Math.Round(component.CumulativeProportion, 4).ToString();
                    eigenvectorDataGridView.DataSource = new ArrayDataView(component.Eigenvector.ToJagged(), new string[] { "Eigenvector" });
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
                projectionResult = pca.Transform(inputValues);
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

        private void revertButton_Click(object sender, EventArgs e)
        {
            double[] inputValues = new double[projectionResultDataGridView.Columns.Count];
            try
            {
                for (int columnIndex = 0; columnIndex < projectionResultDataGridView.Columns.Count; columnIndex++)
                    inputValues[columnIndex] = Convert.ToDouble(projectionResultDataGridView.Rows[0].Cells[columnIndex].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            double[] reversionResult = null;
            try
            {
                reversionResult = pca.Revert(inputValues.ToJagged().Transpose())[0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            for (int columnIndex = 0; columnIndex < reversionResult.Length; columnIndex++)
                projectionDataGridView.Rows[0].Cells[columnIndex].Value = Math.Round(reversionResult[columnIndex], 4).ToString();

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

        private void inputSpaceNavigateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (inputSpaceNavigateCheckBox.Checked)
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
            if (!inputSpaceNavigateCheckBox.Enabled || !inputSpaceNavigateCheckBox.Checked || !machineTrained)
                return;

            double x;
            double y;
            inputSpaceZedGraphControl.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out x, out y);

            double[] result;
            try
            {
                result = pca.Transform(new double[] { x, y });
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

        private void featureSpaceNavigateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (featureSpaceNavigateCheckBox.Checked)
            {
                featureSpaceXComboBox.SelectedIndex = 0;
                featureSpaceYComboBox.SelectedIndex = 1;
                featureSpaceXComboBox.Enabled = false;
                featureSpaceYComboBox.Enabled = false;
            }
            else
            {
                featureSpaceXComboBox.Enabled = true;
                featureSpaceYComboBox.Enabled = true;
            }
        }

        private void featureSpaceZedGraphControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!featureSpaceNavigateCheckBox.Enabled || !featureSpaceNavigateCheckBox.Checked || !machineTrained)
                return;

            double x;
            double y;
            featureSpaceZedGraphControl.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out x, out y);

            double[] result;
            try
            {
                result = pca.Revert((new double[] { x, y }).ToJagged().Transpose())[0];
            }
            catch
            {
                return;
            }

            inputSpaceZedGraphControl.GraphPane.CurveList["Navigation"].Clear();
            inputSpaceZedGraphControl.GraphPane.CurveList["Navigation"].AddPoint(result[inputSpaceXComboBox.SelectedIndex], result[inputSpaceYComboBox.SelectedIndex]);
            inputSpaceZedGraphControl.Invalidate();
        }
    }
}