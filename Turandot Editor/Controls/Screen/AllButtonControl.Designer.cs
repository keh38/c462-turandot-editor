namespace Turandot_Editor.Controls.Inputs
{
    partial class AllButtonControl
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
            this.buttonListBox = new KLib.Controls.KUserListBox();
            this.buttonControl = new Turandot_Editor.Controls.Inputs.ButtonControl();
            this.SuspendLayout();
            // 
            // buttonListBox
            // 
            this.buttonListBox.DefaultName = "Button";
            this.buttonListBox.Location = new System.Drawing.Point(3, 3);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.SelectedIndex = -1;
            this.buttonListBox.Size = new System.Drawing.Size(169, 168);
            this.buttonListBox.TabIndex = 1;
            this.buttonListBox.SelectionChanged += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.buttonListBox_SelectionChanged);
            this.buttonListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.buttonListBox_ItemAdded);
            this.buttonListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.buttonListBox_ItemRenamed);
            this.buttonListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.buttonListBox_ItemMoved);
            this.buttonListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.buttonListBox_ItemsDeleted);
            this.buttonListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.buttonListBox_ItemsMoved);
            // 
            // buttonControl
            // 
            this.buttonControl.AutoSize = true;
            this.buttonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonControl.Location = new System.Drawing.Point(178, 3);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(187, 229);
            this.buttonControl.TabIndex = 0;
            this.buttonControl.Value = null;
            // 
            // AllButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.buttonControl);
            this.Name = "AllButtonControl";
            this.Size = new System.Drawing.Size(368, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonControl buttonControl;
        private KLib.Controls.KUserListBox buttonListBox;
    }
}
