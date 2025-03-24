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

using Help = Turandot.Cues.Help;

namespace Turandot_Editor.Controls
{
    public partial class HelpControl : KUserControl
    {
        private Cue _value = new Cue();

        public HelpControl()
        {
            InitializeComponent();
        }

        public Cue Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue(_value);
            }
        }


        private void ShowValue(Cue cue)
        {
            if (cue == null) return;

            _ignoreEvents = true;

            startComboBox.SelectedIndex = cue.startVisible ? 0 : 1;

            delayNumeric.FloatValue = cue.delay_ms;

            changeCheckBox.Checked = cue.changeAppearance;
            appearancePanel.Visible = cue.changeAppearance;

            msgTextBox.Text = (cue as Help).text.Replace("\n", Environment.NewLine);
            messagePanel.Visible = cue.startVisible;

            flashCheckBox.Checked = cue.numFlash > 0;
            flashNumeric.IntValue = cue.numFlash;
            flashNumeric.Visible = cue.numFlash > 0;
            onNumeric.FloatValue = cue.duration_ms;
            periodNumeric.FloatValue = cue.interval_ms;

            endComboBox.SelectedIndex = cue.endVisible ? 0 : 1;

            flashPanel.Visible = cue.startVisible;
            flashPropertiesPanel.Visible = cue.startVisible && cue.numFlash > 0;

            xNumeric.FloatValue = (cue as Help).x;
            yNumeric.FloatValue = (cue as Help).y;
            wNumeric.FloatValue = (cue as Help).w;
            hNumeric.FloatValue = (cue as Help).h;

            _ignoreEvents = false;
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startVisible = startComboBox.SelectedIndex == 0;
                flashPanel.Visible = _value.startVisible;
                flashPropertiesPanel.Visible = _value.startVisible && _value.numFlash > 0;
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

        private void msgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (_value as Turandot.Cues.Help).text = msgTextBox.Text;
                //e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void msgTextBox_Leave(object sender, EventArgs e)
        {
            (_value as Turandot.Cues.Help).text = msgTextBox.Text;
            OnValueChanged();
        }

        private void flashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                flashNumeric.IntValue = flashCheckBox.Checked ? 1 : 0;
                flashNumeric.Visible = flashCheckBox.Checked;
                flashPropertiesPanel.Visible = flashCheckBox.Checked;
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

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.endVisible = endComboBox.SelectedIndex == 0;
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

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Help).x = xNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Help).y = yNumeric.FloatValue;
                OnValueChanged();
            }
        }
        private void wNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Help).w = wNumeric.FloatValue;
                OnValueChanged();
            }
        }
        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Help).h = hNumeric.FloatValue;
                OnValueChanged();
            }
        }

    }
}
