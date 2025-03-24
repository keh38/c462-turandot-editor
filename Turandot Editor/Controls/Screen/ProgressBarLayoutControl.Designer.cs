namespace Turandot_Editor.Controls.Screen
{
    partial class ProgressBarLayoutControl
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
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.wNumeric = new KLib.Controls.KNumericBox();
            this.ylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hNumeric = new KLib.Controls.KNumericBox();
            this.SuspendLayout();
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(25, 27);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 1000000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(90, 20);
            this.yNumeric.TabIndex = 71;
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
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(25, 3);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 1000000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(90, 20);
            this.xNumeric.TabIndex = 70;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // wNumeric
            // 
            this.wNumeric.AutoSize = true;
            this.wNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wNumeric.FloatValue = 0F;
            this.wNumeric.IntValue = 0;
            this.wNumeric.IsInteger = true;
            this.wNumeric.Location = new System.Drawing.Point(25, 51);
            this.wNumeric.MaxCoerce = false;
            this.wNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.wNumeric.MaxValue = 1000000000D;
            this.wNumeric.MinCoerce = false;
            this.wNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.wNumeric.MinValue = 0D;
            this.wNumeric.Name = "wNumeric";
            this.wNumeric.Size = new System.Drawing.Size(90, 20);
            this.wNumeric.TabIndex = 69;
            this.wNumeric.TextFormat = "K4";
            this.wNumeric.Units = "";
            this.wNumeric.Value = 0D;
            this.wNumeric.ValueChanged += new System.EventHandler(this.wNumeric_ValueChanged);
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(9, 30);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(14, 13);
            this.ylabel.TabIndex = 74;
            this.ylabel.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "W";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "H";
            // 
            // hNumeric
            // 
            this.hNumeric.AutoSize = true;
            this.hNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hNumeric.FloatValue = 0F;
            this.hNumeric.IntValue = 0;
            this.hNumeric.IsInteger = true;
            this.hNumeric.Location = new System.Drawing.Point(25, 76);
            this.hNumeric.MaxCoerce = false;
            this.hNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.hNumeric.MaxValue = 1000000000D;
            this.hNumeric.MinCoerce = false;
            this.hNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.hNumeric.MinValue = 0D;
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(90, 20);
            this.hNumeric.TabIndex = 75;
            this.hNumeric.TextFormat = "K4";
            this.hNumeric.Units = "";
            this.hNumeric.Value = 0D;
            this.hNumeric.ValueChanged += new System.EventHandler(this.hNumeric_ValueChanged);
            // 
            // ProgressBarLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.xNumeric);
            this.Controls.Add(this.wNumeric);
            this.Name = "ProgressBarLayoutControl";
            this.Size = new System.Drawing.Size(118, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox xNumeric;
        private KLib.Controls.KNumericBox wNumeric;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private KLib.Controls.KNumericBox hNumeric;
    }
}
