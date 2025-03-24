extern alias KLibUnity;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib;
using KLib.Controls;

using Expressions = KLibUnity.KLib.Expressions;

using Turandot;
using Turandot.Schedules;

namespace Turandot_Editor
{
    public partial class NestedPropertyGridView : KUserControl
    {
        List<Variable> _varList = null;
        EditorParameters _params;
        bool _showDim = true;
        bool _showExpr = true;
        DataGridViewCell _exprCell = null;
        List<Expressions.PropVal> _propVals = null;

        public static List<Variable> Clipboard = new List<Variable>();

        public NestedPropertyGridView()
        {
            InitializeComponent();
        }

        public List<Variable> Value
        {
            get { return _varList; }
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
            get { return _showDim; }
            set
            {
                _showDim = value;
                dataGridView.Columns["Dim"].Visible = _showDim;
            }
        }

        public bool AllowUserToDeleteRows
        {
            get { return dataGridView.AllowUserToDeleteRows; }
            set { dataGridView.AllowUserToDeleteRows = value; }
        }

        public int MaxNumberRows { get; set; }

        public bool ShowExpr
        {
            get { return _showExpr; }
            set
            {
                _showExpr = value;
                dataGridView.Columns["Expr"].Visible = _showExpr;
            }
        }

        public void UpdateAvailableStates()
        {
            List<string> stateList = _params.GetStateNames();

            dataGridView.Rows.Clear();

            DataGridViewComboBoxColumn col = dataGridView.Columns["State"] as DataGridViewComboBoxColumn;
            col.Items.Clear();
            col.Items.AddRange(stateList.ToArray());

            if (_varList!=null && _varList.Count > 0) Debug.WriteLine(_varList[0].state);

            ShowFamily(_varList);
        }

        private void ShowFamily(List<Variable> vlist)
        {
            if (vlist == null) return;

            _ignoreEvents = true;

            dataGridView.Rows.Clear();
            foreach (Variable v in vlist) AddFamilyRow(v);

            if (MaxNumberRows == 0) DisableCells(dataGridView.RowCount - 1, 1);

            _ignoreEvents = false;
        }

        private void DisableCells(int rowIndex, int from)
        {
            if (rowIndex >= 0)
            {
                for (int k = 1; k < 5; k++) dataGridView.Rows[rowIndex].Cells[k].ReadOnly = k >= from;
            }
        }

