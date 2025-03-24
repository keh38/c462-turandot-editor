﻿namespace Turandot_Editor.Controls
{
    partial class AllCuesControl
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
            this.cueListBox.ItemHeight = 16;
            this.cueListBox.Location = new System.Drawing.Point(19, 51);
            this.cueListBox.Name = "cueListBox";
            this.cueListBox.Size = new System.Drawing.Size(189, 164);
            this.cueListBox.TabIndex = 0;
            this.cueListBox.SelectedIndexChanged += new System.EventHandler(this.cueListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(234, 22);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(259, 381);
            this.propertyGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cues";
            // 
            // cueDropDown
            // 
            this.cueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueDropDown.FormattingEnabled = true;
            this.cueDropDown.Location = new System.Drawing.Point(19, 259);
            this.cueDropDown.Name = "cueDropDown";
            this.cueDropDown.Size = new System.Drawing.Size(189, 24);
            this.cueDropDown.TabIndex = 3;
            this.cueDropDown.SelectedIndexChanged += new System.EventHandler(this.cueDropDown_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(19, 221);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 32);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AllCuesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cueDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.cueListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllCuesControl";
            this.Size = new System.Drawing.Size(522, 443);
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
