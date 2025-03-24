namespace Turandot_Editor.Controls
{
    partial class ProgressBarActionCtl
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.actionPanel.AutoSize = true;
            this.actionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionPanel.Controls.Add(this.endComboBox);
            this.actionPanel.Controls.Add(this.label1);
            this.actionPanel.Controls.Add(this.startComboBox);
            this.actionPanel.Controls.Add(this.label2);
            this.actionPanel.Location = new System.Drawing.Point(1, 3);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(174, 52);
            this.actionPanel.TabIndex = 31;
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.endComboBox.Location = new System.Drawing.Point(81, 28);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(90, 21);
            this.endComboBox.TabIndex = 24;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "State end";
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.startComboBox.Location = new System.Drawing.Point(81, 3);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(90, 21);
            this.startComboBox.TabIndex = 23;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Action";
            // 
            // ProgressBarActionCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.actionPanel);
            this.Name = "ProgressBarActionCtl";
            this.Size = new System.Drawing.Size(178, 58);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label2;
    }
}
