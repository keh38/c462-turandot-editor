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
    public partial class ThumbSliderLayoutControl : KUserControl
    {
        private ThumbSliderLayout _value = new ThumbSliderLayout();

        public ThumbSliderLayoutControl()
        {
            InitializeComponent();
        }

        public ThumbSliderLayout Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Show(_value);
            }
        }

        private void Show(ThumbSliderLayout layout)
        {
            if (layout == null) return;

            _ignoreEvents = true;

            xNumeric.IntValue = layout.thumbX;
            yNumeric.IntValue = layout.thumbY;
            scaleYNumeric.IntValue = layout.sliderY;

            _ignoreEvents = false;
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.thumbX = xNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.thumbY = yNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void scaleYNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.sliderY = scaleYNumeric.IntValue;
                OnValueChanged();
            }
        }
    }
}
