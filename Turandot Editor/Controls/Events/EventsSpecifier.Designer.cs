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
            this.eventListBox.Location = new System.Drawing.Point(5, 5);
            this.eventListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.SelectedIndex = -1;
            this.eventListBox.Size = new System.Drawing.Size(225, 207);
            this.eventListBox.TabIndex = 5;
            this.eventListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemAdded);
            // 
            // inputCriteria
            // 
            this.inputCriteria.AutoSize = true;
            this.inputCriteria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputCriteria.Location = new System.Drawing.Point(19, 207);
            this.inputCriteria.Margin = new System.Windows.Forms.Padding(5);
            this.inputCriteria.Name = "inputCriteria";
            this.inputCriteria.Size = new System.Drawing.Size(538, 357);
            this.inputCriteria.TabIndex = 9;
            this.inputCriteria.Value = ((System.Collections.Generic.List<Turandot.InputCriterion>)(resources.GetObject("inputCriteria.Value")));
            this.inputCriteria.ValueChanged += new System.EventHandler(this.inputCriteria_ValueChanged);
            // 
            // flagControl
            // 
            this.flagControl.Location = new System.Drawing.Point(255, 31);
            this.flagControl.Margin = new System.Windows.Forms.Padding(5);
            this.flagControl.Name = "flagControl";
            this.flagControl.Size = new System.Drawing.Size(297, 167);
            this.flagControl.TabIndex = 8;
            this.flagControl.Value = null;
            // 
            // EventsSpecifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.inputCriteria);
            this.Controls.Add(this.flagControl);
            this.Controls.Add(this.eventListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventsSpecifier";
            this.Size = new System.Drawing.Size(562, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KUserListBox eventListBox;
        private FlagControl flagControl;
        private InputCriteria inputCriteria;
    }
}
