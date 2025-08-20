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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenInputsSpecifier));
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.inputListBox = new KLib.Controls.CollectionListBox();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(209, 25);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(244, 364);
            this.propertyGrid.TabIndex = 4;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // inputListBox
            // 
            this.inputListBox.AddDropDownItems = ((System.ComponentModel.BindingList<string>)(resources.GetObject("inputListBox.AddDropDownItems")));
            this.inputListBox.AutoSize = true;
            this.inputListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputListBox.Collection = null;
            this.inputListBox.CreateNewItem = null;
            this.inputListBox.GetDisplayText = null;
            this.inputListBox.ListTitle = "Inputs";
            this.inputListBox.Location = new System.Drawing.Point(3, 3);
            this.inputListBox.MinimumSize = new System.Drawing.Size(200, 225);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.ShowAddDropDown = true;
            this.inputListBox.Size = new System.Drawing.Size(200, 272);
            this.inputListBox.TabIndex = 5;
            this.inputListBox.ItemRenamed += new System.EventHandler<KLib.Controls.CollectionListBox.RenamedItem>(this.inputListBox_ItemRenamed);
            this.inputListBox.ItemAdded += new System.EventHandler<KLib.Controls.CollectionListBox.ChangedItem>(this.inputListBox_ItemAdded);
            this.inputListBox.ItemRemoved += new System.EventHandler<KLib.Controls.CollectionListBox.ChangedItem>(this.inputListBox_ItemRemoved);
            // 
            // ScreenInputsSpecifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputListBox);
            this.Controls.Add(this.propertyGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScreenInputsSpecifier";
            this.Size = new System.Drawing.Size(468, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private KLib.Controls.CollectionListBox inputListBox;
    }
}
