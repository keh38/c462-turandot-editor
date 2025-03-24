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
    public partial class ScoreboardProperties : KUserControl
    {
        private Scoreboard _value = null;

        public ScoreboardProperties()
        {
            InitializeComponent();
        }
        public Scoreboard Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue(_value);
            }
        }

        private void ShowValue(Scoreboard s)
        {
            if (s == null) return;

            _ignoreEvents = true;
            xNumeric.IntValue = s.X;
            yNumeric.IntValue = s.Y;
            sizeNumeric.IntValue = s.size;
            colorBox.ValueAsUInt = s.color;
            negColorBox.ValueAsUInt = s.negativeColor;

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

        private void negColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.negativeColor = negColorBox.ValueAsUInt;
                OnValueChanged();
            }
        }

    }
}
