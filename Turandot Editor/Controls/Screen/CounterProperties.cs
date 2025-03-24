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

namespace Turandot_Editor.Controls.Screen
{
    public partial class CounterProperties : KUserControl
    {
        private Counter _value = null;

        public CounterProperties()
        {
            InitializeComponent();
        }
        public Counter Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue(_value);
            }
        }

        private void ShowValue(Counter c)
        {
            if (c == null) return;

            _ignoreEvents = true;
            xNumeric.IntValue = c.X;
            yNumeric.IntValue = c.Y;
            sizeNumeric.IntValue = c.size;
            colorBox.ValueAsUInt = c.color;

            _ignoreEvents = false;
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

        private void sizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.size = sizeNumeric.IntValue;
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
