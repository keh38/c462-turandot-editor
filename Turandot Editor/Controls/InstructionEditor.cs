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

namespace Turandot_Editor.Controls
{
    public partial class InstructionEditor : KUserControl
    {
        Instructions _value = null;

        public InstructionEditor()
        {
            InitializeComponent();
        }

        public Instructions Value
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
            if (_value == null)
            {
                textBox.Text = "";
                return;
            }

            _ignoreEvents = true;
            
            propertyGrid.SelectedObject = _value;

            if (_value.Text == null)
            {
                textBox.Text = "";
            }
            else
            {
                string text = _value.Text.Replace("\n", Environment.NewLine);
                textBox.Text = text;
            }

            _ignoreEvents = false;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            _value.Text = textBox.Text;
            OnValueChanged();
        }

    }

}
