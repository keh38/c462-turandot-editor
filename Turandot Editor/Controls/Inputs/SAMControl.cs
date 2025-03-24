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

namespace Turandot_Editor.Controls
{
    public partial class SAMControl : KUserControl
    {
        private SAM.Appearance _value = null;
        private string _title = "SAM";

        public SAMControl()
        {
            InitializeComponent();
        } 

        public SAM.Appearance Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                checkBox.Text = _title;
            }
        }

        private void ShowValue()
        {
            if (_value == null) return;

            _ignoreEvents = true;

            checkBox.Checked = _value.visible;
            minTextBox.Text = _value.minlabel;
            maxTextBox.Text = _value.maxLabel;

            _ignoreEvents = false;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.visible = checkBox.Checked;
                OnValueChanged();
            }
        }

        private void minTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _value.minlabel = minTextBox.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void minTextBox_Leave(object sender, EventArgs e)
        {
            _value.minlabel = minTextBox.Text;
            OnValueChanged();
        }

        private void maxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _value.maxLabel = maxTextBox.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void maxTextBox_Leave(object sender, EventArgs e)
        {
            _value.maxLabel = maxTextBox.Text;
            OnValueChanged();
        }
    }
}
