using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Accord.IO;
using Accord.Math;

namespace MachineLearning
{
    public partial class MainForm : Form
    {
        //Fields
        private DataTable inputData = new DataTable();
        private string[] classificationModels = new string[] { "Support Vector Machine (SVM)", "Naive-Bayes", "k-Nearest Neighbors (kNN)",
            "Decision Tree", "Logistic Regression", "Multinomial Logistic Regression", "Artificial Neural Network (ANN)",
            "Deep Belief Network (DBN)" };
        private string[] regressionModels = new string[] { "Linear Regression", "Polynomial Regression", "Support Vector Machine (SVM)", "Artificial Neural Network (ANN)" };
        private string[] clusteringModels = new string[] { "k-Means", "Balanced k-Means", "Binary Split", "k-Medoids", "k-Modes", "Mean-Shift",
            "Gaussian Mixture", "Restricted Boltzmann Machine (RBM)", "Deep Belief Network (DBN)" };
        private string[] ensembleLearningModels = new string[] { "Random Forest", "AdaBoost" };
        private string[] ruleLearningModels = new string[] { "Apriori" };
        //Contructor
        public MainForm()
        {
            InitializeComponent();

            taskComboBox.SelectedIndex = 0;
            importDatabaseFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "SampleDatabases");
        }

