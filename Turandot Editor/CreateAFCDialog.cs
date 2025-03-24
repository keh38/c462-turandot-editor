using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turandot_Editor
{
    public partial class CreateAFCDialog : Form
    {
        string _fmt = "";

        public CreateAFCDialog()
        {
            InitializeComponent();
            _fmt = msgBox.Text;
        }

        public int NumIntervals
        {
            get { return numintNumeric.IntValue; }
            set
            {
                numintNumeric.IntValue = value;
                msgBox.Text = _fmt.Replace("%d", numintNumeric.IntValue.ToString());
            }
        }
        public float ISI
        {
            get { return isiNumeric.FloatValue; }
            set { isiNumeric.FloatValue = value; }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void numintNumeric_ValueChanged(object sender, EventArgs e)
        {
            msgBox.Text = _fmt.Replace("%d", numintNumeric.IntValue.ToString());
        }

        private void isiNumeric_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
