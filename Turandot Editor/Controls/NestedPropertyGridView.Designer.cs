namespace Turandot_Editor
{
    partial class NestedPropertyGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView = new System.Windows.Forms.DataGridView();
            State = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Channel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Property = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Dim = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Expr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            expressionEditor = new Turandot_Editor.Controls.ExpressionEditor();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 21;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { State, Channel, Property, Dim, Expr });
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new System.Drawing.Point(4, 5);
            dataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.RowHeadersWidth = 20;
            dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new System.Drawing.Size(787, 312);
            dataGridView.TabIndex = 7;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            dataGridView.CellValueChanged += propGridView_CellValueChanged;
            dataGridView.CurrentCellDirtyStateChanged += dataGridView_CurrentCellDirtyStateChanged;
            dataGridView.DataError += dataGridView_DataError;
            dataGridView.UserAddedRow += dataGridView_UserAddedRow;
            dataGridView.UserDeletingRow += dataGridView_UserDeletingRow;
            dataGridView.Leave += dataGridView_Leave;
            dataGridView.MouseUp += dataGridView_MouseUp;
            // 
            // State
            // 
            State.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            State.HeaderText = "State";
            State.MinimumWidth = 6;
            State.Name = "State";
            State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            State.Width = 75;
            // 
            // Channel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            Channel.DefaultCellStyle = dataGridViewCellStyle2;
            Channel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            Channel.HeaderText = "Channel";
            Channel.MinimumWidth = 6;
            Channel.Name = "Channel";
            Channel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Channel.Width = 75;
            // 
            // Property
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            Property.DefaultCellStyle = dataGridViewCellStyle3;
            Property.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            Property.HeaderText = "Property";
            Property.Items.AddRange(new object[] { "", "true" });
            Property.MinimumWidth = 6;
            Property.Name = "Property";
            Property.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Property.Width = 150;
            // 
            // Dim
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Dim.DefaultCellStyle = dataGridViewCellStyle4;
            Dim.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            Dim.HeaderText = "Dim";
            Dim.Items.AddRange(new object[] { "X", "Y", "Ind" });
            Dim.MinimumWidth = 6;
            Dim.Name = "Dim";
            Dim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Dim.Width = 50;
            // 
            // Expr
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Expr.DefaultCellStyle = dataGridViewCellStyle5;
            Expr.HeaderText = "Expression";
            Expr.MinimumWidth = 6;
            Expr.Name = "Expr";
            Expr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Expr.Width = 200;
            // 
            // expressionEditor
            // 
            expressionEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expressionEditor.Location = new System.Drawing.Point(125, 118);
            expressionEditor.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            expressionEditor.MaximumSize = new System.Drawing.Size(766, 537);
            expressionEditor.MinimumSize = new System.Drawing.Size(266, 153);
            expressionEditor.Name = "expressionEditor";
            expressionEditor.Padding = new System.Windows.Forms.Padding(4, 0, 0, 5);
            expressionEditor.PropValPairs = null;
            expressionEditor.Sizable.Bottom = true;
            expressionEditor.Sizable.Left = true;
            expressionEditor.Sizable.Right = false;
            expressionEditor.Sizable.Top = false;
            expressionEditor.Size = new System.Drawing.Size(643, 165);
            expressionEditor.TabIndex = 8;
            expressionEditor.Value = "";
            expressionEditor.Visible = false;
            expressionEditor.XVector = null;
            expressionEditor.YVector = null;
            expressionEditor.ValueChanged += expressionEditor_ValueChanged;
            // 
            // NestedPropertyGridView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(expressionEditor);
            Controls.Add(dataGridView);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "NestedPropertyGridView";
            Size = new System.Drawing.Size(804, 322);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn State;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Property;
        private System.Windows.Forms.DataGridViewComboBoxColumn Dim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr;
        private Controls.ExpressionEditor expressionEditor;
    }
}
