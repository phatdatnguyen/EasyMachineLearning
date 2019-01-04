namespace MachineLearning
{
    partial class KPCAModelForm
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
            this.centerComboBox = new System.Windows.Forms.CheckBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfComponentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.methodLabel = new System.Windows.Forms.Label();
            this.numberOfComponentsLabel = new System.Windows.Forms.Label();
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
            this.principleComponentsTabPage = new System.Windows.Forms.TabPage();
            this.visualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.cumulativeProportionComponentView = new Accord.Controls.ComponentView();
            this.proportionComponentView = new Accord.Controls.ComponentView();
            this.principleComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.eigenvectorDataGridView = new System.Windows.Forms.DataGridView();
            this.projectionTabPage = new System.Windows.Forms.TabPage();
            this.featureSpaceGroupBox = new System.Windows.Forms.GroupBox();
            this.featureSpaceZedGraphControl = new ZedGraph.ZedGraphControl();
            this.featureSpacePanel = new System.Windows.Forms.Panel();
            this.featureSpaceNavigateCheckBox = new System.Windows.Forms.CheckBox();
            this.featureSpaceXComboBox = new System.Windows.Forms.ComboBox();
            this.featureSpaceYComboBox = new System.Windows.Forms.ComboBox();
            this.featureSpaceYLabel = new System.Windows.Forms.Label();
            this.featureSpaceXLabel = new System.Windows.Forms.Label();
            this.inputSpaceGroupBox = new System.Windows.Forms.GroupBox();
            this.inputSpaceZedGraphControl = new ZedGraph.ZedGraphControl();
            this.inputSpacePanel = new System.Windows.Forms.Panel();
            this.inputSpaceNavigateCheckBox = new System.Windows.Forms.CheckBox();
            this.inputSpaceXComboBox = new System.Windows.Forms.ComboBox();
            this.inputSpaceYComboBox = new System.Windows.Forms.ComboBox();
            this.inputSpaceYLabel = new System.Windows.Forms.Label();
            this.inputSpaceXLabel = new System.Windows.Forms.Label();
            this.projectionGroupBox = new System.Windows.Forms.GroupBox();
            this.revertButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.projectionResultDataGridView = new System.Windows.Forms.DataGridView();
            this.projectionDataGridView = new System.Windows.Forms.DataGridView();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cumulativeProportionTextBox = new System.Windows.Forms.TextBox();
            this.cumulativeProportionLabel = new System.Windows.Forms.Label();
            this.proportionTextBox = new System.Windows.Forms.TextBox();
            this.proportionLabel = new System.Windows.Forms.Label();
            this.eigenvalueTextBox = new System.Windows.Forms.TextBox();
            this.principleComponentLabel = new System.Windows.Forms.Label();
            this.eigenvalueLabel = new System.Windows.Forms.Label();
            this.principleComponentComboBox = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numberOfComponentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningFromNumericUpDown)).BeginInit();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.principleComponentsTabPage.SuspendLayout();
            this.visualizationGroupBox.SuspendLayout();
            this.principleComponentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).BeginInit();
            this.projectionTabPage.SuspendLayout();
            this.featureSpaceGroupBox.SuspendLayout();
            this.featureSpacePanel.SuspendLayout();
            this.inputSpaceGroupBox.SuspendLayout();
            this.inputSpacePanel.SuspendLayout();
            this.projectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectionResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionDataGridView)).BeginInit();
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
            this.mainTabControl.Controls.Add(this.principleComponentsTabPage);
            this.mainTabControl.Controls.Add(this.projectionTabPage);
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
            this.projectedDataGroupBox.Location = new System.Drawing.Point(403, 138);
            this.projectedDataGroupBox.Name = "projectedDataGroupBox";
            this.projectedDataGroupBox.Size = new System.Drawing.Size(570, 383);
            this.projectedDataGroupBox.TabIndex = 2;
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
            this.projectedDataDataGridView.Size = new System.Drawing.Size(564, 358);
            this.projectedDataDataGridView.TabIndex = 0;
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.centerComboBox);
            this.learningGroupBox.Controls.Add(this.methodComboBox);
            this.learningGroupBox.Controls.Add(this.numberOfComponentsNumericUpDown);
            this.learningGroupBox.Controls.Add(this.methodLabel);
            this.learningGroupBox.Controls.Add(this.numberOfComponentsLabel);
            this.learningGroupBox.Controls.Add(this.learnButton);
            this.learningGroupBox.Controls.Add(this.learningToNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningToLabel);
            this.learningGroupBox.Controls.Add(this.learningFromNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningFromLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.learningGroupBox.Location = new System.Drawing.Point(403, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(570, 135);
            this.learningGroupBox.TabIndex = 1;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // centerComboBox
            // 
            this.centerComboBox.AutoSize = true;
            this.centerComboBox.Checked = true;
            this.centerComboBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.centerComboBox.Location = new System.Drawing.Point(104, 100);
            this.centerComboBox.Name = "centerComboBox";
            this.centerComboBox.Size = new System.Drawing.Size(202, 24);
            this.centerComboBox.TabIndex = 4;
            this.centerComboBox.Text = "Center in Feature Space";
            this.centerComboBox.UseVisualStyleBackColor = true;
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Center",
            "Standardize"});
            this.methodComboBox.Location = new System.Drawing.Point(401, 29);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(150, 28);
            this.methodComboBox.TabIndex = 2;
            // 
            // numberOfComponentsNumericUpDown
            // 
            this.numberOfComponentsNumericUpDown.Location = new System.Drawing.Point(206, 64);
            this.numberOfComponentsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfComponentsNumericUpDown.Name = "numberOfComponentsNumericUpDown";
            this.numberOfComponentsNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.numberOfComponentsNumericUpDown.TabIndex = 3;
            this.numberOfComponentsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(332, 33);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(63, 20);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Method";
            // 
            // numberOfComponentsLabel
            // 
            this.numberOfComponentsLabel.AutoSize = true;
            this.numberOfComponentsLabel.Location = new System.Drawing.Point(22, 66);
            this.numberOfComponentsLabel.Name = "numberOfComponentsLabel";
            this.numberOfComponentsLabel.Size = new System.Drawing.Size(178, 20);
            this.numberOfComponentsLabel.TabIndex = 0;
            this.numberOfComponentsLabel.Text = "Number of Components";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(451, 96);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(100, 30);
            this.learnButton.TabIndex = 5;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // learningToNumericUpDown
            // 
            this.learningToNumericUpDown.Location = new System.Drawing.Point(206, 29);
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
            this.learningToLabel.Location = new System.Drawing.Point(173, 31);
            this.learningToLabel.Name = "learningToLabel";
            this.learningToLabel.Size = new System.Drawing.Size(27, 20);
            this.learningToLabel.TabIndex = 0;
            this.learningToLabel.Text = "To";
            // 
            // learningFromNumericUpDown
            // 
            this.learningFromNumericUpDown.Location = new System.Drawing.Point(67, 29);
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
            this.learningFromLabel.Location = new System.Drawing.Point(15, 31);
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
            this.kernelGroupBox.TabIndex = 0;
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
            // principleComponentsTabPage
            // 
            this.principleComponentsTabPage.Controls.Add(this.visualizationGroupBox);
            this.principleComponentsTabPage.Controls.Add(this.principleComponentsGroupBox);
            this.principleComponentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.principleComponentsTabPage.Name = "principleComponentsTabPage";
            this.principleComponentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.principleComponentsTabPage.Size = new System.Drawing.Size(976, 524);
            this.principleComponentsTabPage.TabIndex = 6;
            this.principleComponentsTabPage.Text = "Priciple Components";
            this.principleComponentsTabPage.UseVisualStyleBackColor = true;
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
            this.cumulativeProportionComponentView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.proportionComponentView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proportionComponentView.Name = "proportionComponentView";
            this.proportionComponentView.Size = new System.Drawing.Size(424, 210);
            this.proportionComponentView.TabIndex = 0;
            // 
            // principleComponentsGroupBox
            // 
            this.principleComponentsGroupBox.Controls.Add(this.cumulativeProportionTextBox);
            this.principleComponentsGroupBox.Controls.Add(this.cumulativeProportionLabel);
            this.principleComponentsGroupBox.Controls.Add(this.proportionTextBox);
            this.principleComponentsGroupBox.Controls.Add(this.proportionLabel);
            this.principleComponentsGroupBox.Controls.Add(this.eigenvalueTextBox);
            this.principleComponentsGroupBox.Controls.Add(this.principleComponentLabel);
            this.principleComponentsGroupBox.Controls.Add(this.eigenvalueLabel);
            this.principleComponentsGroupBox.Controls.Add(this.principleComponentComboBox);
            this.principleComponentsGroupBox.Controls.Add(this.eigenvectorDataGridView);
            this.principleComponentsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.principleComponentsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.principleComponentsGroupBox.Name = "principleComponentsGroupBox";
            this.principleComponentsGroupBox.Size = new System.Drawing.Size(540, 518);
            this.principleComponentsGroupBox.TabIndex = 0;
            this.principleComponentsGroupBox.TabStop = false;
            this.principleComponentsGroupBox.Text = "Principle Components";
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
            this.featureSpaceZedGraphControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.featureSpaceZedGraphControl_MouseMove);
            // 
            // featureSpacePanel
            // 
            this.featureSpacePanel.Controls.Add(this.featureSpaceNavigateCheckBox);
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
            // featureSpaceNavigateCheckBox
            // 
            this.featureSpaceNavigateCheckBox.AutoSize = true;
            this.featureSpaceNavigateCheckBox.Location = new System.Drawing.Point(335, 16);
            this.featureSpaceNavigateCheckBox.Name = "featureSpaceNavigateCheckBox";
            this.featureSpaceNavigateCheckBox.Size = new System.Drawing.Size(90, 24);
            this.featureSpaceNavigateCheckBox.TabIndex = 2;
            this.featureSpaceNavigateCheckBox.Text = "Navigate";
            this.featureSpaceNavigateCheckBox.UseVisualStyleBackColor = true;
            this.featureSpaceNavigateCheckBox.CheckedChanged += new System.EventHandler(this.featureSpaceNavigateCheckBox_CheckedChanged);
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
            this.inputSpacePanel.Controls.Add(this.inputSpaceNavigateCheckBox);
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
            // inputSpaceNavigateCheckBox
            // 
            this.inputSpaceNavigateCheckBox.AutoSize = true;
            this.inputSpaceNavigateCheckBox.Location = new System.Drawing.Point(395, 16);
            this.inputSpaceNavigateCheckBox.Name = "inputSpaceNavigateCheckBox";
            this.inputSpaceNavigateCheckBox.Size = new System.Drawing.Size(90, 24);
            this.inputSpaceNavigateCheckBox.TabIndex = 2;
            this.inputSpaceNavigateCheckBox.Text = "Navigate";
            this.inputSpaceNavigateCheckBox.UseVisualStyleBackColor = true;
            this.inputSpaceNavigateCheckBox.CheckedChanged += new System.EventHandler(this.inputSpaceNavigateCheckBox_CheckedChanged);
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
            this.projectionGroupBox.Controls.Add(this.revertButton);
            this.projectionGroupBox.Controls.Add(this.projectButton);
            this.projectionGroupBox.Controls.Add(this.projectionResultDataGridView);
            this.projectionGroupBox.Controls.Add(this.projectionDataGridView);
            this.projectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.projectionGroupBox.Name = "projectionGroupBox";
            this.projectionGroupBox.Size = new System.Drawing.Size(970, 150);
            this.projectionGroupBox.TabIndex = 0;
            this.projectionGroupBox.TabStop = false;
            this.projectionGroupBox.Text = "Projection";
            // 
            // revertButton
            // 
            this.revertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revertButton.Enabled = false;
            this.revertButton.Location = new System.Drawing.Point(461, 84);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(80, 63);
            this.revertButton.TabIndex = 2;
            this.revertButton.Text = "Revert";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // projectButton
            // 
            this.projectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectButton.Enabled = false;
            this.projectButton.Location = new System.Drawing.Point(461, 22);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(80, 62);
            this.projectButton.TabIndex = 1;
            this.projectButton.Text = "Project";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // projectionResultDataGridView
            // 
            this.projectionResultDataGridView.AllowUserToAddRows = false;
            this.projectionResultDataGridView.AllowUserToDeleteRows = false;
            this.projectionResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectionResultDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.projectionResultDataGridView.Location = new System.Drawing.Point(541, 22);
            this.projectionResultDataGridView.Name = "projectionResultDataGridView";
            this.projectionResultDataGridView.RowHeadersVisible = false;
            this.projectionResultDataGridView.RowTemplate.Height = 24;
            this.projectionResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectionResultDataGridView.ShowCellErrors = false;
            this.projectionResultDataGridView.ShowEditingIcon = false;
            this.projectionResultDataGridView.ShowRowErrors = false;
            this.projectionResultDataGridView.Size = new System.Drawing.Size(426, 125);
            this.projectionResultDataGridView.TabIndex = 3;
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
            this.cumulativeProportionTextBox.TabIndex = 19;
            // 
            // cumulativeProportionLabel
            // 
            this.cumulativeProportionLabel.AutoSize = true;
            this.cumulativeProportionLabel.Location = new System.Drawing.Point(21, 126);
            this.cumulativeProportionLabel.Name = "cumulativeProportionLabel";
            this.cumulativeProportionLabel.Size = new System.Drawing.Size(164, 20);
            this.cumulativeProportionLabel.TabIndex = 12;
            this.cumulativeProportionLabel.Text = "Cumulative Proportion";
            // 
            // proportionTextBox
            // 
            this.proportionTextBox.Location = new System.Drawing.Point(191, 91);
            this.proportionTextBox.Name = "proportionTextBox";
            this.proportionTextBox.Size = new System.Drawing.Size(100, 26);
            this.proportionTextBox.TabIndex = 18;
            // 
            // proportionLabel
            // 
            this.proportionLabel.AutoSize = true;
            this.proportionLabel.Location = new System.Drawing.Point(103, 94);
            this.proportionLabel.Name = "proportionLabel";
            this.proportionLabel.Size = new System.Drawing.Size(82, 20);
            this.proportionLabel.TabIndex = 13;
            this.proportionLabel.Text = "Proportion";
            // 
            // eigenvalueTextBox
            // 
            this.eigenvalueTextBox.Location = new System.Drawing.Point(191, 59);
            this.eigenvalueTextBox.Name = "eigenvalueTextBox";
            this.eigenvalueTextBox.Size = new System.Drawing.Size(100, 26);
            this.eigenvalueTextBox.TabIndex = 17;
            // 
            // principleComponentLabel
            // 
            this.principleComponentLabel.AutoSize = true;
            this.principleComponentLabel.Location = new System.Drawing.Point(30, 28);
            this.principleComponentLabel.Name = "principleComponentLabel";
            this.principleComponentLabel.Size = new System.Drawing.Size(155, 20);
            this.principleComponentLabel.TabIndex = 14;
            this.principleComponentLabel.Text = "Principle Component";
            // 
            // eigenvalueLabel
            // 
            this.eigenvalueLabel.AutoSize = true;
            this.eigenvalueLabel.Location = new System.Drawing.Point(98, 62);
            this.eigenvalueLabel.Name = "eigenvalueLabel";
            this.eigenvalueLabel.Size = new System.Drawing.Size(87, 20);
            this.eigenvalueLabel.TabIndex = 15;
            this.eigenvalueLabel.Text = "Eigenvalue";
            // 
            // principleComponentComboBox
            // 
            this.principleComponentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.principleComponentComboBox.FormattingEnabled = true;
            this.principleComponentComboBox.Location = new System.Drawing.Point(191, 25);
            this.principleComponentComboBox.Name = "principleComponentComboBox";
            this.principleComponentComboBox.Size = new System.Drawing.Size(100, 28);
            this.principleComponentComboBox.TabIndex = 16;
            this.principleComponentComboBox.SelectedIndexChanged += new System.EventHandler(this.principleComponentComboBox_SelectedIndexChanged);
            // 
            // KPCAModelForm
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
            this.Name = "KPCAModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kernel Principle Component Analysis (KPCA)";
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
            ((System.ComponentModel.ISupportInitialize)(this.numberOfComponentsNumericUpDown)).EndInit();
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
            this.principleComponentsTabPage.ResumeLayout(false);
            this.visualizationGroupBox.ResumeLayout(false);
            this.principleComponentsGroupBox.ResumeLayout(false);
            this.principleComponentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage learningTabPage;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.NumericUpDown learningToNumericUpDown;
        private System.Windows.Forms.Label learningToLabel;
        private System.Windows.Forms.NumericUpDown learningFromNumericUpDown;
        private System.Windows.Forms.Label learningFromLabel;
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
        private System.Windows.Forms.CheckBox inputSpaceNavigateCheckBox;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.NumericUpDown numberOfComponentsNumericUpDown;
        private System.Windows.Forms.Label numberOfComponentsLabel;
        private System.Windows.Forms.CheckBox featureSpaceNavigateCheckBox;
        private System.Windows.Forms.TabPage principleComponentsTabPage;
        private System.Windows.Forms.GroupBox visualizationGroupBox;
        private Accord.Controls.ComponentView cumulativeProportionComponentView;
        private Accord.Controls.ComponentView proportionComponentView;
        private System.Windows.Forms.GroupBox principleComponentsGroupBox;
        private System.Windows.Forms.DataGridView eigenvectorDataGridView;
        private System.Windows.Forms.GroupBox projectedDataGroupBox;
        private System.Windows.Forms.DataGridView projectedDataDataGridView;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.CheckBox centerComboBox;
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
        private System.Windows.Forms.Label principleComponentLabel;
        private System.Windows.Forms.Label eigenvalueLabel;
        private System.Windows.Forms.ComboBox principleComponentComboBox;
    }
}