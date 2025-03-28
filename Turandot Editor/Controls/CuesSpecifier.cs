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
    public partial class CuesSpecifier : KUserControl
    {
        private List<CueLayout> _value;

        public List<CueLayout> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public CuesSpecifier()
        {
            InitializeComponent();

            KLib.Controls.Utilities.SetCueBanner(cueDropDown.Handle, "Add...");
        }

        private void ShowValue()
        {
            if (_value == null) return;

            cueListBox.Items.Clear();
            cueListBox.Items.AddRange(_value.Select(x => x.Name).ToArray());
            if (_value.Count > 0)
            {
                cueListBox.SelectedIndex = 0;
            }
        }

        private void cueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ignoreEvents) return;

            propertyGrid.SelectedObject = _value[cueListBox.SelectedIndex];
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (e.ChangedItem.Label == "Name")
            {
                _ignoreEvents = true;
                int index = cueListBox.SelectedIndex;
                cueListBox.Items[index] = e.ChangedItem.Value.ToString();
                cueListBox.SelectedIndex = index;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void cueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newCue = new Turandot.Screen.MessageLayout() { Name = "Message" };
            _value.Add(newCue);

            cueListBox.Items.Add(newCue.Name);
            cueListBox.SelectedItem = _value.Count - 1;

        }
    }
}
