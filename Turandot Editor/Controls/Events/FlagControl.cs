using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib.Controls;

using Turandot;

namespace Turandot_Editor.Controls
{
    public partial class FlagControl : KUserControl
    {
        List<Flag> _flags = null;

        public FlagControl()
        {
            InitializeComponent();
        }

        public List<Flag> Value
        {
            get { return _flags; }
            set
            {
                _flags = value;
                ShowTable();
            }
        }

        private void ShowTable()
        {
            if (_flags == null) return;

            _ignoreEvents = true;

            flagGridView.Rows.Clear();
            foreach (Flag f in _flags)
            {
                int rowIndex = flagGridView.Rows.Add();
                var cells = flagGridView.Rows[rowIndex].Cells;

                cells["FlagName"].Value = f.name;
                cells["FlagDefault"].Value = f.value.ToString();
            }

            _ignoreEvents = false;
        }

        private void flagGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_ignoreEvents && _flags != null)
            {
                int rowIndex = flagGridView.CurrentCell.RowIndex;
                var cells = flagGridView.Rows[rowIndex].Cells;

                if (flagGridView.CurrentCell.ColumnIndex == 0)
                {
                    string name = cells[0].Value as string;
                    if (string.IsNullOrEmpty(name))
                    {
                        _flags.RemoveAt(rowIndex);
                        flagGridView.Rows.RemoveAt(rowIndex);
                    }
                    else
                    {
                        _flags[rowIndex].name = name;
                    }
                }
                else if (flagGridView.CurrentCell.ColumnIndex == 1)
                {
                    _flags[rowIndex].value = int.Parse(cells[1].Value as string);
                }
                OnValueChanged();
            }
        }

        private void flagGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!_ignoreEvents)
            {
                _flags.RemoveAt(e.Row.Index);
                OnValueChanged();
            }
        }

        private void flagGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_flags == null) _flags = new List<Flag>();
            _flags.Insert(e.Row.Index-1, new Flag());
        }

        private void flagGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumberColumn_KeyPress);
            if (flagGridView.CurrentCell.ColumnIndex == 1) //Desired Column
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
    }
}
