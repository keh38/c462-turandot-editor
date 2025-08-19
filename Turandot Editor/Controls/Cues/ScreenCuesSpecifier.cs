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
using ImageLayout = Turandot.Screen.ImageLayout;

namespace Turandot_Editor.Controls
{
    public partial class ScreenCuesSpecifier : KUserControl
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

        public ScreenCuesSpecifier()
        {
            InitializeComponent();

            cueListBox.AttachPropertyGrid(propertyGrid);
            cueListBox.GetDisplayText += GetDisplayText;
            cueListBox.CreateNewItem += CreateNewCueLayout;

//            KLib.Controls.Utilities.SetCueBanner(cueDropDown.Handle, "Add...");
        }

        private void ShowValue()
        {
            cueListBox.Collection = _value;
            //if (_value == null) return;

            //cueListBox.co

            //cueListBox2.Items.Clear();
            //cueListBox2.Items.AddRange(_value.Select(x => x.Name).ToArray());
            //if (_value.Count > 0)
            //{
            //    cueListBox2.SelectedIndex = 0;
            //}
            //else
            //{
            //    propertyGrid.SelectedObject = null;
            //}
        }

        private string GetDisplayText(object item)
        {
            if (item != null && item is CueLayout)
            {
                return (item as CueLayout).Name;
            }
            return "";
        }

        private object CreateNewCueLayout(object item)
        {
            if (!(item is string)) return null;
            string cueType = (string)item;
            string baseName = cueType;
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

            switch (baseName)
            {
                case "Fixation point":
                    return new FixationPointLayout() { Name = name };
                case "Image":
                    return new ImageLayout() { Name = name };
                case "Message":
                    return new MessageLayout() { Name = name };
                case "Video":
                    return new VideoLayout() { Name = name };
            }
            return null;
        }


        private void cueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (_ignoreEvents) return;

            //propertyGrid.SelectedObject = _value.Find(x => x.Name.Equals(cueListBox2.SelectedItem.ToString()));
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //if (e.ChangedItem.Label == "Name")
            //{
            //    _ignoreEvents = true;
            //    int index = cueListBox2.SelectedIndex;
            //    cueListBox2.Items[index] = e.ChangedItem.Value.ToString();
            //    cueListBox2.SelectedIndex = index;
            //    OnNameChange(e.OldValue.ToString(), e.ChangedItem.Value.ToString());
            //}
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //if (cueListBox2.SelectedIndex < 0) return;
            //var toRemove = _value.Find(x => x.Name == cueListBox2.SelectedItem.ToString());
            //if (toRemove != null)
            //{
            //    _value.Remove(toRemove);
            //}
            //ShowValue();
            //OnValueChanged();
        }

        private void cueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cueDropDown.SelectedIndex < 0) return;

            //string baseName = cueDropDown.SelectedItem.ToString();
            //string name = baseName;
            //int num = 1;
            //while (true)
            //{
            //    if (_value.Find(x => x.Name.Equals(name)) == null)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        num++;
            //        name = $"{baseName}_{num}";
            //    }
            //}

            //switch (baseName)
            //{
            //    case "Fixation point":
            //        _value.Add(new FixationPointLayout() { Name = name });
            //        break;
            //    case "Image":
            //        _value.Add(new ImageLayout() { Name = name });
            //        break;
            //    case "Message":
            //        _value.Add(new MessageLayout() { Name = name });
            //        break;
            //    case "Video":
            //        _value.Add(new VideoLayout() { Name = name });
            //        break;
            //}

            //cueListBox2.Items.Add(name);
            //cueListBox2.SelectedItem = _value.Count - 1;
            //cueDropDown.SelectedIndex = -1;
            //ShowValue();
            //OnValueChanged();
        }
    }
}
