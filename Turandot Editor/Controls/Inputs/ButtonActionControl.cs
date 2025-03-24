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

namespace Turandot_Editor.Controls.Inputs
{
    public partial class ButtonActionControl : KUserControl
    {
        private Turandot.Inputs.Button _value;

        public ButtonActionControl()
        {
            InitializeComponent();
        }

        public Turandot.Inputs.Button Value
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

            flashCheckBox.Checked = _value.numFlash > 0;
            flashNumeric.IntValue = _value.numFlash;
            delayNumeric.FloatValue = _value.delay_ms;
            onNumeric.FloatValue = _value.duration_ms;
            periodNumeric.FloatValue = _value.interval_ms;
            scaleCheckBox.Checked = _value.tweenScale;
            scaleNumeric.FloatValue = _value.scaleTo;

            flashPanel.Visible = flashCheckBox.Checked;
            flashNumeric.Visible = flashCheckBox.Checked;
            scaleCheckBox.Visible = flashCheckBox.Checked;
            scaleNumeric.Visible = flashCheckBox.Checked && scaleCheckBox.Checked;

            changeCheckBox.Checked = _value.changeAppearance;
            appearancePanel.Visible = _value.changeAppearance;
            colorBox.ValueAsUInt = _value.color;

            _ignoreEvents = false;
        }

        private void flashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                flashNumeric.IntValue = flashCheckBox.Checked ? 1 : 0;
                _value.numFlash = flashCheckBox.Checked ? 1 : 0;

                flashPanel.Visible = flashCheckBox.Checked;
                flashNumeric.Visible = flashCheckBox.Checked;

                OnValueChanged();
            }
        }

        private void flashNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.numFlash = flashNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void onNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.duration_ms = onNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void periodNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.interval_ms = periodNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void delayNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.delay_ms = delayNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void scaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.tweenScale = scaleCheckBox.Checked;
                scaleNumeric.Visible = scaleCheckBox.Checked;

                OnValueChanged();
            }
        }

        private void scaleNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.scaleTo = scaleNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void changeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.changeAppearance = changeCheckBox.Checked;
                appearancePanel.Visible = _value.changeAppearance;
                OnValueChanged();
            }
        }

        private void colorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.color = colorBox.ValueAsUInt;
                OnValueChanged();
            }
        }
    }
}