        //Methods
        private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importDatabaseFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = importDatabaseFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".xls" || extension == ".xlsx")
                {
                    ExcelReader excelReader = new ExcelReader(filename, true, false);
                    TableSelectDialog tableSelectDialog = new TableSelectDialog(excelReader.GetWorksheetList());

                    if (tableSelectDialog.ShowDialog(this) == DialogResult.OK && tableSelectDialog.Selection != "")
                    {
                        Cursor = Cursors.WaitCursor;
                        toolStripStatusLabel.Text = "Loading data...";

                        inputData = excelReader.GetWorksheet(tableSelectDialog.Selection);
                    }
                    else
                        return;
                }
                else if (extension == ".csv")
                {
                    Cursor = Cursors.WaitCursor;
                    toolStripStatusLabel.Text = "Loading data...";

                    CsvReader csvReader = new CsvReader(filename, true);
                    inputData = csvReader.ToTable();

                    foreach (DataColumn dataColumn in inputData.Columns)
                        dataColumn.ReadOnly = false;
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "";
                Cursor = Cursors.Arrow;
                return;
            }

            inputDataGridView.DataSource = inputData;
            foreach (DataGridViewColumn column in inputDataGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            xComboBox.Items.Clear();
            yComboBox.Items.Clear();
            groupComboBox.Items.Clear();
            foreach (DataColumn dataColumn in inputData.Columns)
            {
                xComboBox.Items.Add(dataColumn.ColumnName);
                yComboBox.Items.Add(dataColumn.ColumnName);
                groupComboBox.Items.Add(dataColumn.ColumnName);
            }
            xComboBox.SelectedIndex = 0;
            yComboBox.SelectedIndex = 0;
            groupComboBox.SelectedIndex = 0;
            showScatterPlotButton.Enabled = true;

            columnsDataGridView.Rows.Clear();
            foreach (DataColumn dataColumn in inputData.Columns)
                columnsDataGridView.Rows.Add(new object[] { dataColumn.ColumnName, dataColumn.DataType.Name, false, false });

            editModelButton.Enabled = true;

            toolStripStatusLabel.Text = "";
            Cursor = Cursors.Arrow;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void showScatterPlotButton_Click(object sender, EventArgs e)
        {
            ScatterPlotDialog scatterPlotDialog = new ScatterPlotDialog(inputData, xComboBox.SelectedItem.ToString(),
                yComboBox.SelectedItem.ToString(), groupComboBox.SelectedItem.ToString());
            scatterPlotDialog.ShowDialog(this);
        }

        private void columnsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (inputDataGridView.IsCurrentCellDirty)
                inputDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void columnsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)columnsDataGridView[e.ColumnIndex, e.RowIndex];

                //Change data type
                Type newType = typeof(String);
                switch (cell.Value.ToString())
                {
                    case "String":
                        newType = typeof(String);
                        break;
                    case "Byte":
                        newType = typeof(Byte);
                        break;
                    case "SByte":
                        newType = typeof(SByte);
                        break;
                    case "UInt16":
                        newType = typeof(UInt16);
                        break;
                    case "UInt32":
                        newType = typeof(UInt32);
                        break;
                    case "UInt64":
                        newType = typeof(UInt64);
                        break;
                    case "Int16":
                        newType = typeof(Int16);
                        break;
                    case "Int32":
                        newType = typeof(Int32);
                        break;
                    case "Int64":
                        newType = typeof(Int64);
                        break;
                    case "Single":
                        newType = typeof(Single);
                        break;
                    case "Double":
                        newType = typeof(Double);
                        break;
                    case "Decimal":
                        newType = typeof(Decimal);
                        break;
                    case "Boolean":
                        newType = typeof(Boolean);
                        break;
                    default:
                        return;
                }

                try
                {
                    DataTable tempData = inputData.Clone();
                    tempData.Columns[e.RowIndex].DataType = newType;
                    foreach (DataRow row in inputData.Rows)
                        tempData.ImportRow(row);

                    inputData = tempData.DeepClone();
                    inputDataGridView.DataSource = inputData;
                    tempData.Dispose();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Reverse change
                    cell.Value = inputData.Columns[e.RowIndex].DataType.Name;
                }
            }
        }

        private void taskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskComboBox.SelectedIndex < 0)
                return;

            modelComboBox.Items.Clear();
            switch (taskComboBox.SelectedItem.ToString())
            {
                case "Classification":
                    foreach (string model in classificationModels)
                        modelComboBox.Items.Add(model);
                    break;
                case "Regression":
                    foreach (string model in regressionModels)
                        modelComboBox.Items.Add(model);
                    break;
                case "Clustering":
                    foreach (string model in clusteringModels)
                        modelComboBox.Items.Add(model);
                    break;
                case "Rule Learning":
                    foreach (string model in ruleLearningModels)
                        modelComboBox.Items.Add(model);
                    break;
                case "Ensemble Learning":
                    foreach (string model in ensembleLearningModels)
                        modelComboBox.Items.Add(model);
                    break;
            }
            modelComboBox.SelectedIndex = 0;
        }

        private void editModelButton_Click(object sender, EventArgs e)
        {
            switch (taskComboBox.SelectedItem.ToString())
            {
                case "Classification":
                    openClassificationForm(modelComboBox.SelectedItem.ToString());
                    break;
                case "Regression":
                    openRegressionForm(modelComboBox.SelectedItem.ToString());
                    break;
                case "Clustering":
                    openClusteringForm(modelComboBox.SelectedItem.ToString());
                    break;
                case "Rule Learning":
                    openRuleLearningForm(modelComboBox.SelectedItem.ToString());
                    break;
                case "Ensemble Learning":
                    openEnsembleLearningForm(modelComboBox.SelectedItem.ToString());
                    break;
            }
        }

        private void openClassificationForm(string model)
        {
            List<string> inputColumnNames = new List<string>();
            List<string> outputColumnNames = new List<string>();
            foreach (DataGridViewRow row in columnsDataGridView.Rows)
            {
                if ((bool)row.Cells[2].Value)
                    inputColumnNames.Add(row.Cells[0].Value.ToString());
                if ((bool)row.Cells[3].Value)
                    outputColumnNames.Add(row.Cells[0].Value.ToString());
            }

            if (inputColumnNames.Count == 0)
            {
                MessageBox.Show(this, "You have to choose as least 1 input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string inputFieldName in inputColumnNames)
                if (!Program.IsNumericType(inputData.Columns[inputFieldName].DataType))
                {
                    MessageBox.Show(this, "Input fields have to be of numeric type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (outputColumnNames.Count != 1)
            {
                MessageBox.Show(this, "You can only choose 1 output field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inputColumnNames.Contains(outputColumnNames[0]))
            {
                MessageBox.Show(this, "Output field cannot be input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() == 1)
            {
                MessageBox.Show(this, "Oneclass-classification is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (model)
            {
                case "k-Nearest Neighbors (kNN)":
                    KNNModelForm kNNModelForm = new KNNModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    kNNModelForm.ShowDialog(this);
                    break;
                case "Naive-Bayes":
                    NaiveBayesModelForm naiveBayesModelForm = new NaiveBayesModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    naiveBayesModelForm.ShowDialog(this);
                    break;
                case "Decision Tree":
                    DecisionTreeModelForm decisionTreeModelForm = new DecisionTreeModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    decisionTreeModelForm.ShowDialog(this);
                    break;
                case "Random Forest":
                    RandomForestModelForm randomForestModelForm = new RandomForestModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    randomForestModelForm.ShowDialog(this);
                    break;
                case "Support Vector Machine (SVM)":
                    if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() == 2)
                    {
                        SVMBinaryClassifierModelForm svmBinaryClassifierModelForm = new SVMBinaryClassifierModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                        svmBinaryClassifierModelForm.ShowDialog(this);
                    }
                    else if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() >= 2)
                    {
                        SVMMulticlassClassifierModelForm svmMulticlassClassifierModel = new SVMMulticlassClassifierModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                        svmMulticlassClassifierModel.ShowDialog(this);
                    }
                    break;
                case "Logistic Regression":
                    if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() == 2)
                    {
                        LogisticRegressionModelForm logisticRegressionModelForm = new LogisticRegressionModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                        logisticRegressionModelForm.ShowDialog(this);
                    }
                    else //inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() >= 2
                    {
                        MessageBox.Show(this, "Logistic Regression can only be used in binary classification problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Multinomial Logistic Regression":
                    MultinomialLogisticRegressionModelForm multinomialLogisticRegressionModelForm = new MultinomialLogisticRegressionModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    multinomialLogisticRegressionModelForm.ShowDialog(this);
                    break;
                case "Artificial Neural Network (ANN)":
                    ANNClassifierModelForm annClassifierModelForm = new ANNClassifierModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    annClassifierModelForm.ShowDialog(this);
                    break;
                case "Deep Belief Network (DBN)":
                    DBNClassifierModelForm dbnClassifierModelForm = new DBNClassifierModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    dbnClassifierModelForm.ShowDialog(this);
                    break;
            }
        }

        private void openRegressionForm(string model)
        {
            List<string> inputColumnNames = new List<string>();
            List<string> outputColumnNames = new List<string>();
            foreach (DataGridViewRow row in columnsDataGridView.Rows)
            {
                if ((bool)row.Cells[2].Value)
                    inputColumnNames.Add(row.Cells[0].Value.ToString());
                if ((bool)row.Cells[3].Value)
                    outputColumnNames.Add(row.Cells[0].Value.ToString());
            }

            if (inputColumnNames.Count == 0)
            {
                MessageBox.Show(this, "You have to choose as least 1 input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string inputFieldName in inputColumnNames)
                if (!Program.IsNumericType(inputData.Columns[inputFieldName].DataType))
                {
                    MessageBox.Show(this, "Input fields have to be of numeric type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (outputColumnNames.Count != 1)
            {
                MessageBox.Show(this, "You can only choose 1 output field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Program.IsNumericType(inputData.Columns[outputColumnNames[0]].DataType))
            {
                MessageBox.Show(this, "Output field have to be of numeric type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inputColumnNames.Contains(outputColumnNames[0]))
            {
                MessageBox.Show(this, "Output field cannot be input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (model)
            {
                case "Linear Regression":
                    LinearRegressionModelForm linearRegressionModelForm = new LinearRegressionModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    linearRegressionModelForm.ShowDialog(this);
                    break;
                case "Polynomial Regression":
                    if (inputColumnNames.Count != 1)
                    {
                        MessageBox.Show(this, "You can only choose 1 input field for polynomial regression!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    PolynomialRegressionModelForm PolynomialRegressionModelForm = new PolynomialRegressionModelForm(inputData, inputColumnNames[0], outputColumnNames[0]);
                    PolynomialRegressionModelForm.ShowDialog(this);
                    break;
                case "Support Vector Machine (SVM)":
                    SVMRegressionModelForm svmRegressionModelForm = new SVMRegressionModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    svmRegressionModelForm.ShowDialog(this);
                    break;
                case "Artificial Neural Network (ANN)":
                    ANNRegressionModelForm annRegressionModelForm = new ANNRegressionModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    annRegressionModelForm.ShowDialog(this);
                    break;
            }
        }

        private void openClusteringForm(string model)
        {
            List<string> inputColumnNames = new List<string>();
            foreach (DataGridViewRow row in columnsDataGridView.Rows)
            {
                if ((bool)row.Cells[2].Value)
                    inputColumnNames.Add(row.Cells[0].Value.ToString());
            }

            if (inputColumnNames.Count == 0)
            {
                MessageBox.Show(this, "You have to choose as least 1 input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string inputFieldName in inputColumnNames)
                if (!Program.IsNumericType(inputData.Columns[inputFieldName].DataType))
                {
                    MessageBox.Show(this, "Input fields have to be of numeric type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            switch (model)
            {
                case "k-Means":
                case "Balanced k-Means":
                case "k-Medoids":
                case "k-Modes":
                case "Mean-Shift":
                case "Gaussian Mixture":
                    ClusteringForm clusteringForm = new ClusteringForm(model, inputData, inputColumnNames.ToArray<string>());
                    clusteringForm.ShowDialog(this);
                    break;
                case "Restricted Boltzmann Machine (RBM)":
                    RBMModelForm rbmModelForm = new RBMModelForm(inputData, inputColumnNames.ToArray<string>());
                    rbmModelForm.ShowDialog(this);
                    break;
                case "Deep Belief Network (DBN)":
                    DBNModelForm dbnModelForm = new DBNModelForm(inputData, inputColumnNames.ToArray<string>());
                    dbnModelForm.ShowDialog(this);
                    break;
            }
        }

        private void openEnsembleLearningForm(string model)
        {
            List<string> inputColumnNames = new List<string>();
            List<string> outputColumnNames = new List<string>();
            foreach (DataGridViewRow row in columnsDataGridView.Rows)
            {
                if ((bool)row.Cells[2].Value)
                    inputColumnNames.Add(row.Cells[0].Value.ToString());
                if ((bool)row.Cells[3].Value)
                    outputColumnNames.Add(row.Cells[0].Value.ToString());
            }

            if (inputColumnNames.Count == 0)
            {
                MessageBox.Show(this, "You have to choose as least 1 input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string inputFieldName in inputColumnNames)
                if (!Program.IsNumericType(inputData.Columns[inputFieldName].DataType))
                {
                    MessageBox.Show(this, "Input fields have to be of numeric type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (outputColumnNames.Count != 1)
            {
                MessageBox.Show(this, "You can only choose 1 output field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inputColumnNames.Contains(outputColumnNames[0]))
            {
                MessageBox.Show(this, "Output field cannot be input field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (model)
            {
                case "Random Forest":
                    RandomForestModelForm randomForestModelForm = new RandomForestModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                    randomForestModelForm.ShowDialog(this);
                    break;
                case "AdaBoost":
                    if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() == 2)
                    {
                        AdaBoostModelForm multiclassAdaBoostModelForm = new AdaBoostModelForm(inputData, inputColumnNames.ToArray<string>(), outputColumnNames[0]);
                        multiclassAdaBoostModelForm.ShowDialog(this);
                    }
                    else if (inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().Count() >= 2)
                    {
                        MessageBox.Show(this, "AdaBoost is not available for multiclass classification problems!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
        }

        private void openRuleLearningForm(string model)
        {
            AprioriModelForm aprioriModelForm = new AprioriModelForm(inputData);
            aprioriModelForm.ShowDialog(this);
        }
    }
}
