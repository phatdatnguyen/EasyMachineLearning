using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.MachineLearning.Rules;
using Accord.Math;
using Accord.Statistics.Kernels;
using ZedGraph;

namespace MachineLearning
{
    public partial class AprioriModelForm : Form
    {
        //Fields
        private string[][] inputData;
        //Constructor
        public AprioriModelForm(DataTable inputData)
        {
            InitializeComponent();

            //Load data
            int numberOfRows = inputData.Rows.Count;
            int numberOfColumns = inputData.Columns.Count;
            this.inputData = new string[numberOfRows][];
            for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
            {
                List<string> items = new List<string>();
                for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++)
                    if (inputData.Rows[rowIndex][columnIndex].ToString() != "")
                        items.Add(inputData.Rows[rowIndex][columnIndex].ToString());
                this.inputData[rowIndex] = items.ToArray();
            }

            //Show data
            for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
            {
                List<string> items = new List<string>();
                foreach (string item in this.inputData[rowIndex])
                    items.Add("\"" + item + "\"");
                string row = string.Join(", ", items);
                inputDataListBox.Items.Add(row);
            }
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            AssociationRuleMatcher<string> associationRuleMatcher;
            AssociationRule<string>[] rules;

            Cursor = Cursors.WaitCursor;
            toolStripStatusLabel.Text = "Computing...";

            try
            {
                Apriori<string> apriori = new Apriori<string>((int)thresholdNumericUpDown.Value, (double)confidenceNumericUpDown.Value);
                associationRuleMatcher = apriori.Learn(inputData);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            rules = associationRuleMatcher.Rules;

            rulesDataGridView.Rows.Clear();
            foreach (AssociationRule<string> rule in rules)
            {
                List<string> xs = new List<string>();
                List<string> ys = new List<string>();
                foreach (string x in rule.X)
                    xs.Add("\"" + x + "\"");
                foreach (string y in rule.Y)
                    ys.Add("\"" + y + "\"");
                string input = string.Join(", ", xs);
                string output = string.Join(", ", ys);
                rulesDataGridView.Rows.Add("[" + input + "] => [" + output + "]", rule.Support.ToString(), rule.Confidence.ToString());
            }

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }
    }
}
