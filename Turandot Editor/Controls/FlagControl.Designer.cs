namespace Turandot_Editor.Controls
{
    partial class FlagControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flagGridView = new System.Windows.Forms.DataGridView();
            this.FlagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlagDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flagGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flagGridView
            // 
            this.flagGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flagGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlagName,
            this.FlagDefault});
            this.flagGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flagGridView.Location = new System.Drawing.Point(0, 0);
            this.flagGridView.Name = "flagGridView";
            this.flagGridView.RowHeadersWidth = 21;
            this.flagGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.flagGridView.Size = new System.Drawing.Size(223, 112);
            this.flagGridView.TabIndex = 6;
            this.flagGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.flagGridView_CellValueChanged);
            this.flagGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.flagGridView_EditingControlShowing);
            this.flagGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.flagGridView_UserAddedRow);
            this.flagGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.flagGridView_UserDeletingRow);
            // 
            // FlagName
            // 
            this.FlagName.HeaderText = "Name";
            this.FlagName.Name = "FlagName";
            // 
            // FlagDefault
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FlagDefault.DefaultCellStyle = dataGridViewCellStyle2;
            this.FlagDefault.HeaderText = "Default";
            this.FlagDefault.Name = "FlagDefault";
            // 
            // FlagControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flagGridView);
            this.Name = "FlagControl";
            this.Size = new System.Drawing.Size(223, 112);
            ((System.ComponentModel.ISupportInitialize)(this.flagGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flagGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagDefault;
    }
}
