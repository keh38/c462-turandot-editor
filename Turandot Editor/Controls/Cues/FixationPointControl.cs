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
using Turandot.Screen;

namespace Turandot_Editor.Controls
{
    public partial class FixationPointControl : KUserControl
    {
        private FixationPoint _fp;

        public FixationPointControl()
        {
            InitializeComponent();
            styleDropDown.Fill(typeof(FixationPoint.Style));
        }

        public FixationPoint Value
        {
            get { return _fp; }
            set
            {
                _fp = value;
                ShowValue(_fp);
            }
        }

        private void ShowValue(FixationPoint fp)
        {
            if (fp == null) return;

            _ignoreEvents = true;

            styleDropDown.SetEnumValue(fp.style);
            sizeNumeric.IntValue = fp.size;
            colorBox.ValueAsUInt = fp.color;

            barwidthNumeric.IntValue = fp.barWidth;
            barcolorBox.ValueAsUInt = fp.barColor;
            barangleNumeric.FloatValue = fp.barAngle;
            labelBox.Text = fp.label;

            _ignoreEvents = false;
        }


        private void styleDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.style = (FixationPoint.Style)styleDropDown.Value;
                OnValueChanged();
            }
        }

        private void sizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.size = sizeNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void barwidthNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.barWidth = barwidthNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void barangleNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.barAngle = barangleNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void labelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                labelBox.Text = _fp.label;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _fp.label = labelBox.Text;
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
            _fp.label = labelBox.Text;
            OnValueChanged();
        }

        private void colorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.color = colorBox.ValueAsUInt;
                OnValueChanged();
            }
        }

        private void barcolorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _fp.barColor = barcolorBox.ValueAsUInt;
                OnValueChanged();
            }
        }
    }
}
