namespace MachineLearning
{
    partial class ClusteringForm
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
            this.clusteringTabPage = new System.Windows.Forms.TabPage();
            this.clusteringVisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.clusteringVisualizationTabControl = new System.Windows.Forms.TabControl();
            this.scatterPlotTabPage = new System.Windows.Forms.TabPage();
            this.outputZedGraphControl = new ZedGraph.ZedGraphControl();
            this.clustersTabPage = new System.Windows.Forms.TabPage();
            this.clustersScatterplotView = new Accord.Controls.ScatterplotView();
            this.clusteringVisualizationPanel = new System.Windows.Forms.Panel();
            this.clusteringXComboBox = new System.Windows.Forms.ComboBox();
            this.clusteringYComboBox = new System.Windows.Forms.ComboBox();
            this.clusteringYLabel = new System.Windows.Forms.Label();
            this.clusteringXLabel = new System.Windows.Forms.Label();
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.createClustersButton = new System.Windows.Forms.Button();
            this.kMeansBalancedCheckBox = new System.Windows.Forms.CheckBox();
            this.kMedoidsRadioButton = new System.Windows.Forms.RadioButton();
            this.kModesRadioButton = new System.Windows.Forms.RadioButton();
            this.binarySplitRadioButton = new System.Windows.Forms.RadioButton();
            this.kMeansRadioButton = new System.Windows.Forms.RadioButton();
            this.gaussianLabel = new System.Windows.Forms.Label();
            this.kMedoidsKLabel = new System.Windows.Forms.Label();
            this.kModesKLabel = new System.Windows.Forms.Label();
            this.binarySplitKLabel = new System.Windows.Forms.Label();
            this.kMeansKLabel = new System.Windows.Forms.Label();
            this.meanShiftRadiusLabel = new System.Windows.Forms.Label();
            this.meanShiftRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianMixtureRadioButton = new System.Windows.Forms.RadioButton();
            this.meanShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.kMedoidsKNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kModesKNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.binarySplitKNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kMeansKNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.inputDataTabPage.SuspendLayout();
            this.inputDataVisualizationGroupBox.SuspendLayout();
            this.inputDataVisualizationPanel.SuspendLayout();
            this.clusteringTabPage.SuspendLayout();
            this.clusteringVisualizationGroupBox.SuspendLayout();
            this.clusteringVisualizationTabControl.SuspendLayout();
            this.scatterPlotTabPage.SuspendLayout();
            this.clustersTabPage.SuspendLayout();
            this.clusteringVisualizationPanel.SuspendLayout();
            this.modelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meanShiftRadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMedoidsKNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kModesKNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarySplitKNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMeansKNumericUpDown)).BeginInit();
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
            this.mainTabControl.Controls.Add(this.clusteringTabPage);
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
            // clusteringTabPage
            // 
            this.clusteringTabPage.Controls.Add(this.clusteringVisualizationGroupBox);
            this.clusteringTabPage.Controls.Add(this.modelGroupBox);
            this.clusteringTabPage.Location = new System.Drawing.Point(4, 29);
            this.clusteringTabPage.Name = "clusteringTabPage";
            this.clusteringTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clusteringTabPage.Size = new System.Drawing.Size(976, 524);
            this.clusteringTabPage.TabIndex = 1;
            this.clusteringTabPage.Text = "Clustering";
            this.clusteringTabPage.UseVisualStyleBackColor = true;
            // 
            // clusteringVisualizationGroupBox
            // 
            this.clusteringVisualizationGroupBox.Controls.Add(this.clusteringVisualizationTabControl);
            this.clusteringVisualizationGroupBox.Controls.Add(this.clusteringVisualizationPanel);
            this.clusteringVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusteringVisualizationGroupBox.Location = new System.Drawing.Point(373, 3);
            this.clusteringVisualizationGroupBox.Name = "clusteringVisualizationGroupBox";
            this.clusteringVisualizationGroupBox.Size = new System.Drawing.Size(600, 518);
            this.clusteringVisualizationGroupBox.TabIndex = 1;
            this.clusteringVisualizationGroupBox.TabStop = false;
            this.clusteringVisualizationGroupBox.Text = "2D Visualization";
            // 
            // clusteringVisualizationTabControl
            // 
            this.clusteringVisualizationTabControl.Controls.Add(this.scatterPlotTabPage);
            this.clusteringVisualizationTabControl.Controls.Add(this.clustersTabPage);
            this.clusteringVisualizationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusteringVisualizationTabControl.Location = new System.Drawing.Point(3, 77);
            this.clusteringVisualizationTabControl.Name = "clusteringVisualizationTabControl";
            this.clusteringVisualizationTabControl.SelectedIndex = 0;
            this.clusteringVisualizationTabControl.Size = new System.Drawing.Size(594, 438);
            this.clusteringVisualizationTabControl.TabIndex = 1;
            // 
            // scatterPlotTabPage
            // 
            this.scatterPlotTabPage.Controls.Add(this.outputZedGraphControl);
            this.scatterPlotTabPage.Location = new System.Drawing.Point(4, 29);
            this.scatterPlotTabPage.Name = "scatterPlotTabPage";
            this.scatterPlotTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scatterPlotTabPage.Size = new System.Drawing.Size(586, 405);
            this.scatterPlotTabPage.TabIndex = 0;
            this.scatterPlotTabPage.Text = "Scatter Plot";
            this.scatterPlotTabPage.UseVisualStyleBackColor = true;
            // 
            // outputZedGraphControl
            // 
            this.outputZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputZedGraphControl.Location = new System.Drawing.Point(3, 3);
            this.outputZedGraphControl.Margin = new System.Windows.Forms.Padding(12);
            this.outputZedGraphControl.Name = "outputZedGraphControl";
            this.outputZedGraphControl.ScrollGrace = 0D;
            this.outputZedGraphControl.ScrollMaxX = 0D;
            this.outputZedGraphControl.ScrollMaxY = 0D;
            this.outputZedGraphControl.ScrollMaxY2 = 0D;
            this.outputZedGraphControl.ScrollMinX = 0D;
            this.outputZedGraphControl.ScrollMinY = 0D;
            this.outputZedGraphControl.ScrollMinY2 = 0D;
            this.outputZedGraphControl.Size = new System.Drawing.Size(580, 399);
            this.outputZedGraphControl.TabIndex = 0;
            this.outputZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // clustersTabPage
            // 
            this.clustersTabPage.Controls.Add(this.clustersScatterplotView);
            this.clustersTabPage.Location = new System.Drawing.Point(4, 29);
            this.clustersTabPage.Name = "clustersTabPage";
            this.clustersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clustersTabPage.Size = new System.Drawing.Size(586, 411);
            this.clustersTabPage.TabIndex = 1;
            this.clustersTabPage.Text = "Clusters";
            this.clustersTabPage.UseVisualStyleBackColor = true;
            // 
            // clustersScatterplotView
            // 
            this.clustersScatterplotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clustersScatterplotView.LinesVisible = false;
            this.clustersScatterplotView.Location = new System.Drawing.Point(3, 3);
            this.clustersScatterplotView.Name = "clustersScatterplotView";
            this.clustersScatterplotView.ScaleTight = false;
            this.clustersScatterplotView.Size = new System.Drawing.Size(580, 405);
            this.clustersScatterplotView.SymbolSize = 7F;
            this.clustersScatterplotView.TabIndex = 0;
            // 
            // clusteringVisualizationPanel
            // 
            this.clusteringVisualizationPanel.Controls.Add(this.clusteringXComboBox);
            this.clusteringVisualizationPanel.Controls.Add(this.clusteringYComboBox);
            this.clusteringVisualizationPanel.Controls.Add(this.clusteringYLabel);
            this.clusteringVisualizationPanel.Controls.Add(this.clusteringXLabel);
            this.clusteringVisualizationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clusteringVisualizationPanel.Location = new System.Drawing.Point(3, 22);
            this.clusteringVisualizationPanel.Name = "clusteringVisualizationPanel";
            this.clusteringVisualizationPanel.Size = new System.Drawing.Size(594, 55);
            this.clusteringVisualizationPanel.TabIndex = 0;
            // 
            // clusteringXComboBox
            // 
            this.clusteringXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clusteringXComboBox.Enabled = false;
            this.clusteringXComboBox.FormattingEnabled = true;
            this.clusteringXComboBox.Location = new System.Drawing.Point(43, 11);
            this.clusteringXComboBox.Name = "clusteringXComboBox";
            this.clusteringXComboBox.Size = new System.Drawing.Size(200, 28);
            this.clusteringXComboBox.TabIndex = 0;
            this.clusteringXComboBox.SelectedIndexChanged += new System.EventHandler(this.clusteringComboBox_SelectedIndexChanged);
            // 
            // clusteringYComboBox
            // 
            this.clusteringYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clusteringYComboBox.Enabled = false;
            this.clusteringYComboBox.FormattingEnabled = true;
            this.clusteringYComboBox.Location = new System.Drawing.Point(283, 11);
            this.clusteringYComboBox.Name = "clusteringYComboBox";
            this.clusteringYComboBox.Size = new System.Drawing.Size(200, 28);
            this.clusteringYComboBox.TabIndex = 1;
            this.clusteringYComboBox.SelectedIndexChanged += new System.EventHandler(this.clusteringComboBox_SelectedIndexChanged);
            // 
            // clusteringYLabel
            // 
            this.clusteringYLabel.AutoSize = true;
            this.clusteringYLabel.Location = new System.Drawing.Point(257, 14);
            this.clusteringYLabel.Name = "clusteringYLabel";
            this.clusteringYLabel.Size = new System.Drawing.Size(20, 20);
            this.clusteringYLabel.TabIndex = 0;
            this.clusteringYLabel.Text = "y:";
            // 
            // clusteringXLabel
            // 
            this.clusteringXLabel.AutoSize = true;
            this.clusteringXLabel.Location = new System.Drawing.Point(17, 14);
            this.clusteringXLabel.Name = "clusteringXLabel";
            this.clusteringXLabel.Size = new System.Drawing.Size(20, 20);
            this.clusteringXLabel.TabIndex = 0;
            this.clusteringXLabel.Text = "x:";
            // 
            // modelGroupBox
            // 
            this.modelGroupBox.Controls.Add(this.createClustersButton);
            this.modelGroupBox.Controls.Add(this.kMeansBalancedCheckBox);
            this.modelGroupBox.Controls.Add(this.kMedoidsRadioButton);
            this.modelGroupBox.Controls.Add(this.kModesRadioButton);
            this.modelGroupBox.Controls.Add(this.binarySplitRadioButton);
            this.modelGroupBox.Controls.Add(this.kMeansRadioButton);
            this.modelGroupBox.Controls.Add(this.gaussianLabel);
            this.modelGroupBox.Controls.Add(this.kMedoidsKLabel);
            this.modelGroupBox.Controls.Add(this.kModesKLabel);
            this.modelGroupBox.Controls.Add(this.binarySplitKLabel);
            this.modelGroupBox.Controls.Add(this.kMeansKLabel);
            this.modelGroupBox.Controls.Add(this.meanShiftRadiusLabel);
            this.modelGroupBox.Controls.Add(this.meanShiftRadiusNumericUpDown);
            this.modelGroupBox.Controls.Add(this.gaussianMixtureRadioButton);
            this.modelGroupBox.Controls.Add(this.meanShiftRadioButton);
            this.modelGroupBox.Controls.Add(this.kMedoidsKNumericUpDown);
            this.modelGroupBox.Controls.Add(this.gaussianNumericUpDown);
            this.modelGroupBox.Controls.Add(this.kModesKNumericUpDown);
            this.modelGroupBox.Controls.Add(this.binarySplitKNumericUpDown);
            this.modelGroupBox.Controls.Add(this.kMeansKNumericUpDown);
            this.modelGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.modelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.Size = new System.Drawing.Size(370, 518);
            this.modelGroupBox.TabIndex = 0;
            this.modelGroupBox.TabStop = false;
            this.modelGroupBox.Text = "Model";
            // 
            // createClustersButton
            // 
            this.createClustersButton.Location = new System.Drawing.Point(205, 478);
            this.createClustersButton.Name = "createClustersButton";
            this.createClustersButton.Size = new System.Drawing.Size(150, 30);
            this.createClustersButton.TabIndex = 13;
            this.createClustersButton.Text = "Create Clusters";
            this.createClustersButton.UseVisualStyleBackColor = true;
            this.createClustersButton.Click += new System.EventHandler(this.createClustersButton_Click);
            // 
            // kMeansBalancedCheckBox
            // 
            this.kMeansBalancedCheckBox.AutoSize = true;
            this.kMeansBalancedCheckBox.Location = new System.Drawing.Point(260, 67);
            this.kMeansBalancedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.kMeansBalancedCheckBox.Name = "kMeansBalancedCheckBox";
            this.kMeansBalancedCheckBox.Size = new System.Drawing.Size(95, 24);
            this.kMeansBalancedCheckBox.TabIndex = 2;
            this.kMeansBalancedCheckBox.Text = "Balanced";
            this.kMeansBalancedCheckBox.UseVisualStyleBackColor = true;
            // 
            // kMedoidsRadioButton
            // 
            this.kMedoidsRadioButton.AutoSize = true;
            this.kMedoidsRadioButton.Location = new System.Drawing.Point(17, 175);
            this.kMedoidsRadioButton.Name = "kMedoidsRadioButton";
            this.kMedoidsRadioButton.Size = new System.Drawing.Size(100, 24);
            this.kMedoidsRadioButton.TabIndex = 5;
            this.kMedoidsRadioButton.Text = "k-Medoids";
            this.kMedoidsRadioButton.UseVisualStyleBackColor = true;
            this.kMedoidsRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // kModesRadioButton
            // 
            this.kModesRadioButton.AutoSize = true;
            this.kModesRadioButton.Location = new System.Drawing.Point(17, 245);
            this.kModesRadioButton.Name = "kModesRadioButton";
            this.kModesRadioButton.Size = new System.Drawing.Size(88, 24);
            this.kModesRadioButton.TabIndex = 7;
            this.kModesRadioButton.Text = "k-Modes";
            this.kModesRadioButton.UseVisualStyleBackColor = true;
            this.kModesRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // binarySplitRadioButton
            // 
            this.binarySplitRadioButton.AutoSize = true;
            this.binarySplitRadioButton.Location = new System.Drawing.Point(17, 107);
            this.binarySplitRadioButton.Name = "binarySplitRadioButton";
            this.binarySplitRadioButton.Size = new System.Drawing.Size(106, 24);
            this.binarySplitRadioButton.TabIndex = 3;
            this.binarySplitRadioButton.Text = "Binary Split";
            this.binarySplitRadioButton.UseVisualStyleBackColor = true;
            this.binarySplitRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // kMeansRadioButton
            // 
            this.kMeansRadioButton.AutoSize = true;
            this.kMeansRadioButton.Checked = true;
            this.kMeansRadioButton.Location = new System.Drawing.Point(17, 34);
            this.kMeansRadioButton.Name = "kMeansRadioButton";
            this.kMeansRadioButton.Size = new System.Drawing.Size(88, 24);
            this.kMeansRadioButton.TabIndex = 0;
            this.kMeansRadioButton.TabStop = true;
            this.kMeansRadioButton.Text = "k-Means";
            this.kMeansRadioButton.UseVisualStyleBackColor = true;
            this.kMeansRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // gaussianLabel
            // 
            this.gaussianLabel.AutoSize = true;
            this.gaussianLabel.Location = new System.Drawing.Point(25, 425);
            this.gaussianLabel.Name = "gaussianLabel";
            this.gaussianLabel.Size = new System.Drawing.Size(85, 20);
            this.gaussianLabel.TabIndex = 0;
            this.gaussianLabel.Text = "Gaussians";
            // 
            // kMedoidsKLabel
            // 
            this.kMedoidsKLabel.AutoSize = true;
            this.kMedoidsKLabel.Location = new System.Drawing.Point(89, 208);
            this.kMedoidsKLabel.Name = "kMedoidsKLabel";
            this.kMedoidsKLabel.Size = new System.Drawing.Size(21, 20);
            this.kMedoidsKLabel.TabIndex = 0;
            this.kMedoidsKLabel.Text = "k:";
            // 
            // kModesKLabel
            // 
            this.kModesKLabel.AutoSize = true;
            this.kModesKLabel.Location = new System.Drawing.Point(89, 278);
            this.kModesKLabel.Name = "kModesKLabel";
            this.kModesKLabel.Size = new System.Drawing.Size(21, 20);
            this.kModesKLabel.TabIndex = 0;
            this.kModesKLabel.Text = "k:";
            // 
            // binarySplitKLabel
            // 
            this.binarySplitKLabel.AutoSize = true;
            this.binarySplitKLabel.Location = new System.Drawing.Point(89, 139);
            this.binarySplitKLabel.Name = "binarySplitKLabel";
            this.binarySplitKLabel.Size = new System.Drawing.Size(21, 20);
            this.binarySplitKLabel.TabIndex = 0;
            this.binarySplitKLabel.Text = "k:";
            // 
            // kMeansKLabel
            // 
            this.kMeansKLabel.AutoSize = true;
            this.kMeansKLabel.Location = new System.Drawing.Point(89, 67);
            this.kMeansKLabel.Name = "kMeansKLabel";
            this.kMeansKLabel.Size = new System.Drawing.Size(21, 20);
            this.kMeansKLabel.TabIndex = 0;
            this.kMeansKLabel.Text = "k:";
            // 
            // meanShiftRadiusLabel
            // 
            this.meanShiftRadiusLabel.AutoSize = true;
            this.meanShiftRadiusLabel.Location = new System.Drawing.Point(51, 351);
            this.meanShiftRadiusLabel.Name = "meanShiftRadiusLabel";
            this.meanShiftRadiusLabel.Size = new System.Drawing.Size(59, 20);
            this.meanShiftRadiusLabel.TabIndex = 0;
            this.meanShiftRadiusLabel.Text = "Radius";
            // 
            // meanShiftRadiusNumericUpDown
            // 
            this.meanShiftRadiusNumericUpDown.DecimalPlaces = 2;
            this.meanShiftRadiusNumericUpDown.Enabled = false;
            this.meanShiftRadiusNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.meanShiftRadiusNumericUpDown.Location = new System.Drawing.Point(116, 349);
            this.meanShiftRadiusNumericUpDown.Name = "meanShiftRadiusNumericUpDown";
            this.meanShiftRadiusNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.meanShiftRadiusNumericUpDown.TabIndex = 10;
            this.meanShiftRadiusNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.meanShiftRadiusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // gaussianMixtureRadioButton
            // 
            this.gaussianMixtureRadioButton.AutoSize = true;
            this.gaussianMixtureRadioButton.Location = new System.Drawing.Point(17, 391);
            this.gaussianMixtureRadioButton.Name = "gaussianMixtureRadioButton";
            this.gaussianMixtureRadioButton.Size = new System.Drawing.Size(150, 24);
            this.gaussianMixtureRadioButton.TabIndex = 11;
            this.gaussianMixtureRadioButton.Text = "Gaussian Mixture";
            this.gaussianMixtureRadioButton.UseVisualStyleBackColor = true;
            this.gaussianMixtureRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // meanShiftRadioButton
            // 
            this.meanShiftRadioButton.AutoSize = true;
            this.meanShiftRadioButton.Location = new System.Drawing.Point(17, 317);
            this.meanShiftRadioButton.Name = "meanShiftRadioButton";
            this.meanShiftRadioButton.Size = new System.Drawing.Size(105, 24);
            this.meanShiftRadioButton.TabIndex = 9;
            this.meanShiftRadioButton.Text = "Mean-Shift";
            this.meanShiftRadioButton.UseVisualStyleBackColor = true;
            this.meanShiftRadioButton.CheckedChanged += new System.EventHandler(this.modelRadioButton_CheckedChanged);
            // 
            // kMedoidsKNumericUpDown
            // 
            this.kMedoidsKNumericUpDown.Enabled = false;
            this.kMedoidsKNumericUpDown.Location = new System.Drawing.Point(116, 206);
            this.kMedoidsKNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kMedoidsKNumericUpDown.Name = "kMedoidsKNumericUpDown";
            this.kMedoidsKNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.kMedoidsKNumericUpDown.TabIndex = 6;
            this.kMedoidsKNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kMedoidsKNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // gaussianNumericUpDown
            // 
            this.gaussianNumericUpDown.Enabled = false;
            this.gaussianNumericUpDown.Location = new System.Drawing.Point(116, 423);
            this.gaussianNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaussianNumericUpDown.Name = "gaussianNumericUpDown";
            this.gaussianNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.gaussianNumericUpDown.TabIndex = 12;
            this.gaussianNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gaussianNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kModesKNumericUpDown
            // 
            this.kModesKNumericUpDown.Enabled = false;
            this.kModesKNumericUpDown.Location = new System.Drawing.Point(116, 276);
            this.kModesKNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kModesKNumericUpDown.Name = "kModesKNumericUpDown";
            this.kModesKNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.kModesKNumericUpDown.TabIndex = 8;
            this.kModesKNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kModesKNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // binarySplitKNumericUpDown
            // 
            this.binarySplitKNumericUpDown.Location = new System.Drawing.Point(116, 137);
            this.binarySplitKNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.binarySplitKNumericUpDown.Name = "binarySplitKNumericUpDown";
            this.binarySplitKNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.binarySplitKNumericUpDown.TabIndex = 4;
            this.binarySplitKNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.binarySplitKNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kMeansKNumericUpDown
            // 
            this.kMeansKNumericUpDown.Location = new System.Drawing.Point(116, 65);
            this.kMeansKNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kMeansKNumericUpDown.Name = "kMeansKNumericUpDown";
            this.kMeansKNumericUpDown.Size = new System.Drawing.Size(122, 26);
            this.kMeansKNumericUpDown.TabIndex = 1;
            this.kMeansKNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kMeansKNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            // ClusteringForm
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
            this.Name = "ClusteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clustering";
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataVisualizationGroupBox.ResumeLayout(false);
            this.inputDataVisualizationPanel.ResumeLayout(false);
            this.inputDataVisualizationPanel.PerformLayout();
            this.clusteringTabPage.ResumeLayout(false);
            this.clusteringVisualizationGroupBox.ResumeLayout(false);
            this.clusteringVisualizationTabControl.ResumeLayout(false);
            this.scatterPlotTabPage.ResumeLayout(false);
            this.clustersTabPage.ResumeLayout(false);
            this.clusteringVisualizationPanel.ResumeLayout(false);
            this.clusteringVisualizationPanel.PerformLayout();
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meanShiftRadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMedoidsKNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kModesKNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarySplitKNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMeansKNumericUpDown)).EndInit();
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
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.GroupBox inputDataVisualizationGroupBox;
        private System.Windows.Forms.Label inputDataYLabel;
        private System.Windows.Forms.Label inputDataXLabel;
        private System.Windows.Forms.ComboBox inputDataYComboBox;
        private System.Windows.Forms.ComboBox inputDataXComboBox;
        private ZedGraph.ZedGraphControl inputDataZedGraphControl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel inputDataVisualizationPanel;
        private System.Windows.Forms.TabPage clusteringTabPage;
        private System.Windows.Forms.GroupBox clusteringVisualizationGroupBox;
        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.TabControl clusteringVisualizationTabControl;
        private System.Windows.Forms.TabPage scatterPlotTabPage;
        private System.Windows.Forms.TabPage clustersTabPage;
        private System.Windows.Forms.Button createClustersButton;
        private System.Windows.Forms.CheckBox kMeansBalancedCheckBox;
        private System.Windows.Forms.RadioButton kMeansRadioButton;
        private System.Windows.Forms.Label gaussianLabel;
        private System.Windows.Forms.Label kMeansKLabel;
        private System.Windows.Forms.Label meanShiftRadiusLabel;
        private System.Windows.Forms.NumericUpDown meanShiftRadiusNumericUpDown;
        private System.Windows.Forms.RadioButton gaussianMixtureRadioButton;
        private System.Windows.Forms.RadioButton meanShiftRadioButton;
        private System.Windows.Forms.NumericUpDown gaussianNumericUpDown;
        private System.Windows.Forms.NumericUpDown kMeansKNumericUpDown;
        private Accord.Controls.ScatterplotView clustersScatterplotView;
        private System.Windows.Forms.Panel clusteringVisualizationPanel;
        private System.Windows.Forms.ComboBox clusteringXComboBox;
        private System.Windows.Forms.ComboBox clusteringYComboBox;
        private System.Windows.Forms.Label clusteringYLabel;
        private System.Windows.Forms.Label clusteringXLabel;
        private ZedGraph.ZedGraphControl outputZedGraphControl;
        private System.Windows.Forms.RadioButton kModesRadioButton;
        private System.Windows.Forms.Label kModesKLabel;
        private System.Windows.Forms.NumericUpDown kModesKNumericUpDown;
        private System.Windows.Forms.RadioButton kMedoidsRadioButton;
        private System.Windows.Forms.NumericUpDown kMedoidsKNumericUpDown;
        private System.Windows.Forms.Label kMedoidsKLabel;
        private System.Windows.Forms.RadioButton binarySplitRadioButton;
        private System.Windows.Forms.Label binarySplitKLabel;
        private System.Windows.Forms.NumericUpDown binarySplitKNumericUpDown;
    }
}