namespace Turandot_Editor.Controls
{
    partial class InstructionEditor
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.instructionFontSizeNumeric = new KLib.Controls.KNumericBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(4, 85);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(308, 252);
            this.textBox.TabIndex = 0;
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Font size";
            // 
            // instructionFontSizeNumeric
            // 
            this.instructionFontSizeNumeric.AllowInf = false;
            this.instructionFontSizeNumeric.AutoSize = true;
            this.instructionFontSizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.instructionFontSizeNumeric.ClearOnDisable = false;
            this.instructionFontSizeNumeric.FloatValue = 0F;
            this.instructionFontSizeNumeric.IntValue = 0;
            this.instructionFontSizeNumeric.IsInteger = true;
            this.instructionFontSizeNumeric.Location = new System.Drawing.Point(4, 25);
            this.instructionFontSizeNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.instructionFontSizeNumeric.MaxCoerce = false;
            this.instructionFontSizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.instructionFontSizeNumeric.MaxValue = 100D;
            this.instructionFontSizeNumeric.MinCoerce = false;
            this.instructionFontSizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.instructionFontSizeNumeric.MinValue = 1D;
            this.instructionFontSizeNumeric.Name = "instructionFontSizeNumeric";
            this.instructionFontSizeNumeric.Size = new System.Drawing.Size(80, 20);
            this.instructionFontSizeNumeric.TabIndex = 13;
            this.instructionFontSizeNumeric.TextFormat = "K4";
            this.instructionFontSizeNumeric.ToolTip = "";
            this.instructionFontSizeNumeric.Units = "";
            this.instructionFontSizeNumeric.Value = 0D;
            this.instructionFontSizeNumeric.ValueChanged += new System.EventHandler(this.instructionFontSizeNumeric_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Markdown";
            // 
            // InstructionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.instructionFontSizeNumeric);
            this.Controls.Add(this.textBox);
            this.Name = "InstructionEditor";
            this.Size = new System.Drawing.Size(318, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label22;
        private KLib.Controls.KNumericBox instructionFontSizeNumeric;
        private System.Windows.Forms.Label label23;
    }
}
