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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCuesSpecifier));
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.cueListBox = new KLib.Controls.CollectionListBox();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(229, 27);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(244, 364);
            this.propertyGrid.TabIndex = 4;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // cueListBox
            // 
            this.cueListBox.AddDropDownItems = ((System.ComponentModel.BindingList<string>)(resources.GetObject("cueListBox.AddDropDownItems")));
            this.cueListBox.AutoSize = true;
            this.cueListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cueListBox.Collection = null;
            this.cueListBox.CreateNewItem = null;
            this.cueListBox.GetDisplayText = null;
            this.cueListBox.ListTitle = "Cues";
            this.cueListBox.Location = new System.Drawing.Point(3, 2);
            this.cueListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cueListBox.MinimumSize = new System.Drawing.Size(200, 225);
            this.cueListBox.Name = "cueListBox";
            this.cueListBox.ShowAddDropDown = true;
            this.cueListBox.Size = new System.Drawing.Size(220, 272);
            this.cueListBox.TabIndex = 8;
            // 
            // ScreenCuesSpecifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cueListBox);
            this.Controls.Add(this.propertyGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScreenCuesSpecifier";
            this.Size = new System.Drawing.Size(485, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private KLib.Controls.CollectionListBox cueListBox;
    }
}
