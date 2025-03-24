namespace Turandot_Editor.Controls
{
    partial class CueControl
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flashCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.delayNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.flashPanel = new System.Windows.Forms.Panel();
            this.flashNumeric = new KLib.Controls.KNumericBox();
            this.flashPropertiesPanel = new System.Windows.Forms.Panel();
            this.periodNumeric = new KLib.Controls.KNumericBox();
            this.onNumeric = new KLib.Controls.KNumericBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.iconSizeNumeric = new KLib.Controls.KNumericBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconEnum = new KLib.Controls.EnumDropDown();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.fontSizeNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.flashPanel.SuspendLayout();
            this.flashPropertiesPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            this.SuspendLayout();
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Period";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "On";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Action";
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
            this.actionPanel.Location = new System.Drawing.Point(3, 3);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(174, 52);
            this.actionPanel.TabIndex = 30;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Color";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Yellow;
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.Location = new System.Drawing.Point(40, 30);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(130, 21);
            this.colorBox.TabIndex = 33;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
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
            this.flashPanel.Size = new System.Drawing.Size(174, 51);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.actionPanel);
            this.flowLayoutPanel1.Controls.Add(this.flashPanel);
            this.flowLayoutPanel1.Controls.Add(this.flashPropertiesPanel);
            this.flowLayoutPanel1.Controls.Add(this.messagePanel);
            this.flowLayoutPanel1.Controls.Add(this.changeCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.appearancePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 395);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // messagePanel
            // 
            this.messagePanel.AutoSize = true;
            this.messagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagePanel.Controls.Add(this.iconSizeNumeric);
            this.messagePanel.Controls.Add(this.label7);
            this.messagePanel.Controls.Add(this.label5);
            this.messagePanel.Controls.Add(this.iconEnum);
            this.messagePanel.Controls.Add(this.msgTextBox);
            this.messagePanel.Location = new System.Drawing.Point(3, 166);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(174, 123);
            this.messagePanel.TabIndex = 33;
            // 
            // iconSizeNumeric
            // 
            this.iconSizeNumeric.AutoSize = true;
            this.iconSizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconSizeNumeric.FloatValue = 50F;
            this.iconSizeNumeric.IntValue = 50;
            this.iconSizeNumeric.IsInteger = true;
            this.iconSizeNumeric.Location = new System.Drawing.Point(81, 100);
            this.iconSizeNumeric.MaxCoerce = true;
            this.iconSizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.iconSizeNumeric.MaxValue = 256D;
            this.iconSizeNumeric.MinCoerce = true;
            this.iconSizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.iconSizeNumeric.MinValue = 50D;
            this.iconSizeNumeric.Name = "iconSizeNumeric";
            this.iconSizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.iconSizeNumeric.TabIndex = 38;
            this.iconSizeNumeric.TextFormat = "K4";
            this.iconSizeNumeric.Units = "";
            this.iconSizeNumeric.Value = 50D;
            this.iconSizeNumeric.ValueChanged += new System.EventHandler(this.iconSizeNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Icon";
            // 
            // iconEnum
            // 
            this.iconEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iconEnum.FormattingEnabled = true;
            this.iconEnum.Location = new System.Drawing.Point(81, 75);
            this.iconEnum.Name = "iconEnum";
            this.iconEnum.Size = new System.Drawing.Size(90, 21);
            this.iconEnum.Sort = false;
            this.iconEnum.TabIndex = 35;
            this.iconEnum.ValueChanged += new System.EventHandler(this.iconEnum_ValueChanged);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(3, 4);
            this.msgTextBox.Multiline = true;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(168, 66);
            this.msgTextBox.TabIndex = 34;
            this.msgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msgTextBox_KeyPress);
            this.msgTextBox.Leave += new System.EventHandler(this.msgTextBox_Leave);
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.Location = new System.Drawing.Point(3, 292);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(123, 17);
            this.changeCheckBox.TabIndex = 50;
            this.changeCheckBox.Text = "Change appearance";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            this.changeCheckBox.CheckedChanged += new System.EventHandler(this.changeCheckBox_CheckedChanged);
            // 
            // appearancePanel
            // 
            this.appearancePanel.AutoSize = true;
            this.appearancePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appearancePanel.Controls.Add(this.fontSizeNumeric);
            this.appearancePanel.Controls.Add(this.label4);
            this.appearancePanel.Controls.Add(this.yNumeric);
            this.appearancePanel.Controls.Add(this.xNumeric);
            this.appearancePanel.Controls.Add(this.label6);
            this.appearancePanel.Controls.Add(this.xLabel);
            this.appearancePanel.Controls.Add(this.label3);
            this.appearancePanel.Controls.Add(this.colorBox);
            this.appearancePanel.Location = new System.Drawing.Point(3, 315);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(173, 77);
            this.appearancePanel.TabIndex = 51;
            // 
            // fontSizeNumeric
            // 
            this.fontSizeNumeric.AutoSize = true;
            this.fontSizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fontSizeNumeric.FloatValue = 6F;
            this.fontSizeNumeric.IntValue = 6;
            this.fontSizeNumeric.IsInteger = false;
            this.fontSizeNumeric.Location = new System.Drawing.Point(80, 6);
            this.fontSizeNumeric.MaxCoerce = false;
            this.fontSizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.fontSizeNumeric.MaxValue = 100D;
            this.fontSizeNumeric.MinCoerce = true;
            this.fontSizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.fontSizeNumeric.MinValue = 6D;
            this.fontSizeNumeric.Name = "fontSizeNumeric";
            this.fontSizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.fontSizeNumeric.TabIndex = 40;
            this.fontSizeNumeric.TextFormat = "K4";
            this.fontSizeNumeric.Units = "";
            this.fontSizeNumeric.Value = 6D;
            this.fontSizeNumeric.ValueChanged += new System.EventHandler(this.fontSizeNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Font size";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = false;
            this.yNumeric.Location = new System.Drawing.Point(118, 54);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 2000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = -2000D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(51, 20);
            this.yNumeric.TabIndex = 38;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = false;
            this.xNumeric.Location = new System.Drawing.Point(40, 54);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 2000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = -2000D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(50, 20);
            this.xNumeric.TabIndex = 37;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(23, 56);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 35;
            this.xLabel.Text = "X";
            // 
            // CueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CueControl";
            this.Size = new System.Drawing.Size(183, 398);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.flashPanel.ResumeLayout(false);
            this.flashPanel.PerformLayout();
            this.flashPropertiesPanel.ResumeLayout(false);
            this.flashPropertiesPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.appearancePanel.ResumeLayout(false);
            this.appearancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KNumericBox flashNumeric;
        private KLib.Controls.KNumericBox delayNumeric;
        private System.Windows.Forms.Label label13;
        private KLib.Controls.KNumericBox periodNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox flashCheckBox;
        private KLib.Controls.KNumericBox onNumeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel flashPropertiesPanel;
        private System.Windows.Forms.Panel flashPanel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private System.Windows.Forms.Panel appearancePanel;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.EnumDropDown iconEnum;
        private KLib.Controls.KNumericBox iconSizeNumeric;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.KNumericBox fontSizeNumeric;
        private System.Windows.Forms.Label label4;
    }
}
