namespace Turandot_Editor.Controls.Screen
{
    partial class CounterProperties
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
            this.colorBox = new KLib.Controls.KColorBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sizeNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.ylabel = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(36, 75);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(90, 21);
            this.colorBox.TabIndex = 64;
            this.colorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorBox.ValueAsUInt = ((uint)(4294967295u));
            this.colorBox.ValueChanged += new System.EventHandler(this.colorBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Size";
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.AutoSize = true;
            this.sizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeNumeric.FloatValue = 0F;
            this.sizeNumeric.IntValue = 0;
            this.sizeNumeric.IsInteger = true;
            this.sizeNumeric.Location = new System.Drawing.Point(36, 51);
            this.sizeNumeric.MaxCoerce = false;
            this.sizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.sizeNumeric.MaxValue = 1000000000D;
            this.sizeNumeric.MinCoerce = false;
            this.sizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.sizeNumeric.MinValue = 0D;
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.sizeNumeric.TabIndex = 62;
            this.sizeNumeric.TextFormat = "K4";
            this.sizeNumeric.Units = "";
            this.sizeNumeric.Value = 0D;
            this.sizeNumeric.ValueChanged += new System.EventHandler(this.sizeNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "X";
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(36, 3);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 1000000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(90, 20);
            this.xNumeric.TabIndex = 66;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(20, 30);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(14, 13);
            this.ylabel.TabIndex = 67;
            this.ylabel.Text = "Y";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(36, 27);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 1000000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(90, 20);
            this.yNumeric.TabIndex = 68;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // CounterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xNumeric);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sizeNumeric);
            this.Name = "CounterProperties";
            this.Size = new System.Drawing.Size(129, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KColorBox colorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private KLib.Controls.KNumericBox sizeNumeric;
        private System.Windows.Forms.Label label3;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label ylabel;
        private KLib.Controls.KNumericBox yNumeric;
    }
}
