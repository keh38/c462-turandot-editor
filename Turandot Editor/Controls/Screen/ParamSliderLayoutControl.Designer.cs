namespace Turandot_Editor.Controls.Screen
{
    partial class ParamSliderLayoutControl
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
            this.hNumeric = new KLib.Controls.KNumericBox();
            this.wNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hNumeric
            // 
            this.hNumeric.AutoSize = true;
            this.hNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hNumeric.FloatValue = 0F;
            this.hNumeric.IntValue = 0;
            this.hNumeric.IsInteger = false;
            this.hNumeric.Location = new System.Drawing.Point(117, 29);
            this.hNumeric.MaxCoerce = false;
            this.hNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.hNumeric.MaxValue = 2000D;
            this.hNumeric.MinCoerce = false;
            this.hNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.hNumeric.MinValue = -2000D;
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(51, 20);
            this.hNumeric.TabIndex = 44;
            this.hNumeric.TextFormat = "K4";
            this.hNumeric.Units = "";
            this.hNumeric.Value = 0D;
            this.hNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // wNumeric
            // 
            this.wNumeric.AutoSize = true;
            this.wNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wNumeric.FloatValue = 0F;
            this.wNumeric.IntValue = 0;
            this.wNumeric.IsInteger = false;
            this.wNumeric.Location = new System.Drawing.Point(118, 3);
            this.wNumeric.MaxCoerce = false;
            this.wNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.wNumeric.MaxValue = 2000D;
            this.wNumeric.MinCoerce = false;
            this.wNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.wNumeric.MinValue = -2000D;
            this.wNumeric.Name = "wNumeric";
            this.wNumeric.Size = new System.Drawing.Size(50, 20);
            this.wNumeric.TabIndex = 43;
            this.wNumeric.TextFormat = "K4";
            this.wNumeric.Units = "";
            this.wNumeric.Value = 0D;
            this.wNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Height";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(80, 6);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(35, 13);
            this.xLabel.TabIndex = 41;
            this.xLabel.Text = "Width";
            // 
            // ParamSliderLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.wNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xLabel);
            this.Name = "ParamSliderLayoutControl";
            this.Size = new System.Drawing.Size(171, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KLib.Controls.KNumericBox hNumeric;
        private KLib.Controls.KNumericBox wNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xLabel;
    }
}
