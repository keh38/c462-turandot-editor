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
    public partial class ScreenInputsSpecifier : KUserControl
    {
        private List<InputLayout> _value;

        public List<InputLayout> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                inputListBox.Collection = _value;
            }
        }

        public delegate void NameChangeDelegate(string oldName, string newName);
        public NameChangeDelegate NameChange;
        private void OnNameChange(string oldName, string newName) { NameChange?.Invoke(oldName, newName); }

        public ScreenInputsSpecifier()
        {
            InitializeComponent();

            inputListBox.AttachPropertyGrid(propertyGrid);
            inputListBox.GetDisplayText += GetDisplayText;
            inputListBox.CreateNewItem += CreateNewInputLayout;
        }

        private string GetDisplayText(object item)
        {
            if (item != null && item is InputLayout)
            {
                return (item as InputLayout).Name;
            }
            return "";
        }

        private object CreateNewInputLayout(object item)
        {
            if (!(item is string)) return null;

            string baseName = item as string;
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
                case "Button":
                    return CreateNewButtonLayout(name);
//                    return new ButtonLayout() { Name = name };
                case "Checklist":
                    return new ChecklistLayout() { Name = name };
                case "Manikins":
                    return new ManikinLayout() { Name = name };
                case "Param Slider":
                    return new ParamSliderLayout() { Name = name };
                case "Scaler":
                    return new ScalerLayout() { Name = name };
            }

            return null;
        }

        private ButtonLayout CreateNewButtonLayout(string name)
        {
            var layout = _value.FindLast(x => x is ButtonLayout);
            if (layout == null)
            {
                return new ButtonLayout() { Name = name };
            }

            var lastButton = layout as ButtonLayout;

            return new ButtonLayout()
            {
                Name = name,
                Label = lastButton.Name,
                Width = lastButton.Width,
                Height = lastButton.Height,
                Style = lastButton.Style,
                FontSize = lastButton.FontSize
            };
        }

        private void inputListBox_ItemAdded(object sender, CollectionListBox.ChangedItem e)
        {
            OnValueChanged();
        }

        private void inputListBox_ItemRemoved(object sender, CollectionListBox.ChangedItem e)
        {
            OnValueChanged();
        }

        private void inputListBox_ItemRenamed(object sender, CollectionListBox.RenamedItem e)
        {
            OnNameChange(e.oldName, e.newName);
        }
    }
}
