using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DlgResult = System.Windows.Forms.DialogResult;

using KLib.Controls;
using Turandot.Cues;

namespace Turandot_Editor.Controls
{
    public partial class CueControl : KUserControl
    {
        private bool _isMessage = true;
        private Cue _value = new Cue();

        public CueControl()
        {
            InitializeComponent();
            iconEnum.Fill(typeof(Turandot.Cues.Message.Icon));
        }

        public bool IsMessage
        {
            get { return _isMessage; }
            set
            {
                _isMessage = value;
                messagePanel.Visible = value;
            }
        }

        public Cue Value
        {
            get { return _value; }
            set { SetValue(value); }

        }

        private void SetValue(Cue cue)
        {
            _value = cue;

            _ignoreEvents = true;

            ShowCue(_value);

            _ignoreEvents = false;

        }

        private void ShowCue(Cue cue)
        {
            if (cue == null) return;

            _ignoreEvents = true;

            startComboBox.SelectedIndex = cue.startVisible ? 0 : 1;

            delayNumeric.FloatValue = cue.delay_ms;
            colorBox.BackColor = Color.FromArgb(cue.color);
            xNumeric.IntValue = cue.X;
            yNumeric.IntValue = cue.Y;

            changeCheckBox.Checked = cue.changeAppearance;
            appearancePanel.Visible = cue.changeAppearance;

            if (_isMessage && _value is Turandot.Cues.Message)
            {
                fontSizeNumeric.IntValue = (_value as Turandot.Cues.Message).fontSize;
                msgTextBox.Text = (_value as Turandot.Cues.Message).text;
                iconEnum.SetEnumValue((_value as Turandot.Cues.Message).icon);
                iconSizeNumeric.IntValue = (_value as Turandot.Cues.Message).iconSize;
                messagePanel.Visible = cue.startVisible;
            }

            flashCheckBox.Checked = cue.numFlash > 0;
            flashNumeric.IntValue = cue.numFlash;
            flashNumeric.Visible = cue.numFlash > 0;
            onNumeric.FloatValue = cue.duration_ms;
            periodNumeric.FloatValue = cue.interval_ms;

            endComboBox.SelectedIndex = cue.endVisible ? 0 : 1;

            actionPanel.Visible = true;
            flashPanel.Visible = cue.startVisible;
            flashPropertiesPanel.Visible = cue.startVisible && cue.numFlash > 0;

            _ignoreEvents = false;
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startVisible = startComboBox.SelectedIndex == 0;
                messagePanel.Visible = _isMessage && _value.startVisible;
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

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Color.FromArgb(_value.color);

            if (dlg.ShowDialog() == DlgResult.OK)
            {
                _value.color = dlg.Color.ToArgb();
                colorBox.BackColor = Color.FromArgb(_value.color);
                OnValueChanged();
            }
        }

        private void fontSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Turandot.Cues.Message).fontSize = fontSizeNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void msgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (_value as Turandot.Cues.Message).text = msgTextBox.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void msgTextBox_Leave(object sender, EventArgs e)
        {
            (_value as Turandot.Cues.Message).text = msgTextBox.Text;
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
                _value.X = xNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.Y = yNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void iconEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Turandot.Cues.Message).icon = (Turandot.Cues.Message.Icon)iconEnum.Value;
                OnValueChanged();
            }
        }

        private void iconSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (_value as Turandot.Cues.Message).iconSize = iconSizeNumeric.IntValue;
                OnValueChanged();
            }
        }
    }
}
