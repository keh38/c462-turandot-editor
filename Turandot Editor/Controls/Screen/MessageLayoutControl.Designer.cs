namespace Turandot_Editor.Controls.Screen
{
    partial class MessageLayoutControl
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
            this.fontSizeNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new KLib.Controls.KColorBox();
            this.SuspendLayout();
            // 
            // fontSizeNumeric
            // 
            this.fontSizeNumeric.AutoSize = true;
            this.fontSizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fontSizeNumeric.FloatValue = 6F;
            this.fontSizeNumeric.IntValue = 6;
            this.fontSizeNumeric.IsInteger = false;
            this.fontSizeNumeric.Location = new System.Drawing.Point(79, 3);
            this.fontSizeNumeric.MaxCoerce = false;
            this.fontSizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.fontSizeNumeric.MaxValue = 100D;
            this.fontSizeNumeric.MinCoerce = true;
            this.fontSizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.fontSizeNumeric.MinValue = 6D;
            this.fontSizeNumeric.Name = "fontSizeNumeric";
            this.fontSizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.fontSizeNumeric.TabIndex = 22;
            this.fontSizeNumeric.TextFormat = "K4";
            this.fontSizeNumeric.Units = "";
            this.fontSizeNumeric.Value = 6D;
            this.fontSizeNumeric.ValueChanged += new System.EventHandler(this.fontSizeNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Font size";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = false;
            this.yNumeric.Location = new System.Drawing.Point(117, 50);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 2000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = -2000D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(51, 20);
            this.yNumeric.TabIndex = 44;
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
            this.xNumeric.Location = new System.Drawing.Point(39, 50);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 2000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = -2000D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(50, 20);
            this.xNumeric.TabIndex = 43;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(22, 52);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 41;
            this.xLabel.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Color";
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(39, 27);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(130, 19);
            this.colorBox.TabIndex = 45;
            this.colorBox.Value = System.Drawing.Color.White;
            this.colorBox.ValueAsUInt = ((uint)(4294967295u));
            this.colorBox.ValueChanged += new System.EventHandler(this.colorBox_ValueChanged);
            // 
            // MessageLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.xNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fontSizeNumeric);
            this.Controls.Add(this.label4);
            this.Name = "MessageLayoutControl";
            this.Size = new System.Drawing.Size(172, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KNumericBox fontSizeNumeric;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label3;
        private KLib.Controls.KColorBox colorBox;
    }
}
