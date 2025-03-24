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
    public partial class ProgressBarActionCtl : KUserControl
    {
        private ProgressBarAction _value = null;

        public ProgressBarActionCtl()
        {
            InitializeComponent();
        }

        public Cue Value
        {
            get { return _value; }
            set
            {
                _value = value as ProgressBarAction;
                ShowValue();
            }
        }

        private void ShowValue()
        {
            if (_value == null) return;

            _ignoreEvents = true;

            startComboBox.SelectedIndex = _value.startVisible ? 0 : 1;
            endComboBox.SelectedIndex = _value.endVisible ? 0 : 1;

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
    }
}
