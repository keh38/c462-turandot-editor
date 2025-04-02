namespace Turandot_Editor.Controls
{
    partial class ScreenInputsSpecifier
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
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Inputs";
            // 
            // inputListBox
            // 
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 16;
            this.inputListBox.Location = new System.Drawing.Point(13, 42);
            this.inputListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(180, 180);
            this.inputListBox.TabIndex = 2;
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.inputListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(213, 11);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(244, 364);
            this.propertyGrid.TabIndex = 4;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(13, 228);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(181, 30);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inputDropDown
            // 
            this.inputDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDropDown.FormattingEnabled = true;
            this.inputDropDown.Items.AddRange(new object[] {
            "Button"});
            this.inputDropDown.Location = new System.Drawing.Point(13, 262);
            this.inputDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDropDown.Name = "inputDropDown";
            this.inputDropDown.Size = new System.Drawing.Size(180, 24);
            this.inputDropDown.TabIndex = 7;
            this.inputDropDown.SelectedIndexChanged += new System.EventHandler(this.inputDropDown_SelectedIndexChanged);
            // 
            // InputLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputDropDown);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.inputListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputLayout";
            this.Size = new System.Drawing.Size(468, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox inputDropDown;
    }
}
