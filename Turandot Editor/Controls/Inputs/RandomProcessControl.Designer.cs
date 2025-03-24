namespace Turandot_Editor.Controls.Inputs
{
    partial class RandomProcessControl
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
            this.intervalExprBox = new KLib.Controls.KTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valuesExprBox = new KLib.Controls.KTextBox();
            this.SuspendLayout();
            // 
            // intervalExprBox
            // 
            this.intervalExprBox.AutoSize = true;
            this.intervalExprBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intervalExprBox.Location = new System.Drawing.Point(92, 3);
            this.intervalExprBox.Name = "intervalExprBox";
            this.intervalExprBox.Size = new System.Drawing.Size(191, 20);
            this.intervalExprBox.TabIndex = 0;
            this.intervalExprBox.ValueChanged += new System.EventHandler(this.intervalExprBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervals (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Values";
            // 
            // valuesExprBox
            // 
            this.valuesExprBox.AutoSize = true;
            this.valuesExprBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valuesExprBox.Location = new System.Drawing.Point(92, 29);
            this.valuesExprBox.Name = "valuesExprBox";
            this.valuesExprBox.Size = new System.Drawing.Size(191, 20);
            this.valuesExprBox.TabIndex = 2;
            this.valuesExprBox.ValueChanged += new System.EventHandler(this.valuesExprBox_ValueChanged);
            // 
            // RandomProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valuesExprBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalExprBox);
            this.Name = "RandomProcessControl";
            this.Size = new System.Drawing.Size(286, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KTextBox intervalExprBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KLib.Controls.KTextBox valuesExprBox;
    }
}
