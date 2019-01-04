﻿namespace MachineLearning
{
    partial class AdaBoostModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.inputDataTabPage = new System.Windows.Forms.TabPage();
            this.inputDataVisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDataZedGraphControl = new ZedGraph.ZedGraphControl();
            this.inputDataVisualizationPanel = new System.Windows.Forms.Panel();
            this.inputDataXComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataYComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataYLabel = new System.Windows.Forms.Label();
            this.inputDataXLabel = new System.Windows.Forms.Label();
            this.learningTabPage = new System.Windows.Forms.TabPage();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.learningToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningToLabel = new System.Windows.Forms.Label();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            this.learningFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningFromLabel = new System.Windows.Forms.Label();
            this.kernelGroupBox = new System.Windows.Forms.GroupBox();
            this.sigmoidEstimateButton = new System.Windows.Forms.Button();
            this.laplacianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianEstimateButton = new System.Windows.Forms.Button();
            this.complexityEstimateButton = new System.Windows.Forms.Button();
            this.svmToleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaLabel = new System.Windows.Forms.Label();
            this.gaussianSigmaLabel = new System.Windows.Forms.Label();
            this.sigmoidConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidAlphaLabel = new System.Windows.Forms.Label();
            this.sigmoidAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantLabel = new System.Windows.Forms.Label();
            this.polynomialDegreeLabel = new System.Windows.Forms.Label();
            this.negativeWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.positiveWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.complexityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialDegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidConstantLabel = new System.Windows.Forms.Label();
            this.complexityLabel = new System.Windows.Forms.Label();
            this.sigmoidKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.costRatioLabel = new System.Windows.Forms.Label();
            this.svmToleranceLabel = new System.Windows.Forms.Label();
            this.laplacianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.regulationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.regulationLabel = new System.Windows.Forms.Label();
            this.logisticRegressionMethodComboBox = new System.Windows.Forms.ComboBox();
            this.logisticRegressionMethodLabel = new System.Windows.Forms.Label();
            this.svmMethodComboBox = new System.Windows.Forms.ComboBox();
            this.svmMethodLabel = new System.Windows.Forms.Label();
            this.logisticRegressionMaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.logisticRegressionToleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.logisticRegressionMethodToleranceLabel = new System.Windows.Forms.Label();
            this.logisticRegressionMethodMaxIterationLabel = new System.Windows.Forms.Label();
            this.svmRadioButton = new System.Windows.Forms.RadioButton();
            this.logisticRegressionRadioButton = new System.Windows.Forms.RadioButton();
            this.decisionTreeRadioButton = new System.Windows.Forms.RadioButton();
            this.modelTestingTabPage = new System.Windows.Forms.TabPage();
            this.testingVisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.testingZedGraphControl = new ZedGraph.ZedGraphControl();
            this.testingVisualizationPanel = new System.Windows.Forms.Panel();
            this.testingXComboBox = new System.Windows.Forms.ComboBox();
            this.testingYComboBox = new System.Windows.Forms.ComboBox();
            this.testingYLabel = new System.Windows.Forms.Label();
            this.testingXLabel = new System.Windows.Forms.Label();
            this.predictionGroupBox = new System.Windows.Forms.GroupBox();
            this.predictionDataGridView = new System.Windows.Forms.DataGridView();
            this.predictButton = new System.Windows.Forms.Button();
            this.testingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.testingDataGridView = new System.Windows.Forms.DataGridView();
            this.testingPanel = new System.Windows.Forms.Panel();
            this.testingFromLabel = new System.Windows.Forms.Label();
            this.numberOfMatchesLabel = new System.Windows.Forms.Label();
            this.testingFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.testingToLabel = new System.Windows.Forms.Label();
            this.testingToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.testButton = new System.Windows.Forms.Button();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.inputDataTabPage.SuspendLayout();
            this.inputDataVisualizationGroupBox.SuspendLayout();
            this.inputDataVisualizationPanel.SuspendLayout();
            this.learningTabPage.SuspendLayout();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).BeginInit();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svmToleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positiveWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.modelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regulationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticRegressionMaxIterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticRegressionToleranceNumericUpDown)).BeginInit();
            this.modelTestingTabPage.SuspendLayout();
            this.testingVisualizationGroupBox.SuspendLayout();
            this.testingVisualizationPanel.SuspendLayout();
            this.predictionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionDataGridView)).BeginInit();
            this.testingDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataGridView)).BeginInit();
            this.testingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testingFromNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingToNumericUpDown)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.inputDataGridView);
            this.inputDataGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputDataGroupBox.Location = new System.Drawing.Point(3, 3);
            this.inputDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Size = new System.Drawing.Size(385, 518);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Input Data";
            // 
            // inputDataGridView
            // 
            this.inputDataGridView.AllowUserToAddRows = false;
            this.inputDataGridView.AllowUserToDeleteRows = false;
            this.inputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inputDataGridView.Location = new System.Drawing.Point(4, 24);
            this.inputDataGridView.Name = "inputDataGridView";
            this.inputDataGridView.ReadOnly = true;
            this.inputDataGridView.RowHeadersVisible = false;
            this.inputDataGridView.RowTemplate.Height = 24;
            this.inputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputDataGridView.ShowCellErrors = false;
            this.inputDataGridView.ShowEditingIcon = false;
            this.inputDataGridView.ShowRowErrors = false;
            this.inputDataGridView.Size = new System.Drawing.Size(377, 489);
            this.inputDataGridView.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.inputDataTabPage);
            this.mainTabControl.Controls.Add(this.learningTabPage);
            this.mainTabControl.Controls.Add(this.modelTestingTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(984, 557);
            this.mainTabControl.TabIndex = 0;
            // 
            // inputDataTabPage
            // 
            this.inputDataTabPage.Controls.Add(this.inputDataVisualizationGroupBox);
            this.inputDataTabPage.Controls.Add(this.inputDataGroupBox);
            this.inputDataTabPage.Location = new System.Drawing.Point(4, 29);
            this.inputDataTabPage.Name = "inputDataTabPage";
            this.inputDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inputDataTabPage.Size = new System.Drawing.Size(976, 524);
            this.inputDataTabPage.TabIndex = 0;
            this.inputDataTabPage.Text = "Input Data";
            this.inputDataTabPage.UseVisualStyleBackColor = true;
            // 
            // inputDataVisualizationGroupBox
            // 
            this.inputDataVisualizationGroupBox.Controls.Add(this.inputDataZedGraphControl);
            this.inputDataVisualizationGroupBox.Controls.Add(this.inputDataVisualizationPanel);
            this.inputDataVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataVisualizationGroupBox.Location = new System.Drawing.Point(388, 3);
            this.inputDataVisualizationGroupBox.Name = "inputDataVisualizationGroupBox";
            this.inputDataVisualizationGroupBox.Size = new System.Drawing.Size(585, 518);
            this.inputDataVisualizationGroupBox.TabIndex = 1;
            this.inputDataVisualizationGroupBox.TabStop = false;
            this.inputDataVisualizationGroupBox.Text = "2D Visualization";
            // 
            // inputDataZedGraphControl
            // 
            this.inputDataZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataZedGraphControl.Location = new System.Drawing.Point(3, 77);
            this.inputDataZedGraphControl.Margin = new System.Windows.Forms.Padding(8);
            this.inputDataZedGraphControl.Name = "inputDataZedGraphControl";
            this.inputDataZedGraphControl.ScrollGrace = 0D;
            this.inputDataZedGraphControl.ScrollMaxX = 0D;
            this.inputDataZedGraphControl.ScrollMaxY = 0D;
            this.inputDataZedGraphControl.ScrollMaxY2 = 0D;
            this.inputDataZedGraphControl.ScrollMinX = 0D;
            this.inputDataZedGraphControl.ScrollMinY = 0D;
            this.inputDataZedGraphControl.ScrollMinY2 = 0D;
            this.inputDataZedGraphControl.Size = new System.Drawing.Size(579, 438);
            this.inputDataZedGraphControl.TabIndex = 1;
            this.inputDataZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // inputDataVisualizationPanel
            // 
            this.inputDataVisualizationPanel.Controls.Add(this.inputDataXComboBox);
            this.inputDataVisualizationPanel.Controls.Add(this.inputDataYComboBox);
            this.inputDataVisualizationPanel.Controls.Add(this.inputDataYLabel);
            this.inputDataVisualizationPanel.Controls.Add(this.inputDataXLabel);
            this.inputDataVisualizationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputDataVisualizationPanel.Location = new System.Drawing.Point(3, 22);
            this.inputDataVisualizationPanel.Name = "inputDataVisualizationPanel";
            this.inputDataVisualizationPanel.Size = new System.Drawing.Size(579, 55);
            this.inputDataVisualizationPanel.TabIndex = 0;
            // 
            // inputDataXComboBox
            // 
            this.inputDataXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDataXComboBox.FormattingEnabled = true;
            this.inputDataXComboBox.Location = new System.Drawing.Point(38, 11);
            this.inputDataXComboBox.Name = "inputDataXComboBox";
            this.inputDataXComboBox.Size = new System.Drawing.Size(200, 28);
            this.inputDataXComboBox.TabIndex = 0;
            this.inputDataXComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYComboBox
            // 
            this.inputDataYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDataYComboBox.FormattingEnabled = true;
            this.inputDataYComboBox.Location = new System.Drawing.Point(278, 11);
            this.inputDataYComboBox.Name = "inputDataYComboBox";
            this.inputDataYComboBox.Size = new System.Drawing.Size(200, 28);
            this.inputDataYComboBox.TabIndex = 1;
            this.inputDataYComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYLabel
            // 
            this.inputDataYLabel.AutoSize = true;
            this.inputDataYLabel.Location = new System.Drawing.Point(252, 14);
            this.inputDataYLabel.Name = "inputDataYLabel";
            this.inputDataYLabel.Size = new System.Drawing.Size(20, 20);
            this.inputDataYLabel.TabIndex = 0;
            this.inputDataYLabel.Text = "y:";
            // 
            // inputDataXLabel
            // 
            this.inputDataXLabel.AutoSize = true;
            this.inputDataXLabel.Location = new System.Drawing.Point(12, 14);
            this.inputDataXLabel.Name = "inputDataXLabel";
            this.inputDataXLabel.Size = new System.Drawing.Size(20, 20);
            this.inputDataXLabel.TabIndex = 0;
            this.inputDataXLabel.Text = "x:";
            // 
            // learningTabPage
            // 
            this.learningTabPage.Controls.Add(this.learningGroupBox);
            this.learningTabPage.Controls.Add(this.kernelGroupBox);
            this.learningTabPage.Controls.Add(this.modelGroupBox);
            this.learningTabPage.Location = new System.Drawing.Point(4, 29);
            this.learningTabPage.Name = "learningTabPage";
            this.learningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.learningTabPage.Size = new System.Drawing.Size(976, 524);
            this.learningTabPage.TabIndex = 3;
            this.learningTabPage.Text = "Learning";
            this.learningTabPage.UseVisualStyleBackColor = true;
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.learnButton);
            this.learningGroupBox.Controls.Add(this.toleranceNumericUpDown);
            this.learningGroupBox.Controls.Add(this.toleranceLabel);
            this.learningGroupBox.Controls.Add(this.learningToNumericUpDown);
            this.learningGroupBox.Controls.Add(this.maxIterationNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningToLabel);
            this.learningGroupBox.Controls.Add(this.maxIterationLabel);
            this.learningGroupBox.Controls.Add(this.learningFromNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningFromLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningGroupBox.Location = new System.Drawing.Point(748, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(225, 518);
            this.learningGroupBox.TabIndex = 2;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(119, 190);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(100, 30);
            this.learnButton.TabIndex = 4;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // toleranceNumericUpDown
            // 
            this.toleranceNumericUpDown.DecimalPlaces = 5;
            this.toleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(119, 60);
            this.toleranceNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.toleranceNumericUpDown.TabIndex = 1;
            this.toleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(34, 62);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(79, 20);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // learningToNumericUpDown
            // 
            this.learningToNumericUpDown.Location = new System.Drawing.Point(119, 142);
            this.learningToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningToNumericUpDown.Name = "learningToNumericUpDown";
            this.learningToNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.learningToNumericUpDown.TabIndex = 3;
            this.learningToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxIterationNumericUpDown
            // 
            this.maxIterationNumericUpDown.Location = new System.Drawing.Point(119, 28);
            this.maxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Name = "maxIterationNumericUpDown";
            this.maxIterationNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.maxIterationNumericUpDown.TabIndex = 0;
            this.maxIterationNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // learningToLabel
            // 
            this.learningToLabel.AutoSize = true;
            this.learningToLabel.Location = new System.Drawing.Point(86, 144);
            this.learningToLabel.Name = "learningToLabel";
            this.learningToLabel.Size = new System.Drawing.Size(27, 20);
            this.learningToLabel.TabIndex = 0;
            this.learningToLabel.Text = "To";
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Location = new System.Drawing.Point(12, 30);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(101, 20);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max Iteration";
            // 
            // learningFromNumericUpDown
            // 
            this.learningFromNumericUpDown.Location = new System.Drawing.Point(119, 110);
            this.learningFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningFromNumericUpDown.Name = "learningFromNumericUpDown";
            this.learningFromNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.learningFromNumericUpDown.TabIndex = 2;
            this.learningFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // learningFromLabel
            // 
            this.learningFromLabel.AutoSize = true;
            this.learningFromLabel.Location = new System.Drawing.Point(67, 112);
            this.learningFromLabel.Name = "learningFromLabel";
            this.learningFromLabel.Size = new System.Drawing.Size(46, 20);
            this.learningFromLabel.TabIndex = 0;
            this.learningFromLabel.Text = "From";
            // 
            // kernelGroupBox
            // 
            this.kernelGroupBox.Controls.Add(this.sigmoidEstimateButton);
            this.kernelGroupBox.Controls.Add(this.laplacianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.complexityEstimateButton);
            this.kernelGroupBox.Controls.Add(this.svmToleranceNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeLabel);
            this.kernelGroupBox.Controls.Add(this.negativeWeightNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.positiveWeightNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.complexityNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantLabel);
            this.kernelGroupBox.Controls.Add(this.complexityLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.polynomialKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.costRatioLabel);
            this.kernelGroupBox.Controls.Add(this.svmToleranceLabel);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaNumericUpDown);
            this.kernelGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.kernelGroupBox.Enabled = false;
            this.kernelGroupBox.Location = new System.Drawing.Point(358, 3);
            this.kernelGroupBox.Name = "kernelGroupBox";
            this.kernelGroupBox.Size = new System.Drawing.Size(390, 518);
            this.kernelGroupBox.TabIndex = 1;
            this.kernelGroupBox.TabStop = false;
            this.kernelGroupBox.Text = "Kernel (for SVM)";
            // 
            // sigmoidEstimateButton
            // 
            this.sigmoidEstimateButton.Enabled = false;
            this.sigmoidEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidEstimateButton.Location = new System.Drawing.Point(260, 312);
            this.sigmoidEstimateButton.Name = "sigmoidEstimateButton";
            this.sigmoidEstimateButton.Size = new System.Drawing.Size(100, 30);
            this.sigmoidEstimateButton.TabIndex = 11;
            this.sigmoidEstimateButton.Text = "Estimate";
            this.sigmoidEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sigmoidEstimateButton.UseVisualStyleBackColor = true;
            this.sigmoidEstimateButton.Click += new System.EventHandler(this.sigmoidEstimateButton_Click);
            // 
            // laplacianEstimateButton
            // 
            this.laplacianEstimateButton.Enabled = false;
            this.laplacianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianEstimateButton.Location = new System.Drawing.Point(260, 240);
            this.laplacianEstimateButton.Name = "laplacianEstimateButton";
            this.laplacianEstimateButton.Size = new System.Drawing.Size(100, 30);
            this.laplacianEstimateButton.TabIndex = 8;
            this.laplacianEstimateButton.Text = "Estimate";
            this.laplacianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.laplacianEstimateButton.UseVisualStyleBackColor = true;
            this.laplacianEstimateButton.Click += new System.EventHandler(this.laplacianEstimateButton_Click);
            // 
            // gaussianEstimateButton
            // 
            this.gaussianEstimateButton.Enabled = false;
            this.gaussianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianEstimateButton.Location = new System.Drawing.Point(260, 169);
            this.gaussianEstimateButton.Name = "gaussianEstimateButton";
            this.gaussianEstimateButton.Size = new System.Drawing.Size(100, 30);
            this.gaussianEstimateButton.TabIndex = 5;
            this.gaussianEstimateButton.Text = "Estimate";
            this.gaussianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gaussianEstimateButton.UseVisualStyleBackColor = true;
            this.gaussianEstimateButton.Click += new System.EventHandler(this.gaussianEstimateButton_Click);
            // 
            // complexityEstimateButton
            // 
            this.complexityEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexityEstimateButton.Location = new System.Drawing.Point(260, 394);
            this.complexityEstimateButton.Name = "complexityEstimateButton";
            this.complexityEstimateButton.Size = new System.Drawing.Size(100, 30);
            this.complexityEstimateButton.TabIndex = 14;
            this.complexityEstimateButton.Text = "Estimate";
            this.complexityEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.complexityEstimateButton.UseVisualStyleBackColor = true;
            this.complexityEstimateButton.Click += new System.EventHandler(this.complexityEstimateButton_Click);
            // 
            // svmToleranceNumericUpDown
            // 
            this.svmToleranceNumericUpDown.DecimalPlaces = 4;
            this.svmToleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.svmToleranceNumericUpDown.Location = new System.Drawing.Point(133, 467);
            this.svmToleranceNumericUpDown.Name = "svmToleranceNumericUpDown";
            this.svmToleranceNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.svmToleranceNumericUpDown.TabIndex = 17;
            this.svmToleranceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.svmToleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // gaussianKernelRadioButton
            // 
            this.gaussianKernelRadioButton.AutoSize = true;
            this.gaussianKernelRadioButton.Location = new System.Drawing.Point(6, 136);
            this.gaussianKernelRadioButton.Name = "gaussianKernelRadioButton";
            this.gaussianKernelRadioButton.Size = new System.Drawing.Size(144, 24);
            this.gaussianKernelRadioButton.TabIndex = 3;
            this.gaussianKernelRadioButton.Text = "Gaussian Kernel";
            this.gaussianKernelRadioButton.UseVisualStyleBackColor = true;
            this.gaussianKernelRadioButton.CheckedChanged += new System.EventHandler(this.kernelRadioButton_CheckedChanged);
            // 
            // laplacianSigmaLabel
            // 
            this.laplacianSigmaLabel.AutoSize = true;
            this.laplacianSigmaLabel.Location = new System.Drawing.Point(105, 244);
            this.laplacianSigmaLabel.Name = "laplacianSigmaLabel";
            this.laplacianSigmaLabel.Size = new System.Drawing.Size(22, 20);
            this.laplacianSigmaLabel.TabIndex = 0;
            this.laplacianSigmaLabel.Text = "σ:";
            // 
            // gaussianSigmaLabel
            // 
            this.gaussianSigmaLabel.AutoSize = true;
            this.gaussianSigmaLabel.Location = new System.Drawing.Point(105, 173);
            this.gaussianSigmaLabel.Name = "gaussianSigmaLabel";
            this.gaussianSigmaLabel.Size = new System.Drawing.Size(22, 20);
            this.gaussianSigmaLabel.TabIndex = 0;
            this.gaussianSigmaLabel.Text = "σ:";
            // 
            // sigmoidConstantNumericUpDown
            // 
            this.sigmoidConstantNumericUpDown.DecimalPlaces = 4;
            this.sigmoidConstantNumericUpDown.Enabled = false;
            this.sigmoidConstantNumericUpDown.Location = new System.Drawing.Point(133, 349);
            this.sigmoidConstantNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.sigmoidConstantNumericUpDown.Name = "sigmoidConstantNumericUpDown";
            this.sigmoidConstantNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.sigmoidConstantNumericUpDown.TabIndex = 12;
            this.sigmoidConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sigmoidAlphaLabel
            // 
            this.sigmoidAlphaLabel.AutoSize = true;
            this.sigmoidAlphaLabel.Location = new System.Drawing.Point(105, 317);
            this.sigmoidAlphaLabel.Name = "sigmoidAlphaLabel";
            this.sigmoidAlphaLabel.Size = new System.Drawing.Size(22, 20);
            this.sigmoidAlphaLabel.TabIndex = 0;
            this.sigmoidAlphaLabel.Text = "α:";
            // 
            // sigmoidAlphaNumericUpDown
            // 
            this.sigmoidAlphaNumericUpDown.DecimalPlaces = 4;
            this.sigmoidAlphaNumericUpDown.Enabled = false;
            this.sigmoidAlphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.sigmoidAlphaNumericUpDown.Location = new System.Drawing.Point(133, 313);
            this.sigmoidAlphaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidAlphaNumericUpDown.Name = "sigmoidAlphaNumericUpDown";
            this.sigmoidAlphaNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.sigmoidAlphaNumericUpDown.TabIndex = 10;
            this.sigmoidAlphaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // polynomialConstantLabel
            // 
            this.polynomialConstantLabel.AutoSize = true;
            this.polynomialConstantLabel.Location = new System.Drawing.Point(49, 102);
            this.polynomialConstantLabel.Name = "polynomialConstantLabel";
            this.polynomialConstantLabel.Size = new System.Drawing.Size(78, 20);
            this.polynomialConstantLabel.TabIndex = 0;
            this.polynomialConstantLabel.Text = "Constant:";
            // 
            // polynomialDegreeLabel
            // 
            this.polynomialDegreeLabel.AutoSize = true;
            this.polynomialDegreeLabel.Location = new System.Drawing.Point(61, 67);
            this.polynomialDegreeLabel.Name = "polynomialDegreeLabel";
            this.polynomialDegreeLabel.Size = new System.Drawing.Size(66, 20);
            this.polynomialDegreeLabel.TabIndex = 0;
            this.polynomialDegreeLabel.Text = "Degree:";
            // 
            // negativeWeightNumericUpDown
            // 
            this.negativeWeightNumericUpDown.DecimalPlaces = 4;
            this.negativeWeightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.negativeWeightNumericUpDown.Location = new System.Drawing.Point(260, 431);
            this.negativeWeightNumericUpDown.Name = "negativeWeightNumericUpDown";
            this.negativeWeightNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.negativeWeightNumericUpDown.TabIndex = 16;
            this.negativeWeightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.negativeWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // positiveWeightNumericUpDown
            // 
            this.positiveWeightNumericUpDown.DecimalPlaces = 4;
            this.positiveWeightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.positiveWeightNumericUpDown.Location = new System.Drawing.Point(133, 431);
            this.positiveWeightNumericUpDown.Name = "positiveWeightNumericUpDown";
            this.positiveWeightNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.positiveWeightNumericUpDown.TabIndex = 15;
            this.positiveWeightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.positiveWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // complexityNumericUpDown
            // 
            this.complexityNumericUpDown.DecimalPlaces = 4;
            this.complexityNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.complexityNumericUpDown.Location = new System.Drawing.Point(133, 395);
            this.complexityNumericUpDown.Name = "complexityNumericUpDown";
            this.complexityNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.complexityNumericUpDown.TabIndex = 13;
            this.complexityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.complexityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // polynomialConstantNumericUpDown
            // 
            this.polynomialConstantNumericUpDown.DecimalPlaces = 4;
            this.polynomialConstantNumericUpDown.Location = new System.Drawing.Point(133, 100);
            this.polynomialConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.polynomialConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.polynomialConstantNumericUpDown.Name = "polynomialConstantNumericUpDown";
            this.polynomialConstantNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.polynomialConstantNumericUpDown.TabIndex = 2;
            this.polynomialConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // polynomialDegreeNumericUpDown
            // 
            this.polynomialDegreeNumericUpDown.Location = new System.Drawing.Point(133, 64);
            this.polynomialDegreeNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Name = "polynomialDegreeNumericUpDown";
            this.polynomialDegreeNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.polynomialDegreeNumericUpDown.TabIndex = 1;
            this.polynomialDegreeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.polynomialDegreeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sigmoidConstantLabel
            // 
            this.sigmoidConstantLabel.AutoSize = true;
            this.sigmoidConstantLabel.Location = new System.Drawing.Point(49, 351);
            this.sigmoidConstantLabel.Name = "sigmoidConstantLabel";
            this.sigmoidConstantLabel.Size = new System.Drawing.Size(78, 20);
            this.sigmoidConstantLabel.TabIndex = 0;
            this.sigmoidConstantLabel.Text = "Constant:";
            // 
            // complexityLabel
            // 
            this.complexityLabel.AutoSize = true;
            this.complexityLabel.Location = new System.Drawing.Point(38, 399);
            this.complexityLabel.Name = "complexityLabel";
            this.complexityLabel.Size = new System.Drawing.Size(89, 20);
            this.complexityLabel.TabIndex = 0;
            this.complexityLabel.Text = "Complexity:";
            // 
            // sigmoidKernelRadioButton
            // 
            this.sigmoidKernelRadioButton.AutoSize = true;
            this.sigmoidKernelRadioButton.Location = new System.Drawing.Point(6, 278);
            this.sigmoidKernelRadioButton.Name = "sigmoidKernelRadioButton";
            this.sigmoidKernelRadioButton.Size = new System.Drawing.Size(133, 24);
            this.sigmoidKernelRadioButton.TabIndex = 9;
            this.sigmoidKernelRadioButton.Text = "Sigmoid Kernel";
            this.sigmoidKernelRadioButton.UseVisualStyleBackColor = true;
            this.sigmoidKernelRadioButton.CheckedChanged += new System.EventHandler(this.kernelRadioButton_CheckedChanged);
            // 
            // laplacianKernelRadioButton
            // 
            this.laplacianKernelRadioButton.AutoSize = true;
            this.laplacianKernelRadioButton.Location = new System.Drawing.Point(6, 207);
            this.laplacianKernelRadioButton.Name = "laplacianKernelRadioButton";
            this.laplacianKernelRadioButton.Size = new System.Drawing.Size(144, 24);
            this.laplacianKernelRadioButton.TabIndex = 6;
            this.laplacianKernelRadioButton.Text = "Laplacian Kernel";
            this.laplacianKernelRadioButton.UseVisualStyleBackColor = true;
            this.laplacianKernelRadioButton.CheckedChanged += new System.EventHandler(this.kernelRadioButton_CheckedChanged);
            // 
            // polynomialKernelRadioButton
            // 
            this.polynomialKernelRadioButton.AutoSize = true;
            this.polynomialKernelRadioButton.Checked = true;
            this.polynomialKernelRadioButton.Location = new System.Drawing.Point(6, 29);
            this.polynomialKernelRadioButton.Name = "polynomialKernelRadioButton";
            this.polynomialKernelRadioButton.Size = new System.Drawing.Size(151, 24);
            this.polynomialKernelRadioButton.TabIndex = 0;
            this.polynomialKernelRadioButton.TabStop = true;
            this.polynomialKernelRadioButton.Text = "Polynomial Kernel";
            this.polynomialKernelRadioButton.UseVisualStyleBackColor = true;
            this.polynomialKernelRadioButton.CheckedChanged += new System.EventHandler(this.kernelRadioButton_CheckedChanged);
            // 
            // costRatioLabel
            // 
            this.costRatioLabel.AutoSize = true;
            this.costRatioLabel.Location = new System.Drawing.Point(39, 433);
            this.costRatioLabel.Name = "costRatioLabel";
            this.costRatioLabel.Size = new System.Drawing.Size(88, 20);
            this.costRatioLabel.TabIndex = 0;
            this.costRatioLabel.Text = "Cost Ratio:";
            // 
            // svmToleranceLabel
            // 
            this.svmToleranceLabel.AutoSize = true;
            this.svmToleranceLabel.Location = new System.Drawing.Point(44, 469);
            this.svmToleranceLabel.Name = "svmToleranceLabel";
            this.svmToleranceLabel.Size = new System.Drawing.Size(83, 20);
            this.svmToleranceLabel.TabIndex = 0;
            this.svmToleranceLabel.Text = "Tolerance:";
            // 
            // laplacianSigmaNumericUpDown
            // 
            this.laplacianSigmaNumericUpDown.DecimalPlaces = 4;
            this.laplacianSigmaNumericUpDown.Enabled = false;
            this.laplacianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.laplacianSigmaNumericUpDown.Location = new System.Drawing.Point(133, 242);
            this.laplacianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.laplacianSigmaNumericUpDown.Name = "laplacianSigmaNumericUpDown";
            this.laplacianSigmaNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.laplacianSigmaNumericUpDown.TabIndex = 7;
            this.laplacianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplacianSigmaNumericUpDown.Value = new decimal(new int[] {
            12236,
            0,
            0,
            262144});
            // 
            // gaussianSigmaNumericUpDown
            // 
            this.gaussianSigmaNumericUpDown.DecimalPlaces = 4;
            this.gaussianSigmaNumericUpDown.Enabled = false;
            this.gaussianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gaussianSigmaNumericUpDown.Location = new System.Drawing.Point(133, 171);
            this.gaussianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaussianSigmaNumericUpDown.Name = "gaussianSigmaNumericUpDown";
            this.gaussianSigmaNumericUpDown.Size = new System.Drawing.Size(121, 26);
            this.gaussianSigmaNumericUpDown.TabIndex = 4;
            this.gaussianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gaussianSigmaNumericUpDown.Value = new decimal(new int[] {
            12236,
            0,
            0,
            262144});
            // 
            // modelGroupBox
            // 
            this.modelGroupBox.Controls.Add(this.regulationNumericUpDown);
            this.modelGroupBox.Controls.Add(this.regulationLabel);
            this.modelGroupBox.Controls.Add(this.logisticRegressionMethodComboBox);
            this.modelGroupBox.Controls.Add(this.logisticRegressionMethodLabel);
            this.modelGroupBox.Controls.Add(this.svmMethodComboBox);
            this.modelGroupBox.Controls.Add(this.svmMethodLabel);
            this.modelGroupBox.Controls.Add(this.logisticRegressionMaxIterationNumericUpDown);
            this.modelGroupBox.Controls.Add(this.logisticRegressionToleranceNumericUpDown);
            this.modelGroupBox.Controls.Add(this.logisticRegressionMethodToleranceLabel);
            this.modelGroupBox.Controls.Add(this.logisticRegressionMethodMaxIterationLabel);
            this.modelGroupBox.Controls.Add(this.svmRadioButton);
            this.modelGroupBox.Controls.Add(this.logisticRegressionRadioButton);
            this.modelGroupBox.Controls.Add(this.decisionTreeRadioButton);
            this.modelGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.modelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.Size = new System.Drawing.Size(355, 518);
            this.modelGroupBox.TabIndex = 0;
            this.modelGroupBox.TabStop = false;
            this.modelGroupBox.Text = "Model";
            // 
            // regulationNumericUpDown
            // 
            this.regulationNumericUpDown.Enabled = false;
            this.regulationNumericUpDown.Location = new System.Drawing.Point(135, 166);
            this.regulationNumericUpDown.Name = "regulationNumericUpDown";
            this.regulationNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.regulationNumericUpDown.TabIndex = 12;
            // 
            // regulationLabel
            // 
            this.regulationLabel.AutoSize = true;
            this.regulationLabel.Location = new System.Drawing.Point(39, 168);
            this.regulationLabel.Name = "regulationLabel";
            this.regulationLabel.Size = new System.Drawing.Size(90, 20);
            this.regulationLabel.TabIndex = 11;
            this.regulationLabel.Text = "Regulation:";
            // 
            // logisticRegressionMethodComboBox
            // 
            this.logisticRegressionMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logisticRegressionMethodComboBox.Enabled = false;
            this.logisticRegressionMethodComboBox.FormattingEnabled = true;
            this.logisticRegressionMethodComboBox.Items.AddRange(new object[] {
            "Iterative Reweighted Least Squares"});
            this.logisticRegressionMethodComboBox.Location = new System.Drawing.Point(9, 132);
            this.logisticRegressionMethodComboBox.Name = "logisticRegressionMethodComboBox";
            this.logisticRegressionMethodComboBox.Size = new System.Drawing.Size(340, 28);
            this.logisticRegressionMethodComboBox.TabIndex = 5;
            // 
            // logisticRegressionMethodLabel
            // 
            this.logisticRegressionMethodLabel.AutoSize = true;
            this.logisticRegressionMethodLabel.Location = new System.Drawing.Point(28, 109);
            this.logisticRegressionMethodLabel.Name = "logisticRegressionMethodLabel";
            this.logisticRegressionMethodLabel.Size = new System.Drawing.Size(63, 20);
            this.logisticRegressionMethodLabel.TabIndex = 0;
            this.logisticRegressionMethodLabel.Text = "Method";
            // 
            // svmMethodComboBox
            // 
            this.svmMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.svmMethodComboBox.Enabled = false;
            this.svmMethodComboBox.FormattingEnabled = true;
            this.svmMethodComboBox.Items.AddRange(new object[] {
            "Sequential Minimal Optimization",
            "Least Squares",
            "Linear Coordinate Descent",
            "Linear Dual Coordinate Descent",
            "Linear Newton",
            "Probabilistic Coordinate Descent",
            "Probabilistic Dual Coordinate Descent",
            "Probabilistic Newton"});
            this.svmMethodComboBox.Location = new System.Drawing.Point(5, 411);
            this.svmMethodComboBox.Name = "svmMethodComboBox";
            this.svmMethodComboBox.Size = new System.Drawing.Size(340, 28);
            this.svmMethodComboBox.TabIndex = 9;
            // 
            // svmMethodLabel
            // 
            this.svmMethodLabel.AutoSize = true;
            this.svmMethodLabel.Location = new System.Drawing.Point(23, 388);
            this.svmMethodLabel.Name = "svmMethodLabel";
            this.svmMethodLabel.Size = new System.Drawing.Size(63, 20);
            this.svmMethodLabel.TabIndex = 0;
            this.svmMethodLabel.Text = "Method";
            // 
            // logisticRegressionMaxIterationNumericUpDown
            // 
            this.logisticRegressionMaxIterationNumericUpDown.Enabled = false;
            this.logisticRegressionMaxIterationNumericUpDown.Location = new System.Drawing.Point(135, 198);
            this.logisticRegressionMaxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.logisticRegressionMaxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logisticRegressionMaxIterationNumericUpDown.Name = "logisticRegressionMaxIterationNumericUpDown";
            this.logisticRegressionMaxIterationNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.logisticRegressionMaxIterationNumericUpDown.TabIndex = 6;
            this.logisticRegressionMaxIterationNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // logisticRegressionToleranceNumericUpDown
            // 
            this.logisticRegressionToleranceNumericUpDown.DecimalPlaces = 4;
            this.logisticRegressionToleranceNumericUpDown.Enabled = false;
            this.logisticRegressionToleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.logisticRegressionToleranceNumericUpDown.Location = new System.Drawing.Point(135, 230);
            this.logisticRegressionToleranceNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logisticRegressionToleranceNumericUpDown.Name = "logisticRegressionToleranceNumericUpDown";
            this.logisticRegressionToleranceNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.logisticRegressionToleranceNumericUpDown.TabIndex = 7;
            this.logisticRegressionToleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // logisticRegressionMethodToleranceLabel
            // 
            this.logisticRegressionMethodToleranceLabel.AutoSize = true;
            this.logisticRegressionMethodToleranceLabel.Location = new System.Drawing.Point(46, 232);
            this.logisticRegressionMethodToleranceLabel.Name = "logisticRegressionMethodToleranceLabel";
            this.logisticRegressionMethodToleranceLabel.Size = new System.Drawing.Size(83, 20);
            this.logisticRegressionMethodToleranceLabel.TabIndex = 0;
            this.logisticRegressionMethodToleranceLabel.Text = "Tolerance:";
            // 
            // logisticRegressionMethodMaxIterationLabel
            // 
            this.logisticRegressionMethodMaxIterationLabel.AutoSize = true;
            this.logisticRegressionMethodMaxIterationLabel.Location = new System.Drawing.Point(24, 200);
            this.logisticRegressionMethodMaxIterationLabel.Name = "logisticRegressionMethodMaxIterationLabel";
            this.logisticRegressionMethodMaxIterationLabel.Size = new System.Drawing.Size(105, 20);
            this.logisticRegressionMethodMaxIterationLabel.TabIndex = 0;
            this.logisticRegressionMethodMaxIterationLabel.Text = "Max Iteration:";
            // 
            // svmRadioButton
            // 
            this.svmRadioButton.AutoSize = true;
            this.svmRadioButton.Location = new System.Drawing.Point(0, 351);
            this.svmRadioButton.Name = "svmRadioButton";
            this.svmRadioButton.Size = new System.Drawing.Size(248, 24);
            this.svmRadioButton.TabIndex = 8;
            this.svmRadioButton.Text = "Support Vector Machine (SVM)";
            this.svmRadioButton.UseVisualStyleBackColor = true;
            this.svmRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // logisticRegressionRadioButton
            // 
            this.logisticRegressionRadioButton.AutoSize = true;
            this.logisticRegressionRadioButton.Location = new System.Drawing.Point(6, 67);
            this.logisticRegressionRadioButton.Name = "logisticRegressionRadioButton";
            this.logisticRegressionRadioButton.Size = new System.Drawing.Size(166, 24);
            this.logisticRegressionRadioButton.TabIndex = 4;
            this.logisticRegressionRadioButton.Text = "Logistic Regression";
            this.logisticRegressionRadioButton.UseVisualStyleBackColor = true;
            this.logisticRegressionRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // decisionTreeRadioButton
            // 
            this.decisionTreeRadioButton.AutoSize = true;
            this.decisionTreeRadioButton.Checked = true;
            this.decisionTreeRadioButton.Location = new System.Drawing.Point(6, 30);
            this.decisionTreeRadioButton.Name = "decisionTreeRadioButton";
            this.decisionTreeRadioButton.Size = new System.Drawing.Size(167, 24);
            this.decisionTreeRadioButton.TabIndex = 3;
            this.decisionTreeRadioButton.TabStop = true;
            this.decisionTreeRadioButton.Text = "Decision Tree (C45)";
            this.decisionTreeRadioButton.UseVisualStyleBackColor = true;
            this.decisionTreeRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // modelTestingTabPage
            // 
            this.modelTestingTabPage.Controls.Add(this.testingVisualizationGroupBox);
            this.modelTestingTabPage.Controls.Add(this.predictionGroupBox);
            this.modelTestingTabPage.Controls.Add(this.testingDataGroupBox);
            this.modelTestingTabPage.Location = new System.Drawing.Point(4, 29);
            this.modelTestingTabPage.Name = "modelTestingTabPage";
            this.modelTestingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelTestingTabPage.Size = new System.Drawing.Size(976, 524);
            this.modelTestingTabPage.TabIndex = 2;
            this.modelTestingTabPage.Text = "Model Testing";
            this.modelTestingTabPage.UseVisualStyleBackColor = true;
            // 
            // testingVisualizationGroupBox
            // 
            this.testingVisualizationGroupBox.Controls.Add(this.testingZedGraphControl);
            this.testingVisualizationGroupBox.Controls.Add(this.testingVisualizationPanel);
            this.testingVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingVisualizationGroupBox.Location = new System.Drawing.Point(443, 153);
            this.testingVisualizationGroupBox.Name = "testingVisualizationGroupBox";
            this.testingVisualizationGroupBox.Size = new System.Drawing.Size(530, 368);
            this.testingVisualizationGroupBox.TabIndex = 2;
            this.testingVisualizationGroupBox.TabStop = false;
            this.testingVisualizationGroupBox.Text = "2D Visualization";
            // 
            // testingZedGraphControl
            // 
            this.testingZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingZedGraphControl.Location = new System.Drawing.Point(3, 77);
            this.testingZedGraphControl.Margin = new System.Windows.Forms.Padding(8);
            this.testingZedGraphControl.Name = "testingZedGraphControl";
            this.testingZedGraphControl.ScrollGrace = 0D;
            this.testingZedGraphControl.ScrollMaxX = 0D;
            this.testingZedGraphControl.ScrollMaxY = 0D;
            this.testingZedGraphControl.ScrollMaxY2 = 0D;
            this.testingZedGraphControl.ScrollMinX = 0D;
            this.testingZedGraphControl.ScrollMinY = 0D;
            this.testingZedGraphControl.ScrollMinY2 = 0D;
            this.testingZedGraphControl.Size = new System.Drawing.Size(524, 288);
            this.testingZedGraphControl.TabIndex = 1;
            this.testingZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // testingVisualizationPanel
            // 
            this.testingVisualizationPanel.Controls.Add(this.testingXComboBox);
            this.testingVisualizationPanel.Controls.Add(this.testingYComboBox);
            this.testingVisualizationPanel.Controls.Add(this.testingYLabel);
            this.testingVisualizationPanel.Controls.Add(this.testingXLabel);
            this.testingVisualizationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.testingVisualizationPanel.Location = new System.Drawing.Point(3, 22);
            this.testingVisualizationPanel.Name = "testingVisualizationPanel";
            this.testingVisualizationPanel.Size = new System.Drawing.Size(524, 55);
            this.testingVisualizationPanel.TabIndex = 0;
            // 
            // testingXComboBox
            // 
            this.testingXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testingXComboBox.Enabled = false;
            this.testingXComboBox.FormattingEnabled = true;
            this.testingXComboBox.Location = new System.Drawing.Point(38, 11);
            this.testingXComboBox.Name = "testingXComboBox";
            this.testingXComboBox.Size = new System.Drawing.Size(200, 28);
            this.testingXComboBox.TabIndex = 0;
            this.testingXComboBox.SelectedIndexChanged += new System.EventHandler(this.testingComboBox_SelectedIndexChanged);
            // 
            // testingYComboBox
            // 
            this.testingYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testingYComboBox.Enabled = false;
            this.testingYComboBox.FormattingEnabled = true;
            this.testingYComboBox.Location = new System.Drawing.Point(280, 11);
            this.testingYComboBox.Name = "testingYComboBox";
            this.testingYComboBox.Size = new System.Drawing.Size(200, 28);
            this.testingYComboBox.TabIndex = 1;
            this.testingYComboBox.SelectedIndexChanged += new System.EventHandler(this.testingComboBox_SelectedIndexChanged);
            // 
            // testingYLabel
            // 
            this.testingYLabel.AutoSize = true;
            this.testingYLabel.Location = new System.Drawing.Point(254, 14);
            this.testingYLabel.Name = "testingYLabel";
            this.testingYLabel.Size = new System.Drawing.Size(20, 20);
            this.testingYLabel.TabIndex = 0;
            this.testingYLabel.Text = "y:";
            // 
            // testingXLabel
            // 
            this.testingXLabel.AutoSize = true;
            this.testingXLabel.Location = new System.Drawing.Point(12, 14);
            this.testingXLabel.Name = "testingXLabel";
            this.testingXLabel.Size = new System.Drawing.Size(20, 20);
            this.testingXLabel.TabIndex = 0;
            this.testingXLabel.Text = "x:";
            // 
            // predictionGroupBox
            // 
            this.predictionGroupBox.Controls.Add(this.predictionDataGridView);
            this.predictionGroupBox.Controls.Add(this.predictButton);
            this.predictionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.predictionGroupBox.Location = new System.Drawing.Point(443, 3);
            this.predictionGroupBox.Name = "predictionGroupBox";
            this.predictionGroupBox.Size = new System.Drawing.Size(530, 150);
            this.predictionGroupBox.TabIndex = 1;
            this.predictionGroupBox.TabStop = false;
            this.predictionGroupBox.Text = "Prediction";
            // 
            // predictionDataGridView
            // 
            this.predictionDataGridView.AllowUserToAddRows = false;
            this.predictionDataGridView.AllowUserToDeleteRows = false;
            this.predictionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionDataGridView.Location = new System.Drawing.Point(3, 22);
            this.predictionDataGridView.Name = "predictionDataGridView";
            this.predictionDataGridView.RowHeadersVisible = false;
            this.predictionDataGridView.RowTemplate.Height = 24;
            this.predictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predictionDataGridView.ShowCellErrors = false;
            this.predictionDataGridView.ShowEditingIcon = false;
            this.predictionDataGridView.ShowRowErrors = false;
            this.predictionDataGridView.Size = new System.Drawing.Size(444, 125);
            this.predictionDataGridView.TabIndex = 0;
            // 
            // predictButton
            // 
            this.predictButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.predictButton.Enabled = false;
            this.predictButton.Location = new System.Drawing.Point(447, 22);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(80, 125);
            this.predictButton.TabIndex = 1;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // testingDataGroupBox
            // 
            this.testingDataGroupBox.Controls.Add(this.testingDataGridView);
            this.testingDataGroupBox.Controls.Add(this.testingPanel);
            this.testingDataGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.testingDataGroupBox.Location = new System.Drawing.Point(3, 3);
            this.testingDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testingDataGroupBox.Name = "testingDataGroupBox";
            this.testingDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testingDataGroupBox.Size = new System.Drawing.Size(440, 518);
            this.testingDataGroupBox.TabIndex = 0;
            this.testingDataGroupBox.TabStop = false;
            this.testingDataGroupBox.Text = "Testing Data";
            // 
            // testingDataGridView
            // 
            this.testingDataGridView.AllowUserToAddRows = false;
            this.testingDataGridView.AllowUserToDeleteRows = false;
            this.testingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.testingDataGridView.Location = new System.Drawing.Point(4, 24);
            this.testingDataGridView.Name = "testingDataGridView";
            this.testingDataGridView.ReadOnly = true;
            this.testingDataGridView.RowHeadersVisible = false;
            this.testingDataGridView.RowTemplate.Height = 24;
            this.testingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testingDataGridView.ShowCellErrors = false;
            this.testingDataGridView.ShowEditingIcon = false;
            this.testingDataGridView.ShowRowErrors = false;
            this.testingDataGridView.Size = new System.Drawing.Size(432, 413);
            this.testingDataGridView.TabIndex = 0;
            // 
            // testingPanel
            // 
            this.testingPanel.Controls.Add(this.testingFromLabel);
            this.testingPanel.Controls.Add(this.numberOfMatchesLabel);
            this.testingPanel.Controls.Add(this.testingFromNumericUpDown);
            this.testingPanel.Controls.Add(this.testingToLabel);
            this.testingPanel.Controls.Add(this.testingToNumericUpDown);
            this.testingPanel.Controls.Add(this.testButton);
            this.testingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testingPanel.Location = new System.Drawing.Point(4, 437);
            this.testingPanel.Name = "testingPanel";
            this.testingPanel.Size = new System.Drawing.Size(432, 76);
            this.testingPanel.TabIndex = 4;
            // 
            // testingFromLabel
            // 
            this.testingFromLabel.AutoSize = true;
            this.testingFromLabel.Location = new System.Drawing.Point(14, 13);
            this.testingFromLabel.Name = "testingFromLabel";
            this.testingFromLabel.Size = new System.Drawing.Size(46, 20);
            this.testingFromLabel.TabIndex = 0;
            this.testingFromLabel.Text = "From";
            // 
            // numberOfMatchesLabel
            // 
            this.numberOfMatchesLabel.AutoSize = true;
            this.numberOfMatchesLabel.Location = new System.Drawing.Point(14, 45);
            this.numberOfMatchesLabel.Name = "numberOfMatchesLabel";
            this.numberOfMatchesLabel.Size = new System.Drawing.Size(152, 20);
            this.numberOfMatchesLabel.TabIndex = 0;
            this.numberOfMatchesLabel.Text = "Number of matches:";
            // 
            // testingFromNumericUpDown
            // 
            this.testingFromNumericUpDown.Location = new System.Drawing.Point(66, 11);
            this.testingFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testingFromNumericUpDown.Name = "testingFromNumericUpDown";
            this.testingFromNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.testingFromNumericUpDown.TabIndex = 1;
            this.testingFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // testingToLabel
            // 
            this.testingToLabel.AutoSize = true;
            this.testingToLabel.Location = new System.Drawing.Point(181, 13);
            this.testingToLabel.Name = "testingToLabel";
            this.testingToLabel.Size = new System.Drawing.Size(27, 20);
            this.testingToLabel.TabIndex = 0;
            this.testingToLabel.Text = "To";
            // 
            // testingToNumericUpDown
            // 
            this.testingToNumericUpDown.Location = new System.Drawing.Point(214, 11);
            this.testingToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testingToNumericUpDown.Name = "testingToNumericUpDown";
            this.testingToNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.testingToNumericUpDown.TabIndex = 2;
            this.testingToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // testButton
            // 
            this.testButton.Enabled = false;
            this.testButton.Location = new System.Drawing.Point(320, 8);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 30);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 557);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(984, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "Main Status Strip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // AdaBoostModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "AdaBoostModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaBoost (Binary Classifier)";
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataVisualizationGroupBox.ResumeLayout(false);
            this.inputDataVisualizationPanel.ResumeLayout(false);
            this.inputDataVisualizationPanel.PerformLayout();
            this.learningTabPage.ResumeLayout(false);
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).EndInit();
            this.kernelGroupBox.ResumeLayout(false);
            this.kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svmToleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positiveWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).EndInit();
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regulationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticRegressionMaxIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticRegressionToleranceNumericUpDown)).EndInit();
            this.modelTestingTabPage.ResumeLayout(false);
            this.testingVisualizationGroupBox.ResumeLayout(false);
            this.testingVisualizationPanel.ResumeLayout(false);
            this.testingVisualizationPanel.PerformLayout();
            this.predictionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.predictionDataGridView)).EndInit();
            this.testingDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testingDataGridView)).EndInit();
            this.testingPanel.ResumeLayout(false);
            this.testingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testingFromNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingToNumericUpDown)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage inputDataTabPage;
        private System.Windows.Forms.TabPage modelTestingTabPage;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.GroupBox inputDataVisualizationGroupBox;
        private System.Windows.Forms.Label inputDataYLabel;
        private System.Windows.Forms.Label inputDataXLabel;
        private System.Windows.Forms.ComboBox inputDataYComboBox;
        private System.Windows.Forms.ComboBox inputDataXComboBox;
        private ZedGraph.ZedGraphControl inputDataZedGraphControl;
        private System.Windows.Forms.GroupBox testingVisualizationGroupBox;
        private ZedGraph.ZedGraphControl testingZedGraphControl;
        private System.Windows.Forms.Label testingYLabel;
        private System.Windows.Forms.Label testingXLabel;
        private System.Windows.Forms.ComboBox testingYComboBox;
        private System.Windows.Forms.ComboBox testingXComboBox;
        private System.Windows.Forms.GroupBox testingDataGroupBox;
        private System.Windows.Forms.DataGridView testingDataGridView;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.NumericUpDown testingToNumericUpDown;
        private System.Windows.Forms.NumericUpDown testingFromNumericUpDown;
        private System.Windows.Forms.Label testingFromLabel;
        private System.Windows.Forms.Label testingToLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox predictionGroupBox;
        private System.Windows.Forms.DataGridView predictionDataGridView;
        private System.Windows.Forms.Label numberOfMatchesLabel;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.Panel inputDataVisualizationPanel;
        private System.Windows.Forms.Panel testingVisualizationPanel;
        private System.Windows.Forms.Panel testingPanel;
        private System.Windows.Forms.TabPage learningTabPage;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.NumericUpDown learningToNumericUpDown;
        private System.Windows.Forms.Label learningToLabel;
        private System.Windows.Forms.NumericUpDown learningFromNumericUpDown;
        private System.Windows.Forms.Label learningFromLabel;
        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.NumericUpDown toleranceNumericUpDown;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.NumericUpDown maxIterationNumericUpDown;
        private System.Windows.Forms.Label maxIterationLabel;
        private System.Windows.Forms.GroupBox kernelGroupBox;
        private System.Windows.Forms.Button sigmoidEstimateButton;
        private System.Windows.Forms.Button laplacianEstimateButton;
        private System.Windows.Forms.Button gaussianEstimateButton;
        private System.Windows.Forms.Button complexityEstimateButton;
        private System.Windows.Forms.NumericUpDown svmToleranceNumericUpDown;
        private System.Windows.Forms.RadioButton gaussianKernelRadioButton;
        private System.Windows.Forms.Label laplacianSigmaLabel;
        private System.Windows.Forms.Label gaussianSigmaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidConstantNumericUpDown;
        private System.Windows.Forms.Label sigmoidAlphaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidAlphaNumericUpDown;
        private System.Windows.Forms.Label polynomialConstantLabel;
        private System.Windows.Forms.Label polynomialDegreeLabel;
        private System.Windows.Forms.NumericUpDown negativeWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown positiveWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown complexityNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialConstantNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialDegreeNumericUpDown;
        private System.Windows.Forms.Label sigmoidConstantLabel;
        private System.Windows.Forms.Label complexityLabel;
        private System.Windows.Forms.RadioButton sigmoidKernelRadioButton;
        private System.Windows.Forms.RadioButton laplacianKernelRadioButton;
        private System.Windows.Forms.RadioButton polynomialKernelRadioButton;
        private System.Windows.Forms.Label costRatioLabel;
        private System.Windows.Forms.Label svmToleranceLabel;
        private System.Windows.Forms.NumericUpDown laplacianSigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussianSigmaNumericUpDown;
        private System.Windows.Forms.RadioButton decisionTreeRadioButton;
        private System.Windows.Forms.RadioButton logisticRegressionRadioButton;
        private System.Windows.Forms.NumericUpDown logisticRegressionMaxIterationNumericUpDown;
        private System.Windows.Forms.NumericUpDown logisticRegressionToleranceNumericUpDown;
        private System.Windows.Forms.Label logisticRegressionMethodToleranceLabel;
        private System.Windows.Forms.Label logisticRegressionMethodMaxIterationLabel;
        private System.Windows.Forms.ComboBox logisticRegressionMethodComboBox;
        private System.Windows.Forms.Label logisticRegressionMethodLabel;
        private System.Windows.Forms.ComboBox svmMethodComboBox;
        private System.Windows.Forms.Label svmMethodLabel;
        private System.Windows.Forms.RadioButton svmRadioButton;
        private System.Windows.Forms.NumericUpDown regulationNumericUpDown;
        private System.Windows.Forms.Label regulationLabel;
    }
}