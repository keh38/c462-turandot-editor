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
    public partial class ProgressBarLayoutControl : KUserControl
    {
        private ProgressBarLayout _value = null;

        public ProgressBarLayoutControl()
        {
            InitializeComponent();
        }

        public ProgressBarLayout Value
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

            xNumeric.IntValue = _value.X;
            yNumeric.IntValue = _value.Y;
            wNumeric.IntValue = _value.W;
            hNumeric.IntValue = _value.H;

            _ignoreEvents = false;
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.X = xNumeric.IntValue;
            }
        }
        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.Y = yNumeric.IntValue;
            }
        }
        private void wNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.W = wNumeric.IntValue;
            }
        }
        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.H = hNumeric.IntValue;
            }
        }
    }
}
