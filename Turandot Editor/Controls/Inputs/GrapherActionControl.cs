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
    public partial class GrapherActionControl : KUserControl
    {
        private GrapherAction _value = null;

        public GrapherActionControl()
        {
            InitializeComponent();
        }

        public GrapherAction Value
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

            resetCheckbox.Checked = _value.reset;
            markCheckbox.Checked = _value.markStimuli;

            _ignoreEvents = false;
        }

        private void resetCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.reset = resetCheckbox.Checked;
                OnValueChanged();
            }
        }

        private void markCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _value.markStimuli = markCheckbox.Checked;
                OnValueChanged();
            }
        }
    }
}
