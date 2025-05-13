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

using KLib.Controls;

using Turandot;
using Turandot.Schedules;

namespace Turandot_Editor.Controls
{
    public partial class ScheduleControl : KUserControl
    {
        private Schedule _schedule;
        private int _selectedFamily = -1;
        private DataGridViewComboBoxCell.ObjectCollection _orderItems;

        public ScheduleControl()
        {
            InitializeComponent();
            _orderItems = (groupGridView.Columns["Order"] as DataGridViewComboBoxColumn).Items;
            groupOrderEnum.Fill(typeof(Order));
        }

        public Schedule Value
        {
            get { return _schedule; }
            set
            {
                _schedule = value;
                ShowSchedule(_schedule);
            }
        }

        public void SetDataForContext(EditorParameters par)
        {
            propGridView.SetDataForContext(par);
        }

        public void UpdateAvailableStates()
        {
            propGridView.UpdateAvailableStates();
        }

        private void ShowSchedule(Schedule sched)
        {
            if (sched == null) return;

            _ignoreEvents = true;

            numBlocksNumeric.IntValue = sched.numBlocks;
            groupOrderEnum.SetEnumValue(sched.order);
            trainingCheckBox.Checked = sched.training;
            trainingPanel.Visible = sched.training;
            targetpcNumeric.FloatValue = sched.targetPc;
            maxPracticeNumeric.IntValue = sched.maxPracticeBlocks;
            perfPromptTextBox.Text = sched.performancePrompt.Replace("\n", Environment.NewLine);

            groupGridView.Columns["TrialType"].Visible = sched.mode == Mode.CS;

            groupGridView.Rows.Clear();
            foreach (Family f in sched.families) AddFamilyRow(f);

            EnableRow(groupGridView.RowCount - 1, false);
            propGridView.Visible = groupGridView.RowCount > 1;
            resultPanel.Visible = propGridView.Visible;

            _ignoreEvents = false;
        }

        public void UpdateMode()
        {
            groupGridView.Columns["TrialType"].Visible = _schedule.mode == Mode.CS;
        }

        private void EnableRow(int rowIndex, bool enable)
        {
            for (int k = 1; k < 4; k++) groupGridView.Rows[rowIndex].Cells[k].ReadOnly = !enable;
        }

