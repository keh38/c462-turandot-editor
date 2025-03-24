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

using Turandot;
using Turandot.Schedules;

namespace Turandot_Editor
{
    public partial class NestedPropertyGridView : KUserControl
    {
        List<Variable> _varList = null;
        EditorParameters _params;
        int _selectedRow = -1;
        bool _showDim = true;

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

        public bool Dafuq { get; set; }

        public bool ShowDim
        {
            get { return _showDim; }
            set
            {
                _showDim = value;
                dataGridView.Columns["Dim"].Visible = _showDim;
            }
        }

        public void UpdateAvailableStates()
        {
            List<string> stateList = _params.GetStateNames();

            dataGridView.Rows.Clear();

            DataGridViewComboBoxColumn col = dataGridView.Columns["State"] as DataGridViewComboBoxColumn;
            col.Items.Clear();
            col.Items.AddRange(stateList.ToArray());

            ShowFamily(_varList);
        }

        private void ShowFamily(List<Variable> vlist)
        {
            if (vlist == null) return;

            _ignoreEvents = true;

            dataGridView.Rows.Clear();
            foreach (Variable v in vlist) AddFamilyRow(v);

            DisableCells(dataGridView.RowCount - 1, 1);

            _ignoreEvents = false;
        }

        private void DisableCells(int rowIndex, int from)
        {
            for (int k = 1; k < 5; k++) dataGridView.Rows[rowIndex].Cells[k].ReadOnly = k >= from;
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
                    if (dataGridView.CurrentCell.RowIndex == _varList.Count)
                    {
                        AddNewVariable();
                        DisableCells(rowIndex, 2);
                    }
                    else
                    {
                        _varList[rowIndex].state = cells["State"].Value as string;
                    }
                    _ignoreEvents = true;
                    UpdateStateSelection(rowIndex, state);
                    _ignoreEvents = false;
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 1)
                {
                    _varList[rowIndex].chan = cells["Channel"].Value as string;
                    _ignoreEvents = true;
                    UpdateChannelSelection(rowIndex);
                    _ignoreEvents = false;
                }
                else if (dataGridView.CurrentCell.ColumnIndex == 2)
                { 
                    _varList[rowIndex].property = cells["Property"].Value as string;
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
            if (!Expressions.TryEvaluate(cell.Value as string))
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
    }
}
