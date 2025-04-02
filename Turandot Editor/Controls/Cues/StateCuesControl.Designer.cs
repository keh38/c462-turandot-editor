namespace Turandot_Editor.Controls
{
    partial class StateCuesControl
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
            this.cueListBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.cueDropDown = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cueListBox
            // 
            this.cueListBox.FormattingEnabled = true;
            this.cueListBox.Location = new System.Drawing.Point(14, 41);
            this.cueListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cueListBox.Name = "cueListBox";
            this.cueListBox.Size = new System.Drawing.Size(143, 134);
            this.cueListBox.TabIndex = 0;
            this.cueListBox.SelectedIndexChanged += new System.EventHandler(this.cueListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(176, 18);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(194, 310);
            this.propertyGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cues";
            // 
            // cueDropDown
            // 
            this.cueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueDropDown.FormattingEnabled = true;
            this.cueDropDown.Items.AddRange(new object[] {
            "Message"});
            this.cueDropDown.Location = new System.Drawing.Point(14, 210);
            this.cueDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cueDropDown.Name = "cueDropDown";
            this.cueDropDown.Size = new System.Drawing.Size(143, 21);
            this.cueDropDown.TabIndex = 3;
            this.cueDropDown.SelectedIndexChanged += new System.EventHandler(this.cueDropDown_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(14, 180);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(142, 26);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AllCuesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cueDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.cueListBox);
            this.Name = "AllCuesControl";
            this.Size = new System.Drawing.Size(392, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cueListBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cueDropDown;
        private System.Windows.Forms.Button removeButton;
    }
}
