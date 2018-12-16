namespace MachineLearning
{
    partial class MinimumMeanDistanceModelForm
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
            this.learningZedGraphControl = new ZedGraph.ZedGraphControl();
            this.learningVisualizationPanel = new System.Windows.Forms.Panel();
            this.learningXComboBox = new System.Windows.Forms.ComboBox();
            this.learningYComboBox = new System.Windows.Forms.ComboBox();
            this.learningYLabel = new System.Windows.Forms.Label();
            this.learningXLabel = new System.Windows.Forms.Label();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.learningToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningToLabel = new System.Windows.Forms.Label();
            this.learningFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningFromLabel = new System.Windows.Forms.Label();
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
            this.learningVisualizationGroupBox.SuspendLayout();
            this.learningVisualizationPanel.SuspendLayout();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).BeginInit();
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
            this.inputDataXComboBox.FormattingEnabled = true;
            this.inputDataXComboBox.Location = new System.Drawing.Point(38, 11);
            this.inputDataXComboBox.Name = "inputDataXComboBox";
            this.inputDataXComboBox.Size = new System.Drawing.Size(200, 28);
            this.inputDataXComboBox.TabIndex = 0;
            this.inputDataXComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDataComboBox_SelectedIndexChanged);
            // 
            // inputDataYComboBox
            // 
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
            this.learningTabPage.Controls.Add(this.learningVisualizationGroupBox);
            this.learningTabPage.Controls.Add(this.learningGroupBox);
            this.learningTabPage.Location = new System.Drawing.Point(4, 29);
            this.learningTabPage.Name = "learningTabPage";
            this.learningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.learningTabPage.Size = new System.Drawing.Size(976, 524);
            this.learningTabPage.TabIndex = 3;
            this.learningTabPage.Text = "Learning";
            this.learningTabPage.UseVisualStyleBackColor = true;
            // 
            // learningVisualizationGroupBox
            // 
            this.learningVisualizationGroupBox.Controls.Add(this.learningZedGraphControl);
            this.learningVisualizationGroupBox.Controls.Add(this.learningVisualizationPanel);
            this.learningVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningVisualizationGroupBox.Location = new System.Drawing.Point(3, 73);
            this.learningVisualizationGroupBox.Name = "learningVisualizationGroupBox";
            this.learningVisualizationGroupBox.Size = new System.Drawing.Size(970, 448);
            this.learningVisualizationGroupBox.TabIndex = 1;
            this.learningVisualizationGroupBox.TabStop = false;
            this.learningVisualizationGroupBox.Text = "2D Visualization";
            // 
            // learningZedGraphControl
            // 
            this.learningZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningZedGraphControl.Location = new System.Drawing.Point(3, 77);
            this.learningZedGraphControl.Margin = new System.Windows.Forms.Padding(12);
            this.learningZedGraphControl.Name = "learningZedGraphControl";
            this.learningZedGraphControl.ScrollGrace = 0D;
            this.learningZedGraphControl.ScrollMaxX = 0D;
            this.learningZedGraphControl.ScrollMaxY = 0D;
            this.learningZedGraphControl.ScrollMaxY2 = 0D;
            this.learningZedGraphControl.ScrollMinX = 0D;
            this.learningZedGraphControl.ScrollMinY = 0D;
            this.learningZedGraphControl.ScrollMinY2 = 0D;
            this.learningZedGraphControl.Size = new System.Drawing.Size(964, 368);
            this.learningZedGraphControl.TabIndex = 1;
            this.learningZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // learningVisualizationPanel
            // 
            this.learningVisualizationPanel.Controls.Add(this.learningXComboBox);
            this.learningVisualizationPanel.Controls.Add(this.learningYComboBox);
            this.learningVisualizationPanel.Controls.Add(this.learningYLabel);
            this.learningVisualizationPanel.Controls.Add(this.learningXLabel);
            this.learningVisualizationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.learningVisualizationPanel.Location = new System.Drawing.Point(3, 22);
            this.learningVisualizationPanel.Name = "learningVisualizationPanel";
            this.learningVisualizationPanel.Size = new System.Drawing.Size(964, 55);
            this.learningVisualizationPanel.TabIndex = 0;
            // 
            // learningXComboBox
            // 
            this.learningXComboBox.Enabled = false;
            this.learningXComboBox.FormattingEnabled = true;
            this.learningXComboBox.Location = new System.Drawing.Point(38, 11);
            this.learningXComboBox.Name = "learningXComboBox";
            this.learningXComboBox.Size = new System.Drawing.Size(200, 28);
            this.learningXComboBox.TabIndex = 0;
            // 
            // learningYComboBox
            // 
            this.learningYComboBox.Enabled = false;
            this.learningYComboBox.FormattingEnabled = true;
            this.learningYComboBox.Location = new System.Drawing.Point(278, 11);
            this.learningYComboBox.Name = "learningYComboBox";
            this.learningYComboBox.Size = new System.Drawing.Size(200, 28);
            this.learningYComboBox.TabIndex = 1;
            // 
            // learningYLabel
            // 
            this.learningYLabel.AutoSize = true;
            this.learningYLabel.Location = new System.Drawing.Point(252, 14);
            this.learningYLabel.Name = "learningYLabel";
            this.learningYLabel.Size = new System.Drawing.Size(20, 20);
            this.learningYLabel.TabIndex = 0;
            this.learningYLabel.Text = "y:";
            // 
            // learningXLabel
            // 
            this.learningXLabel.AutoSize = true;
            this.learningXLabel.Location = new System.Drawing.Point(12, 14);
            this.learningXLabel.Name = "learningXLabel";
            this.learningXLabel.Size = new System.Drawing.Size(20, 20);
            this.learningXLabel.TabIndex = 0;
            this.learningXLabel.Text = "x:";
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.learnButton);
            this.learningGroupBox.Controls.Add(this.learningToNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningToLabel);
            this.learningGroupBox.Controls.Add(this.learningFromNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningFromLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.learningGroupBox.Location = new System.Drawing.Point(3, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(970, 70);
            this.learningGroupBox.TabIndex = 0;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(324, 25);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(100, 30);
            this.learnButton.TabIndex = 3;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // learningToNumericUpDown
            // 
            this.learningToNumericUpDown.Location = new System.Drawing.Point(218, 28);
            this.learningToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningToNumericUpDown.Name = "learningToNumericUpDown";
            this.learningToNumericUpDown.Size = new System.Drawing.Size(100, 26);
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
            this.learningToLabel.Location = new System.Drawing.Point(185, 30);
            this.learningToLabel.Name = "learningToLabel";
            this.learningToLabel.Size = new System.Drawing.Size(27, 20);
            this.learningToLabel.TabIndex = 0;
            this.learningToLabel.Text = "To";
            // 
            // learningFromNumericUpDown
            // 
            this.learningFromNumericUpDown.Location = new System.Drawing.Point(66, 28);
            this.learningFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningFromNumericUpDown.Name = "learningFromNumericUpDown";
            this.learningFromNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.learningFromNumericUpDown.TabIndex = 1;
            this.learningFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // learningFromLabel
            // 
            this.learningFromLabel.AutoSize = true;
            this.learningFromLabel.Location = new System.Drawing.Point(14, 30);
            this.learningFromLabel.Name = "learningFromLabel";
            this.learningFromLabel.Size = new System.Drawing.Size(46, 20);
            this.learningFromLabel.TabIndex = 0;
            this.learningFromLabel.Text = "From";
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
            this.testingYLabel.Location = new System.Drawing.Point(246, 14);
            this.testingYLabel.Name = "testingYLabel";
            this.testingYLabel.Size = new System.Drawing.Size(20, 20);
            this.testingYLabel.TabIndex = 0;
            this.testingYLabel.Text = "y:";
            // 
            // testingXLabel
            // 
            this.testingXLabel.AutoSize = true;
            this.testingXLabel.Location = new System.Drawing.Point(4, 14);
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
            // MinimumMeanDistanceModelForm
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
            this.Name = "MinimumMeanDistanceModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mininum Mean Distance Model";
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataVisualizationGroupBox.ResumeLayout(false);
            this.inputDataVisualizationPanel.ResumeLayout(false);
            this.inputDataVisualizationPanel.PerformLayout();
            this.learningTabPage.ResumeLayout(false);
            this.learningVisualizationGroupBox.ResumeLayout(false);
            this.learningVisualizationPanel.ResumeLayout(false);
            this.learningVisualizationPanel.PerformLayout();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).EndInit();
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
        private System.Windows.Forms.GroupBox learningVisualizationGroupBox;
        private ZedGraph.ZedGraphControl learningZedGraphControl;
        private System.Windows.Forms.Panel learningVisualizationPanel;
        private System.Windows.Forms.ComboBox learningXComboBox;
        private System.Windows.Forms.ComboBox learningYComboBox;
        private System.Windows.Forms.Label learningYLabel;
        private System.Windows.Forms.Label learningXLabel;
    }
}