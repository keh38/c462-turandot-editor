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
    public partial class GrapherLayoutControl : KUserControl
    {
        private GrapherLayout _value = new GrapherLayout();

        public GrapherLayoutControl()
        {
            InitializeComponent();
        }

        public GrapherLayout Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Show(_value);
            }
        }

        private void Show(GrapherLayout layout)
        {
            if (layout == null) return;

            _ignoreEvents = true;

            xNumeric.FloatValue = layout.graphX;
            yNumeric.FloatValue = layout.graphY;
            wNumeric.FloatValue = layout.graphW;
            hNumeric.FloatValue = layout.graphH;
            sizeNumeric.FloatValue = layout.stylusW;
            stylusXNumeric.FloatValue = layout.stylusX;
            speedNumeric.FloatValue = layout.speed;
            inkColorBox.ValueAsUInt = layout.inkColor;
            contactCheckbox.Checked = layout.mustContactStylus;
            fixedCheckbox.Checked = layout.stylusPositionFixed;

            _ignoreEvents = false;
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.graphX = xNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.graphY = yNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void wNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.graphW = wNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.graphH = hNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void sizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.stylusW = sizeNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void stylusXNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.stylusX = stylusXNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void speedNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.speed = speedNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void inkColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.inkColor = inkColorBox.ValueAsUInt;
                OnValueChanged();
            }
        }

        private void contactCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.mustContactStylus = contactCheckbox.Checked;
                OnValueChanged();
            }
        }

        private void fixedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.stylusPositionFixed = fixedCheckbox.Checked;
                OnValueChanged();
            }
        }
    }
}
