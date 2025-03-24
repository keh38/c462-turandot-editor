namespace Turandot_Editor.Controls.Screen
{
    partial class ThumbSliderLayoutControl
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
            this.ylabel = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label13 = new System.Windows.Forms.Label();
            this.scaleYNumeric = new KLib.Controls.KNumericBox();
            this.SuspendLayout();
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(6, 30);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(50, 13);
            this.ylabel.TabIndex = 73;
            this.ylabel.Text = "Thumb Y";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(58, 27);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 1000000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(90, 20);
            this.yNumeric.TabIndex = 74;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Thumb X";
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(58, 3);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 1000000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(90, 20);
            this.xNumeric.TabIndex = 72;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Scale Y";
            // 
            // scaleYNumeric
            // 
            this.scaleYNumeric.AutoSize = true;
            this.scaleYNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scaleYNumeric.FloatValue = 0F;
            this.scaleYNumeric.IntValue = 0;
            this.scaleYNumeric.IsInteger = true;
            this.scaleYNumeric.Location = new System.Drawing.Point(58, 51);
            this.scaleYNumeric.MaxCoerce = false;
            this.scaleYNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.scaleYNumeric.MaxValue = 1000000000D;
            this.scaleYNumeric.MinCoerce = false;
            this.scaleYNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.scaleYNumeric.MinValue = 0D;
            this.scaleYNumeric.Name = "scaleYNumeric";
            this.scaleYNumeric.Size = new System.Drawing.Size(90, 20);
            this.scaleYNumeric.TabIndex = 70;
            this.scaleYNumeric.TextFormat = "K4";
            this.scaleYNumeric.Units = "";
            this.scaleYNumeric.Value = 0D;
            this.scaleYNumeric.ValueChanged += new System.EventHandler(this.scaleYNumeric_ValueChanged);
            // 
            // ThumbSliderLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xNumeric);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.scaleYNumeric);
            this.Name = "ThumbSliderLayoutControl";
            this.Size = new System.Drawing.Size(151, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ylabel;
        private KLib.Controls.KNumericBox yNumeric;
        private System.Windows.Forms.Label label3;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label13;
        private KLib.Controls.KNumericBox scaleYNumeric;
    }
}
