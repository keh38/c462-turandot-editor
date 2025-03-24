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

namespace Turandot_Editor.Controls.Inputs
{
    public partial class ButtonControl : KUserControl
    {
        private ButtonSpec _value;

        public ButtonControl()
        {
            InitializeComponent();

            styleEnum.Fill(typeof(ButtonSpec.ButtonStyle));
            keyEnum.Fill(typeof(UnityEngine.KeyCode));
        }

        public ButtonSpec Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public bool AllowXbox
        {
            set { xboxLinkControl.Visible = value; }
        }

        private void ShowValue()
        {
            if (_value == null) return;

            _ignoreEvents = true;

            nameBox.Text = _value.name;
            labelBox.Text = _value.label;
            styleEnum.SetEnumValue(_value.style);
            xNumeric.IntValue = _value.x;
            yNumeric.IntValue = _value.y;
            sizeNumeric.IntValue = _value.size;

            hNumeric.Visible = _value.style == ButtonSpec.ButtonStyle.Rectangle;
            hPrompt.Visible = hNumeric.Visible;
            hNumeric.IntValue = _value.height;

            xboxLinkControl.Value = _value.xbox;

            if (!_value.useKeyboard)
            {
                _value.keyboardValue = UnityEngine.KeyCode.None;
            }

            keyEnum.SetEnumValue(_value.keyboardValue);

            _ignoreEvents = false;
        }

        public void ChangeName(string name)
        {
            _ignoreEvents = true;

            _value.name = name;
            nameBox.Text = name;

            _ignoreEvents = false;
        }

        private void labelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                labelBox.Text = _value.label;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _value.label = labelBox.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void labelBox_Leave(object sender, EventArgs e)
        {
            if (_value != null && _value.label != labelBox.Text)
            {
                _value.label = labelBox.Text;
                OnValueChanged();
            }
        }

        private void styleEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.style = (ButtonSpec.ButtonStyle) styleEnum.Value;
                hNumeric.Visible = _value.style == ButtonSpec.ButtonStyle.Rectangle;
                hPrompt.Visible = hNumeric.Visible;
                OnValueChanged();
            }
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.x = xNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.y = yNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void sizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.size = sizeNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.height = hNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void keyEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.keyboardValue = (UnityEngine.KeyCode)keyEnum.Value;
                _value.useKeyboard = _value.keyboardValue != UnityEngine.KeyCode.None;
                OnValueChanged();
            }
        }
    }
}
