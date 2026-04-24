using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Versioning;

using KLib;
using KLib.Controls;

using Turandot;
using Turandot.Schedules;

using KLib.Expressions;

namespace Turandot_Editor
{
    [SupportedOSPlatform("windows")]
    public partial class NestedPropertyGridView : KUserControl
    {
        private List<Variable> _varList = null;
        private EditorParameters _params;
        private bool _showDim = true;
        private bool _showExpr = true;
        private DataGridViewCell _exprCell = null;
        private List<Expressions.PropVal> _propVals = null;

        public static List<Variable> Clipboard = new List<Variable>();

        public NestedPropertyGridView()
        {
            InitializeComponent();
        }

        // -----------------------------------------------------------------------
        // Public API
        // -----------------------------------------------------------------------

        public List<Variable> Value
        {
            get => _varList;
            set
            {
                _varList = value;
                ShowFamily(_varList);
            }
        }

        public void SetDataForContext(EditorParameters par)
        {
            _varList = null;
            _params = par;
            UpdateAvailableStates();
        }

        public void SetPropValPairs(List<Expressions.PropVal> propVals)
        {
            _propVals = propVals;
        }

        public bool ShowDim
        {
            get => _showDim;
            set
            {
                _showDim = value;
                dataGridView.Columns["Dim"].Visible = _showDim;
            }
        }

        public bool AllowUserToDeleteRows
        {
            get => dataGridView.AllowUserToDeleteRows;
            set => dataGridView.AllowUserToDeleteRows = value;
        }

        public int MaxNumberRows { get; set; }

        public bool ShowExpr
        {
            get => _showExpr;
            set
            {
                _showExpr = value;
                dataGridView.Columns["Expr"].Visible = _showExpr;
            }
        }

        public void UpdateAvailableStates()
        {
            var stateList = _params.GetStateNames();

            dataGridView.Rows.Clear();

            var col = dataGridView.Columns["State"] as DataGridViewComboBoxColumn;
            col.Items.Clear();
            col.Items.AddRange(stateList.ToArray());

            if (_varList != null && _varList.Count > 0) Debug.WriteLine(_varList[0].state);

            ShowFamily(_varList);
        }

        // -----------------------------------------------------------------------
        // Display
        // -----------------------------------------------------------------------

        private void ShowFamily(List<Variable> vlist)
        {
            if (vlist == null) return;

            _ignoreEvents = true;
            dataGridView.Rows.Clear();
            foreach (var v in vlist) AddFamilyRow(v);

            // The empty new-row placeholder should start with only State editable,
            // so the user is forced to fill in the hierarchy top-down.
            if (dataGridView.AllowUserToAddRows)
                LockNewRowPlaceholder();

            _ignoreEvents = false;
        }

        private void AddFamilyRow(Variable v)
        {
            int rowIndex = dataGridView.Rows.Add();
            var cells = dataGridView.Rows[rowIndex].Cells;

            // Populate channel dropdown for this state
            var chanCell = (DataGridViewComboBoxCell)cells["Channel"];
            chanCell.Items.AddRange(_params.GetChannelNames(v.state).ToArray());

            // Populate property dropdown for this state+channel (if channel is set)
            if (!string.IsNullOrEmpty(v.chan))
            {
                var propCell = (DataGridViewComboBoxCell)cells["Property"];
                propCell.Items.AddRange(_params.GetChannelProperties(v.state, v.chan).ToArray());
            }

            cells["State"].Value = v.state;
            cells["Channel"].Value = v.chan;
            cells["Property"].Value = v.property;
            cells["Dim"].Value = v.dim.ToString();
            cells["Expr"].Value = v.expression;

            dataGridView.AllowUserToAddRows = MaxNumberRows == 0 || dataGridView.Rows.Count < MaxNumberRows;

            RefreshRowEditability(rowIndex);
        }

        // -----------------------------------------------------------------------
        // Row editability
        // -----------------------------------------------------------------------

        /// <summary>
        /// Enables cells in the row based on how far the user has filled in the hierarchy.
        /// State is always editable. Channel requires State. Property / Dim / Expr require Channel.
        /// </summary>
        private void RefreshRowEditability(int rowIndex)
        {
            if (rowIndex < 0 || _varList == null || rowIndex >= _varList.Count) return;

            var v = _varList[rowIndex];
            var cells = dataGridView.Rows[rowIndex].Cells;

            bool hasState = !string.IsNullOrEmpty(v.state);
            bool hasChannel = !string.IsNullOrEmpty(v.chan);

            cells["Channel"].ReadOnly = !hasState;
            cells["Property"].ReadOnly = !hasChannel;
            cells["Dim"].ReadOnly = !hasChannel;
            cells["Expr"].ReadOnly = !hasChannel;
        }