        private void groupGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumberColumn_KeyPress);
            if (groupGridView.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumberColumn_KeyPress);
                }
            }
        }

        private void NumberColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numBlocksNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.numBlocks = numBlocksNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void groupGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_ignoreEvents && _schedule != null)
            {
                int rowIndex = groupGridView.CurrentCell.RowIndex;
                var cells = groupGridView.Rows[rowIndex].Cells;

                if (groupGridView.CurrentCell.ColumnIndex == 0)
                {
                    if (groupGridView.CurrentCell.RowIndex == _schedule.families.Count)
                    {
                        AddNewFamily();
                        EnableRow(rowIndex, true);
                    }
                    else
                    {
                        _schedule.families[rowIndex].name = cells["UserName"].Value as string;
                    }
                }
                else if (groupGridView.CurrentCell.ColumnIndex == 1)
                {
                    _schedule.families[rowIndex].number = Convert.ToInt32(cells["Number"].Value as string);
                }
                else if (groupGridView.CurrentCell.ColumnIndex == 2)
                {
                    _schedule.families[rowIndex].oneEach = cells["OneEach"].Value as string == "true";
                }
                else if (groupGridView.CurrentCell.ColumnIndex == 3)
                {
                    _schedule.families[rowIndex].order = (VariableOrder) _orderItems.IndexOf(cells["Order"].Value);
                }
                else if (groupGridView.CurrentCell.ColumnIndex == 4)
                {
                    _schedule.families[rowIndex].type = cells["TrialType"].Value as string == "CS-" ? Turandot.Schedules.TrialType.CSminus : Turandot.Schedules.TrialType.CSplus;
                }
                OnValueChanged();
            }
        }

        private void AddNewFamily()
        {
            var cells = groupGridView.Rows[groupGridView.CurrentCell.RowIndex].Cells;

            Family family = new Family(cells["UserName"].Value as string);
            family.number = 1;
            family.oneEach = false;
            family.order = VariableOrder.FullRandom;
            family.type = Turandot.Schedules.TrialType.CSplus;
            _schedule.families.Add(family);

            cells["Number"].Value = family.number.ToString();
            cells["OneEach"].Value = family.oneEach ? "true" : "";
            cells["Order"].Value = _orderItems[(int)family.order];
            cells["TrialType"].Value = family.type == Turandot.Schedules.TrialType.CSminus ? "CS-" : "CS+";
        }

        private void AddFamilyRow(Family family)
        {
            int rowIndex = groupGridView.Rows.Add();
            var cells = groupGridView.Rows[rowIndex].Cells;

            cells["UserName"].Value = family.name;
            cells["Number"].Value = family.number.ToString();
            cells["OneEach"].Value = family.oneEach ? "true" : "";
            cells["Order"].Value = _orderItems[(int)family.order];
            cells["TrialType"].Value = family.type == Turandot.Schedules.TrialType.CSminus ? "CS-" : "CS+";

            EnableRow(rowIndex, true);
        }

        private void groupGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && groupGridView.IsCurrentCellDirty && (groupGridView.CurrentCell.ColumnIndex == 2 || groupGridView.CurrentCell.ColumnIndex == 3))
            {
                groupGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void groupGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected) UpdateRowSelection();
        }

        private void UpdateRowSelection()
        {
            int selected = groupGridView.SelectedRows.Count == 1 ? groupGridView.SelectedRows[0].Index : -1;
            if (selected != _selectedFamily)
            {
                _selectedFamily = selected;
                bool isValid = _selectedFamily >= 0 && _selectedFamily < _schedule.families.Count;
                if (isValid)
                {
                    propGridView.Value = _schedule.families[_selectedFamily].variables;
                    resultExprBox.Text = _schedule.families[_selectedFamily].resultExpression;
                    saveasTextBox.Text = _schedule.families[_selectedFamily].storeResultAs;
                }
                propGridView.Visible = isValid;
                resultPanel.Visible = isValid;
            }
            else
            {
                propGridView.Visible = groupGridView.RowCount > 1;
                resultPanel.Visible = propGridView.Visible;
            }
        }

        private void propGridView_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void resultExprBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.families[_selectedFamily].resultExpression = resultExprBox.Text;
                OnValueChanged();
            }
        }

        private void saveasTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.families[_selectedFamily].storeResultAs = saveasTextBox.Text;
                OnValueChanged();
            }
        }

        private void groupGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            _schedule.families.RemoveAt(e.Row.Index);

            UpdateRowSelection();
            OnValueChanged();
        }

        private void trainingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.training = trainingCheckBox.Checked;
                trainingPanel.Visible = _schedule.training;
                OnValueChanged();
            }
        }

        private void targetpcNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.targetPc = targetpcNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            foreach (Family f in _schedule.families.FindAll(o => o.oneEach))
            {
                try
                {
                    f.Apply();
                    f.number = f.NumTotal;
                }
                catch (Exception ex)
                {
                    errors.AppendLine($"{f.name}: {ex.Message}");
                }
            }
            ShowSchedule(_schedule);

            if (errors.Length > 0)
            {
                MsgBox.Show(errors.ToString(), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupOrderEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _schedule.order = (Order)groupOrderEnum.Value;
                OnValueChanged();
            }
        }
        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = BuildContextMenu(e.Location);
                cm.Show(sender as Control, e.Location);
            }
        }

        private ContextMenu BuildContextMenu(Point point)
        {
            var cm = new ContextMenu();

            MenuItem mi;

            if (_schedule.families.Count > 0)
            {
                mi = new MenuItem();
                mi.Text = "Duplicate selected row";
                mi.Click += duplicateRowClick;
                cm.MenuItems.Add(mi);
            }

            return cm;
        }

        void duplicateRowClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in groupGridView.SelectedRows)
            {
                Family f = _schedule.families[row.Index].Clone();
                _schedule.families.Add(f);
                AddFamilyRow(f);
            }
//            ShowFamily(_varList);

            OnValueChanged();
        }

        private void perfPromptTextBox_Enter(object sender, EventArgs e)
        {
            var xr = perfPromptTextBox.Location.X + perfPromptTextBox.Width;
            perfPromptTextBox.Height = 80;
            perfPromptTextBox.Width = 170;
            perfPromptTextBox.Location = new Point(xr - perfPromptTextBox.Width, perfPromptTextBox.Location.Y);
        }

        private void perfPromptTextBox_Leave(object sender, EventArgs e)
        {
            var xr = perfPromptTextBox.Location.X + perfPromptTextBox.Width;
            perfPromptTextBox.Height = 20;
            perfPromptTextBox.Width = 75;
            perfPromptTextBox.Location = new Point(xr - perfPromptTextBox.Width, perfPromptTextBox.Location.Y);
            _schedule.performancePrompt = perfPromptTextBox.Text;
        }

        private void maxPracticeNumeric_ValueChanged(object sender, EventArgs e)
        {
            _schedule.maxPracticeBlocks = maxPracticeNumeric.IntValue;
            OnValueChanged();
        }
    }
}
