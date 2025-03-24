namespace Turandot_Editor
{
    partial class InputCriteria
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
            this.inputCriterion = new Turandot_Editor.InputCriterionControl();
            this.SuspendLayout();
            // 
            // inputCriterion
            // 
            this.inputCriterion.AutoSize = true;
            this.inputCriterion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputCriterion.Location = new System.Drawing.Point(3, 3);
            this.inputCriterion.Name = "inputCriterion";
            this.inputCriterion.Size = new System.Drawing.Size(404, 24);
            this.inputCriterion.TabIndex = 0;
            this.inputCriterion.ValueChanged += new System.EventHandler(this.inputCriterion_ValueChanged);
            this.inputCriterion.RowBecameValid += new System.EventHandler(this.inputCriterion_RowBecameValid);
            this.inputCriterion.OperatorChanged += new System.EventHandler<InputCriterionControl.OperatorChangedArgs>(this.inputCriterion_OperatorChanged);
            // 
            // InputCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.inputCriterion);
            this.Name = "InputCriteria";
            this.Size = new System.Drawing.Size(410, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputCriterionControl inputCriterion;
    }
}
