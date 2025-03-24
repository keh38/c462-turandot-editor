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
using Turandot.Screen;

using DlgResult = System.Windows.Forms.DialogResult;

namespace Turandot_Editor.Controls.Screen
{
    public partial class MessageLayoutControl : KUserControl
    {
        private MessageLayout _value;

        public MessageLayoutControl()
        {
            InitializeComponent();
        }

        public MessageLayout Value
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

            fontSizeNumeric.IntValue = _value.fontSize;
            colorBox.Value = Color.FromArgb((int) _value.color);
            xNumeric.IntValue = _value.X;
            yNumeric.IntValue = _value.Y;

            _ignoreEvents = false;
        }

        private void fontSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.fontSize = fontSizeNumeric.IntValue;
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

        private void colorBox_ValueChanged(object sender, EventArgs e)
        {
            _value.color = colorBox.ValueAsUInt;
            OnValueChanged();
        }
    }
}
