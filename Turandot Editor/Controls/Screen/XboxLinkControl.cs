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

namespace Turandot_Editor.Controls.Screen
{
    public partial class XboxLinkControl : KUserControl
    {
        private XboxLink _value;

        public XboxLinkControl()
        {
            InitializeComponent();

            sourceEnum.Fill<XboxLink.ControlSource>();
        }

        public XboxLink Value
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

            sourceEnum.SetEnumValue(_value.control);
            showCheckBox.Checked = _value.display;
            xNumeric.IntValue = _value.x;
            yNumeric.IntValue = _value.y;

            UpdateContextDependentDisplay();

            _ignoreEvents = false;
        }

        private void UpdateContextDependentDisplay()
        {
            showCheckBox.Visible = _value.control != XboxLink.ControlSource.None;
            positionPanel.Visible = showCheckBox.Visible && _value.display;
        }

        private void sourceEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.control = (XboxLink.ControlSource)sourceEnum.Value;
                UpdateContextDependentDisplay();
                OnValueChanged();
            }
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.display = showCheckBox.Checked;
                UpdateContextDependentDisplay();
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
    }
}
