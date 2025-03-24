namespace Turandot_Editor.Controls
{
    partial class ScheduleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneEach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TrialType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numBlocksNumeric = new KLib.Controls.KNumericBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trainingCheckBox = new KLib.Controls.KCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.targetpcNumeric = new KLib.Controls.KNumericBox();
            this.trainingPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.perfPromptTextBox = new System.Windows.Forms.TextBox();
            this.maxPracticeNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupOrderEnum = new KLib.Controls.EnumDropDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.saveasTextBox = new KLib.Controls.KTextBox();
            this.resultExprBox = new KLib.Controls.KTextBox();
            this.propGridView = new Turandot_Editor.NestedPropertyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            this.trainingPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupGridView
            // 
            this.groupGridView.AllowUserToResizeColumns = false;
            this.groupGridView.AllowUserToResizeRows = false;
            this.groupGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groupGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.groupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Number,
            this.OneEach,
            this.Order,
            this.TrialType});
            this.groupGridView.EnableHeadersVisualStyles = false;
            this.groupGridView.Location = new System.Drawing.Point(3, 3);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.groupGridView.RowHeadersVisible = false;
            this.groupGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.groupGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupGridView.Size = new System.Drawing.Size(384, 124);
            this.groupGridView.TabIndex = 1;
            this.groupGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupGridView_CellValueChanged);
            this.groupGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.groupGridView_CurrentCellDirtyStateChanged);
            this.groupGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.groupGridView_EditingControlShowing);
            this.groupGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.groupGridView_RowStateChanged);
            this.groupGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.groupGridView_UserDeletingRow);
            this.groupGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User-defined name";
            this.UserName.Name = "UserName";
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserName.Width = 110;
            // 
            // Number
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 50;
            // 
            // OneEach
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OneEach.DefaultCellStyle = dataGridViewCellStyle3;
            this.OneEach.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.OneEach.HeaderText = "One each";
            this.OneEach.Items.AddRange(new object[] {
            "",
            "true"});
            this.OneEach.Name = "OneEach";
            this.OneEach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OneEach.Width = 60;
            // 
            // Order
            // 
            this.Order.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Order.HeaderText = "Order";
            this.Order.Items.AddRange(new object[] {
            "Random",
            "X seq, Y seq",
            "X seq, Y rand",
            "X rand, Y seq",
            "X rand, Y rand"});
            this.Order.Name = "Order";
            this.Order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TrialType
            // 
            this.TrialType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TrialType.HeaderText = "Type";
            this.TrialType.Items.AddRange(new object[] {
            "CS+",
            "CS-"});
            this.TrialType.Name = "TrialType";
            this.TrialType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrialType.Width = 60;
            // 
            // numBlocksNumeric
            // 
            this.numBlocksNumeric.AllowInf = false;
            this.numBlocksNumeric.AutoSize = true;
            this.numBlocksNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.numBlocksNumeric.ClearOnDisable = false;
            this.numBlocksNumeric.FloatValue = 1F;
            this.numBlocksNumeric.IntValue = 1;
            this.numBlocksNumeric.IsInteger = false;
            this.numBlocksNumeric.Location = new System.Drawing.Point(511, 3);
            this.numBlocksNumeric.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numBlocksNumeric.MaxCoerce = false;
            this.numBlocksNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.numBlocksNumeric.MaxValue = double.PositiveInfinity;
            this.numBlocksNumeric.MinCoerce = false;
            this.numBlocksNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.numBlocksNumeric.MinValue = 1D;
            this.numBlocksNumeric.Name = "numBlocksNumeric";
            this.numBlocksNumeric.Size = new System.Drawing.Size(75, 20);
            this.numBlocksNumeric.TabIndex = 4;
            this.numBlocksNumeric.TextFormat = "K4";
            this.numBlocksNumeric.ToolTip = "";
            this.numBlocksNumeric.Units = "";
            this.numBlocksNumeric.Value = 1D;
            this.numBlocksNumeric.ValueChanged += new System.EventHandler(this.numBlocksNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Do this many blocks";
            // 
            // trainingCheckBox
            // 
            this.trainingCheckBox.AutoSize = true;
            this.trainingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trainingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingCheckBox.Location = new System.Drawing.Point(504, 47);
            this.trainingCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 10, 5);
            this.trainingCheckBox.Name = "trainingCheckBox";
            this.trainingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainingCheckBox.Size = new System.Drawing.Size(235, 29);
            this.trainingCheckBox.TabIndex = 34;
            this.trainingCheckBox.Text = "                                              ";
            this.trainingCheckBox.UseVisualStyleBackColor = true;
            this.trainingCheckBox.CheckedChanged += new System.EventHandler(this.trainingCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Training";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Target Pc";
            // 
            // targetpcNumeric
            // 
            this.targetpcNumeric.AllowInf = false;
            this.targetpcNumeric.AutoSize = true;
            this.targetpcNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetpcNumeric.ClearOnDisable = false;
            this.targetpcNumeric.FloatValue = 1F;
            this.targetpcNumeric.IntValue = 1;
            this.targetpcNumeric.IsInteger = false;
            this.targetpcNumeric.Location = new System.Drawing.Point(117, 3);
            this.targetpcNumeric.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.targetpcNumeric.MaxCoerce = false;
            this.targetpcNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.targetpcNumeric.MaxValue = 100D;
            this.targetpcNumeric.MinCoerce = false;
            this.targetpcNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.targetpcNumeric.MinValue = 0D;
            this.targetpcNumeric.Name = "targetpcNumeric";
            this.targetpcNumeric.Size = new System.Drawing.Size(75, 20);
            this.targetpcNumeric.TabIndex = 36;
            this.targetpcNumeric.TextFormat = "K4";
            this.targetpcNumeric.ToolTip = "";
            this.targetpcNumeric.Units = "";
            this.targetpcNumeric.Value = 1D;
            this.targetpcNumeric.ValueChanged += new System.EventHandler(this.targetpcNumeric_ValueChanged);
            // 
            // trainingPanel
            // 
            this.trainingPanel.AutoSize = true;
            this.trainingPanel.Controls.Add(this.label6);
            this.trainingPanel.Controls.Add(this.perfPromptTextBox);
            this.trainingPanel.Controls.Add(this.maxPracticeNumeric);
            this.trainingPanel.Controls.Add(this.label5);
            this.trainingPanel.Controls.Add(this.targetpcNumeric);
            this.trainingPanel.Controls.Add(this.label3);
            this.trainingPanel.Location = new System.Drawing.Point(393, 73);
            this.trainingPanel.Name = "trainingPanel";
            this.trainingPanel.Size = new System.Drawing.Size(196, 73);
            this.trainingPanel.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Max training blocks";
            // 
            // perfPromptTextBox
            // 
            this.perfPromptTextBox.Location = new System.Drawing.Point(117, 25);
            this.perfPromptTextBox.Multiline = true;
            this.perfPromptTextBox.Name = "perfPromptTextBox";
            this.perfPromptTextBox.Size = new System.Drawing.Size(75, 20);
            this.perfPromptTextBox.TabIndex = 58;
            this.perfPromptTextBox.Enter += new System.EventHandler(this.perfPromptTextBox_Enter);
            this.perfPromptTextBox.Leave += new System.EventHandler(this.perfPromptTextBox_Leave);
            // 
            // maxPracticeNumeric
            // 
            this.maxPracticeNumeric.AllowInf = false;
            this.maxPracticeNumeric.AutoSize = true;
            this.maxPracticeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxPracticeNumeric.ClearOnDisable = false;
            this.maxPracticeNumeric.FloatValue = 1F;
            this.maxPracticeNumeric.IntValue = 1;
            this.maxPracticeNumeric.IsInteger = true;
            this.maxPracticeNumeric.Location = new System.Drawing.Point(117, 48);
            this.maxPracticeNumeric.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.maxPracticeNumeric.MaxCoerce = false;
            this.maxPracticeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxPracticeNumeric.MaxValue = double.PositiveInfinity;
            this.maxPracticeNumeric.MinCoerce = false;
            this.maxPracticeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxPracticeNumeric.MinValue = -1D;
            this.maxPracticeNumeric.Name = "maxPracticeNumeric";
            this.maxPracticeNumeric.Size = new System.Drawing.Size(75, 20);
            this.maxPracticeNumeric.TabIndex = 58;
            this.maxPracticeNumeric.TextFormat = "";
            this.maxPracticeNumeric.ToolTip = "";
            this.maxPracticeNumeric.Units = "";
            this.maxPracticeNumeric.Value = 1D;
            this.maxPracticeNumeric.ValueChanged += new System.EventHandler(this.maxPracticeNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Prompt";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(511, 152);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 39;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupOrderEnum
            // 
            this.groupOrderEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupOrderEnum.FormattingEnabled = true;
            this.groupOrderEnum.Location = new System.Drawing.Point(511, 29);
            this.groupOrderEnum.Name = "groupOrderEnum";
            this.groupOrderEnum.Size = new System.Drawing.Size(75, 21);
            this.groupOrderEnum.Sort = false;
            this.groupOrderEnum.TabIndex = 40;
            this.groupOrderEnum.ValueChanged += new System.EventHandler(this.groupOrderEnum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Group order";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 56;
            this.label26.Text = "Final result =";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(323, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Save as";
            // 
            // resultPanel
            // 
            this.resultPanel.AutoSize = true;
            this.resultPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultPanel.Controls.Add(this.saveasTextBox);
            this.resultPanel.Controls.Add(this.resultExprBox);
            this.resultPanel.Controls.Add(this.label26);
            this.resultPanel.Controls.Add(this.label21);
            this.resultPanel.Location = new System.Drawing.Point(3, 470);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(464, 26);
            this.resultPanel.TabIndex = 57;
            // 
            // saveasTextBox
            // 
            this.saveasTextBox.AutoSize = true;
            this.saveasTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveasTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveasTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.saveasTextBox.IsIPAddress = false;
            this.saveasTextBox.Location = new System.Drawing.Point(372, 3);
            this.saveasTextBox.Name = "saveasTextBox";
            this.saveasTextBox.Size = new System.Drawing.Size(89, 20);
            this.saveasTextBox.TabIndex = 58;
            this.saveasTextBox.ValueChanged += new System.EventHandler(this.saveasTextBox_ValueChanged);
            // 
            // resultExprBox
            // 
            this.resultExprBox.AutoSize = true;
            this.resultExprBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultExprBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.resultExprBox.IsIPAddress = false;
            this.resultExprBox.Location = new System.Drawing.Point(77, 3);
            this.resultExprBox.Name = "resultExprBox";
            this.resultExprBox.Size = new System.Drawing.Size(240, 20);
            this.resultExprBox.TabIndex = 59;
            this.resultExprBox.ValueChanged += new System.EventHandler(this.resultExprBox_ValueChanged);
            // 
            // propGridView
            // 
            this.propGridView.AllowUserToDeleteRows = true;
            this.propGridView.Location = new System.Drawing.Point(3, 181);
            this.propGridView.MaxNumberRows = 0;
            this.propGridView.Name = "propGridView";
            this.propGridView.ShowDim = true;
            this.propGridView.ShowExpr = true;
            this.propGridView.Size = new System.Drawing.Size(592, 274);
            this.propGridView.TabIndex = 6;
            this.propGridView.Value = null;
            this.propGridView.ValueChanged += new System.EventHandler(this.propGridView_ValueChanged);
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainingPanel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupOrderEnum);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trainingCheckBox);
            this.Controls.Add(this.propGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBlocksNumeric);
            this.Controls.Add(this.groupGridView);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(595, 532);
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            this.trainingPanel.ResumeLayout(false);
            this.trainingPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupGridView;
        private KLib.Controls.KNumericBox numBlocksNumeric;
        private System.Windows.Forms.Label label1;
        private NestedPropertyGridView propGridView;
        private KLib.Controls.KCheckBox trainingCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private KLib.Controls.KNumericBox targetpcNumeric;
        private System.Windows.Forms.Panel trainingPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn OneEach;
        private System.Windows.Forms.DataGridViewComboBoxColumn Order;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrialType;
        private KLib.Controls.EnumDropDown groupOrderEnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel resultPanel;
        private KLib.Controls.KTextBox saveasTextBox;
        private KLib.Controls.KTextBox resultExprBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perfPromptTextBox;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox maxPracticeNumeric;
    }
}
