namespace Turandot_Editor.Controls
{
    partial class StateInputsControl
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
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDropDown = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputListBox
            // 
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 16;
            this.inputListBox.Location = new System.Drawing.Point(19, 50);
            this.inputListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(189, 164);
            this.inputListBox.TabIndex = 0;
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.inputListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(235, 22);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(397, 382);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inputs";
            // 
            // inputDropDown
            // 
            this.inputDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDropDown.FormattingEnabled = true;
            this.inputDropDown.Items.AddRange(new object[] {
            "Message"});
            this.inputDropDown.Location = new System.Drawing.Point(19, 258);
            this.inputDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDropDown.Name = "inputDropDown";
            this.inputDropDown.Size = new System.Drawing.Size(189, 24);
            this.inputDropDown.TabIndex = 3;
            this.inputDropDown.SelectedIndexChanged += new System.EventHandler(this.inputDropDown_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(19, 222);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 32);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // StateInputsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.inputDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.inputListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StateInputsControl";
            this.Size = new System.Drawing.Size(661, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputDropDown;
        private System.Windows.Forms.Button removeButton;
    }
}
