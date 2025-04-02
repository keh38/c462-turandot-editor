namespace Turandot_Editor.Controls
{
    partial class ScreenCuesSpecifier
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
            this.label21 = new System.Windows.Forms.Label();
            this.cueListBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.removeButton = new System.Windows.Forms.Button();
            this.cueDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Cues";
            // 
            // cueListBox
            // 
            this.cueListBox.FormattingEnabled = true;
            this.cueListBox.Location = new System.Drawing.Point(10, 34);
            this.cueListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cueListBox.Name = "cueListBox";
            this.cueListBox.Size = new System.Drawing.Size(136, 147);
            this.cueListBox.TabIndex = 2;
            this.cueListBox.SelectedIndexChanged += new System.EventHandler(this.cueListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(160, 9);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(183, 296);
            this.propertyGrid.TabIndex = 4;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 185);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(136, 24);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cueDropDown
            // 
            this.cueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueDropDown.FormattingEnabled = true;
            this.cueDropDown.Items.AddRange(new object[] {
            "Message"});
            this.cueDropDown.Location = new System.Drawing.Point(10, 213);
            this.cueDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.cueDropDown.Name = "cueDropDown";
            this.cueDropDown.Size = new System.Drawing.Size(136, 21);
            this.cueDropDown.TabIndex = 7;
            this.cueDropDown.SelectedIndexChanged += new System.EventHandler(this.cueDropDown_SelectedIndexChanged);
            // 
            // CuesSpecifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cueDropDown);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cueListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CuesSpecifier";
            this.Size = new System.Drawing.Size(351, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox cueListBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox cueDropDown;
    }
}
