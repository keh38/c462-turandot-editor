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

namespace Turandot_Editor.Controls
{
    public partial class ImageControl : KUserControl
    {
        private Turandot.Cues.Image _value = new Turandot.Cues.Image();

        public ImageControl()
        {
            InitializeComponent();

            horzAlignEnum.Fill<Turandot.Cues.Image.HorizontalAlignment>();
            vertAlignEnum.Fill<Turandot.Cues.Image.VerticalAlignment>();
        }

        public Turandot.Cues.Image Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue(_value);
            }
        }

        private void ShowValue(Turandot.Cues.Image cue)
        {
            if (cue == null) return;

            _ignoreEvents = true;

            startComboBox.SelectedIndex = cue.startVisible ? 0 : 1;

            delayNumeric.FloatValue = cue.delay_ms;

            flashCheckBox.Checked = cue.numFlash > 0;
            flashNumeric.IntValue = cue.numFlash;
            flashNumeric.Visible = cue.numFlash > 0;
            onNumeric.FloatValue = cue.duration_ms;
            periodNumeric.FloatValue = cue.interval_ms;

            endComboBox.SelectedIndex = cue.endVisible ? 0 : 1;

            flashPanel.Visible = cue.startVisible;
            flashPropertiesPanel.Visible = cue.startVisible && cue.numFlash > 0;

            imageFile.Value = cue.filename;

            xNumeric.IntValue = cue.X;
            yNumeric.IntValue = cue.Y;

            horzAlignEnum.SetEnumValue(cue.horizontalAlignment);
            vertAlignEnum.SetEnumValue(cue.verticalAlignment);

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

        private void imageFile_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.filename = imageFile.Value;
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

        private void horzAlignEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.horizontalAlignment = (Turandot.Cues.Image.HorizontalAlignment)horzAlignEnum.Value;
                OnValueChanged();
            }
        }

        private void vertAlignEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.verticalAlignment = (Turandot.Cues.Image.VerticalAlignment) vertAlignEnum.Value;
                OnValueChanged();
            }
        }

    }
}