        /// <summary>
        /// Disables all cells except State on the DataGridView's new-row placeholder row.
        /// </summary>
        private void LockNewRowPlaceholder()
        {
            // AllowUserToAddRows keeps a blank row at the end that has no backing variable.
            int placeholderIndex = dataGridView.Rows.Count - 1;
            if (placeholderIndex < 0) return;

            var cells = dataGridView.Rows[placeholderIndex].Cells;
            cells["Channel"].ReadOnly = true;
            cells["Property"].ReadOnly = true;
            cells["Dim"].ReadOnly = true;
            cells["Expr"].ReadOnly = true;
        }

        // -----------------------------------------------------------------------
        // Cascade updates — preserve downstream selections when still valid
        // -----------------------------------------------------------------------

        /// <summary>
        /// Called after the State value changes on an existing row.
        /// Refreshes the Channel dropdown. If the previously selected channel still
        /// exists in the new state's channel list it is preserved and the cascade
        /// continues into <see cref="CascadeFromChannel"/>; otherwise channel,
        /// property, and expression are cleared.
        /// </summary>
        private void CascadeFromState(int rowIndex)
        {
            var v = _varList[rowIndex];
            var cells = dataGridView.Rows[rowIndex].Cells;

            var chanCell = (DataGridViewComboBoxCell)cells["Channel"];
            chanCell.Items.Clear();
            var channelNames = _params.GetChannelNames(v.state);
            chanCell.Items.AddRange(channelNames.ToArray());

            if (!channelNames.Contains(v.chan))
            {
                // Previous channel is no longer valid — clear everything downstream.
                v.chan = "";
                v.property = "";
                v.expression = "";
                cells["Channel"].Value = null;
                cells["Property"].Value = null;
                cells["Expr"].Value = null;
            }
            // If the channel is still valid, leave Channel / Property / Expr cells
            // as they are and let CascadeFromChannel re-validate the property.

            CascadeFromChannel(rowIndex);
        }

        /// <summary>
        /// Called after the Channel value changes (or after <see cref="CascadeFromState"/>).
        /// Refreshes the Property dropdown. Auto-selects if only one option is available.
        /// Preserves the existing property if it remains valid; clears it otherwise.
        /// </summary>
        private void CascadeFromChannel(int rowIndex)
        {
            var v = _varList[rowIndex];
            var cells = dataGridView.Rows[rowIndex].Cells;

            var propCell = (DataGridViewComboBoxCell)cells["Property"];
            propCell.Items.Clear();

            if (string.IsNullOrEmpty(v.chan))
            {
                RefreshRowEditability(rowIndex);
                return;
            }

            var props = _params.GetChannelProperties(v.state, v.chan);
            propCell.Items.AddRange(props.ToArray());

            if (props.Count == 1)
            {
                // Only one option — auto-select it.
                v.property = props[0];
                propCell.Value = props[0];
            }
            else if (props.Contains(v.property))
            {
                // Existing selection is still valid — keep it.
                propCell.Value = v.property;
            }
            else
            {
                // Previous property is no longer valid.
                v.property = "";
                propCell.Value = null;
            }

            RefreshRowEditability(rowIndex);
        }

        // -----------------------------------------------------------------------
        // Event handlers — grid
        // -----------------------------------------------------------------------

        private void propGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_ignoreEvents || _varList == null || e.RowIndex < 0) return;

            int rowIndex = e.RowIndex;
            var cells = dataGridView.Rows[rowIndex].Cells;
            string columnName = dataGridView.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "State":
                    if (rowIndex == _varList.Count)
                    {
                        // User filled in the new-row placeholder — create the backing variable.
                        if (MaxNumberRows == 0 || dataGridView.Rows.Count <= MaxNumberRows)
                            AddNewVariable(rowIndex);
                    }
                    else
                    {
                        _varList[rowIndex].state = cells["State"].Value as string;
                    }
                    _ignoreEvents = true;
                    CascadeFromState(rowIndex);
                    _ignoreEvents = false;
                    break;

                case "Channel":
                    _varList[rowIndex].chan = cells["Channel"].Value as string;
                    _ignoreEvents = true;
                    CascadeFromChannel(rowIndex);
                    _ignoreEvents = false;
                    break;

                case "Property":
                    _varList[rowIndex].property = cells["Property"].Value as string;
                    RefreshRowEditability(rowIndex);
                    break;

