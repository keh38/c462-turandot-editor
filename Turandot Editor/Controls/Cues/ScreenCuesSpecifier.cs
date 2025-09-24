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
                cueListBox.Collection = _value;
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
                case "Text box":
                    return new TextBoxLayout() { Name = name };
                case "Video":
                    return new VideoLayout() { Name = name };
            }
            return null;
        }

        private void cueListBox_ItemAdded(object sender, CollectionListBox.ChangedItem e)
        {
            OnValueChanged();
        }

        private void cueListBox_ItemRemoved(object sender, CollectionListBox.ChangedItem e)
        {
            OnValueChanged();
        }

        private void cueListBox_ItemRenamed(object sender, CollectionListBox.RenamedItem e)
        {
            OnNameChange(e.oldName, e.newName);
        }
    }
}
