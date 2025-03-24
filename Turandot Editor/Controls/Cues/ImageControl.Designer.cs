namespace Turandot_Editor.Controls
{
    partial class ImageControl
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
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.horzAlignEnum = new KLib.Controls.EnumDropDown();
            this.vertAlignEnum = new KLib.Controls.EnumDropDown();
            this.imageFile = new KLib.Controls.FileBrowser();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flashPanel.SuspendLayout();
            this.flashPropertiesPanel.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flashPanel);
            this.flowLayoutPanel1.Controls.Add(this.flashPropertiesPanel);
            this.flowLayoutPanel1.Controls.Add(this.messagePanel);
            this.flowLayoutPanel1.Controls.Add(this.imageFile);
            this.flowLayoutPanel1.Controls.Add(this.appearancePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 251);
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
            // appearancePanel
            // 
            this.appearancePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appearancePanel.AutoSize = true;
            this.appearancePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appearancePanel.Controls.Add(this.vertAlignEnum);
            this.appearancePanel.Controls.Add(this.yNumeric);
            this.appearancePanel.Controls.Add(this.xNumeric);
            this.appearancePanel.Controls.Add(this.yLabel);
            this.appearancePanel.Controls.Add(this.xLabel);
            this.appearancePanel.Controls.Add(this.horzAlignEnum);
            this.appearancePanel.Location = new System.Drawing.Point(17, 196);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(160, 52);
            this.appearancePanel.TabIndex = 36;
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = false;
            this.yNumeric.Location = new System.Drawing.Point(21, 29);
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
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = false;
            this.xNumeric.Location = new System.Drawing.Point(22, 5);
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
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(5, 33);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 15;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(5, 7);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "X";
            // 
            // messagePanel
            // 
            this.messagePanel.AutoSize = true;
            this.messagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagePanel.Location = new System.Drawing.Point(3, 166);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(0, 0);
            this.messagePanel.TabIndex = 33;
            // 
            // horzAlignEnum
            // 
            this.horzAlignEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horzAlignEnum.FormattingEnabled = true;
            this.horzAlignEnum.Location = new System.Drawing.Point(80, 5);
            this.horzAlignEnum.Name = "horzAlignEnum";
            this.horzAlignEnum.Size = new System.Drawing.Size(77, 21);
            this.horzAlignEnum.Sort = false;
            this.horzAlignEnum.TabIndex = 37;
            this.horzAlignEnum.ValueChanged += new System.EventHandler(this.horzAlignEnum_ValueChanged);
            // 
            // vertAlignEnum
            // 
            this.vertAlignEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertAlignEnum.FormattingEnabled = true;
            this.vertAlignEnum.Location = new System.Drawing.Point(80, 28);
            this.vertAlignEnum.Name = "vertAlignEnum";
            this.vertAlignEnum.Size = new System.Drawing.Size(77, 21);
            this.vertAlignEnum.Sort = false;
            this.vertAlignEnum.TabIndex = 38;
            this.vertAlignEnum.ValueChanged += new System.EventHandler(this.vertAlignEnum_ValueChanged);
            // 
            // imageFile
            // 
            this.imageFile.AutoSize = true;
            this.imageFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageFile.DefaultFolder = null;
            this.imageFile.FileMustExist = false;
            this.imageFile.Filter = null;
            this.imageFile.FoldersOnly = false;
            this.imageFile.HideFolder = false;
            this.imageFile.Location = new System.Drawing.Point(3, 169);
            this.imageFile.Name = "imageFile";
            this.imageFile.Size = new System.Drawing.Size(174, 21);
            this.imageFile.TabIndex = 37;
            this.imageFile.UseEllipsis = false;
            this.imageFile.Value = "";
            this.imageFile.ValueChanged += new System.EventHandler(this.imageFile_ValueChanged);
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ImageControl";
            this.Size = new System.Drawing.Size(183, 254);
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
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox xNumeric;
        private KLib.Controls.FileBrowser imageFile;
        private KLib.Controls.EnumDropDown vertAlignEnum;
        private KLib.Controls.EnumDropDown horzAlignEnum;
    }
}
