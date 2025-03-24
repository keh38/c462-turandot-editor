namespace Turandot_Editor.Controls
{
    partial class ExpressionEditor
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
            this.expressionBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // expressionBox
            // 
            this.expressionBox.AcceptsReturn = true;
            this.expressionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expressionBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionBox.Location = new System.Drawing.Point(6, 3);
            this.expressionBox.Name = "expressionBox";
            this.expressionBox.Size = new System.Drawing.Size(189, 20);
            this.expressionBox.TabIndex = 0;
            this.expressionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expressionBox_KeyPress);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultBox.Enabled = false;
            this.resultBox.Location = new System.Drawing.Point(6, 29);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(189, 103);
            this.resultBox.TabIndex = 1;
            // 
            // ExpressionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.expressionBox);
            this.Controls.Add(this.resultBox);
            this.MaximumSize = new System.Drawing.Size(575, 350);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "ExpressionEditor";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Sizable.Bottom = true;
            this.Sizable.Left = true;
            this.Sizable.Right = false;
            this.Sizable.Top = false;
            this.Size = new System.Drawing.Size(198, 138);
            this.Leave += new System.EventHandler(this.ExpressionEditor_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expressionBox;
        private System.Windows.Forms.TextBox resultBox;
    }
}
