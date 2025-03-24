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
using Turandot.Inputs;

namespace Turandot_Editor.Controls.Inputs
{
    public partial class ScalerControl : KUserControl
    {

        private Scaler _value;

        public ScalerControl()
        {
            InitializeComponent();
            tickTypeEnum.Fill<TickSpex.TickType>();
            referenceEnum.Fill<ScaleReference.RefType>();
        }

        public Scaler Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        private void ShowValue()
        {
            if (_value == null) return;
            _ignoreEvents = true;

            posNumeric.FloatValue = _value.value;
            lengthNumeric.IntValue = _value.length;
            scaleBGColorBox.ValueAsUInt = _value.bgColor;
            thumbCheckBox.Checked = _value.thumb;

            tickTypeEnum.SetEnumValue(_value.tickSpex.tickType);
            tickTabs.Visible = _value.tickSpex.tickType != TickSpex.TickType.None;
            minNumeric.FloatValue = _value.tickSpex.min;
            maxNumeric.FloatValue = _value.tickSpex.max;
            stepNumeric.FloatValue = _value.tickSpex.step;

            dataGridView.Rows.Clear();
            if (_value.tickSpex.labels != null)
            {
                dataGridView.Rows.Add(_value.tickSpex.labels.ToArray());
            }

            tickTabs.SelectedIndex = (int)_value.tickSpex.tickType;

            referenceEnum.SetEnumValue(_value.scaleReference.refType);
            refTabs.SelectedIndex = (int) _value.scaleReference.refType;

            refLabelTextBox.Text = _value.scaleReference.label;
            refColorBox.ValueAsUInt = _value.scaleReference.color;
            refLocationTextBox.Text = _value.scaleReference.location;
            refStartAtCheckBox.Checked = _value.scaleReference.startAt;

            _ignoreEvents = false;
        }

        private void posNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.value = posNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void lengthNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.length = lengthNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void scaleBGColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.bgColor = scaleBGColorBox.ValueAsUInt;
                OnValueChanged();
            }
        }

        private void thumbCheckBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.thumb = thumbCheckBox.Checked;
                OnValueChanged();
            }
        }

        private void tickTypeEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.tickSpex.tickType = (TickSpex.TickType)tickTypeEnum.Value;
                tickTabs.SelectedIndex = tickTypeEnum.Value;
                tickTabs.Visible = _value.tickSpex.tickType != TickSpex.TickType.None;
                OnValueChanged();
            }
        }

        private void minNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.tickSpex.min = minNumeric.FloatValue;
                OnValueChanged();
            }
        }
        private void maxNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.tickSpex.max = maxNumeric.FloatValue;
                OnValueChanged();
            }
        }
        private void stepNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.tickSpex.step = stepNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_value.tickSpex.labels.Count < e.RowIndex + 1)
                _value.tickSpex.labels.Add("");

            _value.tickSpex.labels[e.RowIndex] = dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
            OnValueChanged();
        }

        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_value.tickSpex.labels == null) _value.tickSpex.labels = new List<string>();
            _value.tickSpex.labels.Add("");
        }

        private void referenceEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleReference.refType = (ScaleReference.RefType)referenceEnum.Value;
                refTabs.SelectedIndex = referenceEnum.Value;
                OnValueChanged();
            }
        }

        private void refLabelTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleReference.label = refLabelTextBox.Text;
                OnValueChanged();
            }
        }

        private void refColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleReference.color = refColorBox.ValueAsUInt;
                OnValueChanged();
            }
        }

        private void refLocationTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleReference.location = refLocationTextBox.Text;
                OnValueChanged();
            }
        }

        private void refStartAtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleReference.startAt = refStartAtCheckBox.Checked;
                OnValueChanged();
            }
        }
    }
}
