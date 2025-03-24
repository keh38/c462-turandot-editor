namespace Turandot_Editor.Controls
{
    partial class HelpControl
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
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flashPanel = new System.Windows.Forms.Panel();
            this.flashNumeric = new KLib.Controls.KNumericBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flashCheckBox = new System.Windows.Forms.CheckBox();
            this.delayNumeric = new KLib.Controls.KNumericBox();
            this.flashPropertiesPanel = new System.Windows.Forms.Panel();
            this.periodNumeric = new KLib.Controls.KNumericBox();
            this.label11 = new System.Windows.Forms.Label();
            this.onNumeric = new KLib.Controls.KNumericBox();
            this.label12 = new System.Windows.Forms.Label();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.hNumeric = new KLib.Controls.KNumericBox();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.wNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flashPanel.SuspendLayout();
            this.flashPropertiesPanel.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(0, 247);
            this.msgTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.msgTextBox.Multiline = true;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(217, 114);
            this.msgTextBox.TabIndex = 35;
            this.msgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msgTextBox_KeyPress);
            this.msgTextBox.Leave += new System.EventHandler(this.msgTextBox_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flashPanel);
            this.flowLayoutPanel1.Controls.Add(this.flashPropertiesPanel);
            this.flowLayoutPanel1.Controls.Add(this.changeCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.appearancePanel);
            this.flowLayoutPanel1.Controls.Add(this.msgTextBox);
            this.flowLayoutPanel1.Controls.Add(this.messagePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 361);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.endComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 52);
            this.panel1.TabIndex = 30;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "State end";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Action";
            // 
            // flashPanel
            // 
            this.flashPanel.AutoSize = true;
            this.flashPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashPanel.Controls.Add(this.flashNumeric);
            this.flashPanel.Controls.Add(this.label13);
            this.flashPanel.Controls.Add(this.flashCheckBox);
            this.flashPanel.Controls.Add(this.delayNumeric);
            this.flashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashPanel.Location = new System.Drawing.Point(3, 61);
            this.flashPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flashPanel.Name = "flashPanel";
            this.flashPanel.Size = new System.Drawing.Size(211, 51);
            this.flashPanel.TabIndex = 31;
            // 
            // flashNumeric
            // 
            this.flashNumeric.AutoSize = true;
            this.flashNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashNumeric.FloatValue = 1F;
            this.flashNumeric.IntValue = 1;
            this.flashNumeric.IsInteger = true;
            this.flashNumeric.Location = new System.Drawing.Point(101, 28);
            this.flashNumeric.MaxCoerce = false;
            this.flashNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.flashNumeric.MaxValue = 1000000000D;
            this.flashNumeric.MinCoerce = true;
            this.flashNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.flashNumeric.MinValue = 1D;
            this.flashNumeric.Name = "flashNumeric";
            this.flashNumeric.Size = new System.Drawing.Size(70, 20);
            this.flashNumeric.TabIndex = 22;
            this.flashNumeric.TextFormat = "K4";
            this.flashNumeric.Units = "X";
            this.flashNumeric.Value = 1D;
            this.flashNumeric.ValueChanged += new System.EventHandler(this.flashNumeric_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Delay";
            // 
            // flashCheckBox
            // 
            this.flashCheckBox.AutoSize = true;
            this.flashCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flashCheckBox.Location = new System.Drawing.Point(44, 31);
            this.flashCheckBox.Name = "flashCheckBox";
            this.flashCheckBox.Size = new System.Drawing.Size(51, 17);
            this.flashCheckBox.TabIndex = 15;
            this.flashCheckBox.Text = "Flash";
            this.flashCheckBox.UseVisualStyleBackColor = true;
            this.flashCheckBox.CheckedChanged += new System.EventHandler(this.flashCheckBox_CheckedChanged);
            // 
            // delayNumeric
            // 
            this.delayNumeric.AutoSize = true;
            this.delayNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delayNumeric.FloatValue = 0F;
            this.delayNumeric.IntValue = 0;
            this.delayNumeric.IsInteger = false;
            this.delayNumeric.Location = new System.Drawing.Point(81, 3);
            this.delayNumeric.MaxCoerce = false;
            this.delayNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.delayNumeric.MaxValue = 1000000000D;
            this.delayNumeric.MinCoerce = true;
            this.delayNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.delayNumeric.MinValue = 0D;
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(90, 20);
            this.delayNumeric.TabIndex = 20;
            this.delayNumeric.TextFormat = "K4";
            this.delayNumeric.Units = "ms";
            this.delayNumeric.Value = 0D;
            this.delayNumeric.ValueChanged += new System.EventHandler(this.delayNumeric_ValueChanged);
            // 
            // flashPropertiesPanel
            // 
            this.flashPropertiesPanel.AutoSize = true;
            this.flashPropertiesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashPropertiesPanel.Controls.Add(this.periodNumeric);
            this.flashPropertiesPanel.Controls.Add(this.label11);
            this.flashPropertiesPanel.Controls.Add(this.onNumeric);
            this.flashPropertiesPanel.Controls.Add(this.label12);
            this.flashPropertiesPanel.Location = new System.Drawing.Point(3, 112);
            this.flashPropertiesPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flashPropertiesPanel.Name = "flashPropertiesPanel";
            this.flashPropertiesPanel.Size = new System.Drawing.Size(174, 51);
            this.flashPropertiesPanel.TabIndex = 31;
            // 
            // periodNumeric
            // 
            this.periodNumeric.AutoSize = true;
            this.periodNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.periodNumeric.FloatValue = 0F;
            this.periodNumeric.IntValue = 0;
            this.periodNumeric.IsInteger = false;
            this.periodNumeric.Location = new System.Drawing.Point(81, 28);
            this.periodNumeric.MaxCoerce = false;
            this.periodNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.periodNumeric.MaxValue = 1000000000D;
            this.periodNumeric.MinCoerce = true;
            this.periodNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.periodNumeric.MinValue = 0D;
            this.periodNumeric.Name = "periodNumeric";
            this.periodNumeric.Size = new System.Drawing.Size(90, 20);
            this.periodNumeric.TabIndex = 18;
            this.periodNumeric.TextFormat = "K4";
            this.periodNumeric.Units = "ms";
            this.periodNumeric.Value = 0D;
            this.periodNumeric.ValueChanged += new System.EventHandler(this.periodNumeric_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "On";
            // 
            // onNumeric
            // 
            this.onNumeric.AutoSize = true;
            this.onNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.onNumeric.FloatValue = 0F;
            this.onNumeric.IntValue = 0;
            this.onNumeric.IsInteger = false;
            this.onNumeric.Location = new System.Drawing.Point(81, 2);
            this.onNumeric.MaxCoerce = false;
            this.onNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.onNumeric.MaxValue = 1000000000D;
            this.onNumeric.MinCoerce = true;
            this.onNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.onNumeric.MinValue = 0D;
            this.onNumeric.Name = "onNumeric";
            this.onNumeric.Size = new System.Drawing.Size(90, 20);
            this.onNumeric.TabIndex = 14;
            this.onNumeric.TextFormat = "K4";
            this.onNumeric.Units = "ms";
            this.onNumeric.Value = 0D;
            this.onNumeric.ValueChanged += new System.EventHandler(this.onNumeric_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Period";
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.Location = new System.Drawing.Point(3, 169);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(123, 17);
            this.changeCheckBox.TabIndex = 51;
            this.changeCheckBox.Text = "Change appearance";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            this.changeCheckBox.CheckedChanged += new System.EventHandler(this.changeCheckBox_CheckedChanged);
            // 
            // appearancePanel
            // 
            this.appearancePanel.AutoSize = true;
            this.appearancePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appearancePanel.Controls.Add(this.hNumeric);
            this.appearancePanel.Controls.Add(this.yNumeric);
            this.appearancePanel.Controls.Add(this.wNumeric);
            this.appearancePanel.Controls.Add(this.xNumeric);
            this.appearancePanel.Controls.Add(this.label6);
            this.appearancePanel.Controls.Add(this.label5);
            this.appearancePanel.Controls.Add(this.yLabel);
            this.appearancePanel.Controls.Add(this.xLabel);
            this.appearancePanel.Location = new System.Drawing.Point(3, 192);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(175, 52);
            this.appearancePanel.TabIndex = 36;
            // 
            // hNumeric
            // 
            this.hNumeric.AutoSize = true;
            this.hNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hNumeric.FloatValue = 0F;
            this.hNumeric.IntValue = 0;
            this.hNumeric.IsInteger = false;
            this.hNumeric.Location = new System.Drawing.Point(120, 29);
            this.hNumeric.MaxCoerce = false;
            this.hNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.hNumeric.MaxValue = 2000D;
            this.hNumeric.MinCoerce = false;
            this.hNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.hNumeric.MinValue = -2000D;
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(51, 20);
            this.hNumeric.TabIndex = 21;
            this.hNumeric.TextFormat = "K4";
            this.hNumeric.Units = "";
            this.hNumeric.Value = 0D;
            this.hNumeric.ValueChanged += new System.EventHandler(this.hNumeric_ValueChanged);
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = false;
            this.yNumeric.Location = new System.Drawing.Point(42, 29);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 2000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = -2000D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(51, 20);
            this.yNumeric.TabIndex = 20;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // wNumeric
            // 
            this.wNumeric.AutoSize = true;
            this.wNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wNumeric.FloatValue = 0F;
            this.wNumeric.IntValue = 0;
            this.wNumeric.IsInteger = false;
            this.wNumeric.Location = new System.Drawing.Point(121, 5);
            this.wNumeric.MaxCoerce = false;
            this.wNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.wNumeric.MaxValue = 2000D;
            this.wNumeric.MinCoerce = false;
            this.wNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.wNumeric.MinValue = -2000D;
            this.wNumeric.Name = "wNumeric";
            this.wNumeric.Size = new System.Drawing.Size(51, 20);
            this.wNumeric.TabIndex = 19;
            this.wNumeric.TextFormat = "K4";
            this.wNumeric.Units = "";
            this.wNumeric.Value = 0D;
            this.wNumeric.ValueChanged += new System.EventHandler(this.wNumeric_ValueChanged);
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = false;
            this.xNumeric.Location = new System.Drawing.Point(43, 5);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 2000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = -2000D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(50, 20);
            this.xNumeric.TabIndex = 18;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "W";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "H";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(26, 33);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 15;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(26, 7);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "X";
            // 
            // messagePanel
            // 
            this.messagePanel.AutoSize = true;
            this.messagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagePanel.Location = new System.Drawing.Point(3, 361);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(0, 0);
            this.messagePanel.TabIndex = 33;
            // 
            // HelpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HelpControl";
            this.Size = new System.Drawing.Size(220, 364);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flashPanel.ResumeLayout(false);
            this.flashPanel.PerformLayout();
            this.flashPropertiesPanel.ResumeLayout(false);
            this.flashPropertiesPanel.PerformLayout();
            this.appearancePanel.ResumeLayout(false);
            this.appearancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel flashPanel;
        private KLib.Controls.KNumericBox flashNumeric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox flashCheckBox;
        private KLib.Controls.KNumericBox delayNumeric;
        private System.Windows.Forms.Panel flashPropertiesPanel;
        private KLib.Controls.KNumericBox periodNumeric;
        private System.Windows.Forms.Label label11;
        private KLib.Controls.KNumericBox onNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel appearancePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private KLib.Controls.KNumericBox hNumeric;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox wNumeric;
        private KLib.Controls.KNumericBox xNumeric;
    }
}
