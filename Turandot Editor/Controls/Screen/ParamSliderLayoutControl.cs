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
    public partial class ParamSliderLayoutControl : KUserControl
    {
        private ParamSliderLayout _value;

        public ParamSliderLayoutControl()
        {
            InitializeComponent();
        }

        public ParamSliderLayout Value
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

            wNumeric.IntValue = _value.width;
            hNumeric.IntValue = _value.height;

            _ignoreEvents = false;
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.width = wNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.height = hNumeric.IntValue;
                OnValueChanged();
            }
        }

    }
}
