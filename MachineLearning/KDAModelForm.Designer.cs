﻿namespace MachineLearning
{
    partial class KDAModelForm
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
            this.projectedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.projectedDataDataGridView = new System.Windows.Forms.DataGridView();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfDiscriminantsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfDiscriminantLabel = new System.Windows.Forms.Label();
            this.learnButton = new System.Windows.Forms.Button();
            this.learningToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningToLabel = new System.Windows.Forms.Label();
            this.learningFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningFromLabel = new System.Windows.Forms.Label();
            this.kernelGroupBox = new System.Windows.Forms.GroupBox();
            this.sigmoidEstimateButton = new System.Windows.Forms.Button();
            this.laplacianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaLabel = new System.Windows.Forms.Label();
            this.gaussianSigmaLabel = new System.Windows.Forms.Label();
            this.sigmoidConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidAlphaLabel = new System.Windows.Forms.Label();
            this.sigmoidAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantLabel = new System.Windows.Forms.Label();
            this.polynomialDegreeLabel = new System.Windows.Forms.Label();
            this.polynomialConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialDegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidConstantLabel = new System.Windows.Forms.Label();
            this.sigmoidKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discriminantsTabPage = new System.Windows.Forms.TabPage();
            this.visualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.cumulativeProportionComponentView = new Accord.Controls.ComponentView();
            this.proportionComponentView = new Accord.Controls.ComponentView();
            this.discriminatsGroupBox = new System.Windows.Forms.GroupBox();
            this.eigenvectorDataGridView = new System.Windows.Forms.DataGridView();
            this.scatterMatricesTabPage = new System.Windows.Forms.TabPage();
            this.withinClassScatterMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.withinClassScatterMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.betweenClassScatterMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.betweenClassScatterMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.totalScatterMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.totalScatterMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.projectionTabPage = new System.Windows.Forms.TabPage();
            this.featureSpaceGroupBox = new System.Windows.Forms.GroupBox();
            this.featureSpaceZedGraphControl = new ZedGraph.ZedGraphControl();
            this.featureSpacePanel = new System.Windows.Forms.Panel();
            this.featureSpaceXComboBox = new System.Windows.Forms.ComboBox();
            this.featureSpaceYComboBox = new System.Windows.Forms.ComboBox();
            this.featureSpaceYLabel = new System.Windows.Forms.Label();
            this.featureSpaceXLabel = new System.Windows.Forms.Label();
            this.inputSpaceGroupBox = new System.Windows.Forms.GroupBox();
            this.inputSpaceZedGraphControl = new ZedGraph.ZedGraphControl();
            this.inputSpacePanel = new System.Windows.Forms.Panel();
            this.navigateCheckBox = new System.Windows.Forms.CheckBox();
            this.inputSpaceXComboBox = new System.Windows.Forms.ComboBox();
            this.inputSpaceYComboBox = new System.Windows.Forms.ComboBox();
            this.inputSpaceYLabel = new System.Windows.Forms.Label();
            this.inputSpaceXLabel = new System.Windows.Forms.Label();
            this.projectionGroupBox = new System.Windows.Forms.GroupBox();
            this.projectionResultDataGridView = new System.Windows.Forms.DataGridView();
            this.projectButton = new System.Windows.Forms.Button();
            this.projectionDataGridView = new System.Windows.Forms.DataGridView();
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
            this.cumulativeProportionTextBox = new System.Windows.Forms.TextBox();
            this.cumulativeProportionLabel = new System.Windows.Forms.Label();
            this.proportionTextBox = new System.Windows.Forms.TextBox();
            this.proportionLabel = new System.Windows.Forms.Label();
            this.eigenvalueTextBox = new System.Windows.Forms.TextBox();
            this.discriminantLabel = new System.Windows.Forms.Label();
            this.eigenvalueLabel = new System.Windows.Forms.Label();
            this.discriminantComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.inputDataTabPage.SuspendLayout();
            this.inputDataVisualizationGroupBox.SuspendLayout();
            this.inputDataVisualizationPanel.SuspendLayout();
            this.learningTabPage.SuspendLayout();
            this.projectedDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectedDataDataGridView)).BeginInit();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).BeginInit();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.discriminantsTabPage.SuspendLayout();
            this.visualizationGroupBox.SuspendLayout();
            this.discriminatsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).BeginInit();
            this.scatterMatricesTabPage.SuspendLayout();
            this.withinClassScatterMatrixGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withinClassScatterMatrixDataGridView)).BeginInit();
            this.betweenClassScatterMatrixGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betweenClassScatterMatrixDataGridView)).BeginInit();
            this.totalScatterMatrixGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalScatterMatrixDataGridView)).BeginInit();
            this.projectionTabPage.SuspendLayout();
            this.featureSpaceGroupBox.SuspendLayout();
            this.featureSpacePanel.SuspendLayout();
            this.inputSpaceGroupBox.SuspendLayout();
            this.inputSpacePanel.SuspendLayout();
            this.projectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectionResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionDataGridView)).BeginInit();
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
            this.inputDataGroupBox.Size = new System.Drawing.Size(456, 518);
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
            this.inputDataGridView.Size = new System.Drawing.Size(448, 489);
            this.inputDataGridView.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.inputDataTabPage);
            this.mainTabControl.Controls.Add(this.learningTabPage);
            this.mainTabControl.Controls.Add(this.discriminantsTabPage);
            this.mainTabControl.Controls.Add(this.scatterMatricesTabPage);
            this.mainTabControl.Controls.Add(this.projectionTabPage);
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
            this.inputDataVisualizationGroupBox.Location = new System.Drawing.Point(459, 3);
            this.inputDataVisualizationGroupBox.Name = "inputDataVisualizationGroupBox";
            this.inputDataVisualizationGroupBox.Size = new System.Drawing.Size(514, 518);
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
            this.inputDataZedGraphControl.Size = new System.Drawing.Size(508, 438);
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
            this.inputDataVisualizationPanel.Size = new System.Drawing.Size(508, 55);
            this.inputDataVisualizationPanel.TabIndex = 0;
            // 
            // inputDataXComboBox
            // 
            this.inputDataXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDataXComboBox.FormattingEnabled = true;
            this.inputDataXComboBox.Location = new System.Drawing.Point(43, 11);
            this.inputDataXComboBox.Name = "inputDataXComboBox";
            this.inputDataXComboBox.Size = new System.Drawing.Size(200, 28);
            this.inputDataXComboBox.TabIndex = 0;
            this.inputDataXComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYComboBox
            // 
            this.inputDataYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDataYComboBox.FormattingEnabled = true;
            this.inputDataYComboBox.Location = new System.Drawing.Point(283, 11);
            this.inputDataYComboBox.Name = "inputDataYComboBox";
            this.inputDataYComboBox.Size = new System.Drawing.Size(200, 28);
            this.inputDataYComboBox.TabIndex = 1;
            this.inputDataYComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYLabel
            // 
            this.inputDataYLabel.AutoSize = true;
            this.inputDataYLabel.Location = new System.Drawing.Point(257, 14);
            this.inputDataYLabel.Name = "inputDataYLabel";
            this.inputDataYLabel.Size = new System.Drawing.Size(20, 20);
            this.inputDataYLabel.TabIndex = 0;
            this.inputDataYLabel.Text = "y:";
            // 
            // inputDataXLabel
            // 
            this.inputDataXLabel.AutoSize = true;
            this.inputDataXLabel.Location = new System.Drawing.Point(17, 14);
            this.inputDataXLabel.Name = "inputDataXLabel";
            this.inputDataXLabel.Size = new System.Drawing.Size(20, 20);
            this.inputDataXLabel.TabIndex = 0;
            this.inputDataXLabel.Text = "x:";
            // 
            // learningTabPage
            // 
            this.learningTabPage.Controls.Add(this.projectedDataGroupBox);
            this.learningTabPage.Controls.Add(this.learningGroupBox);
            this.learningTabPage.Controls.Add(this.kernelGroupBox);
            this.learningTabPage.Location = new System.Drawing.Point(4, 29);
            this.learningTabPage.Name = "learningTabPage";
            this.learningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.learningTabPage.Size = new System.Drawing.Size(976, 524);
            this.learningTabPage.TabIndex = 3;
            this.learningTabPage.Text = "Learning";
            this.learningTabPage.UseVisualStyleBackColor = true;
            // 
            // projectedDataGroupBox
            // 
            this.projectedDataGroupBox.Controls.Add(this.projectedDataDataGridView);
            this.projectedDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataGroupBox.Location = new System.Drawing.Point(403, 103);
            this.projectedDataGroupBox.Name = "projectedDataGroupBox";
            this.projectedDataGroupBox.Size = new System.Drawing.Size(570, 418);
            this.projectedDataGroupBox.TabIndex = 1;
            this.projectedDataGroupBox.TabStop = false;
            this.projectedDataGroupBox.Text = "Projected Data";
            // 
            // projectedDataDataGridView
            // 
            this.projectedDataDataGridView.AllowUserToAddRows = false;
            this.projectedDataDataGridView.AllowUserToDeleteRows = false;
            this.projectedDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectedDataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.projectedDataDataGridView.Location = new System.Drawing.Point(3, 22);
            this.projectedDataDataGridView.Name = "projectedDataDataGridView";
            this.projectedDataDataGridView.ReadOnly = true;
            this.projectedDataDataGridView.RowHeadersVisible = false;
            this.projectedDataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectedDataDataGridView.Size = new System.Drawing.Size(564, 393);
            this.projectedDataDataGridView.TabIndex = 0;
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.numberOfDiscriminantsNumericUpDown);
            this.learningGroupBox.Controls.Add(this.numberOfDiscriminantLabel);
            this.learningGroupBox.Controls.Add(this.learnButton);
            this.learningGroupBox.Controls.Add(this.learningToNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningToLabel);
            this.learningGroupBox.Controls.Add(this.learningFromNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningFromLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.learningGroupBox.Location = new System.Drawing.Point(403, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(570, 100);
            this.learningGroupBox.TabIndex = 0;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // numberOfDiscriminantsNumericUpDown
            // 
            this.numberOfDiscriminantsNumericUpDown.Location = new System.Drawing.Point(225, 61);
            this.numberOfDiscriminantsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDiscriminantsNumericUpDown.Name = "numberOfDiscriminantsNumericUpDown";
            this.numberOfDiscriminantsNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.numberOfDiscriminantsNumericUpDown.TabIndex = 2;
            this.numberOfDiscriminantsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfDiscriminantLabel
            // 
            this.numberOfDiscriminantLabel.AutoSize = true;
            this.numberOfDiscriminantLabel.Location = new System.Drawing.Point(37, 64);
            this.numberOfDiscriminantLabel.Name = "numberOfDiscriminantLabel";
            this.numberOfDiscriminantLabel.Size = new System.Drawing.Size(182, 20);
            this.numberOfDiscriminantLabel.TabIndex = 0;
            this.numberOfDiscriminantLabel.Text = "Number of Discriminants";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(341, 59);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(100, 30);
            this.learnButton.TabIndex = 3;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // learningToNumericUpDown
            // 
            this.learningToNumericUpDown.Location = new System.Drawing.Point(225, 29);
            this.learningToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningToNumericUpDown.Name = "learningToNumericUpDown";
            this.learningToNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.learningToNumericUpDown.TabIndex = 1;
            this.learningToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // learningToLabel
            // 
            this.learningToLabel.AutoSize = true;
            this.learningToLabel.Location = new System.Drawing.Point(192, 31);
            this.learningToLabel.Name = "learningToLabel";
            this.learningToLabel.Size = new System.Drawing.Size(27, 20);
            this.learningToLabel.TabIndex = 0;
            this.learningToLabel.Text = "To";
            // 
            // learningFromNumericUpDown
            // 
            this.learningFromNumericUpDown.Location = new System.Drawing.Point(77, 29);
            this.learningFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningFromNumericUpDown.Name = "learningFromNumericUpDown";
            this.learningFromNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.learningFromNumericUpDown.TabIndex = 0;
            this.learningFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // learningFromLabel
            // 
            this.learningFromLabel.AutoSize = true;
            this.learningFromLabel.Location = new System.Drawing.Point(25, 31);
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
            this.kernelGroupBox.Controls.Add(this.gaussianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.polynomialKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaNumericUpDown);
            this.kernelGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.kernelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.kernelGroupBox.Name = "kernelGroupBox";
            this.kernelGroupBox.Size = new System.Drawing.Size(400, 518);
            this.kernelGroupBox.TabIndex = 2;
            this.kernelGroupBox.TabStop = false;
            this.kernelGroupBox.Text = "Kernel";
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
            // discriminantsTabPage
            // 
            this.discriminantsTabPage.Controls.Add(this.visualizationGroupBox);
            this.discriminantsTabPage.Controls.Add(this.discriminatsGroupBox);
            this.discriminantsTabPage.Location = new System.Drawing.Point(4, 29);
            this.discriminantsTabPage.Name = "discriminantsTabPage";
            this.discriminantsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.discriminantsTabPage.Size = new System.Drawing.Size(976, 524);
            this.discriminantsTabPage.TabIndex = 6;
            this.discriminantsTabPage.Text = "Discriminants";
            this.discriminantsTabPage.UseVisualStyleBackColor = true;
            // 
            // visualizationGroupBox
            // 
            this.visualizationGroupBox.Controls.Add(this.cumulativeProportionComponentView);
            this.visualizationGroupBox.Controls.Add(this.proportionComponentView);
            this.visualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizationGroupBox.Location = new System.Drawing.Point(543, 3);
            this.visualizationGroupBox.Name = "visualizationGroupBox";
            this.visualizationGroupBox.Size = new System.Drawing.Size(430, 518);
            this.visualizationGroupBox.TabIndex = 1;
            this.visualizationGroupBox.TabStop = false;
            this.visualizationGroupBox.Text = "Visualization";
            // 
            // cumulativeProportionComponentView
            // 
            this.cumulativeProportionComponentView.Cumulative = true;
            this.cumulativeProportionComponentView.DataSource = null;
            this.cumulativeProportionComponentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cumulativeProportionComponentView.Location = new System.Drawing.Point(3, 232);
            this.cumulativeProportionComponentView.Name = "cumulativeProportionComponentView";
            this.cumulativeProportionComponentView.Size = new System.Drawing.Size(424, 283);
            this.cumulativeProportionComponentView.TabIndex = 1;
            // 
            // proportionComponentView
            // 
            this.proportionComponentView.Cumulative = false;
            this.proportionComponentView.DataSource = null;
            this.proportionComponentView.Dock = System.Windows.Forms.DockStyle.Top;
            this.proportionComponentView.Location = new System.Drawing.Point(3, 22);
            this.proportionComponentView.Name = "proportionComponentView";
            this.proportionComponentView.Size = new System.Drawing.Size(424, 210);
            this.proportionComponentView.TabIndex = 0;
            // 
            // discriminatsGroupBox
            // 
            this.discriminatsGroupBox.Controls.Add(this.cumulativeProportionTextBox);
            this.discriminatsGroupBox.Controls.Add(this.cumulativeProportionLabel);
            this.discriminatsGroupBox.Controls.Add(this.proportionTextBox);
            this.discriminatsGroupBox.Controls.Add(this.proportionLabel);
            this.discriminatsGroupBox.Controls.Add(this.eigenvalueTextBox);
            this.discriminatsGroupBox.Controls.Add(this.discriminantLabel);
            this.discriminatsGroupBox.Controls.Add(this.eigenvalueLabel);
            this.discriminatsGroupBox.Controls.Add(this.discriminantComboBox);
            this.discriminatsGroupBox.Controls.Add(this.eigenvectorDataGridView);
            this.discriminatsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.discriminatsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.discriminatsGroupBox.Name = "discriminatsGroupBox";
            this.discriminatsGroupBox.Size = new System.Drawing.Size(540, 518);
            this.discriminatsGroupBox.TabIndex = 0;
            this.discriminatsGroupBox.TabStop = false;
            this.discriminatsGroupBox.Text = "Discriminants";
            // 
            // eigenvectorDataGridView
            // 
            this.eigenvectorDataGridView.AllowUserToAddRows = false;
            this.eigenvectorDataGridView.AllowUserToDeleteRows = false;
            this.eigenvectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eigenvectorDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.eigenvectorDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.eigenvectorDataGridView.Location = new System.Drawing.Point(297, 22);
            this.eigenvectorDataGridView.Name = "eigenvectorDataGridView";
            this.eigenvectorDataGridView.ReadOnly = true;
            this.eigenvectorDataGridView.RowHeadersVisible = false;
            this.eigenvectorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eigenvectorDataGridView.Size = new System.Drawing.Size(240, 493);
            this.eigenvectorDataGridView.TabIndex = 0;
            // 
            // scatterMatricesTabPage
            // 
            this.scatterMatricesTabPage.Controls.Add(this.withinClassScatterMatrixGroupBox);
            this.scatterMatricesTabPage.Controls.Add(this.betweenClassScatterMatrixGroupBox);
            this.scatterMatricesTabPage.Controls.Add(this.totalScatterMatrixGroupBox);
            this.scatterMatricesTabPage.Location = new System.Drawing.Point(4, 29);
            this.scatterMatricesTabPage.Name = "scatterMatricesTabPage";
            this.scatterMatricesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scatterMatricesTabPage.Size = new System.Drawing.Size(976, 524);
            this.scatterMatricesTabPage.TabIndex = 4;
            this.scatterMatricesTabPage.Text = "Scatter Matrices";
            this.scatterMatricesTabPage.UseVisualStyleBackColor = true;
            // 
            // withinClassScatterMatrixGroupBox
            // 
            this.withinClassScatterMatrixGroupBox.Controls.Add(this.withinClassScatterMatrixDataGridView);
            this.withinClassScatterMatrixGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.withinClassScatterMatrixGroupBox.Location = new System.Drawing.Point(430, 258);
            this.withinClassScatterMatrixGroupBox.Name = "withinClassScatterMatrixGroupBox";
            this.withinClassScatterMatrixGroupBox.Size = new System.Drawing.Size(543, 263);
            this.withinClassScatterMatrixGroupBox.TabIndex = 2;
            this.withinClassScatterMatrixGroupBox.TabStop = false;
            this.withinClassScatterMatrixGroupBox.Text = "Within Class Scatter Matrix";
            // 
            // withinClassScatterMatrixDataGridView
            // 
            this.withinClassScatterMatrixDataGridView.AllowUserToAddRows = false;
            this.withinClassScatterMatrixDataGridView.AllowUserToDeleteRows = false;
            this.withinClassScatterMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withinClassScatterMatrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.withinClassScatterMatrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.withinClassScatterMatrixDataGridView.Location = new System.Drawing.Point(3, 22);
            this.withinClassScatterMatrixDataGridView.Name = "withinClassScatterMatrixDataGridView";
            this.withinClassScatterMatrixDataGridView.ReadOnly = true;
            this.withinClassScatterMatrixDataGridView.RowHeadersVisible = false;
            this.withinClassScatterMatrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.withinClassScatterMatrixDataGridView.Size = new System.Drawing.Size(537, 238);
            this.withinClassScatterMatrixDataGridView.TabIndex = 0;
            // 
            // betweenClassScatterMatrixGroupBox
            // 
            this.betweenClassScatterMatrixGroupBox.Controls.Add(this.betweenClassScatterMatrixDataGridView);
            this.betweenClassScatterMatrixGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.betweenClassScatterMatrixGroupBox.Location = new System.Drawing.Point(430, 3);
            this.betweenClassScatterMatrixGroupBox.Name = "betweenClassScatterMatrixGroupBox";
            this.betweenClassScatterMatrixGroupBox.Size = new System.Drawing.Size(543, 255);
            this.betweenClassScatterMatrixGroupBox.TabIndex = 1;
            this.betweenClassScatterMatrixGroupBox.TabStop = false;
            this.betweenClassScatterMatrixGroupBox.Text = "Between Class Scatter Matrix";
            // 
            // betweenClassScatterMatrixDataGridView
            // 
            this.betweenClassScatterMatrixDataGridView.AllowUserToAddRows = false;
            this.betweenClassScatterMatrixDataGridView.AllowUserToDeleteRows = false;
            this.betweenClassScatterMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.betweenClassScatterMatrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betweenClassScatterMatrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.betweenClassScatterMatrixDataGridView.Location = new System.Drawing.Point(3, 22);
            this.betweenClassScatterMatrixDataGridView.Name = "betweenClassScatterMatrixDataGridView";
            this.betweenClassScatterMatrixDataGridView.ReadOnly = true;
            this.betweenClassScatterMatrixDataGridView.RowHeadersVisible = false;
            this.betweenClassScatterMatrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.betweenClassScatterMatrixDataGridView.Size = new System.Drawing.Size(537, 230);
            this.betweenClassScatterMatrixDataGridView.TabIndex = 0;
            // 
            // totalScatterMatrixGroupBox
            // 
            this.totalScatterMatrixGroupBox.Controls.Add(this.totalScatterMatrixDataGridView);
            this.totalScatterMatrixGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalScatterMatrixGroupBox.Location = new System.Drawing.Point(3, 3);
            this.totalScatterMatrixGroupBox.Name = "totalScatterMatrixGroupBox";
            this.totalScatterMatrixGroupBox.Size = new System.Drawing.Size(427, 518);
            this.totalScatterMatrixGroupBox.TabIndex = 0;
            this.totalScatterMatrixGroupBox.TabStop = false;
            this.totalScatterMatrixGroupBox.Text = "Total Scatter Matrix";
            // 
            // totalScatterMatrixDataGridView
            // 
            this.totalScatterMatrixDataGridView.AllowUserToAddRows = false;
            this.totalScatterMatrixDataGridView.AllowUserToDeleteRows = false;
            this.totalScatterMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalScatterMatrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalScatterMatrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.totalScatterMatrixDataGridView.Location = new System.Drawing.Point(3, 22);
            this.totalScatterMatrixDataGridView.Name = "totalScatterMatrixDataGridView";
            this.totalScatterMatrixDataGridView.ReadOnly = true;
            this.totalScatterMatrixDataGridView.RowHeadersVisible = false;
            this.totalScatterMatrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.totalScatterMatrixDataGridView.Size = new System.Drawing.Size(421, 493);
            this.totalScatterMatrixDataGridView.TabIndex = 0;
            // 
            // projectionTabPage
            // 
            this.projectionTabPage.Controls.Add(this.featureSpaceGroupBox);
            this.projectionTabPage.Controls.Add(this.inputSpaceGroupBox);
            this.projectionTabPage.Controls.Add(this.projectionGroupBox);
            this.projectionTabPage.Location = new System.Drawing.Point(4, 29);
            this.projectionTabPage.Name = "projectionTabPage";
            this.projectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectionTabPage.Size = new System.Drawing.Size(976, 524);
            this.projectionTabPage.TabIndex = 5;
            this.projectionTabPage.Text = "Projection";
            this.projectionTabPage.UseVisualStyleBackColor = true;
            // 
            // featureSpaceGroupBox
            // 
            this.featureSpaceGroupBox.Controls.Add(this.featureSpaceZedGraphControl);
            this.featureSpaceGroupBox.Controls.Add(this.featureSpacePanel);
            this.featureSpaceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureSpaceGroupBox.Location = new System.Drawing.Point(503, 153);
            this.featureSpaceGroupBox.Name = "featureSpaceGroupBox";
            this.featureSpaceGroupBox.Size = new System.Drawing.Size(470, 368);
            this.featureSpaceGroupBox.TabIndex = 2;
            this.featureSpaceGroupBox.TabStop = false;
            this.featureSpaceGroupBox.Text = "Feature Space";
            // 
            // featureSpaceZedGraphControl
            // 
            this.featureSpaceZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureSpaceZedGraphControl.Location = new System.Drawing.Point(3, 77);
            this.featureSpaceZedGraphControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.featureSpaceZedGraphControl.Name = "featureSpaceZedGraphControl";
            this.featureSpaceZedGraphControl.ScrollGrace = 0D;
            this.featureSpaceZedGraphControl.ScrollMaxX = 0D;
            this.featureSpaceZedGraphControl.ScrollMaxY = 0D;
            this.featureSpaceZedGraphControl.ScrollMaxY2 = 0D;
            this.featureSpaceZedGraphControl.ScrollMinX = 0D;
            this.featureSpaceZedGraphControl.ScrollMinY = 0D;
            this.featureSpaceZedGraphControl.ScrollMinY2 = 0D;
            this.featureSpaceZedGraphControl.Size = new System.Drawing.Size(464, 288);
            this.featureSpaceZedGraphControl.TabIndex = 1;
            this.featureSpaceZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // featureSpacePanel
            // 
            this.featureSpacePanel.Controls.Add(this.featureSpaceXComboBox);
            this.featureSpacePanel.Controls.Add(this.featureSpaceYComboBox);
            this.featureSpacePanel.Controls.Add(this.featureSpaceYLabel);
            this.featureSpacePanel.Controls.Add(this.featureSpaceXLabel);
            this.featureSpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.featureSpacePanel.Location = new System.Drawing.Point(3, 22);
            this.featureSpacePanel.Name = "featureSpacePanel";
            this.featureSpacePanel.Size = new System.Drawing.Size(464, 55);
            this.featureSpacePanel.TabIndex = 0;
            // 
            // featureSpaceXComboBox
            // 
            this.featureSpaceXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureSpaceXComboBox.FormattingEnabled = true;
            this.featureSpaceXComboBox.Location = new System.Drawing.Point(40, 14);
            this.featureSpaceXComboBox.Name = "featureSpaceXComboBox";
            this.featureSpaceXComboBox.Size = new System.Drawing.Size(100, 28);
            this.featureSpaceXComboBox.TabIndex = 0;
            this.featureSpaceXComboBox.SelectedIndexChanged += new System.EventHandler(this.featureSpaceComboBox_SelectedIndexChanged);
            // 
            // featureSpaceYComboBox
            // 
            this.featureSpaceYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureSpaceYComboBox.FormattingEnabled = true;
            this.featureSpaceYComboBox.Location = new System.Drawing.Point(210, 14);
            this.featureSpaceYComboBox.Name = "featureSpaceYComboBox";
            this.featureSpaceYComboBox.Size = new System.Drawing.Size(100, 28);
            this.featureSpaceYComboBox.TabIndex = 1;
            this.featureSpaceYComboBox.SelectedIndexChanged += new System.EventHandler(this.featureSpaceComboBox_SelectedIndexChanged);
            // 
            // featureSpaceYLabel
            // 
            this.featureSpaceYLabel.AutoSize = true;
            this.featureSpaceYLabel.Location = new System.Drawing.Point(184, 17);
            this.featureSpaceYLabel.Name = "featureSpaceYLabel";
            this.featureSpaceYLabel.Size = new System.Drawing.Size(20, 20);
            this.featureSpaceYLabel.TabIndex = 0;
            this.featureSpaceYLabel.Text = "y:";
            // 
            // featureSpaceXLabel
            // 
            this.featureSpaceXLabel.AutoSize = true;
            this.featureSpaceXLabel.Location = new System.Drawing.Point(14, 17);
            this.featureSpaceXLabel.Name = "featureSpaceXLabel";
            this.featureSpaceXLabel.Size = new System.Drawing.Size(20, 20);
            this.featureSpaceXLabel.TabIndex = 0;
            this.featureSpaceXLabel.Text = "x:";
            // 
            // inputSpaceGroupBox
            // 
            this.inputSpaceGroupBox.Controls.Add(this.inputSpaceZedGraphControl);
            this.inputSpaceGroupBox.Controls.Add(this.inputSpacePanel);
            this.inputSpaceGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputSpaceGroupBox.Location = new System.Drawing.Point(3, 153);
            this.inputSpaceGroupBox.Name = "inputSpaceGroupBox";
            this.inputSpaceGroupBox.Size = new System.Drawing.Size(500, 368);
            this.inputSpaceGroupBox.TabIndex = 1;
            this.inputSpaceGroupBox.TabStop = false;
            this.inputSpaceGroupBox.Text = "Input Space";
            // 
            // inputSpaceZedGraphControl
            // 
            this.inputSpaceZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSpaceZedGraphControl.Location = new System.Drawing.Point(3, 77);
            this.inputSpaceZedGraphControl.Margin = new System.Windows.Forms.Padding(8);
            this.inputSpaceZedGraphControl.Name = "inputSpaceZedGraphControl";
            this.inputSpaceZedGraphControl.ScrollGrace = 0D;
            this.inputSpaceZedGraphControl.ScrollMaxX = 0D;
            this.inputSpaceZedGraphControl.ScrollMaxY = 0D;
            this.inputSpaceZedGraphControl.ScrollMaxY2 = 0D;
            this.inputSpaceZedGraphControl.ScrollMinX = 0D;
            this.inputSpaceZedGraphControl.ScrollMinY = 0D;
            this.inputSpaceZedGraphControl.ScrollMinY2 = 0D;
            this.inputSpaceZedGraphControl.Size = new System.Drawing.Size(494, 288);
            this.inputSpaceZedGraphControl.TabIndex = 1;
            this.inputSpaceZedGraphControl.UseExtendedPrintDialog = true;
            this.inputSpaceZedGraphControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inputSpaceZedGraphControl_MouseMove);
            // 
            // inputSpacePanel
            // 
            this.inputSpacePanel.Controls.Add(this.navigateCheckBox);
            this.inputSpacePanel.Controls.Add(this.inputSpaceXComboBox);
            this.inputSpacePanel.Controls.Add(this.inputSpaceYComboBox);
            this.inputSpacePanel.Controls.Add(this.inputSpaceYLabel);
            this.inputSpacePanel.Controls.Add(this.inputSpaceXLabel);
            this.inputSpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputSpacePanel.Location = new System.Drawing.Point(3, 22);
            this.inputSpacePanel.Name = "inputSpacePanel";
            this.inputSpacePanel.Size = new System.Drawing.Size(494, 55);
            this.inputSpacePanel.TabIndex = 0;
            // 
            // navigateCheckBox
            // 
            this.navigateCheckBox.AutoSize = true;
            this.navigateCheckBox.Location = new System.Drawing.Point(395, 16);
            this.navigateCheckBox.Name = "navigateCheckBox";
            this.navigateCheckBox.Size = new System.Drawing.Size(90, 24);
            this.navigateCheckBox.TabIndex = 2;
            this.navigateCheckBox.Text = "Navigate";
            this.navigateCheckBox.UseVisualStyleBackColor = true;
            this.navigateCheckBox.CheckedChanged += new System.EventHandler(this.navigateCheckBox_CheckedChanged);
            // 
            // inputSpaceXComboBox
            // 
            this.inputSpaceXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSpaceXComboBox.FormattingEnabled = true;
            this.inputSpaceXComboBox.Location = new System.Drawing.Point(37, 14);
            this.inputSpaceXComboBox.Name = "inputSpaceXComboBox";
            this.inputSpaceXComboBox.Size = new System.Drawing.Size(160, 28);
            this.inputSpaceXComboBox.TabIndex = 0;
            this.inputSpaceXComboBox.SelectedIndexChanged += new System.EventHandler(this.inputSpaceComboBox_SelectedIndexChanged);
            // 
            // inputSpaceYComboBox
            // 
            this.inputSpaceYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSpaceYComboBox.FormattingEnabled = true;
            this.inputSpaceYComboBox.Location = new System.Drawing.Point(229, 14);
            this.inputSpaceYComboBox.Name = "inputSpaceYComboBox";
            this.inputSpaceYComboBox.Size = new System.Drawing.Size(160, 28);
            this.inputSpaceYComboBox.TabIndex = 1;
            this.inputSpaceYComboBox.SelectedIndexChanged += new System.EventHandler(this.inputSpaceComboBox_SelectedIndexChanged);
            // 
            // inputSpaceYLabel
            // 
            this.inputSpaceYLabel.AutoSize = true;
            this.inputSpaceYLabel.Location = new System.Drawing.Point(203, 17);
            this.inputSpaceYLabel.Name = "inputSpaceYLabel";
            this.inputSpaceYLabel.Size = new System.Drawing.Size(20, 20);
            this.inputSpaceYLabel.TabIndex = 0;
            this.inputSpaceYLabel.Text = "y:";
            // 
            // inputSpaceXLabel
            // 
            this.inputSpaceXLabel.AutoSize = true;
            this.inputSpaceXLabel.Location = new System.Drawing.Point(11, 17);
            this.inputSpaceXLabel.Name = "inputSpaceXLabel";
            this.inputSpaceXLabel.Size = new System.Drawing.Size(20, 20);
            this.inputSpaceXLabel.TabIndex = 0;
            this.inputSpaceXLabel.Text = "x:";
            // 
            // projectionGroupBox
            // 
            this.projectionGroupBox.Controls.Add(this.projectionResultDataGridView);
            this.projectionGroupBox.Controls.Add(this.projectButton);
            this.projectionGroupBox.Controls.Add(this.projectionDataGridView);
            this.projectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.projectionGroupBox.Name = "projectionGroupBox";
            this.projectionGroupBox.Size = new System.Drawing.Size(970, 150);
            this.projectionGroupBox.TabIndex = 0;
            this.projectionGroupBox.TabStop = false;
            this.projectionGroupBox.Text = "Projection";
            // 
            // projectionResultDataGridView
            // 
            this.projectionResultDataGridView.AllowUserToAddRows = false;
            this.projectionResultDataGridView.AllowUserToDeleteRows = false;
            this.projectionResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectionResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectionResultDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.projectionResultDataGridView.Location = new System.Drawing.Point(541, 22);
            this.projectionResultDataGridView.Name = "projectionResultDataGridView";
            this.projectionResultDataGridView.ReadOnly = true;
            this.projectionResultDataGridView.RowHeadersVisible = false;
            this.projectionResultDataGridView.RowTemplate.Height = 24;
            this.projectionResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectionResultDataGridView.ShowCellErrors = false;
            this.projectionResultDataGridView.ShowEditingIcon = false;
            this.projectionResultDataGridView.ShowRowErrors = false;
            this.projectionResultDataGridView.Size = new System.Drawing.Size(426, 125);
            this.projectionResultDataGridView.TabIndex = 2;
            // 
            // projectButton
            // 
            this.projectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.projectButton.Enabled = false;
            this.projectButton.Location = new System.Drawing.Point(461, 22);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(80, 125);
            this.projectButton.TabIndex = 1;
            this.projectButton.Text = "Project";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // projectionDataGridView
            // 
            this.projectionDataGridView.AllowUserToAddRows = false;
            this.projectionDataGridView.AllowUserToDeleteRows = false;
            this.projectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectionDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.projectionDataGridView.Location = new System.Drawing.Point(3, 22);
            this.projectionDataGridView.Name = "projectionDataGridView";
            this.projectionDataGridView.RowHeadersVisible = false;
            this.projectionDataGridView.RowTemplate.Height = 24;
            this.projectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectionDataGridView.ShowCellErrors = false;
            this.projectionDataGridView.ShowEditingIcon = false;
            this.projectionDataGridView.ShowRowErrors = false;
            this.projectionDataGridView.Size = new System.Drawing.Size(458, 125);
            this.projectionDataGridView.TabIndex = 0;
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
            this.testingXComboBox.Location = new System.Drawing.Point(46, 13);
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
            this.testingYComboBox.Location = new System.Drawing.Point(288, 13);
            this.testingYComboBox.Name = "testingYComboBox";
            this.testingYComboBox.Size = new System.Drawing.Size(200, 28);
            this.testingYComboBox.TabIndex = 1;
            this.testingYComboBox.SelectedIndexChanged += new System.EventHandler(this.testingComboBox_SelectedIndexChanged);
            // 
            // testingYLabel
            // 
            this.testingYLabel.AutoSize = true;
            this.testingYLabel.Location = new System.Drawing.Point(262, 16);
            this.testingYLabel.Name = "testingYLabel";
            this.testingYLabel.Size = new System.Drawing.Size(20, 20);
            this.testingYLabel.TabIndex = 0;
            this.testingYLabel.Text = "y:";
            // 
            // testingXLabel
            // 
            this.testingXLabel.AutoSize = true;
            this.testingXLabel.Location = new System.Drawing.Point(20, 16);
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
            this.testingPanel.TabIndex = 1;
            // 
            // testingFromLabel
            // 
            this.testingFromLabel.AutoSize = true;
            this.testingFromLabel.Location = new System.Drawing.Point(14, 12);
            this.testingFromLabel.Name = "testingFromLabel";
            this.testingFromLabel.Size = new System.Drawing.Size(46, 20);
            this.testingFromLabel.TabIndex = 0;
            this.testingFromLabel.Text = "From";
            // 
            // numberOfMatchesLabel
            // 
            this.numberOfMatchesLabel.AutoSize = true;
            this.numberOfMatchesLabel.Location = new System.Drawing.Point(14, 44);
            this.numberOfMatchesLabel.Name = "numberOfMatchesLabel";
            this.numberOfMatchesLabel.Size = new System.Drawing.Size(152, 20);
            this.numberOfMatchesLabel.TabIndex = 0;
            this.numberOfMatchesLabel.Text = "Number of matches:";
            // 
            // testingFromNumericUpDown
            // 
            this.testingFromNumericUpDown.Location = new System.Drawing.Point(66, 10);
            this.testingFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testingFromNumericUpDown.Name = "testingFromNumericUpDown";
            this.testingFromNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.testingFromNumericUpDown.TabIndex = 0;
            this.testingFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // testingToLabel
            // 
            this.testingToLabel.AutoSize = true;
            this.testingToLabel.Location = new System.Drawing.Point(181, 12);
            this.testingToLabel.Name = "testingToLabel";
            this.testingToLabel.Size = new System.Drawing.Size(27, 20);
            this.testingToLabel.TabIndex = 0;
            this.testingToLabel.Text = "To";
            // 
            // testingToNumericUpDown
            // 
            this.testingToNumericUpDown.Location = new System.Drawing.Point(214, 10);
            this.testingToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testingToNumericUpDown.Name = "testingToNumericUpDown";
            this.testingToNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.testingToNumericUpDown.TabIndex = 1;
            this.testingToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // testButton
            // 
            this.testButton.Enabled = false;
            this.testButton.Location = new System.Drawing.Point(320, 7);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 30);
            this.testButton.TabIndex = 2;
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
            // cumulativeProportionTextBox
            // 
            this.cumulativeProportionTextBox.Location = new System.Drawing.Point(191, 123);
            this.cumulativeProportionTextBox.Name = "cumulativeProportionTextBox";
            this.cumulativeProportionTextBox.Size = new System.Drawing.Size(100, 26);
            this.cumulativeProportionTextBox.TabIndex = 11;
            // 
            // cumulativeProportionLabel
            // 
            this.cumulativeProportionLabel.AutoSize = true;
            this.cumulativeProportionLabel.Location = new System.Drawing.Point(21, 126);
            this.cumulativeProportionLabel.Name = "cumulativeProportionLabel";
            this.cumulativeProportionLabel.Size = new System.Drawing.Size(164, 20);
            this.cumulativeProportionLabel.TabIndex = 4;
            this.cumulativeProportionLabel.Text = "Cumulative Proportion";
            // 
            // proportionTextBox
            // 
            this.proportionTextBox.Location = new System.Drawing.Point(191, 91);
            this.proportionTextBox.Name = "proportionTextBox";
            this.proportionTextBox.Size = new System.Drawing.Size(100, 26);
            this.proportionTextBox.TabIndex = 10;
            // 
            // proportionLabel
            // 
            this.proportionLabel.AutoSize = true;
            this.proportionLabel.Location = new System.Drawing.Point(103, 94);
            this.proportionLabel.Name = "proportionLabel";
            this.proportionLabel.Size = new System.Drawing.Size(82, 20);
            this.proportionLabel.TabIndex = 5;
            this.proportionLabel.Text = "Proportion";
            // 
            // eigenvalueTextBox
            // 
            this.eigenvalueTextBox.Location = new System.Drawing.Point(191, 59);
            this.eigenvalueTextBox.Name = "eigenvalueTextBox";
            this.eigenvalueTextBox.Size = new System.Drawing.Size(100, 26);
            this.eigenvalueTextBox.TabIndex = 9;
            // 
            // discriminantLabel
            // 
            this.discriminantLabel.AutoSize = true;
            this.discriminantLabel.Location = new System.Drawing.Point(89, 28);
            this.discriminantLabel.Name = "discriminantLabel";
            this.discriminantLabel.Size = new System.Drawing.Size(96, 20);
            this.discriminantLabel.TabIndex = 6;
            this.discriminantLabel.Text = "Discriminant";
            // 
            // eigenvalueLabel
            // 
            this.eigenvalueLabel.AutoSize = true;
            this.eigenvalueLabel.Location = new System.Drawing.Point(98, 62);
            this.eigenvalueLabel.Name = "eigenvalueLabel";
            this.eigenvalueLabel.Size = new System.Drawing.Size(87, 20);
            this.eigenvalueLabel.TabIndex = 7;
            this.eigenvalueLabel.Text = "Eigenvalue";
            // 
            // discriminantComboBox
            // 
            this.discriminantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discriminantComboBox.FormattingEnabled = true;
            this.discriminantComboBox.Location = new System.Drawing.Point(191, 25);
            this.discriminantComboBox.Name = "discriminantComboBox";
            this.discriminantComboBox.Size = new System.Drawing.Size(100, 28);
            this.discriminantComboBox.TabIndex = 8;
            this.discriminantComboBox.SelectedIndexChanged += new System.EventHandler(this.discriminantComboBox_SelectedIndexChanged);
            // 
            // KDAModelForm
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
            this.Name = "KDAModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kernel Discriminant Analysis (KDA)";
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataVisualizationGroupBox.ResumeLayout(false);
            this.inputDataVisualizationPanel.ResumeLayout(false);
            this.inputDataVisualizationPanel.PerformLayout();
            this.learningTabPage.ResumeLayout(false);
            this.projectedDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectedDataDataGridView)).EndInit();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).EndInit();
            this.kernelGroupBox.ResumeLayout(false);
            this.kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).EndInit();
            this.discriminantsTabPage.ResumeLayout(false);
            this.visualizationGroupBox.ResumeLayout(false);
            this.discriminatsGroupBox.ResumeLayout(false);
            this.discriminatsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).EndInit();
            this.scatterMatricesTabPage.ResumeLayout(false);
            this.withinClassScatterMatrixGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.withinClassScatterMatrixDataGridView)).EndInit();
            this.betweenClassScatterMatrixGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betweenClassScatterMatrixDataGridView)).EndInit();
            this.totalScatterMatrixGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalScatterMatrixDataGridView)).EndInit();
            this.projectionTabPage.ResumeLayout(false);
            this.featureSpaceGroupBox.ResumeLayout(false);
            this.featureSpacePanel.ResumeLayout(false);
            this.featureSpacePanel.PerformLayout();
            this.inputSpaceGroupBox.ResumeLayout(false);
            this.inputSpacePanel.ResumeLayout(false);
            this.inputSpacePanel.PerformLayout();
            this.projectionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectionResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage scatterMatricesTabPage;
        private System.Windows.Forms.GroupBox withinClassScatterMatrixGroupBox;
        private System.Windows.Forms.DataGridView withinClassScatterMatrixDataGridView;
        private System.Windows.Forms.GroupBox betweenClassScatterMatrixGroupBox;
        private System.Windows.Forms.DataGridView betweenClassScatterMatrixDataGridView;
        private System.Windows.Forms.GroupBox totalScatterMatrixGroupBox;
        private System.Windows.Forms.DataGridView totalScatterMatrixDataGridView;
        private System.Windows.Forms.TabPage projectionTabPage;
        private System.Windows.Forms.GroupBox featureSpaceGroupBox;
        private System.Windows.Forms.Panel featureSpacePanel;
        private System.Windows.Forms.ComboBox featureSpaceXComboBox;
        private System.Windows.Forms.ComboBox featureSpaceYComboBox;
        private System.Windows.Forms.Label featureSpaceYLabel;
        private System.Windows.Forms.Label featureSpaceXLabel;
        private ZedGraph.ZedGraphControl featureSpaceZedGraphControl;
        private System.Windows.Forms.GroupBox projectionGroupBox;
        private System.Windows.Forms.DataGridView projectionResultDataGridView;
        private System.Windows.Forms.DataGridView projectionDataGridView;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.GroupBox inputSpaceGroupBox;
        private ZedGraph.ZedGraphControl inputSpaceZedGraphControl;
        private System.Windows.Forms.Panel inputSpacePanel;
        private System.Windows.Forms.ComboBox inputSpaceXComboBox;
        private System.Windows.Forms.ComboBox inputSpaceYComboBox;
        private System.Windows.Forms.Label inputSpaceYLabel;
        private System.Windows.Forms.Label inputSpaceXLabel;
        private System.Windows.Forms.CheckBox navigateCheckBox;
        private System.Windows.Forms.NumericUpDown numberOfDiscriminantsNumericUpDown;
        private System.Windows.Forms.Label numberOfDiscriminantLabel;
        private System.Windows.Forms.GroupBox projectedDataGroupBox;
        private System.Windows.Forms.DataGridView projectedDataDataGridView;
        private System.Windows.Forms.TabPage discriminantsTabPage;
        private System.Windows.Forms.GroupBox visualizationGroupBox;
        private Accord.Controls.ComponentView cumulativeProportionComponentView;
        private Accord.Controls.ComponentView proportionComponentView;
        private System.Windows.Forms.GroupBox discriminatsGroupBox;
        private System.Windows.Forms.DataGridView eigenvectorDataGridView;
        private System.Windows.Forms.GroupBox kernelGroupBox;
        private System.Windows.Forms.Button sigmoidEstimateButton;
        private System.Windows.Forms.Button laplacianEstimateButton;
        private System.Windows.Forms.Button gaussianEstimateButton;
        private System.Windows.Forms.RadioButton gaussianKernelRadioButton;
        private System.Windows.Forms.Label laplacianSigmaLabel;
        private System.Windows.Forms.Label gaussianSigmaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidConstantNumericUpDown;
        private System.Windows.Forms.Label sigmoidAlphaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidAlphaNumericUpDown;
        private System.Windows.Forms.Label polynomialConstantLabel;
        private System.Windows.Forms.Label polynomialDegreeLabel;
        private System.Windows.Forms.NumericUpDown polynomialConstantNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialDegreeNumericUpDown;
        private System.Windows.Forms.Label sigmoidConstantLabel;
        private System.Windows.Forms.RadioButton sigmoidKernelRadioButton;
        private System.Windows.Forms.RadioButton laplacianKernelRadioButton;
        private System.Windows.Forms.RadioButton polynomialKernelRadioButton;
        private System.Windows.Forms.NumericUpDown laplacianSigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussianSigmaNumericUpDown;
        private System.Windows.Forms.TextBox cumulativeProportionTextBox;
        private System.Windows.Forms.Label cumulativeProportionLabel;
        private System.Windows.Forms.TextBox proportionTextBox;
        private System.Windows.Forms.Label proportionLabel;
        private System.Windows.Forms.TextBox eigenvalueTextBox;
        private System.Windows.Forms.Label discriminantLabel;
        private System.Windows.Forms.Label eigenvalueLabel;
        private System.Windows.Forms.ComboBox discriminantComboBox;
    }
}