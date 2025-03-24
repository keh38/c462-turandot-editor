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
using Turandot.Inputs;

namespace Turandot_Editor.Controls.Inputs
{
    public partial class RandomProcessControl : KUserControl
    {
        private RandomProcess _value = null;

        public RandomProcessControl()
        {
            InitializeComponent();
        }

        public RandomProcess Value
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

            intervalExprBox.Text = _value.intervalExpr;
            valuesExprBox.Text = _value.valueExpr;

            _ignoreEvents = false;
        }

        private void intervalExprBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.intervalExpr = intervalExprBox.Text;
                OnValueChanged();
            }
        }

        private void valuesExprBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.valueExpr = valuesExprBox.Text;
                OnValueChanged();
            }
        }
    }
}