        private void propGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_ignoreEvents && _varList != null)
            {
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                var cells = dataGridView.Rows[rowIndex].Cells;
                string state = cells[0].Value as string;

                if (dataGridView.CurrentCell.ColumnIndex == 0)
                {
                    if (dataGridView.CurrentCell.RowIndex == _varList.Count && (MaxNumberRows==0 || dataGridView.Rows.Count < MaxNumberRows))
                    {
                        AddNewVariable();
                        DisableCells(rowIndex, 2);
                    }
                    else
                    {
                        _varList[rowIndex].state = cells["State"].Value as string;
                        DisableCells(rowIndex, 2);
                    }
                    _ignoreEvents = true;
                    UpdateStateSelection(rowIndex, state); 
                    _ignoreEvents = false;
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 1)
                {
                    _varList[rowIndex].chan = cells["Channel"].Value as string;
                    _ignoreEvents = true;
                    DisableCells(rowIndex, 10);
                    UpdateChannelSelection(rowIndex);
                    _ignoreEvents = false;
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 2)
                { 
                    _varList[rowIndex].property = cells["Property"].Value as string;
                    DisableCells(rowIndex, 10);
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 3)
                {
                    _varList[rowIndex].dim = (VarDimension) Enum.GetNames(typeof(VarDimension)).ToList().IndexOf(cells["Dim"].Value as string);
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 4)
                {
                    _varList[rowIndex].expression = cells["Expr"].Value as string;
                    TestExpression(cells["Expr"]);
                }
                OnValueChanged();
            }
        }

        private void TestExpression(DataGridViewCell cell)
        {
            string xvector = "";
            string yvector = "";
            for (int k=0; k<_varList.Count;k++)
            {
                //if (k != cell.RowIndex && _varList[k].dim == VarDimension.X && string.IsNullOrEmpty(xvector))
                if (string.IsNullOrEmpty(xvector) && _varList[k].dim == VarDimension.X)
                {
                    float[] xvec = Expressions.Evaluate(_varList[k].expression);
                    xvector = Expressions.ToVectorString(xvec);
                }

                if (k != cell.RowIndex && _varList[k].dim == VarDimension.Y && string.IsNullOrEmpty(yvector))
                {
                    string yexpr = _varList[k].expression;
                    if (yexpr.Contains("X") && !string.IsNullOrEmpty(xvector)) yexpr = yexpr.Replace("X", xvector);

                    float[] yvec = Expressions.Evaluate(yexpr);
                    yvector = Expressions.ToVectorString(yvec);
                }
            }

            string expr = cell.Value as string;
            if (expr.Contains("X") && !string.IsNullOrEmpty(xvector)) expr = expr.Replace("X", xvector);
            if (expr.Contains("Y") && !string.IsNullOrEmpty(yvector)) expr = expr.Replace("Y", yvector);

            if (!Expressions.TryEvaluate(expr, _propVals))
            {
                cell.ErrorText = Expressions.LastError;
            }
            else cell.ErrorText = "";
        }

        private void UpdateStateSelection(int rowIndex, string stateName)
        {
            dataGridView.Rows[rowIndex].Cells["Channel"].Value = null;
            dataGridView.Rows[rowIndex].Cells["Property"].Value = null;
            dataGridView.Rows[rowIndex].Cells["Expr"].Value = null;

            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dataGridView.Rows[rowIndex].Cells[1];
            cbCell.Items.Clear();
            cbCell.Items.AddRange(_params.GetChannelNames(stateName).ToArray());

            _varList[rowIndex].chan = "";
            _varList[rowIndex].property = "";
            _varList[rowIndex].expression = "";
        }

        private void UpdateChannelSelection(int rowIndex)
        {
            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dataGridView.Rows[rowIndex].Cells[2];
            cbCell.Value = null;
            cbCell.Items.Clear();

            List<string> props = _params.GetChannelProperties(_varList[rowIndex].state, _varList[rowIndex].chan);
            cbCell.Items.AddRange(props.ToArray());

            if (props.Count == 1)
            {
                cbCell.Value = props[0];
                _varList[rowIndex].property = props[0];
                DisableCells(rowIndex, 10);
            }
            else if (props.Contains(_varList[rowIndex].property)) cbCell.Value = _varList[rowIndex].property;
        }

        private void AddNewVariable()
        {
            var cells = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells;

            Variable v = new Variable();
            v.state = cells["State"].Value as string;

            _ignoreEvents = true;
            cells["Dim"].Value = v.dim.ToString();
            _ignoreEvents = false;

            _varList.Add(v);
        }

        private void AddFamilyRow(Variable v)
        {
            int rowIndex = dataGridView.Rows.Add();
            var cells = dataGridView.Rows[rowIndex].Cells;

            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)cells["Channel"];
            cbCell.Items.Clear();
            cbCell.Items.AddRange(_params.GetChannelNames(v.state).ToArray());

            UpdateChannelSelection(rowIndex);

            cells["State"].Value = v.state;
            cells["Channel"].Value = v.chan;
            cells["Property"].Value = v.property;
            cells["Dim"].Value = v.dim.ToString();
            cells["Expr"].Value = v.expression;

            dataGridView.AllowUserToAddRows = MaxNumberRows == 0 || dataGridView.Rows.Count < MaxNumberRows;

            DisableCells(rowIndex, 10);
        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && dataGridView.CurrentCell.ColumnIndex<3 && dataGridView.IsCurrentCellDirty)
            {
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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
            if (MaxNumberRows > 0 && dataGridView.Rows != null) dataGridView.AllowUserToAddRows = dataGridView.Rows.Count < MaxNumberRows;
        }

        private void dataGridView_Leave(object sender, EventArgs e)
        {
            if (_varList == null) return;

            List<Variable> toDelete = new List<Variable>();
            foreach (Variable v in _varList)
            {
                if (string.IsNullOrEmpty(v.state) ||
                    string.IsNullOrEmpty(v.chan) ||
                    string.IsNullOrEmpty(v.property) ||
                    string.IsNullOrEmpty(v.expression))
                {
                    toDelete.Add(v);
                }
            }
            foreach (Variable v in toDelete) _varList.Remove(v);
            if (toDelete.Count > 0) ShowFamily(_varList);
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = BuildContextMenu(e.Location);
                cm.Show(this, e.Location);
            }
        }

        private ContextMenu BuildContextMenu(Point point)
        {
            var cm = new ContextMenu();

            MenuItem mi;

            if (Clipboard.Count > 0)
            {
                mi = new MenuItem();
                mi.Text = "Paste";
                mi.Click += pasteClick;
                cm.MenuItems.Add(mi);

                if (_varList.Count > 0)
                {
                    mi = new MenuItem();
                    mi.Text = "-";
                    cm.MenuItems.Add(mi);
                }
            }

            if (_varList.Count > 1)
            {
                mi = new MenuItem();
                mi.Text = "Sort";
                mi.Click += sortClick;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "-";
                cm.MenuItems.Add(mi);
            }

            if (_varList.Count > 0)
            {
                mi = new MenuItem();
                mi.Text = "Delete selected row(s)";
                mi.Click += deleteRowClick;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "Duplicate selected row(s)";
                mi.Click += duplicateRowClick;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "Copy selected row(s)";
                mi.Click += copyRowClick;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "-";
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "Copy table";
                mi.Click += copyTableClick;
                cm.MenuItems.Add(mi);

                mi = new MenuItem();
                mi.Text = "Clear table";
                mi.Click += clearTableClick;
                cm.MenuItems.Add(mi);
            }

            return cm;
        }

        void deleteRowClick(object sender, EventArgs e)
        {
            List<Variable> toDelete = new List<Variable>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                toDelete.Add(_varList[row.Index]);

            foreach (Variable v in toDelete) _varList.Remove(v);

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                dataGridView.Rows.Remove(row);

            OnValueChanged();
        }

        void duplicateRowClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                _varList.Add(new Variable(_varList[row.Index]));
            }
            ShowFamily(_varList);

            OnValueChanged();
        }

        void copyRowClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                Variable v = new Variable(_varList[row.Index]);
                Clipboard.Add(v);
            }
        }

        void copyTableClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            foreach (Variable v in _varList)
            {
                Clipboard.Add(new Variable(v));
            }
        }

        void clearTableClick(object sender, EventArgs e)
        {
            _varList.Clear();
            ShowFamily(_varList);

            OnValueChanged();
        }

        void pasteClick(object sender, EventArgs e)
        {
            foreach (Variable v in Clipboard)
            {
                _varList.Add(new Variable(v));
            }
            ShowFamily(_varList);

            OnValueChanged();
        }

        void sortClick(object sender, EventArgs e)
        {
            List<Variable> tmp = new List<Variable>();
            foreach (Variable v in _varList) tmp.Add(new Variable(v));

            _varList.Clear();
            foreach (Variable v in tmp.FindAll(o => o.dim == VarDimension.X)) _varList.Add(new Variable(v));
            foreach (Variable v in tmp.FindAll(o => o.dim == VarDimension.Y)) _varList.Add(new Variable(v));
            foreach (Variable v in tmp.FindAll(o => o.dim == VarDimension.Ind)) _varList.Add(new Variable(v));

            ShowFamily(_varList);

            OnValueChanged();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > _varList.Count-1 || dataGridView.Columns[e.ColumnIndex].Name != "Expr") return;

            _exprCell = dataGridView.Rows[e.RowIndex].Cells["Expr"];

            Rectangle r = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            expressionEditor.Top = r.Top;
            expressionEditor.Left = r.Right - expressionEditor.Width;

            string xvector = "";
            string yvector = "";
            for (int k = 0; k < e.RowIndex; k++)
            {
                if (_varList[k].dim == VarDimension.X && string.IsNullOrEmpty(xvector))
                {
                    //var xvec = Expressions.Evaluate(_varList[k].expression);
                    //xvector = Expressions.ToVectorString(xvec);
                }
                if (_varList[k].dim == VarDimension.Y && string.IsNullOrEmpty(yvector))
                {
                    //var yvec = Expressions.Evaluate(_varList[k].expression);
                    //yvector = Expressions.ToVectorString(yvec);
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
            _exprCell.Value = expressionEditor.Value;

            expressionEditor.Visible = false;

            TestExpression(_exprCell);
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }
}
