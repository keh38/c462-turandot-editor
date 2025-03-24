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
    public partial class ParamSliderActionControl : KUserControl
    {
        private ParamSliderAction _value;

        public ParamSliderActionControl()
        {
            InitializeComponent();
        }

        public ParamSliderAction Value
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

            resetCheckbox.Checked = _value.reset;
            panel.Visible = !_value.reset;
            channelTextBox.Text = _value.channel;
            paramTextBox.Text = _value.parameter;
            startNumeric.FloatValue = _value.startVal;
            offsetNumeric.FloatValue = _value.startRange;
            minNumeric.FloatValue = _value.minVal;
            maxNumeric.FloatValue = _value.maxVal;
            logCheckBox.Checked = _value.isLog;
            shrinkNumeric.FloatValue = _value.shrinkFactor;
            showButtonCheckBox.Checked = _value.showButton;

            leftTextBox.Text = _value.leftLabel;
            rightTextBox.Text = _value.rightLabel;

            _ignoreEvents = false;
        }

        private void resetCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.reset = resetCheckbox.Checked;
                panel.Visible = ! _value.reset;
                OnValueChanged();
            }
        }

        private void channelTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.channel = channelTextBox.Text;
                OnValueChanged();
            }
        }

        private void paramTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.parameter = paramTextBox.Text;
                OnValueChanged();
            }
        }

        private void startNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startVal = startNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void offsetNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startRange = offsetNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void minNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.minVal = minNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void maxNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.maxVal = maxNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void logCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.isLog = logCheckBox.Checked;
                OnValueChanged();
            }
        }

        private void shrinkNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.shrinkFactor = shrinkNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void showButtonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.showButton = showButtonCheckBox.Checked;
                OnValueChanged();
            }
        }

        private void leftTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.leftLabel = leftTextBox.Text;
                OnValueChanged();
            }
        }

        private void rightTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.rightLabel = rightTextBox.Text;
                OnValueChanged();
            }
        }
    }
}
