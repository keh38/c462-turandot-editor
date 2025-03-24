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

namespace Turandot_Editor.Controls.Inputs
{
    public partial class AllButtonControl : KUserControl
    {
        private List<ButtonSpec> _value;

        public AllButtonControl()
        {
            InitializeComponent();
        }

        public List<ButtonSpec> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public bool AllowXbox
        {
            set { buttonControl.AllowXbox = value; }
        }

        private void ShowValue()
        {
            if (_value == null) return;

            _ignoreEvents = true;

            buttonListBox.SetItems(_value.Select(e => e.name).ToList());
            buttonListBox.SelectedIndex = _value.Count > 0 ? 0 : -1;

            _ignoreEvents = false;

            ShowButtonProperties(_value.Count > 0 ? _value[0] : null);
        }

        private void ShowButtonProperties(ButtonSpec spec)
        {
            buttonControl.Visible = spec != null;
            buttonControl.Value = spec;
        }

        private void buttonListBox_SelectionChanged(object sender, KUserListBox.ChangedItem e)
        {

            if (!_ignoreEvents && buttonListBox.SelectedIndex >= 0)
            {
                ShowButtonProperties(_value[buttonListBox.SelectedIndex]);
                OnValueChanged();
            }
        }

        private void buttonListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            ButtonSpec b = new ButtonSpec(e.name, e.name);
            b.style = ButtonSpec.ButtonStyle.Square;
            b.size = 200;
            b.y = -35;

            _value.Insert(e.index, b);
//            ShowButtonProperties(_value[buttonListBox.SelectedIndex]);
            ShowButtonProperties(_value[e.index]);

            OnItemAdded(new ChangedItem(e.name, e.index));

            OnValueChanged();
        }

        private void buttonListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        {

        }

        private void buttonListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        {
            string oldName = _value[e.index].name;
            buttonControl.ChangeName(e.name);
            OnItemRenamed(new ChangedItem(e.name, oldName, e.index));
        }

        private void buttonListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        {
            foreach (ButtonSpec b in _value.FindAll(o => e.names.Contains(o.name))) _value.Remove(b);

            _ignoreEvents = true;
            buttonListBox.SelectedIndex = _value.Count > 0 ? 0 : -1;
            _ignoreEvents = false;

            ShowButtonProperties(_value.Count > 0 ? _value[0] : null);

            OnItemsDeleted(new ChangedItems(e.names));
        }

        private void buttonListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        {
            List<ButtonSpec> temp = new List<ButtonSpec>(_value);
            _value.Clear();
            foreach (var n in e.names)
            {
                _value.Add(temp.Find(o => o.name == n));
            }
            OnValueChanged();
        }

        #region Events
        public event EventHandler<ChangedItem> ItemAdded;
        private void OnItemAdded(ChangedItem itemChanged)
        {
            if (ItemAdded != null) ItemAdded(this, itemChanged);
        }

        public event EventHandler<ChangedItem> ItemRenamed;
        private void OnItemRenamed(ChangedItem itemChanged)
        {
            if (ItemRenamed != null) ItemRenamed(this, itemChanged);
        }

        public event EventHandler<ChangedItem> ItemMoved;
        private void OnItemMoved(ChangedItem itemChanged)
        {
            if (ItemMoved != null) ItemMoved(this, itemChanged);
        }

        public event EventHandler<ChangedItems> ItemsDeleted;
        private void OnItemsDeleted(ChangedItems items)
        {
            if (ItemsDeleted != null) ItemsDeleted(this, items);
        }

        public event EventHandler<ChangedItems> ItemsMoved;
        private void OnItemsMoved(ChangedItems items)
        {
            if (ItemsMoved != null) ItemsMoved(this, items);
        }

        public class ChangedItem : EventArgs
        {
            public string name;
            public string oldName;
            public int index;
            public ChangedItem(string name, string oldName, int index)
            {
                this.name = name;
                this.oldName = oldName;
                this.index = index;
            }
            public ChangedItem(string name, int index)
            {
                this.name = name;
                this.oldName = null;
                this.index = index;
            }
        }
        public class ChangedItems : EventArgs
        {
            public List<string> names;
            public ChangedItems(List<string> names)
            {
                this.names = names;
            }
        }

        #endregion
    }
}
