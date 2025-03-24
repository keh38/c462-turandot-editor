using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DlgResult = System.Windows.Forms.DialogResult;

using KLib.Controls;
using Turandot.Inputs;

namespace Turandot_Editor.Controls
{
    public partial class AllSAMControl : KUserControl
    {
        private SAM _value = null;

        public AllSAMControl()
        {
            InitializeComponent();
        }

        public SAM Value
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

            valenceControl.Value = _value.valence;
            arousalControl.Value = _value.arousal;
            dominanceControl.Value = _value.dominance;
            loudnessControl.Value = _value.loudness;
            colorBox.BackColor = Color.FromArgb(_value.color);

            _ignoreEvents = false;
        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Color.FromArgb(_value.color);

            if (dlg.ShowDialog() == DlgResult.OK)
            {
                _value.color = dlg.Color.ToArgb();
                colorBox.BackColor = Color.FromArgb(_value.color);
                OnValueChanged();
            }
        }
    }
}
