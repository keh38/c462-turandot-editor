namespace Turandot_Editor.Controls.Inputs
{
    partial class ParamSliderActionControl
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
            this.resetCheckbox = new System.Windows.Forms.CheckBox();
            this.channelTextBox = new KLib.Controls.KTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paramTextBox = new KLib.Controls.KTextBox();
            this.minNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxNumeric = new KLib.Controls.KNumericBox();
            this.logCheckBox = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rightTextBox = new KLib.Controls.KTextBox();
            this.offsetNumeric = new KLib.Controls.KNumericBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leftTextBox = new KLib.Controls.KTextBox();
            this.shrinkNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startNumeric = new KLib.Controls.KNumericBox();
            this.showButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetCheckbox
            // 
            this.resetCheckbox.AutoSize = true;
            this.resetCheckbox.Location = new System.Drawing.Point(67, 19);
            this.resetCheckbox.Name = "resetCheckbox";
            this.resetCheckbox.Size = new System.Drawing.Size(54, 17);
            this.resetCheckbox.TabIndex = 0;
            this.resetCheckbox.Text = "Reset";
            this.resetCheckbox.UseVisualStyleBackColor = true;
            this.resetCheckbox.CheckedChanged += new System.EventHandler(this.resetCheckbox_CheckedChanged);
            // 
            // channelTextBox
            // 
            this.channelTextBox.AutoSize = true;
            this.channelTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channelTextBox.Location = new System.Drawing.Point(64, 5);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(111, 20);
            this.channelTextBox.TabIndex = 1;
            this.channelTextBox.ValueChanged += new System.EventHandler(this.channelTextBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parameter";
            // 
            // paramTextBox
            // 
            this.paramTextBox.AutoSize = true;
            this.paramTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paramTextBox.Location = new System.Drawing.Point(64, 31);
            this.paramTextBox.Name = "paramTextBox";
            this.paramTextBox.Size = new System.Drawing.Size(111, 20);
            this.paramTextBox.TabIndex = 3;
            this.paramTextBox.ValueChanged += new System.EventHandler(this.paramTextBox_ValueChanged);
            // 
            // minNumeric
            // 
            this.minNumeric.AutoSize = true;
            this.minNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minNumeric.FloatValue = 0F;
            this.minNumeric.IntValue = 0;
            this.minNumeric.IsInteger = false;
            this.minNumeric.Location = new System.Drawing.Point(64, 122);
            this.minNumeric.MaxCoerce = false;
            this.minNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.minNumeric.MaxValue = 1000000000D;
            this.minNumeric.MinCoerce = false;
            this.minNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.minNumeric.MinValue = 0D;
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(111, 20);
            this.minNumeric.TabIndex = 5;
            this.minNumeric.TextFormat = "K4";
            this.minNumeric.Units = "";
            this.minNumeric.Value = 0D;
            this.minNumeric.ValueChanged += new System.EventHandler(this.minNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max";
            // 
            // maxNumeric
            // 
            this.maxNumeric.AutoSize = true;
            this.maxNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxNumeric.FloatValue = 0F;
            this.maxNumeric.IntValue = 0;
            this.maxNumeric.IsInteger = false;
            this.maxNumeric.Location = new System.Drawing.Point(64, 148);
            this.maxNumeric.MaxCoerce = false;
            this.maxNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxNumeric.MaxValue = 1000000000D;
            this.maxNumeric.MinCoerce = false;
            this.maxNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxNumeric.MinValue = 0D;
            this.maxNumeric.Name = "maxNumeric";
            this.maxNumeric.Size = new System.Drawing.Size(111, 20);
            this.maxNumeric.TabIndex = 7;
            this.maxNumeric.TextFormat = "K4";
            this.maxNumeric.Units = "";
            this.maxNumeric.Value = 0D;
            this.maxNumeric.ValueChanged += new System.EventHandler(this.maxNumeric_ValueChanged);
            // 
            // logCheckBox
            // 
            this.logCheckBox.AutoSize = true;
            this.logCheckBox.Location = new System.Drawing.Point(64, 178);
            this.logCheckBox.Name = "logCheckBox";
            this.logCheckBox.Size = new System.Drawing.Size(72, 17);
            this.logCheckBox.TabIndex = 9;
            this.logCheckBox.Text = "Log scale";
            this.logCheckBox.UseVisualStyleBackColor = true;
            this.logCheckBox.CheckedChanged += new System.EventHandler(this.logCheckBox_CheckedChanged);
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.rightTextBox);
            this.panel.Controls.Add(this.offsetNumeric);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.leftTextBox);
            this.panel.Controls.Add(this.shrinkNumeric);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.startNumeric);
            this.panel.Controls.Add(this.minNumeric);
            this.panel.Controls.Add(this.logCheckBox);
            this.panel.Controls.Add(this.channelTextBox);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.maxNumeric);
            this.panel.Controls.Add(this.paramTextBox);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(3, 35);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(323, 228);
            this.panel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Label";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Offset";
            // 
            // rightTextBox
            // 
            this.rightTextBox.AutoSize = true;
            this.rightTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightTextBox.Location = new System.Drawing.Point(216, 148);
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.Size = new System.Drawing.Size(104, 20);
            this.rightTextBox.TabIndex = 66;
            this.rightTextBox.ValueChanged += new System.EventHandler(this.rightTextBox_ValueChanged);
            // 
            // offsetNumeric
            // 
            this.offsetNumeric.AutoSize = true;
            this.offsetNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.offsetNumeric.FloatValue = 0F;
            this.offsetNumeric.IntValue = 0;
            this.offsetNumeric.IsInteger = false;
            this.offsetNumeric.Location = new System.Drawing.Point(64, 90);
            this.offsetNumeric.MaxCoerce = true;
            this.offsetNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.offsetNumeric.MaxValue = 100D;
            this.offsetNumeric.MinCoerce = true;
            this.offsetNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.offsetNumeric.MinValue = 0D;
            this.offsetNumeric.Name = "offsetNumeric";
            this.offsetNumeric.Size = new System.Drawing.Size(111, 20);
            this.offsetNumeric.TabIndex = 14;
            this.offsetNumeric.TextFormat = "K4";
            this.offsetNumeric.Units = "";
            this.offsetNumeric.Value = 0D;
            this.offsetNumeric.ValueChanged += new System.EventHandler(this.offsetNumeric_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shrink by";
            // 
            // leftTextBox
            // 
            this.leftTextBox.AutoSize = true;
            this.leftTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftTextBox.Location = new System.Drawing.Point(216, 122);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(104, 20);
            this.leftTextBox.TabIndex = 64;
            this.leftTextBox.ValueChanged += new System.EventHandler(this.leftTextBox_ValueChanged);
            // 
            // shrinkNumeric
            // 
            this.shrinkNumeric.AutoSize = true;
            this.shrinkNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shrinkNumeric.FloatValue = 0F;
            this.shrinkNumeric.IntValue = 0;
            this.shrinkNumeric.IsInteger = false;
            this.shrinkNumeric.Location = new System.Drawing.Point(64, 205);
            this.shrinkNumeric.MaxCoerce = true;
            this.shrinkNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.shrinkNumeric.MaxValue = 50D;
            this.shrinkNumeric.MinCoerce = true;
            this.shrinkNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.shrinkNumeric.MinValue = 0D;
            this.shrinkNumeric.Name = "shrinkNumeric";
            this.shrinkNumeric.Size = new System.Drawing.Size(111, 20);
            this.shrinkNumeric.TabIndex = 12;
            this.shrinkNumeric.TextFormat = "K4";
            this.shrinkNumeric.Units = "";
            this.shrinkNumeric.Value = 0D;
            this.shrinkNumeric.ValueChanged += new System.EventHandler(this.shrinkNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start";
            // 
            // startNumeric
            // 
            this.startNumeric.AutoSize = true;
            this.startNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startNumeric.FloatValue = 0F;
            this.startNumeric.IntValue = 0;
            this.startNumeric.IsInteger = false;
            this.startNumeric.Location = new System.Drawing.Point(64, 64);
            this.startNumeric.MaxCoerce = false;
            this.startNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.startNumeric.MaxValue = 1000000000D;
            this.startNumeric.MinCoerce = false;
            this.startNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.startNumeric.MinValue = 0D;
            this.startNumeric.Name = "startNumeric";
            this.startNumeric.Size = new System.Drawing.Size(111, 20);
            this.startNumeric.TabIndex = 10;
            this.startNumeric.TextFormat = "K4";
            this.startNumeric.Units = "";
            this.startNumeric.Value = 0D;
            this.startNumeric.ValueChanged += new System.EventHandler(this.startNumeric_ValueChanged);
            // 
            // showButtonCheckBox
            // 
            this.showButtonCheckBox.AutoSize = true;
            this.showButtonCheckBox.Location = new System.Drawing.Point(67, 1);
            this.showButtonCheckBox.Name = "showButtonCheckBox";
            this.showButtonCheckBox.Size = new System.Drawing.Size(86, 17);
            this.showButtonCheckBox.TabIndex = 16;
            this.showButtonCheckBox.Text = "Show button";
            this.showButtonCheckBox.UseVisualStyleBackColor = true;
            this.showButtonCheckBox.CheckedChanged += new System.EventHandler(this.showButtonCheckBox_CheckedChanged);
            // 
            // ParamSliderActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.showButtonCheckBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.resetCheckbox);
            this.Name = "ParamSliderActionControl";
            this.Size = new System.Drawing.Size(329, 266);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox resetCheckbox;
        private KLib.Controls.KTextBox channelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KLib.Controls.KTextBox paramTextBox;
        private KLib.Controls.KNumericBox minNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox maxNumeric;
        private System.Windows.Forms.CheckBox logCheckBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.KNumericBox startNumeric;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.KNumericBox offsetNumeric;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox shrinkNumeric;
        private System.Windows.Forms.CheckBox showButtonCheckBox;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KTextBox rightTextBox;
        private System.Windows.Forms.Label label9;
        private KLib.Controls.KTextBox leftTextBox;
    }
}
