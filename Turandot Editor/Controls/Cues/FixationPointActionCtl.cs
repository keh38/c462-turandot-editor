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

namespace Turandot_Editor.Controls
{
    public partial class FixationPointActionCtl : KUserControl
    {
        FixationPointAction _value = null;

        public FixationPointActionCtl()
        {
            InitializeComponent();
        }

        public Cue Value
        {
            get { return _value; }
            set
            {
                _value = value as FixationPointAction;
                ShowValue();
            }
        }

        void ShowValue()
        {
            _ignoreEvents = true;

            anglePanel.Visible = _value != null;

            if (_value != null)
            {
                startComboBox.SelectedIndex = _value.startVisible ? 0 : 1;
                endComboBox.SelectedIndex = _value.endVisible ? 0 : 1;
                changeCheckBox.Checked = _value.changeAppearance;
                anglePanel.Visible = _value.changeAppearance;
                barangleNumeric.FloatValue = _value.angle;
                labelBox.Text = _value.label;
            }

            _ignoreEvents = false;
        }

        private void barangleNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.angle = barangleNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void labelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                labelBox.Text = _value.label;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _value.label = labelBox.Text;
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
            _value.label = labelBox.Text;
            OnValueChanged();
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.startVisible = startComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.endVisible = endComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void changeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.changeAppearance = changeCheckBox.Checked;
                anglePanel.Visible = _value.changeAppearance;
                OnValueChanged();
            }
        }
    }
}
