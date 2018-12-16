namespace MachineLearning
{
    partial class DBNClassifierModelForm
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
            this.learningVisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.learningScatterplotView = new Accord.Controls.ScatterplotView();
            this.leanrningPanel = new System.Windows.Forms.Panel();
            this.currentIterationGroupBox = new System.Windows.Forms.GroupBox();
            this.elapsedTextBox = new System.Windows.Forms.TextBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.iterationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.learningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.learningToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningToLabel = new System.Windows.Forms.Label();
            this.learningFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.methodLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.learningFromLabel = new System.Windows.Forms.Label();
            this.networkPanel = new System.Windows.Forms.Panel();
            this.networkSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.nguyenWidrowCheckBox = new System.Windows.Forms.CheckBox();
            this.bayesianRegularizationCheckBox = new System.Windows.Forms.CheckBox();
            this.sameWeightsCheckBox = new System.Windows.Forms.CheckBox();
            this.learningRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.networkStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteLayerButton = new System.Windows.Forms.Button();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.networkStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activationFuncionGroupBox = new System.Windows.Forms.GroupBox();
            this.upperLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.upperLimitLabel = new System.Windows.Forms.Label();
            this.lowerLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.activationFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activationFunctionLabel = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.networkTabPage = new System.Windows.Forms.TabPage();
            this.neuronInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.biasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weightsListBox = new System.Windows.Forms.ListBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.weightsLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.neuronTextBox = new System.Windows.Forms.TextBox();
            this.neuronLabel = new System.Windows.Forms.Label();
            this.layerTextBox = new System.Windows.Forms.TextBox();
            this.layerLabel = new System.Windows.Forms.Label();
            this.layerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.layerNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfInputsTextBox = new System.Windows.Forms.TextBox();
            this.layerNameLabel = new System.Windows.Forms.Label();
            this.numberOfNeuronsLabel = new System.Windows.Forms.Label();
            this.numberOfInputsLabel = new System.Windows.Forms.Label();
            this.numberOfNeuronsTextBox = new System.Windows.Forms.TextBox();
            this.networkViewGroupBox = new System.Windows.Forms.GroupBox();
            this.networkTreeView = new System.Windows.Forms.TreeView();
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.inputDataTabPage.SuspendLayout();
            this.inputDataVisualizationGroupBox.SuspendLayout();
            this.inputDataVisualizationPanel.SuspendLayout();
            this.learningTabPage.SuspendLayout();
            this.learningVisualizationGroupBox.SuspendLayout();
            this.leanrningPanel.SuspendLayout();
            this.currentIterationGroupBox.SuspendLayout();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).BeginInit();
            this.networkPanel.SuspendLayout();
            this.networkSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).BeginInit();
            this.networkStructureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).BeginInit();
            this.activationFuncionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            this.networkTabPage.SuspendLayout();
            this.neuronInfoGroupBox.SuspendLayout();
            this.layerInfoGroupBox.SuspendLayout();
            this.networkViewGroupBox.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.inputDataGroupBox.Size = new System.Drawing.Size(468, 513);
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
            this.inputDataGridView.Location = new System.Drawing.Point(4, 28);
            this.inputDataGridView.Name = "inputDataGridView";
            this.inputDataGridView.ReadOnly = true;
            this.inputDataGridView.RowHeadersVisible = false;
            this.inputDataGridView.RowTemplate.Height = 24;
            this.inputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputDataGridView.ShowCellErrors = false;
            this.inputDataGridView.ShowEditingIcon = false;
            this.inputDataGridView.ShowRowErrors = false;
            this.inputDataGridView.Size = new System.Drawing.Size(460, 480);
            this.inputDataGridView.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.inputDataTabPage);
            this.mainTabControl.Controls.Add(this.learningTabPage);
            this.mainTabControl.Controls.Add(this.networkTabPage);
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
            this.inputDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.inputDataTabPage.Name = "inputDataTabPage";
            this.inputDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inputDataTabPage.Size = new System.Drawing.Size(976, 519);
            this.inputDataTabPage.TabIndex = 0;
            this.inputDataTabPage.Text = "Input Data";
            this.inputDataTabPage.UseVisualStyleBackColor = true;
            // 
            // inputDataVisualizationGroupBox
            // 
            this.inputDataVisualizationGroupBox.Controls.Add(this.inputDataZedGraphControl);
            this.inputDataVisualizationGroupBox.Controls.Add(this.inputDataVisualizationPanel);
            this.inputDataVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataVisualizationGroupBox.Location = new System.Drawing.Point(471, 3);
            this.inputDataVisualizationGroupBox.Name = "inputDataVisualizationGroupBox";
            this.inputDataVisualizationGroupBox.Size = new System.Drawing.Size(502, 513);
            this.inputDataVisualizationGroupBox.TabIndex = 1;
            this.inputDataVisualizationGroupBox.TabStop = false;
            this.inputDataVisualizationGroupBox.Text = "2D Visualization";
            // 
            // inputDataZedGraphControl
            // 
            this.inputDataZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataZedGraphControl.Location = new System.Drawing.Point(3, 81);
            this.inputDataZedGraphControl.Margin = new System.Windows.Forms.Padding(8);
            this.inputDataZedGraphControl.Name = "inputDataZedGraphControl";
            this.inputDataZedGraphControl.ScrollGrace = 0D;
            this.inputDataZedGraphControl.ScrollMaxX = 0D;
            this.inputDataZedGraphControl.ScrollMaxY = 0D;
            this.inputDataZedGraphControl.ScrollMaxY2 = 0D;
            this.inputDataZedGraphControl.ScrollMinX = 0D;
            this.inputDataZedGraphControl.ScrollMinY = 0D;
            this.inputDataZedGraphControl.ScrollMinY2 = 0D;
            this.inputDataZedGraphControl.Size = new System.Drawing.Size(496, 429);
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
            this.inputDataVisualizationPanel.Location = new System.Drawing.Point(3, 26);
            this.inputDataVisualizationPanel.Name = "inputDataVisualizationPanel";
            this.inputDataVisualizationPanel.Size = new System.Drawing.Size(496, 55);
            this.inputDataVisualizationPanel.TabIndex = 0;
            // 
            // inputDataXComboBox
            // 
            this.inputDataXComboBox.FormattingEnabled = true;
            this.inputDataXComboBox.Location = new System.Drawing.Point(38, 11);
            this.inputDataXComboBox.Name = "inputDataXComboBox";
            this.inputDataXComboBox.Size = new System.Drawing.Size(200, 33);
            this.inputDataXComboBox.TabIndex = 0;
            this.inputDataXComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYComboBox
            // 
            this.inputDataYComboBox.FormattingEnabled = true;
            this.inputDataYComboBox.Location = new System.Drawing.Point(278, 11);
            this.inputDataYComboBox.Name = "inputDataYComboBox";
            this.inputDataYComboBox.Size = new System.Drawing.Size(200, 33);
            this.inputDataYComboBox.TabIndex = 1;
            this.inputDataYComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYLabel
            // 
            this.inputDataYLabel.AutoSize = true;
            this.inputDataYLabel.Location = new System.Drawing.Point(252, 14);
            this.inputDataYLabel.Name = "inputDataYLabel";
            this.inputDataYLabel.Size = new System.Drawing.Size(28, 25);
            this.inputDataYLabel.TabIndex = 0;
            this.inputDataYLabel.Text = "y:";
            // 
            // inputDataXLabel
            // 
            this.inputDataXLabel.AutoSize = true;
            this.inputDataXLabel.Location = new System.Drawing.Point(12, 14);
            this.inputDataXLabel.Name = "inputDataXLabel";
            this.inputDataXLabel.Size = new System.Drawing.Size(28, 25);
            this.inputDataXLabel.TabIndex = 0;
            this.inputDataXLabel.Text = "x:";
            // 
            // learningTabPage
            // 
            this.learningTabPage.Controls.Add(this.learningVisualizationGroupBox);
            this.learningTabPage.Controls.Add(this.leanrningPanel);
            this.learningTabPage.Controls.Add(this.networkPanel);
            this.learningTabPage.Location = new System.Drawing.Point(4, 34);
            this.learningTabPage.Name = "learningTabPage";
            this.learningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.learningTabPage.Size = new System.Drawing.Size(976, 519);
            this.learningTabPage.TabIndex = 3;
            this.learningTabPage.Text = "Learning";
            this.learningTabPage.UseVisualStyleBackColor = true;
            // 
            // learningVisualizationGroupBox
            // 
            this.learningVisualizationGroupBox.Controls.Add(this.learningScatterplotView);
            this.learningVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningVisualizationGroupBox.Location = new System.Drawing.Point(344, 143);
            this.learningVisualizationGroupBox.Name = "learningVisualizationGroupBox";
            this.learningVisualizationGroupBox.Size = new System.Drawing.Size(629, 373);
            this.learningVisualizationGroupBox.TabIndex = 2;
            this.learningVisualizationGroupBox.TabStop = false;
            this.learningVisualizationGroupBox.Text = "2D Visualization";
            // 
            // learningScatterplotView
            // 
            this.learningScatterplotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningScatterplotView.LinesVisible = false;
            this.learningScatterplotView.Location = new System.Drawing.Point(3, 26);
            this.learningScatterplotView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.learningScatterplotView.Name = "learningScatterplotView";
            this.learningScatterplotView.ScaleTight = true;
            this.learningScatterplotView.Size = new System.Drawing.Size(623, 344);
            this.learningScatterplotView.SymbolSize = 7F;
            this.learningScatterplotView.TabIndex = 0;
            // 
            // leanrningPanel
            // 
            this.leanrningPanel.Controls.Add(this.currentIterationGroupBox);
            this.leanrningPanel.Controls.Add(this.learningGroupBox);
            this.leanrningPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leanrningPanel.Location = new System.Drawing.Point(344, 3);
            this.leanrningPanel.Name = "leanrningPanel";
            this.leanrningPanel.Size = new System.Drawing.Size(629, 140);
            this.leanrningPanel.TabIndex = 1;
            // 
            // currentIterationGroupBox
            // 
            this.currentIterationGroupBox.Controls.Add(this.elapsedTextBox);
            this.currentIterationGroupBox.Controls.Add(this.errorTextBox);
            this.currentIterationGroupBox.Controls.Add(this.iterationTextBox);
            this.currentIterationGroupBox.Controls.Add(this.elapsedLabel);
            this.currentIterationGroupBox.Controls.Add(this.errorLabel);
            this.currentIterationGroupBox.Controls.Add(this.iterationLabel);
            this.currentIterationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentIterationGroupBox.Location = new System.Drawing.Point(390, 0);
            this.currentIterationGroupBox.Name = "currentIterationGroupBox";
            this.currentIterationGroupBox.Size = new System.Drawing.Size(239, 140);
            this.currentIterationGroupBox.TabIndex = 1;
            this.currentIterationGroupBox.TabStop = false;
            this.currentIterationGroupBox.Text = "Current iteration";
            // 
            // elapsedTextBox
            // 
            this.elapsedTextBox.Enabled = false;
            this.elapsedTextBox.Location = new System.Drawing.Point(89, 87);
            this.elapsedTextBox.Name = "elapsedTextBox";
            this.elapsedTextBox.ReadOnly = true;
            this.elapsedTextBox.Size = new System.Drawing.Size(122, 30);
            this.elapsedTextBox.TabIndex = 2;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Enabled = false;
            this.errorTextBox.Location = new System.Drawing.Point(89, 56);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(122, 30);
            this.errorTextBox.TabIndex = 1;
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Enabled = false;
            this.iterationTextBox.Location = new System.Drawing.Point(89, 24);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.ReadOnly = true;
            this.iterationTextBox.Size = new System.Drawing.Size(122, 30);
            this.iterationTextBox.TabIndex = 0;
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Location = new System.Drawing.Point(17, 90);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(83, 25);
            this.elapsedLabel.TabIndex = 0;
            this.elapsedLabel.Text = "Elapsed";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(39, 59);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(54, 25);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Error";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(16, 27);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(81, 25);
            this.iterationLabel.TabIndex = 0;
            this.iterationLabel.Text = "Iteration";
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.iterationsNumericUpDown);
            this.learningGroupBox.Controls.Add(this.startButton);
            this.learningGroupBox.Controls.Add(this.stopButton);
            this.learningGroupBox.Controls.Add(this.learningMethodComboBox);
            this.learningGroupBox.Controls.Add(this.learningToNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningToLabel);
            this.learningGroupBox.Controls.Add(this.learningFromNumericUpDown);
            this.learningGroupBox.Controls.Add(this.methodLabel);
            this.learningGroupBox.Controls.Add(this.iterationsLabel);
            this.learningGroupBox.Controls.Add(this.learningFromLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.learningGroupBox.Location = new System.Drawing.Point(0, 0);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(390, 140);
            this.learningGroupBox.TabIndex = 0;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // iterationsNumericUpDown
            // 
            this.iterationsNumericUpDown.Location = new System.Drawing.Point(85, 91);
            this.iterationsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Name = "iterationsNumericUpDown";
            this.iterationsNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.iterationsNumericUpDown.TabIndex = 3;
            this.iterationsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(191, 91);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 30);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(277, 91);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(80, 30);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // learningMethodComboBox
            // 
            this.learningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.learningMethodComboBox.FormattingEnabled = true;
            this.learningMethodComboBox.Items.AddRange(new object[] {
            "Levenberg-Marquardt",
            "Backpropagation",
            "Resilient Backpropagation",
            "Parallel Resilient Backpropagation"});
            this.learningMethodComboBox.Location = new System.Drawing.Point(85, 25);
            this.learningMethodComboBox.Name = "learningMethodComboBox";
            this.learningMethodComboBox.Size = new System.Drawing.Size(270, 33);
            this.learningMethodComboBox.TabIndex = 0;
            // 
            // learningToNumericUpDown
            // 
            this.learningToNumericUpDown.Location = new System.Drawing.Point(233, 59);
            this.learningToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningToNumericUpDown.Name = "learningToNumericUpDown";
            this.learningToNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.learningToNumericUpDown.TabIndex = 2;
            this.learningToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // learningToLabel
            // 
            this.learningToLabel.AutoSize = true;
            this.learningToLabel.Location = new System.Drawing.Point(200, 61);
            this.learningToLabel.Name = "learningToLabel";
            this.learningToLabel.Size = new System.Drawing.Size(36, 25);
            this.learningToLabel.TabIndex = 0;
            this.learningToLabel.Text = "To";
            // 
            // learningFromNumericUpDown
            // 
            this.learningFromNumericUpDown.Location = new System.Drawing.Point(85, 59);
            this.learningFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningFromNumericUpDown.Name = "learningFromNumericUpDown";
            this.learningFromNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.learningFromNumericUpDown.TabIndex = 1;
            this.learningFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(16, 28);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(78, 25);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Method";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(3, 93);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(91, 25);
            this.iterationsLabel.TabIndex = 0;
            this.iterationsLabel.Text = "Iterations";
            // 
            // learningFromLabel
            // 
            this.learningFromLabel.AutoSize = true;
            this.learningFromLabel.Location = new System.Drawing.Point(33, 61);
            this.learningFromLabel.Name = "learningFromLabel";
            this.learningFromLabel.Size = new System.Drawing.Size(57, 25);
            this.learningFromLabel.TabIndex = 0;
            this.learningFromLabel.Text = "From";
            // 
            // networkPanel
            // 
            this.networkPanel.Controls.Add(this.networkSettingsGroupBox);
            this.networkPanel.Controls.Add(this.networkStructureGroupBox);
            this.networkPanel.Controls.Add(this.activationFuncionGroupBox);
            this.networkPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkPanel.Location = new System.Drawing.Point(3, 3);
            this.networkPanel.Name = "networkPanel";
            this.networkPanel.Size = new System.Drawing.Size(341, 513);
            this.networkPanel.TabIndex = 0;
            // 
            // networkSettingsGroupBox
            // 
            this.networkSettingsGroupBox.Controls.Add(this.nguyenWidrowCheckBox);
            this.networkSettingsGroupBox.Controls.Add(this.bayesianRegularizationCheckBox);
            this.networkSettingsGroupBox.Controls.Add(this.sameWeightsCheckBox);
            this.networkSettingsGroupBox.Controls.Add(this.learningRateNumericUpDown);
            this.networkSettingsGroupBox.Controls.Add(this.learningRateLabel);
            this.networkSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkSettingsGroupBox.Location = new System.Drawing.Point(0, 353);
            this.networkSettingsGroupBox.Name = "networkSettingsGroupBox";
            this.networkSettingsGroupBox.Size = new System.Drawing.Size(341, 160);
            this.networkSettingsGroupBox.TabIndex = 2;
            this.networkSettingsGroupBox.TabStop = false;
            this.networkSettingsGroupBox.Text = "Network Setting";
            // 
            // nguyenWidrowCheckBox
            // 
            this.nguyenWidrowCheckBox.AutoSize = true;
            this.nguyenWidrowCheckBox.Location = new System.Drawing.Point(70, 96);
            this.nguyenWidrowCheckBox.Name = "nguyenWidrowCheckBox";
            this.nguyenWidrowCheckBox.Size = new System.Drawing.Size(292, 29);
            this.nguyenWidrowCheckBox.TabIndex = 2;
            this.nguyenWidrowCheckBox.Text = "Use Nguyen-Widrow Weights";
            this.nguyenWidrowCheckBox.UseVisualStyleBackColor = true;
            this.nguyenWidrowCheckBox.CheckedChanged += new System.EventHandler(this.nguyenWidrowCheckBox_CheckedChanged);
            // 
            // bayesianRegularizationCheckBox
            // 
            this.bayesianRegularizationCheckBox.AutoSize = true;
            this.bayesianRegularizationCheckBox.Location = new System.Drawing.Point(70, 66);
            this.bayesianRegularizationCheckBox.Name = "bayesianRegularizationCheckBox";
            this.bayesianRegularizationCheckBox.Size = new System.Drawing.Size(283, 29);
            this.bayesianRegularizationCheckBox.TabIndex = 1;
            this.bayesianRegularizationCheckBox.Text = "Use Bayesian Regularization";
            this.bayesianRegularizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // sameWeightsCheckBox
            // 
            this.sameWeightsCheckBox.AutoSize = true;
            this.sameWeightsCheckBox.Enabled = false;
            this.sameWeightsCheckBox.Location = new System.Drawing.Point(70, 126);
            this.sameWeightsCheckBox.Name = "sameWeightsCheckBox";
            this.sameWeightsCheckBox.Size = new System.Drawing.Size(291, 29);
            this.sameWeightsCheckBox.TabIndex = 3;
            this.sameWeightsCheckBox.Text = "Use always same initialization";
            this.sameWeightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // learningRateNumericUpDown
            // 
            this.learningRateNumericUpDown.DecimalPlaces = 2;
            this.learningRateNumericUpDown.Location = new System.Drawing.Point(135, 25);
            this.learningRateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            this.learningRateNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.learningRateNumericUpDown.TabIndex = 0;
            this.learningRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Location = new System.Drawing.Point(26, 27);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(126, 25);
            this.learningRateLabel.TabIndex = 0;
            this.learningRateLabel.Text = "Learning rate";
            // 
            // networkStructureGroupBox
            // 
            this.networkStructureGroupBox.Controls.Add(this.deleteLayerButton);
            this.networkStructureGroupBox.Controls.Add(this.addLayerButton);
            this.networkStructureGroupBox.Controls.Add(this.networkStructureDataGridView);
            this.networkStructureGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkStructureGroupBox.Location = new System.Drawing.Point(0, 167);
            this.networkStructureGroupBox.Name = "networkStructureGroupBox";
            this.networkStructureGroupBox.Size = new System.Drawing.Size(341, 186);
            this.networkStructureGroupBox.TabIndex = 1;
            this.networkStructureGroupBox.TabStop = false;
            this.networkStructureGroupBox.Text = "Network Structure";
            // 
            // deleteLayerButton
            // 
            this.deleteLayerButton.Location = new System.Drawing.Point(255, 58);
            this.deleteLayerButton.Name = "deleteLayerButton";
            this.deleteLayerButton.Size = new System.Drawing.Size(80, 30);
            this.deleteLayerButton.TabIndex = 2;
            this.deleteLayerButton.Text = "Delete";
            this.deleteLayerButton.UseVisualStyleBackColor = true;
            this.deleteLayerButton.Click += new System.EventHandler(this.deleteLayerButton_Click);
            // 
            // addLayerButton
            // 
            this.addLayerButton.Location = new System.Drawing.Point(255, 22);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(80, 30);
            this.addLayerButton.TabIndex = 1;
            this.addLayerButton.Text = "Add";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // networkStructureDataGridView
            // 
            this.networkStructureDataGridView.AllowUserToAddRows = false;
            this.networkStructureDataGridView.AllowUserToDeleteRows = false;
            this.networkStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.networkStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.networkStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkStructureDataGridView.Location = new System.Drawing.Point(3, 26);
            this.networkStructureDataGridView.Name = "networkStructureDataGridView";
            this.networkStructureDataGridView.RowHeadersVisible = false;
            this.networkStructureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.networkStructureDataGridView.Size = new System.Drawing.Size(246, 157);
            this.networkStructureDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Layer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Neurons";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activationFuncionGroupBox
            // 
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionComboBox);
            this.activationFuncionGroupBox.Controls.Add(this.alphaNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionLabel);
            this.activationFuncionGroupBox.Controls.Add(this.alphaLabel);
            this.activationFuncionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.activationFuncionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.activationFuncionGroupBox.Name = "activationFuncionGroupBox";
            this.activationFuncionGroupBox.Size = new System.Drawing.Size(341, 167);
            this.activationFuncionGroupBox.TabIndex = 0;
            this.activationFuncionGroupBox.TabStop = false;
            this.activationFuncionGroupBox.Text = "Activation Function";
            // 
            // upperLimitNumericUpDown
            // 
            this.upperLimitNumericUpDown.DecimalPlaces = 1;
            this.upperLimitNumericUpDown.Enabled = false;
            this.upperLimitNumericUpDown.Location = new System.Drawing.Point(144, 124);
            this.upperLimitNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upperLimitNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.upperLimitNumericUpDown.Name = "upperLimitNumericUpDown";
            this.upperLimitNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.upperLimitNumericUpDown.TabIndex = 3;
            this.upperLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperLimitLabel
            // 
            this.upperLimitLabel.AutoSize = true;
            this.upperLimitLabel.Location = new System.Drawing.Point(54, 126);
            this.upperLimitLabel.Name = "upperLimitLabel";
            this.upperLimitLabel.Size = new System.Drawing.Size(103, 25);
            this.upperLimitLabel.TabIndex = 0;
            this.upperLimitLabel.Text = "Upper limit";
            // 
            // lowerLimitNumericUpDown
            // 
            this.lowerLimitNumericUpDown.DecimalPlaces = 1;
            this.lowerLimitNumericUpDown.Enabled = false;
            this.lowerLimitNumericUpDown.Location = new System.Drawing.Point(144, 92);
            this.lowerLimitNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.lowerLimitNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.lowerLimitNumericUpDown.Name = "lowerLimitNumericUpDown";
            this.lowerLimitNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.lowerLimitNumericUpDown.TabIndex = 2;
            this.lowerLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Location = new System.Drawing.Point(55, 94);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(103, 25);
            this.lowerLimitLabel.TabIndex = 0;
            this.lowerLimitLabel.Text = "Lower limit";
            // 
            // activationFunctionComboBox
            // 
            this.activationFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionComboBox.FormattingEnabled = true;
            this.activationFunctionComboBox.Items.AddRange(new object[] {
            "Gaussian",
            "Bernoulli"});
            this.activationFunctionComboBox.Location = new System.Drawing.Point(124, 25);
            this.activationFunctionComboBox.Name = "activationFunctionComboBox";
            this.activationFunctionComboBox.Size = new System.Drawing.Size(120, 33);
            this.activationFunctionComboBox.TabIndex = 0;
            this.activationFunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.activationFunctionComboBox_SelectedIndexChanged);
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.DecimalPlaces = 1;
            this.alphaNumericUpDown.Location = new System.Drawing.Point(144, 59);
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.alphaNumericUpDown.TabIndex = 1;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // activationFunctionLabel
            // 
            this.activationFunctionLabel.AutoSize = true;
            this.activationFunctionLabel.Location = new System.Drawing.Point(47, 28);
            this.activationFunctionLabel.Name = "activationFunctionLabel";
            this.activationFunctionLabel.Size = new System.Drawing.Size(87, 25);
            this.activationFunctionLabel.TabIndex = 0;
            this.activationFunctionLabel.Text = "Function";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(120, 61);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(23, 25);
            this.alphaLabel.TabIndex = 0;
            this.alphaLabel.Text = "α";
            // 
            // networkTabPage
            // 
            this.networkTabPage.Controls.Add(this.neuronInfoGroupBox);
            this.networkTabPage.Controls.Add(this.layerInfoGroupBox);
            this.networkTabPage.Controls.Add(this.networkViewGroupBox);
            this.networkTabPage.Location = new System.Drawing.Point(4, 34);
            this.networkTabPage.Name = "networkTabPage";
            this.networkTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.networkTabPage.Size = new System.Drawing.Size(976, 519);
            this.networkTabPage.TabIndex = 4;
            this.networkTabPage.Text = "Network";
            this.networkTabPage.UseVisualStyleBackColor = true;
            // 
            // neuronInfoGroupBox
            // 
            this.neuronInfoGroupBox.Controls.Add(this.biasTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.label1);
            this.neuronInfoGroupBox.Controls.Add(this.weightsListBox);
            this.neuronInfoGroupBox.Controls.Add(this.outputTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.weightsLabel);
            this.neuronInfoGroupBox.Controls.Add(this.outputLabel);
            this.neuronInfoGroupBox.Controls.Add(this.neuronTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.neuronLabel);
            this.neuronInfoGroupBox.Controls.Add(this.layerTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.layerLabel);
            this.neuronInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuronInfoGroupBox.Location = new System.Drawing.Point(503, 136);
            this.neuronInfoGroupBox.Name = "neuronInfoGroupBox";
            this.neuronInfoGroupBox.Size = new System.Drawing.Size(470, 380);
            this.neuronInfoGroupBox.TabIndex = 2;
            this.neuronInfoGroupBox.TabStop = false;
            this.neuronInfoGroupBox.Text = "Neuron Info";
            // 
            // biasTextBox
            // 
            this.biasTextBox.Location = new System.Drawing.Point(314, 89);
            this.biasTextBox.Name = "biasTextBox";
            this.biasTextBox.Size = new System.Drawing.Size(150, 30);
            this.biasTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bias";
            // 
            // weightsListBox
            // 
            this.weightsListBox.FormattingEnabled = true;
            this.weightsListBox.ItemHeight = 25;
            this.weightsListBox.Location = new System.Drawing.Point(90, 89);
            this.weightsListBox.Name = "weightsListBox";
            this.weightsListBox.Size = new System.Drawing.Size(150, 279);
            this.weightsListBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(314, 121);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(150, 30);
            this.outputTextBox.TabIndex = 4;
            // 
            // weightsLabel
            // 
            this.weightsLabel.AutoSize = true;
            this.weightsLabel.Location = new System.Drawing.Point(17, 92);
            this.weightsLabel.Name = "weightsLabel";
            this.weightsLabel.Size = new System.Drawing.Size(84, 25);
            this.weightsLabel.TabIndex = 0;
            this.weightsLabel.Text = "Weights";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(250, 124);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(71, 25);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output";
            // 
            // neuronTextBox
            // 
            this.neuronTextBox.Location = new System.Drawing.Point(90, 57);
            this.neuronTextBox.Name = "neuronTextBox";
            this.neuronTextBox.Size = new System.Drawing.Size(150, 30);
            this.neuronTextBox.TabIndex = 1;
            // 
            // neuronLabel
            // 
            this.neuronLabel.AutoSize = true;
            this.neuronLabel.Location = new System.Drawing.Point(23, 60);
            this.neuronLabel.Name = "neuronLabel";
            this.neuronLabel.Size = new System.Drawing.Size(76, 25);
            this.neuronLabel.TabIndex = 0;
            this.neuronLabel.Text = "Neuron";
            // 
            // layerTextBox
            // 
            this.layerTextBox.Location = new System.Drawing.Point(90, 25);
            this.layerTextBox.Name = "layerTextBox";
            this.layerTextBox.Size = new System.Drawing.Size(150, 30);
            this.layerTextBox.TabIndex = 0;
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(36, 28);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(61, 25);
            this.layerLabel.TabIndex = 0;
            this.layerLabel.Text = "Layer";
            // 
            // layerInfoGroupBox
            // 
            this.layerInfoGroupBox.Controls.Add(this.layerNameTextBox);
            this.layerInfoGroupBox.Controls.Add(this.numberOfInputsTextBox);
            this.layerInfoGroupBox.Controls.Add(this.layerNameLabel);
            this.layerInfoGroupBox.Controls.Add(this.numberOfNeuronsLabel);
            this.layerInfoGroupBox.Controls.Add(this.numberOfInputsLabel);
            this.layerInfoGroupBox.Controls.Add(this.numberOfNeuronsTextBox);
            this.layerInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.layerInfoGroupBox.Location = new System.Drawing.Point(503, 3);
            this.layerInfoGroupBox.Name = "layerInfoGroupBox";
            this.layerInfoGroupBox.Size = new System.Drawing.Size(470, 133);
            this.layerInfoGroupBox.TabIndex = 1;
            this.layerInfoGroupBox.TabStop = false;
            this.layerInfoGroupBox.Text = "Layer Info";
            // 
            // layerNameTextBox
            // 
            this.layerNameTextBox.Location = new System.Drawing.Point(222, 26);
            this.layerNameTextBox.Name = "layerNameTextBox";
            this.layerNameTextBox.Size = new System.Drawing.Size(150, 30);
            this.layerNameTextBox.TabIndex = 0;
            // 
            // numberOfInputsTextBox
            // 
            this.numberOfInputsTextBox.Location = new System.Drawing.Point(222, 90);
            this.numberOfInputsTextBox.Name = "numberOfInputsTextBox";
            this.numberOfInputsTextBox.Size = new System.Drawing.Size(150, 30);
            this.numberOfInputsTextBox.TabIndex = 2;
            // 
            // layerNameLabel
            // 
            this.layerNameLabel.AutoSize = true;
            this.layerNameLabel.Location = new System.Drawing.Point(168, 29);
            this.layerNameLabel.Name = "layerNameLabel";
            this.layerNameLabel.Size = new System.Drawing.Size(61, 25);
            this.layerNameLabel.TabIndex = 0;
            this.layerNameLabel.Text = "Layer";
            // 
            // numberOfNeuronsLabel
            // 
            this.numberOfNeuronsLabel.AutoSize = true;
            this.numberOfNeuronsLabel.Location = new System.Drawing.Point(69, 61);
            this.numberOfNeuronsLabel.Name = "numberOfNeuronsLabel";
            this.numberOfNeuronsLabel.Size = new System.Drawing.Size(181, 25);
            this.numberOfNeuronsLabel.TabIndex = 0;
            this.numberOfNeuronsLabel.Text = "Number of Neurons";
            // 
            // numberOfInputsLabel
            // 
            this.numberOfInputsLabel.AutoSize = true;
            this.numberOfInputsLabel.Location = new System.Drawing.Point(84, 93);
            this.numberOfInputsLabel.Name = "numberOfInputsLabel";
            this.numberOfInputsLabel.Size = new System.Drawing.Size(160, 25);
            this.numberOfInputsLabel.TabIndex = 0;
            this.numberOfInputsLabel.Text = "Number of Inputs";
            // 
            // numberOfNeuronsTextBox
            // 
            this.numberOfNeuronsTextBox.Location = new System.Drawing.Point(222, 58);
            this.numberOfNeuronsTextBox.Name = "numberOfNeuronsTextBox";
            this.numberOfNeuronsTextBox.Size = new System.Drawing.Size(150, 30);
            this.numberOfNeuronsTextBox.TabIndex = 1;
            // 
            // networkViewGroupBox
            // 
            this.networkViewGroupBox.Controls.Add(this.networkTreeView);
            this.networkViewGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkViewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.networkViewGroupBox.Name = "networkViewGroupBox";
            this.networkViewGroupBox.Size = new System.Drawing.Size(500, 513);
            this.networkViewGroupBox.TabIndex = 0;
            this.networkViewGroupBox.TabStop = false;
            this.networkViewGroupBox.Text = "Network View";
            // 
            // networkTreeView
            // 
            this.networkTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkTreeView.Location = new System.Drawing.Point(3, 26);
            this.networkTreeView.Name = "networkTreeView";
            this.networkTreeView.Size = new System.Drawing.Size(494, 484);
            this.networkTreeView.TabIndex = 0;
            this.networkTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.networkTreeView_NodeMouseClick);
            // 
            // modelTestingTabPage
            // 
            this.modelTestingTabPage.Controls.Add(this.testingVisualizationGroupBox);
            this.modelTestingTabPage.Controls.Add(this.predictionGroupBox);
            this.modelTestingTabPage.Controls.Add(this.testingDataGroupBox);
            this.modelTestingTabPage.Location = new System.Drawing.Point(4, 34);
            this.modelTestingTabPage.Name = "modelTestingTabPage";
            this.modelTestingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelTestingTabPage.Size = new System.Drawing.Size(976, 519);
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
            this.testingVisualizationGroupBox.Size = new System.Drawing.Size(530, 363);
            this.testingVisualizationGroupBox.TabIndex = 2;
            this.testingVisualizationGroupBox.TabStop = false;
            this.testingVisualizationGroupBox.Text = "2D Visualization";
            // 
            // testingZedGraphControl
            // 
            this.testingZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingZedGraphControl.Location = new System.Drawing.Point(3, 81);
            this.testingZedGraphControl.Margin = new System.Windows.Forms.Padding(8);
            this.testingZedGraphControl.Name = "testingZedGraphControl";
            this.testingZedGraphControl.ScrollGrace = 0D;
            this.testingZedGraphControl.ScrollMaxX = 0D;
            this.testingZedGraphControl.ScrollMaxY = 0D;
            this.testingZedGraphControl.ScrollMaxY2 = 0D;
            this.testingZedGraphControl.ScrollMinX = 0D;
            this.testingZedGraphControl.ScrollMinY = 0D;
            this.testingZedGraphControl.ScrollMinY2 = 0D;
            this.testingZedGraphControl.Size = new System.Drawing.Size(524, 279);
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
            this.testingVisualizationPanel.Location = new System.Drawing.Point(3, 26);
            this.testingVisualizationPanel.Name = "testingVisualizationPanel";
            this.testingVisualizationPanel.Size = new System.Drawing.Size(524, 55);
            this.testingVisualizationPanel.TabIndex = 0;
            // 
            // testingXComboBox
            // 
            this.testingXComboBox.Enabled = false;
            this.testingXComboBox.FormattingEnabled = true;
            this.testingXComboBox.Location = new System.Drawing.Point(38, 11);
            this.testingXComboBox.Name = "testingXComboBox";
            this.testingXComboBox.Size = new System.Drawing.Size(200, 33);
            this.testingXComboBox.TabIndex = 0;
            this.testingXComboBox.SelectedIndexChanged += new System.EventHandler(this.testingComboBox_SelectedIndexChanged);
            // 
            // testingYComboBox
            // 
            this.testingYComboBox.Enabled = false;
            this.testingYComboBox.FormattingEnabled = true;
            this.testingYComboBox.Location = new System.Drawing.Point(280, 11);
            this.testingYComboBox.Name = "testingYComboBox";
            this.testingYComboBox.Size = new System.Drawing.Size(200, 33);
            this.testingYComboBox.TabIndex = 1;
            this.testingYComboBox.SelectedIndexChanged += new System.EventHandler(this.testingComboBox_SelectedIndexChanged);
            // 
            // testingYLabel
            // 
            this.testingYLabel.AutoSize = true;
            this.testingYLabel.Location = new System.Drawing.Point(246, 14);
            this.testingYLabel.Name = "testingYLabel";
            this.testingYLabel.Size = new System.Drawing.Size(28, 25);
            this.testingYLabel.TabIndex = 0;
            this.testingYLabel.Text = "y:";
            // 
            // testingXLabel
            // 
            this.testingXLabel.AutoSize = true;
            this.testingXLabel.Location = new System.Drawing.Point(4, 14);
            this.testingXLabel.Name = "testingXLabel";
            this.testingXLabel.Size = new System.Drawing.Size(28, 25);
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
            this.predictionDataGridView.Location = new System.Drawing.Point(3, 26);
            this.predictionDataGridView.Name = "predictionDataGridView";
            this.predictionDataGridView.RowHeadersVisible = false;
            this.predictionDataGridView.RowTemplate.Height = 24;
            this.predictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predictionDataGridView.ShowCellErrors = false;
            this.predictionDataGridView.ShowEditingIcon = false;
            this.predictionDataGridView.ShowRowErrors = false;
            this.predictionDataGridView.Size = new System.Drawing.Size(444, 121);
            this.predictionDataGridView.TabIndex = 0;
            // 
            // predictButton
            // 
            this.predictButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.predictButton.Enabled = false;
            this.predictButton.Location = new System.Drawing.Point(447, 26);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(80, 121);
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
            this.testingDataGroupBox.Size = new System.Drawing.Size(440, 513);
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
            this.testingDataGridView.Location = new System.Drawing.Point(4, 28);
            this.testingDataGridView.Name = "testingDataGridView";
            this.testingDataGridView.ReadOnly = true;
            this.testingDataGridView.RowHeadersVisible = false;
            this.testingDataGridView.RowTemplate.Height = 24;
            this.testingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testingDataGridView.ShowCellErrors = false;
            this.testingDataGridView.ShowEditingIcon = false;
            this.testingDataGridView.ShowRowErrors = false;
            this.testingDataGridView.Size = new System.Drawing.Size(432, 404);
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
            this.testingPanel.Location = new System.Drawing.Point(4, 432);
            this.testingPanel.Name = "testingPanel";
            this.testingPanel.Size = new System.Drawing.Size(432, 76);
            this.testingPanel.TabIndex = 4;
            // 
            // testingFromLabel
            // 
            this.testingFromLabel.AutoSize = true;
            this.testingFromLabel.Location = new System.Drawing.Point(14, 13);
            this.testingFromLabel.Name = "testingFromLabel";
            this.testingFromLabel.Size = new System.Drawing.Size(57, 25);
            this.testingFromLabel.TabIndex = 0;
            this.testingFromLabel.Text = "From";
            // 
            // numberOfMatchesLabel
            // 
            this.numberOfMatchesLabel.AutoSize = true;
            this.numberOfMatchesLabel.Location = new System.Drawing.Point(14, 46);
            this.numberOfMatchesLabel.Name = "numberOfMatchesLabel";
            this.numberOfMatchesLabel.Size = new System.Drawing.Size(187, 25);
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
            this.testingFromNumericUpDown.Size = new System.Drawing.Size(100, 30);
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
            this.testingToLabel.Size = new System.Drawing.Size(36, 25);
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
            this.testingToNumericUpDown.Size = new System.Drawing.Size(100, 30);
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DNNClassifierModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "DNNClassifierModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deep Belief Network (DBN) Classifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DNNBinaryClassifierModelForm_FormClosing);
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataVisualizationGroupBox.ResumeLayout(false);
            this.inputDataVisualizationPanel.ResumeLayout(false);
            this.inputDataVisualizationPanel.PerformLayout();
            this.learningTabPage.ResumeLayout(false);
            this.learningVisualizationGroupBox.ResumeLayout(false);
            this.leanrningPanel.ResumeLayout(false);
            this.currentIterationGroupBox.ResumeLayout(false);
            this.currentIterationGroupBox.PerformLayout();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).EndInit();
            this.networkPanel.ResumeLayout(false);
            this.networkSettingsGroupBox.ResumeLayout(false);
            this.networkSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).EndInit();
            this.networkStructureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).EndInit();
            this.activationFuncionGroupBox.ResumeLayout(false);
            this.activationFuncionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            this.networkTabPage.ResumeLayout(false);
            this.neuronInfoGroupBox.ResumeLayout(false);
            this.neuronInfoGroupBox.PerformLayout();
            this.layerInfoGroupBox.ResumeLayout(false);
            this.layerInfoGroupBox.PerformLayout();
            this.networkViewGroupBox.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.ComboBox learningMethodComboBox;
        private System.Windows.Forms.NumericUpDown learningToNumericUpDown;
        private System.Windows.Forms.Label learningToLabel;
        private System.Windows.Forms.NumericUpDown learningFromNumericUpDown;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label learningFromLabel;
        private System.Windows.Forms.GroupBox learningVisualizationGroupBox;
        private System.Windows.Forms.TabPage networkTabPage;
        private System.Windows.Forms.GroupBox networkViewGroupBox;
        private System.Windows.Forms.GroupBox currentIterationGroupBox;
        private System.Windows.Forms.TextBox elapsedTextBox;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.NumericUpDown iterationsNumericUpDown;
        private Accord.Controls.ScatterplotView learningScatterplotView;
        private System.Windows.Forms.TreeView networkTreeView;
        private System.Windows.Forms.GroupBox neuronInfoGroupBox;
        private System.Windows.Forms.ListBox weightsListBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label weightsLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox neuronTextBox;
        private System.Windows.Forms.Label neuronLabel;
        private System.Windows.Forms.TextBox layerTextBox;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.GroupBox networkSettingsGroupBox;
        private System.Windows.Forms.GroupBox networkStructureGroupBox;
        private System.Windows.Forms.Panel networkPanel;
        private System.Windows.Forms.DataGridView networkStructureDataGridView;
        private System.Windows.Forms.Button deleteLayerButton;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox layerInfoGroupBox;
        private System.Windows.Forms.TextBox layerNameTextBox;
        private System.Windows.Forms.TextBox numberOfInputsTextBox;
        private System.Windows.Forms.Label layerNameLabel;
        private System.Windows.Forms.Label numberOfNeuronsLabel;
        private System.Windows.Forms.Label numberOfInputsLabel;
        private System.Windows.Forms.TextBox numberOfNeuronsTextBox;
        private System.Windows.Forms.Panel leanrningPanel;
        private System.Windows.Forms.GroupBox activationFuncionGroupBox;
        private System.Windows.Forms.NumericUpDown upperLimitNumericUpDown;
        private System.Windows.Forms.Label upperLimitLabel;
        private System.Windows.Forms.NumericUpDown lowerLimitNumericUpDown;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.ComboBox activationFunctionComboBox;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.Label activationFunctionLabel;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.CheckBox nguyenWidrowCheckBox;
        private System.Windows.Forms.CheckBox bayesianRegularizationCheckBox;
        private System.Windows.Forms.CheckBox sameWeightsCheckBox;
        private System.Windows.Forms.NumericUpDown learningRateNumericUpDown;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.TextBox biasTextBox;
        private System.Windows.Forms.Label label1;
    }
}