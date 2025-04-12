namespace Turandot_Editor.Controls.Events
{
    partial class EventsSpecifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsSpecifier));
            this.eventListBox = new KLib.Controls.KUserListBox();
            this.inputCriteria = new Turandot_Editor.InputCriteria();
            this.flagControl = new Turandot_Editor.Controls.FlagControl();
            this.SuspendLayout();
            // 
            // eventListBox
            // 
            this.eventListBox.DefaultName = "Event";
            this.eventListBox.Location = new System.Drawing.Point(4, 4);
            this.eventListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.SelectedIndex = -1;
            this.eventListBox.Size = new System.Drawing.Size(169, 168);
            this.eventListBox.TabIndex = 5;
            this.eventListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemAdded);
            this.eventListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemRenamed);
            this.eventListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemMoved);
            this.eventListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsDeleted);
            this.eventListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsMoved);
            // 
            // inputCriteria
            // 
            this.inputCriteria.AutoSize = true;
            this.inputCriteria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputCriteria.Location = new System.Drawing.Point(14, 168);
            this.inputCriteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputCriteria.Name = "inputCriteria";
            this.inputCriteria.Size = new System.Drawing.Size(403, 289);
            this.inputCriteria.TabIndex = 9;
            this.inputCriteria.Value = ((System.Collections.Generic.List<Turandot.InputCriterion>)(resources.GetObject("inputCriteria.Value")));
            this.inputCriteria.ValueChanged += new System.EventHandler(this.inputCriteria_ValueChanged);
            // 
            // flagControl
            // 
            this.flagControl.Location = new System.Drawing.Point(191, 25);
            this.flagControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flagControl.Name = "flagControl";
            this.flagControl.Size = new System.Drawing.Size(223, 136);
            this.flagControl.TabIndex = 8;
            this.flagControl.Value = null;
            // 
            // EventsSpecifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.inputCriteria);
            this.Controls.Add(this.flagControl);
            this.Controls.Add(this.eventListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventsSpecifier";
            this.Size = new System.Drawing.Size(421, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KUserListBox eventListBox;
        private FlagControl flagControl;
        private InputCriteria inputCriteria;
    }
}
