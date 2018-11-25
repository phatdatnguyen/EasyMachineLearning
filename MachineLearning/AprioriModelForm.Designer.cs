namespace MachineLearning
{
    partial class AprioriModelForm
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
            this.inputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDataListBox = new System.Windows.Forms.ListBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.aprioriTabPage = new System.Windows.Forms.TabPage();
            this.rulesGroupBox = new System.Windows.Forms.GroupBox();
            this.rulesDataGridView = new System.Windows.Forms.DataGridView();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.confidenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDataGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.aprioriTabPage.SuspendLayout();
            this.rulesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).BeginInit();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.inputDataListBox);
            this.inputDataGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputDataGroupBox.Location = new System.Drawing.Point(3, 3);
            this.inputDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputDataGroupBox.Size = new System.Drawing.Size(450, 518);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Input Data";
            // 
            // inputDataListBox
            // 
            this.inputDataListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataListBox.FormattingEnabled = true;
            this.inputDataListBox.HorizontalScrollbar = true;
            this.inputDataListBox.ItemHeight = 20;
            this.inputDataListBox.Location = new System.Drawing.Point(4, 24);
            this.inputDataListBox.Name = "inputDataListBox";
            this.inputDataListBox.Size = new System.Drawing.Size(442, 489);
            this.inputDataListBox.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.aprioriTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(984, 557);
            this.mainTabControl.TabIndex = 0;
            // 
            // aprioriTabPage
            // 
            this.aprioriTabPage.Controls.Add(this.rulesGroupBox);
            this.aprioriTabPage.Controls.Add(this.learningGroupBox);
            this.aprioriTabPage.Controls.Add(this.inputDataGroupBox);
            this.aprioriTabPage.Location = new System.Drawing.Point(4, 29);
            this.aprioriTabPage.Name = "aprioriTabPage";
            this.aprioriTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aprioriTabPage.Size = new System.Drawing.Size(976, 524);
            this.aprioriTabPage.TabIndex = 0;
            this.aprioriTabPage.Text = "Apriori Model";
            this.aprioriTabPage.UseVisualStyleBackColor = true;
            // 
            // rulesGroupBox
            // 
            this.rulesGroupBox.Controls.Add(this.rulesDataGridView);
            this.rulesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesGroupBox.Location = new System.Drawing.Point(453, 73);
            this.rulesGroupBox.Name = "rulesGroupBox";
            this.rulesGroupBox.Size = new System.Drawing.Size(520, 448);
            this.rulesGroupBox.TabIndex = 2;
            this.rulesGroupBox.TabStop = false;
            this.rulesGroupBox.Text = "Rules";
            // 
            // rulesDataGridView
            // 
            this.rulesDataGridView.AllowUserToAddRows = false;
            this.rulesDataGridView.AllowUserToDeleteRows = false;
            this.rulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.rulesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rulesDataGridView.Location = new System.Drawing.Point(3, 22);
            this.rulesDataGridView.Name = "rulesDataGridView";
            this.rulesDataGridView.ReadOnly = true;
            this.rulesDataGridView.RowHeadersVisible = false;
            this.rulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesDataGridView.Size = new System.Drawing.Size(514, 423);
            this.rulesDataGridView.TabIndex = 0;
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.learnButton);
            this.learningGroupBox.Controls.Add(this.confidenceNumericUpDown);
            this.learningGroupBox.Controls.Add(this.confidenceLabel);
            this.learningGroupBox.Controls.Add(this.thresholdNumericUpDown);
            this.learningGroupBox.Controls.Add(this.thresholdLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.learningGroupBox.Location = new System.Drawing.Point(453, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(520, 70);
            this.learningGroupBox.TabIndex = 1;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(400, 26);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(100, 30);
            this.learnButton.TabIndex = 2;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // confidenceNumericUpDown
            // 
            this.confidenceNumericUpDown.DecimalPlaces = 2;
            this.confidenceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.confidenceNumericUpDown.Location = new System.Drawing.Point(294, 29);
            this.confidenceNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.confidenceNumericUpDown.Name = "confidenceNumericUpDown";
            this.confidenceNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.confidenceNumericUpDown.TabIndex = 1;
            this.confidenceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Location = new System.Drawing.Point(198, 31);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(90, 20);
            this.confidenceLabel.TabIndex = 0;
            this.confidenceLabel.Text = "Confidence";
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(92, 29);
            this.thresholdNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.thresholdNumericUpDown.TabIndex = 0;
            this.thresholdNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(7, 31);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(79, 20);
            this.thresholdLabel.TabIndex = 0;
            this.thresholdLabel.Text = "Threshold";
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
            // Column1
            // 
            this.Column1.HeaderText = "Rule";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Support";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Confidence";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AprioriModelForm
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
            this.Name = "AprioriModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apriori";
            this.inputDataGroupBox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.aprioriTabPage.ResumeLayout(false);
            this.rulesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).EndInit();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage aprioriTabPage;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.NumericUpDown confidenceNumericUpDown;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.ListBox inputDataListBox;
        private System.Windows.Forms.GroupBox rulesGroupBox;
        private System.Windows.Forms.DataGridView rulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}