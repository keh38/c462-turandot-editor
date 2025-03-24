namespace Turandot_Editor.Controls.Inputs
{
    partial class ButtonActionControl
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
            this.delayNumeric = new KLib.Controls.KNumericBox();
            this.flashPanel = new System.Windows.Forms.Panel();
            this.scaleNumeric = new KLib.Controls.KNumericBox();
            this.scaleCheckBox = new System.Windows.Forms.CheckBox();
            this.onNumeric = new KLib.Controls.KNumericBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.periodNumeric = new KLib.Controls.KNumericBox();
            this.flashNumeric = new KLib.Controls.KNumericBox();
            this.flashCheckBox = new System.Windows.Forms.CheckBox();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.colorBox = new KLib.Controls.KColorBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flashPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Delay";
            // 
            // delayNumeric
            // 
            this.delayNumeric.AutoSize = true;
            this.delayNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delayNumeric.FloatValue = 0F;
            this.delayNumeric.IntValue = 0;
            this.delayNumeric.IsInteger = false;
            this.delayNumeric.Location = new System.Drawing.Point(52, 3);
            this.delayNumeric.MaxCoerce = false;
            this.delayNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.delayNumeric.MaxValue = 1000000000D;
            this.delayNumeric.MinCoerce = true;
            this.delayNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.delayNumeric.MinValue = 0D;
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(90, 20);
            this.delayNumeric.TabIndex = 36;
            this.delayNumeric.TextFormat = "K4";
            this.delayNumeric.Units = "ms";
            this.delayNumeric.Value = 0D;
            this.delayNumeric.ValueChanged += new System.EventHandler(this.delayNumeric_ValueChanged);
            // 
            // flashPanel
            // 
            this.flashPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flashPanel.AutoSize = true;
            this.flashPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashPanel.Controls.Add(this.scaleNumeric);
            this.flashPanel.Controls.Add(this.scaleCheckBox);
            this.flashPanel.Controls.Add(this.onNumeric);
            this.flashPanel.Controls.Add(this.label12);
            this.flashPanel.Controls.Add(this.label8);
            this.flashPanel.Controls.Add(this.periodNumeric);
            this.flashPanel.Location = new System.Drawing.Point(10, 52);
            this.flashPanel.Name = "flashPanel";
            this.flashPanel.Size = new System.Drawing.Size(138, 79);
            this.flashPanel.TabIndex = 34;
            // 
            // scaleNumeric
            // 
            this.scaleNumeric.AutoSize = true;
            this.scaleNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scaleNumeric.FloatValue = 0F;
            this.scaleNumeric.IntValue = 0;
            this.scaleNumeric.IsInteger = false;
            this.scaleNumeric.Location = new System.Drawing.Point(65, 56);
            this.scaleNumeric.MaxCoerce = false;
            this.scaleNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.scaleNumeric.MaxValue = 100000D;
            this.scaleNumeric.MinCoerce = true;
            this.scaleNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.scaleNumeric.MinValue = 0D;
            this.scaleNumeric.Name = "scaleNumeric";
            this.scaleNumeric.Size = new System.Drawing.Size(70, 20);
            this.scaleNumeric.TabIndex = 33;
            this.scaleNumeric.TextFormat = "K4";
            this.scaleNumeric.Units = "X";
            this.scaleNumeric.Value = 0D;
            this.scaleNumeric.ValueChanged += new System.EventHandler(this.scaleNumeric_ValueChanged);
            // 
            // scaleCheckBox
            // 
            this.scaleCheckBox.AutoSize = true;
            this.scaleCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scaleCheckBox.Location = new System.Drawing.Point(6, 58);
            this.scaleCheckBox.Name = "scaleCheckBox";
            this.scaleCheckBox.Size = new System.Drawing.Size(53, 17);
            this.scaleCheckBox.TabIndex = 32;
            this.scaleCheckBox.Text = "Scale";
            this.scaleCheckBox.UseVisualStyleBackColor = true;
            this.scaleCheckBox.CheckedChanged += new System.EventHandler(this.scaleCheckBox_CheckedChanged);
            // 
            // onNumeric
            // 
            this.onNumeric.AutoSize = true;
            this.onNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.onNumeric.FloatValue = 0F;
            this.onNumeric.IntValue = 0;
            this.onNumeric.IsInteger = false;
            this.onNumeric.Location = new System.Drawing.Point(45, 3);
            this.onNumeric.MaxCoerce = false;
            this.onNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.onNumeric.MaxValue = 1000000000D;
            this.onNumeric.MinCoerce = true;
            this.onNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.onNumeric.MinValue = 0D;
            this.onNumeric.Name = "onNumeric";
            this.onNumeric.Size = new System.Drawing.Size(90, 20);
            this.onNumeric.TabIndex = 24;
            this.onNumeric.TextFormat = "K4";
            this.onNumeric.Units = "ms";
            this.onNumeric.Value = 0D;
            this.onNumeric.ValueChanged += new System.EventHandler(this.onNumeric_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "On";
            // 
            // periodNumeric
            // 
            this.periodNumeric.AutoSize = true;
            this.periodNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.periodNumeric.FloatValue = 0F;
            this.periodNumeric.IntValue = 0;
            this.periodNumeric.IsInteger = false;
            this.periodNumeric.Location = new System.Drawing.Point(45, 29);
            this.periodNumeric.MaxCoerce = false;
            this.periodNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.periodNumeric.MaxValue = 100000D;
            this.periodNumeric.MinCoerce = true;
            this.periodNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.periodNumeric.MinValue = 0D;
            this.periodNumeric.Name = "periodNumeric";
            this.periodNumeric.Size = new System.Drawing.Size(90, 20);
            this.periodNumeric.TabIndex = 27;
            this.periodNumeric.TextFormat = "K4";
            this.periodNumeric.Units = "ms";
            this.periodNumeric.Value = 0D;
            this.periodNumeric.ValueChanged += new System.EventHandler(this.periodNumeric_ValueChanged);
            // 
            // flashNumeric
            // 
            this.flashNumeric.AutoSize = true;
            this.flashNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashNumeric.FloatValue = 1F;
            this.flashNumeric.IntValue = 1;
            this.flashNumeric.IsInteger = true;
            this.flashNumeric.Location = new System.Drawing.Point(72, 26);
            this.flashNumeric.MaxCoerce = false;
            this.flashNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.flashNumeric.MaxValue = 1000000000D;
            this.flashNumeric.MinCoerce = true;
            this.flashNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.flashNumeric.MinValue = 1D;
            this.flashNumeric.Name = "flashNumeric";
            this.flashNumeric.Size = new System.Drawing.Size(70, 20);
            this.flashNumeric.TabIndex = 33;
            this.flashNumeric.TextFormat = "K4";
            this.flashNumeric.Units = "X";
            this.flashNumeric.Value = 1D;
            this.flashNumeric.ValueChanged += new System.EventHandler(this.flashNumeric_ValueChanged);
            // 
            // flashCheckBox
            // 
            this.flashCheckBox.AutoSize = true;
            this.flashCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flashCheckBox.Location = new System.Drawing.Point(15, 29);
            this.flashCheckBox.Name = "flashCheckBox";
            this.flashCheckBox.Size = new System.Drawing.Size(51, 17);
            this.flashCheckBox.TabIndex = 32;
            this.flashCheckBox.Text = "Flash";
            this.flashCheckBox.UseVisualStyleBackColor = true;
            this.flashCheckBox.CheckedChanged += new System.EventHandler(this.flashCheckBox_CheckedChanged);
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeCheckBox.Location = new System.Drawing.Point(22, 137);
            this.changeCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 0);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(123, 17);
            this.changeCheckBox.TabIndex = 34;
            this.changeCheckBox.Text = "Change appearance";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            this.changeCheckBox.CheckedChanged += new System.EventHandler(this.changeCheckBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flashPanel);
            this.flowLayoutPanel1.Controls.Add(this.changeCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.appearancePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(151, 187);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.delayNumeric);
            this.panel1.Controls.Add(this.flashCheckBox);
            this.panel1.Controls.Add(this.flashNumeric);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 49);
            this.panel1.TabIndex = 38;
            // 
            // appearancePanel
            // 
            this.appearancePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appearancePanel.AutoSize = true;
            this.appearancePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appearancePanel.Controls.Add(this.colorBox);
            this.appearancePanel.Controls.Add(this.label3);
            this.appearancePanel.Location = new System.Drawing.Point(3, 157);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(145, 27);
            this.appearancePanel.TabIndex = 38;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(52, 3);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(90, 21);
            this.colorBox.TabIndex = 51;
            this.colorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorBox.ValueAsUInt = ((uint)(4294967295u));
            this.colorBox.ValueChanged += new System.EventHandler(this.colorBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Color";
            // 
            // ButtonActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ButtonActionControl";
            this.Size = new System.Drawing.Size(486, 334);
            this.flashPanel.ResumeLayout(false);
            this.flashPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.appearancePanel.ResumeLayout(false);
            this.appearancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private KLib.Controls.KNumericBox delayNumeric;
        private System.Windows.Forms.Panel flashPanel;
        private KLib.Controls.KNumericBox scaleNumeric;
        private System.Windows.Forms.CheckBox scaleCheckBox;
        private KLib.Controls.KNumericBox onNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KNumericBox periodNumeric;
        private KLib.Controls.KNumericBox flashNumeric;
        private System.Windows.Forms.CheckBox flashCheckBox;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel appearancePanel;
        private KLib.Controls.KColorBox colorBox;
        private System.Windows.Forms.Label label3;
    }
}
