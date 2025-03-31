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

using Turandot.Screen;

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

        public delegate void NameChangeDelegate(string oldName, string newName);
        public NameChangeDelegate NameChange;
        private void OnNameChange(string oldName, string newName) { NameChange?.Invoke(oldName, newName); }


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
                OnNameChange(e.OldValue.ToString(), e.ChangedItem.Value.ToString());
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cueListBox.SelectedIndex < 0) return;
            var toRemove = _value.Find(x => x.Name == cueListBox.SelectedItem.ToString());
            if (toRemove != null)
            {
                _value.Remove(toRemove);
            }
            ShowValue();
            OnValueChanged();
        }

        private void cueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseName = "Message";
            string name = baseName;
            int num = 1;
            while (true)
            {
                if (_value.Find(x => x.Name.Equals(name)) == null)
                {
                    break;
                }
                else
                {
                    num++;
                    name = $"{baseName}_{num}";
                }
            }

            //var newCue = new Turandot.Screen.MessageLayout() { Name = name };
            var newCue = new Turandot.Screen.MessageLayout();
            _value.Add(newCue);

            cueListBox.Items.Add(newCue.Name);
            cueListBox.SelectedItem = _value.Count - 1;
            OnValueChanged();
        }
    }
}
