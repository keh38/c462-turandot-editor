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

namespace Turandot_Editor.Controls.Cues
{
    public partial class ScoreboardActionControl : KUserControl
    {
        private ScoreboardAction _value = null;

        public ScoreboardActionControl()
        {
            InitializeComponent();

            actionEnum.Fill(typeof(ScoreboardAction.ScoreAction));
        }

        public ScoreboardAction Value
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

            startComboBox.SelectedIndex = _value.startVisible ? 0 : 1;
            endComboBox.SelectedIndex = _value.endVisible ? 0 : 1;

            actionEnum.SetEnumValue(_value.action);
            changePanel.Visible = _value.action == ScoreboardAction.ScoreAction.Change;

            deltaExprTextBox.Text = _value.deltaExpr;
            rateNumeric.IntValue = _value.pointsPerSec;
            tmaxNumeric.FloatValue = _value.maxSec;

            _ignoreEvents = false;
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

        private void actionEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.action = (ScoreboardAction.ScoreAction)actionEnum.Value;
                changePanel.Visible = _value.action == ScoreboardAction.ScoreAction.Change;

                OnValueChanged();
            }
        }

        private void deltaExprTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _value.deltaExpr = deltaExprTextBox.Text;
                //e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void deltaExprTextBox_Leave(object sender, EventArgs e)
        {
            _value.deltaExpr = deltaExprTextBox.Text;
            OnValueChanged();
        }

        private void rateNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.pointsPerSec = rateNumeric.IntValue;
                OnValueChanged();
            }
        }
        private void tmaxNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.maxSec = tmaxNumeric.FloatValue;
                OnValueChanged();
            }
        }

    }
}
