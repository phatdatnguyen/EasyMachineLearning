namespace MachineLearning
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.importDatabaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.modalGroupBox = new System.Windows.Forms.GroupBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskComboBox = new System.Windows.Forms.ComboBox();
            this.editModelButton = new System.Windows.Forms.Button();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputAndOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.columnsDataGridView = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsInputField = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsOutputField = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.showScatterPlotButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.yComboBox = new System.Windows.Forms.ComboBox();
            this.xComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.modalGroupBox.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.inputAndOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGridView)).BeginInit();
            this.visualizationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.inputDataGridView);
            this.inputDataGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputDataGroupBox.Location = new System.Drawing.Point(0, 24);
            this.inputDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Size = new System.Drawing.Size(689, 656);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Database";
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
            this.inputDataGridView.Size = new System.Drawing.Size(681, 627);
            this.inputDataGridView.TabIndex = 0;
            // 
            // importDatabaseFileDialog
            // 
            this.importDatabaseFileDialog.FileName = "*.xlsx";
            this.importDatabaseFileDialog.Filter = "Excel (*.xls, *.xlsx)|*.xls;*.xlsx|CSV (*.csv)|*.csv";
            this.importDatabaseFileDialog.Title = "Open Database";
            // 
            // modalGroupBox
            // 
            this.modalGroupBox.Controls.Add(this.modelLabel);
            this.modalGroupBox.Controls.Add(this.taskLabel);
            this.modalGroupBox.Controls.Add(this.taskComboBox);
            this.modalGroupBox.Controls.Add(this.editModelButton);
            this.modalGroupBox.Controls.Add(this.modelComboBox);
            this.modalGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modalGroupBox.Location = new System.Drawing.Point(689, 580);
            this.modalGroupBox.Name = "modalGroupBox";
            this.modalGroupBox.Size = new System.Drawing.Size(495, 100);
            this.modalGroupBox.TabIndex = 3;
            this.modalGroupBox.TabStop = false;
            this.modalGroupBox.Text = "Modal";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(39, 62);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Modal";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(48, 28);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(43, 20);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Task";
            // 
            // taskComboBox
            // 
            this.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskComboBox.FormattingEnabled = true;
            this.taskComboBox.Items.AddRange(new object[] {
            "Classification",
            "Regression",
            "Clustering",
            "Ensemble Learning",
            "Rule Learning"});
            this.taskComboBox.Location = new System.Drawing.Point(97, 25);
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(300, 28);
            this.taskComboBox.TabIndex = 0;
            this.taskComboBox.SelectedIndexChanged += new System.EventHandler(this.taskComboBox_SelectedIndexChanged);
            // 
            // editModelButton
            // 
            this.editModelButton.Enabled = false;
            this.editModelButton.Location = new System.Drawing.Point(403, 25);
            this.editModelButton.Name = "editModelButton";
            this.editModelButton.Size = new System.Drawing.Size(80, 62);
            this.editModelButton.TabIndex = 2;
            this.editModelButton.Text = "Edit";
            this.editModelButton.UseVisualStyleBackColor = true;
            this.editModelButton.Click += new System.EventHandler(this.editModelButton_Click);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Items.AddRange(new object[] {
            "Support Vector Machine (SVM)",
            "Naive-Bayes",
            "k-Nearest Neighbors (kNN)",
            "Decision Tree",
            "Logistic Regression",
            "Multinomial Logistic Regression",
            "Artificial Neural Network (ANN)",
            "Deep Neural Network (DNN)"});
            this.modelComboBox.Location = new System.Drawing.Point(97, 59);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(300, 28);
            this.modelComboBox.TabIndex = 1;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 680);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1184, 22);
            this.mainStatusStrip.TabIndex = 3;
            this.mainStatusStrip.Text = "Main Status Strip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1184, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Main Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importDatabaseToolStripMenuItem.Text = "Import &Database...";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDatabaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inputAndOutputGroupBox
            // 
            this.inputAndOutputGroupBox.Controls.Add(this.columnsDataGridView);
            this.inputAndOutputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAndOutputGroupBox.Location = new System.Drawing.Point(689, 124);
            this.inputAndOutputGroupBox.Name = "inputAndOutputGroupBox";
            this.inputAndOutputGroupBox.Size = new System.Drawing.Size(495, 456);
            this.inputAndOutputGroupBox.TabIndex = 2;
            this.inputAndOutputGroupBox.TabStop = false;
            this.inputAndOutputGroupBox.Text = "Input and Output Fields";
            // 
            // columnsDataGridView
            // 
            this.columnsDataGridView.AllowUserToAddRows = false;
            this.columnsDataGridView.AllowUserToDeleteRows = false;
            this.columnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.FieldType,
            this.IsInputField,
            this.IsOutputField});
            this.columnsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsDataGridView.Location = new System.Drawing.Point(3, 22);
            this.columnsDataGridView.MultiSelect = false;
            this.columnsDataGridView.Name = "columnsDataGridView";
            this.columnsDataGridView.RowHeadersVisible = false;
            this.columnsDataGridView.RowTemplate.Height = 24;
            this.columnsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.columnsDataGridView.ShowCellErrors = false;
            this.columnsDataGridView.ShowEditingIcon = false;
            this.columnsDataGridView.ShowRowErrors = false;
            this.columnsDataGridView.Size = new System.Drawing.Size(489, 431);
            this.columnsDataGridView.TabIndex = 0;
            this.columnsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.columnsDataGridView_CellValueChanged);
            this.columnsDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.columnsDataGridView_CurrentCellDirtyStateChanged);
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Field Name";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            this.FieldName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FieldName.Width = 200;
            // 
            // FieldType
            // 
            this.FieldType.HeaderText = "Type";
            this.FieldType.Items.AddRange(new object[] {
            "String",
            "Byte",
            "SByte",
            "UInt16",
            "UInt32",
            "UInt64",
            "Int16",
            "Int32",
            "Int64",
            "Decimal",
            "Double",
            "Single",
            "Boolean"});
            this.FieldType.Name = "FieldType";
            this.FieldType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsInputField
            // 
            this.IsInputField.HeaderText = "Input";
            this.IsInputField.Name = "IsInputField";
            this.IsInputField.Width = 80;
            // 
            // IsOutputField
            // 
            this.IsOutputField.HeaderText = "Output";
            this.IsOutputField.Name = "IsOutputField";
            this.IsOutputField.Width = 80;
            // 
            // visualizationGroupBox
            // 
            this.visualizationGroupBox.Controls.Add(this.showScatterPlotButton);
            this.visualizationGroupBox.Controls.Add(this.groupLabel);
            this.visualizationGroupBox.Controls.Add(this.yLabel);
            this.visualizationGroupBox.Controls.Add(this.xLabel);
            this.visualizationGroupBox.Controls.Add(this.groupComboBox);
            this.visualizationGroupBox.Controls.Add(this.yComboBox);
            this.visualizationGroupBox.Controls.Add(this.xComboBox);
            this.visualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.visualizationGroupBox.Location = new System.Drawing.Point(689, 24);
            this.visualizationGroupBox.Name = "visualizationGroupBox";
            this.visualizationGroupBox.Size = new System.Drawing.Size(495, 100);
            this.visualizationGroupBox.TabIndex = 1;
            this.visualizationGroupBox.TabStop = false;
            this.visualizationGroupBox.Text = "2D Visualization";
            // 
            // showScatterPlotButton
            // 
            this.showScatterPlotButton.Enabled = false;
            this.showScatterPlotButton.Location = new System.Drawing.Point(383, 64);
            this.showScatterPlotButton.Name = "showScatterPlotButton";
            this.showScatterPlotButton.Size = new System.Drawing.Size(100, 30);
            this.showScatterPlotButton.TabIndex = 3;
            this.showScatterPlotButton.Text = "Show";
            this.showScatterPlotButton.UseVisualStyleBackColor = true;
            this.showScatterPlotButton.Click += new System.EventHandler(this.showScatterPlotButton_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(113, 69);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(58, 20);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Group:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(257, 35);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(20, 20);
            this.yLabel.TabIndex = 0;
            this.yLabel.Text = "y:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(17, 35);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 20);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(177, 66);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(200, 28);
            this.groupComboBox.TabIndex = 2;
            // 
            // yComboBox
            // 
            this.yComboBox.FormattingEnabled = true;
            this.yComboBox.Location = new System.Drawing.Point(283, 32);
            this.yComboBox.Name = "yComboBox";
            this.yComboBox.Size = new System.Drawing.Size(200, 28);
            this.yComboBox.TabIndex = 1;
            // 
            // xComboBox
            // 
            this.xComboBox.FormattingEnabled = true;
            this.xComboBox.Location = new System.Drawing.Point(43, 32);
            this.xComboBox.Name = "xComboBox";
            this.xComboBox.Size = new System.Drawing.Size(200, 28);
            this.xComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 702);
            this.Controls.Add(this.inputAndOutputGroupBox);
            this.Controls.Add(this.modalGroupBox);
            this.Controls.Add(this.visualizationGroupBox);
            this.Controls.Add(this.inputDataGroupBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1200, 741);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Learning";
            this.inputDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.modalGroupBox.ResumeLayout(false);
            this.modalGroupBox.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.inputAndOutputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGridView)).EndInit();
            this.visualizationGroupBox.ResumeLayout(false);
            this.visualizationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.OpenFileDialog importDatabaseFileDialog;
        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.GroupBox modalGroupBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button editModelButton;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.ComboBox taskComboBox;
        private System.Windows.Forms.GroupBox inputAndOutputGroupBox;
        private System.Windows.Forms.DataGridView columnsDataGridView;
        private System.Windows.Forms.GroupBox visualizationGroupBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox yComboBox;
        private System.Windows.Forms.ComboBox xComboBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button showScatterPlotButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FieldType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInputField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOutputField;
    }
}

