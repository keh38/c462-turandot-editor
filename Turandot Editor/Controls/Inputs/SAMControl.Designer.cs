namespace Turandot_Editor.Controls
{
    partial class SAMControl
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
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(127, 3);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 0;
            this.minTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minTextBox_KeyPress);
            this.minTextBox.Leave += new System.EventHandler(this.minTextBox_Leave);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(233, 3);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 1;
            this.maxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxTextBox_KeyPress);
            this.maxTextBox.Leave += new System.EventHandler(this.maxTextBox_Leave);
            // 
            // checkBox
            // 
            this.checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox.Location = new System.Drawing.Point(2, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(119, 20);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "checkBox";
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // SAMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Name = "SAMControl";
            this.Size = new System.Drawing.Size(336, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
