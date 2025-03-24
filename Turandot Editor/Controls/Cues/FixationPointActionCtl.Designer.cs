namespace Turandot_Editor.Controls
{
    partial class FixationPointActionCtl
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
            this.label4 = new System.Windows.Forms.Label();
            this.barangleNumeric = new KLib.Controls.KNumericBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.anglePanel = new System.Windows.Forms.Panel();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.anglePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Angle";
            // 
            // barangleNumeric
            // 
            this.barangleNumeric.AutoSize = true;
            this.barangleNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barangleNumeric.FloatValue = 0F;
            this.barangleNumeric.IntValue = 0;
            this.barangleNumeric.IsInteger = false;
            this.barangleNumeric.Location = new System.Drawing.Point(62, 3);
            this.barangleNumeric.MaxCoerce = false;
            this.barangleNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.barangleNumeric.MaxValue = 360D;
            this.barangleNumeric.MinCoerce = false;
            this.barangleNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.barangleNumeric.MinValue = 0D;
            this.barangleNumeric.Name = "barangleNumeric";
            this.barangleNumeric.Size = new System.Drawing.Size(90, 20);
            this.barangleNumeric.TabIndex = 46;
            this.barangleNumeric.TextFormat = "K4";
            this.barangleNumeric.Units = "deg";
            this.barangleNumeric.Value = 0D;
            this.barangleNumeric.ValueChanged += new System.EventHandler(this.barangleNumeric_ValueChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.changeCheckBox);
            this.flowLayoutPanel.Controls.Add(this.anglePanel);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(161, 138);
            this.flowLayoutPanel.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.endComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 54);
            this.panel1.TabIndex = 53;
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.endComboBox.Location = new System.Drawing.Point(62, 30);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(90, 21);
            this.endComboBox.TabIndex = 51;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "End";
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.startComboBox.Location = new System.Drawing.Point(62, 3);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(90, 21);
            this.startComboBox.TabIndex = 49;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Start";
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.Location = new System.Drawing.Point(3, 63);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(123, 17);
            this.changeCheckBox.TabIndex = 49;
            this.changeCheckBox.Text = "Change appearance";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            this.changeCheckBox.CheckedChanged += new System.EventHandler(this.changeCheckBox_CheckedChanged);
            // 
            // anglePanel
            // 
            this.anglePanel.AutoSize = true;
            this.anglePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.anglePanel.Controls.Add(this.labelBox);
            this.anglePanel.Controls.Add(this.label1);
            this.anglePanel.Controls.Add(this.barangleNumeric);
            this.anglePanel.Controls.Add(this.label4);
            this.anglePanel.Location = new System.Drawing.Point(3, 86);
            this.anglePanel.Name = "anglePanel";
            this.anglePanel.Size = new System.Drawing.Size(155, 49);
            this.anglePanel.TabIndex = 48;
            // 
            // labelBox
            // 
            this.labelBox.Location = new System.Drawing.Point(62, 26);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(90, 20);
            this.labelBox.TabIndex = 48;
            this.labelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelBox_KeyPress);
            this.labelBox.Leave += new System.EventHandler(this.labelBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Label";
            // 
            // FixationPointActionCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "FixationPointActionCtl";
            this.Size = new System.Drawing.Size(167, 144);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.anglePanel.ResumeLayout(false);
            this.anglePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox barangleNumeric;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel anglePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private System.Windows.Forms.Panel panel1;
    }
}
