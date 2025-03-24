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
using Turandot.Cues;

namespace Turandot_Editor.Controls.Cues
{
    public partial class CounterActionControl : KUserControl
    {
        private CounterAction _value = null;

        public CounterActionControl()
        {
            InitializeComponent();

            actionEnum.Fill(typeof(CounterAction.Action));
        }

        public CounterAction Value
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

            startComboBox.SelectedIndex = _value.startVisible ? 0 : 1;
            endComboBox.SelectedIndex = _value.endVisible ? 0 : 1;

            actionEnum.SetEnumValue(_value.action);
            resetPanel.Visible = _value.action == CounterAction.Action.Reset;
            startPanel.Visible = _value.action == CounterAction.Action.Start;

            valueNumeric.IntValue = _value.startAt;
            maxNumeric.IntValue = _value.maxValue;
            minNumeric.IntValue = _value.minValue;

            delayNumeric.FloatValue = _value.delay_s;
            incrementNumeric.IntValue = _value.incrementBy;
            intervalNumeric.FloatValue = _value.interval_s;

            colorCheckBox.Checked = _value.changeColor;
            colorBox.ValueAsUInt = (uint) _value.newColor;

            colorBox.Enabled = _value.changeColor;

            _ignoreEvents = false;
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startVisible = startComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.endVisible = endComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void actionEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.action = (CounterAction.Action)actionEnum.Value;
                resetPanel.Visible = _value.action == CounterAction.Action.Reset;
                startPanel.Visible = _value.action == CounterAction.Action.Start;

                OnValueChanged();
            }
        }

        private void valueNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startAt = valueNumeric.IntValue;
                OnValueChanged();
            }
        }
        private void maxNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.maxValue = maxNumeric.IntValue;
                OnValueChanged();
            }
        }
        private void minNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.minValue = minNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void delayNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.delay_s = delayNumeric.FloatValue;
                OnValueChanged();
            }
        }
        private void incrementNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.incrementBy = incrementNumeric.IntValue;
                OnValueChanged();
            }
        }
        private void intervalNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.interval_s = intervalNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void colorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.changeColor = colorCheckBox.Checked;
                colorBox.Enabled = _value.changeColor;
                OnValueChanged();
            }
        }

        private void colorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.newColor = colorBox.ValueAsUInt;
                OnValueChanged();
            }
        }
    }
}