                case "Dim":
                    _varList[rowIndex].dim = ParseDimension(cells["Dim"].Value as string);
                    break;

                case "Expr":
                    _varList[rowIndex].expression = cells["Expr"].Value as string;
                    TestExpression(cells["Expr"]);
                    break;

                default:
                    return; // Unknown column — don't fire OnValueChanged.
            }

            OnValueChanged();
        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Commit combo-box selections immediately so CellValueChanged fires
            // before the user moves to the next cell.
            if (!_ignoreEvents && dataGridView.CurrentCell.ColumnIndex < 3 && dataGridView.IsCurrentCellDirty)
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!_ignoreEvents)
            {
                _varList.RemoveAt(e.Row.Index);
                OnValueChanged();
            }
        }

        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MaxNumberRows > 0 && dataGridView.Rows != null)
                dataGridView.AllowUserToAddRows = dataGridView.Rows.Count < MaxNumberRows;
        }

        private void dataGridView_Leave(object sender, EventArgs e)
        {
            // The expression editor is a popup that legitimately steals focus from
            // the grid while a row is still being filled in. Don't treat that as
            // the user abandoning the row.
            if (expressionEditor.Visible) return;

            if (_varList == null) return;

            var incomplete = _varList
                .Where(v => string.IsNullOrEmpty(v.state)
                         || string.IsNullOrEmpty(v.chan)
                         || string.IsNullOrEmpty(v.property)
                         || string.IsNullOrEmpty(v.expression))
                .ToList();

            if (incomplete.Count > 0)
            {
                foreach (var v in incomplete) _varList.Remove(v);
                ShowFamily(_varList);
            }
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress DataGridView's built-in error dialog for combo box validation.
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly) return;

            string colName = dataGridView.Columns[e.ColumnIndex].Name;
            if (colName != "State" && colName != "Channel" && colName != "Property" && colName != "Dim")
                return;

            dataGridView.BeginEdit(true);

            if (dataGridView.EditingControl is ComboBox combo)
                combo.DroppedDown = true;
        }

        // -----------------------------------------------------------------------
        // Helpers
        // -----------------------------------------------------------------------

        private void AddNewVariable(int rowIndex)
        {
            string stateName = dataGridView.Rows[rowIndex].Cells["State"].Value as string;
            var v = new Variable { state = stateName };
            _varList.Add(v);

            // Populate the Dim cell with the default without re-triggering the handler.
            _ignoreEvents = true;
            dataGridView.Rows[rowIndex].Cells["Dim"].Value = v.dim.ToString();
            _ignoreEvents = false;
        }

        private static VarDimension ParseDimension(string value)
        {
            var names = Enum.GetNames(typeof(VarDimension)).ToList();
            int index = names.IndexOf(value);
            return index >= 0 ? (VarDimension)index : default;
        }

        // -----------------------------------------------------------------------
        // Expression testing
        // -----------------------------------------------------------------------

        private void TestExpression(DataGridViewCell cell)
        {
            try
            {
                string xvector = "";
                string yvector = "";
                for (int k = 0; k < _varList.Count; k++)
                {
                    if (string.IsNullOrEmpty(xvector) && _varList[k].dim == VarDimension.X)
                    {
                        float[] xvec = Expressions.Evaluate(_varList[k].expression);
                        xvector = Expressions.ToVectorString(xvec);
                    }

                    if (k != cell.RowIndex && string.IsNullOrEmpty(yvector) && _varList[k].dim == VarDimension.Y)
                    {
                        string yexpr = _varList[k].expression;
                        if (yexpr.Contains("X") && !string.IsNullOrEmpty(xvector))
                            yexpr = yexpr.Replace("X", xvector);
                        float[] yvec = Expressions.Evaluate(yexpr);
                        yvector = Expressions.ToVectorString(yvec);
                    }
                }

                string expr = cell.Value as string;
                if (expr.Contains("X") && !string.IsNullOrEmpty(xvector)) expr = expr.Replace("X", xvector);
                if (expr.Contains("Y") && !string.IsNullOrEmpty(yvector)) expr = expr.Replace("Y", yvector);

                cell.ErrorText = Expressions.TryEvaluate(expr, _propVals) ? "" : Expressions.LastError;
            }
            catch (Exception ex)
            {
                cell.ErrorText = ex.Message;
            }
        }

        // -----------------------------------------------------------------------
        // Context menu
        // -----------------------------------------------------------------------

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var cms = BuildContextMenu();
                if (cms.Items.Count > 0) cms.Show(this, e.Location);
            }
        }

        private ContextMenuStrip BuildContextMenu()
        {
            var cms = new ContextMenuStrip();

            if (Clipboard.Count > 0)
            {
                cms.Items.Add(MakeMenuItem("Paste", pasteClick));
                if (_varList.Count > 0) cms.Items.Add(new ToolStripSeparator());
            }

            if (_varList.Count > 1)
            {
                cms.Items.Add(MakeMenuItem("Sort", sortClick));
                cms.Items.Add(new ToolStripSeparator());
            }

            if (_varList.Count > 0)
            {
                cms.Items.Add(MakeMenuItem("Delete selected row(s)", deleteRowClick));
                cms.Items.Add(MakeMenuItem("Duplicate selected row(s)", duplicateRowClick));
                cms.Items.Add(MakeMenuItem("Copy selected row(s)", copyRowClick));
                cms.Items.Add(new ToolStripSeparator());
                cms.Items.Add(MakeMenuItem("Copy table", copyTableClick));
                cms.Items.Add(MakeMenuItem("Clear table", clearTableClick));
            }

            return cms;
        }

        private static ToolStripMenuItem MakeMenuItem(string text, EventHandler handler)
        {
            var mi = new ToolStripMenuItem { Text = text };
            mi.Click += handler;
            return mi;
        }

        void deleteRowClick(object sender, EventArgs e)
        {
            var toDelete = dataGridView.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => _varList[r.Index])
                .ToList();

            foreach (var v in toDelete) _varList.Remove(v);
            foreach (DataGridViewRow row in dataGridView.SelectedRows) dataGridView.Rows.Remove(row);

            OnValueChanged();
        }

        void duplicateRowClick(object sender, EventArgs e)
        {
            var copies = dataGridView.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => new Variable(_varList[r.Index]))
                .ToList();

            foreach (var v in copies) _varList.Add(v);
            ShowFamily(_varList);
            OnValueChanged();
        }

        void copyRowClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                Clipboard.Add(new Variable(_varList[row.Index]));
        }

        void copyTableClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            foreach (var v in _varList) Clipboard.Add(new Variable(v));
        }

        void clearTableClick(object sender, EventArgs e)
        {
            _varList.Clear();
            ShowFamily(_varList);
            OnValueChanged();
        }

        void pasteClick(object sender, EventArgs e)
        {
            foreach (var v in Clipboard) _varList.Add(new Variable(v));
            ShowFamily(_varList);
            OnValueChanged();
        }

        void sortClick(object sender, EventArgs e)
        {
            var snapshot = _varList.Select(v => new Variable(v)).ToList();
            _varList.Clear();
            foreach (var v in snapshot.Where(v => v.dim == VarDimension.X)) _varList.Add(v);
            foreach (var v in snapshot.Where(v => v.dim == VarDimension.Y)) _varList.Add(v);
            foreach (var v in snapshot.Where(v => v.dim == VarDimension.Ind)) _varList.Add(v);

            ShowFamily(_varList);
            OnValueChanged();
        }

        // -----------------------------------------------------------------------
        // Expression editor popup
        // -----------------------------------------------------------------------

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > _varList.Count - 1 || dataGridView.Columns[e.ColumnIndex].Name != "Expr") return;

            _exprCell = dataGridView.Rows[e.RowIndex].Cells["Expr"];

            Rectangle r = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            expressionEditor.Top = r.Top;
            expressionEditor.Left = r.Right - expressionEditor.Width;

            string xvector = "";
            string yvector = "";
            for (int k = 0; k < e.RowIndex; k++)
            {
                if (string.IsNullOrEmpty(xvector) && _varList[k].dim == VarDimension.X)
                {
                    xvector = Expressions.ToVectorString(Expressions.Evaluate(_varList[k].expression));
                }
                if (string.IsNullOrEmpty(yvector) && _varList[k].dim == VarDimension.Y)
                {
                    yvector = Expressions.ToVectorString(Expressions.Evaluate(_varList[k].expression));
                }
            }

            expressionEditor.XVector = xvector;
            expressionEditor.YVector = yvector;
            expressionEditor.Value = _varList[e.RowIndex].expression;
            expressionEditor.Visible = true;
            expressionEditor.Focus();
        }

        private void expressionEditor_ValueChanged(object sender, EventArgs e)
        {
            if (_exprCell.RowIndex < 0) return;

            _varList[_exprCell.RowIndex].expression = expressionEditor.Value;

            _ignoreEvents = true;
            _exprCell.Value = expressionEditor.Value;
            _ignoreEvents = false;

            expressionEditor.Visible = false;
            TestExpression(_exprCell);
            OnValueChanged();
        }
    }
}
