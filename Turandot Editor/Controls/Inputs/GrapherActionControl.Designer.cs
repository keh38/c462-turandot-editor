namespace Turandot_Editor.Controls.Inputs
{
    partial class GrapherActionControl
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
            this.resetCheckbox = new System.Windows.Forms.CheckBox();
            this.markCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // resetCheckbox
            // 
            this.resetCheckbox.AutoSize = true;
            this.resetCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetCheckbox.Location = new System.Drawing.Point(93, 3);
            this.resetCheckbox.Name = "resetCheckbox";
            this.resetCheckbox.Size = new System.Drawing.Size(54, 17);
            this.resetCheckbox.TabIndex = 0;
            this.resetCheckbox.Text = "Reset";
            this.resetCheckbox.UseVisualStyleBackColor = true;
            this.resetCheckbox.CheckedChanged += new System.EventHandler(this.resetCheckbox_CheckedChanged);
            // 
            // markCheckbox
            // 
            this.markCheckbox.AutoSize = true;
            this.markCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.markCheckbox.Location = new System.Drawing.Point(66, 26);
            this.markCheckbox.Name = "markCheckbox";
            this.markCheckbox.Size = new System.Drawing.Size(81, 17);
            this.markCheckbox.TabIndex = 1;
            this.markCheckbox.Text = "Mark stimuli";
            this.markCheckbox.UseVisualStyleBackColor = true;
            this.markCheckbox.CheckedChanged += new System.EventHandler(this.markCheckbox_CheckedChanged);
            // 
            // GrapherActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.markCheckbox);
            this.Controls.Add(this.resetCheckbox);
            this.Name = "GrapherActionControl";
            this.Size = new System.Drawing.Size(155, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox resetCheckbox;
        private System.Windows.Forms.CheckBox markCheckbox;
    }
}
