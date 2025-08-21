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

namespace Turandot_Editor.Controls.Events
{
    public partial class EventsSpecifier : KUserControl
    {
        private List<InputEvent> _events;
        private List<Flag> _flags;

        private List<string> _inputs;

        public EventsSpecifier()
        {
            InitializeComponent();
        }

        public void UpdateInputSources(List<string> inputs, List<string> scalarControls)
        {
            _inputs = inputs;

            _ignoreEvents = true;

            inputCriteria.SetDigitalInputs(inputs);
            //inputCriteria.ScalarNames = scalarControls.ToArray();

            _ignoreEvents = false;
        }

        public void SetData(List<InputEvent> events, List<Flag> flags)
        {
            _events = events;
            _flags = flags;

            _ignoreEvents = true;

            ShowData();

            _ignoreEvents = false;
        }

        void ShowData()
        {
            ShowFlags(_flags);

            _ignoreEvents = true;

            eventListBox.SetItems(_events.Select(e => e.name).ToList());
            eventListBox.SelectedIndex = _events.Count > 0 ? 0 : -1;
            _ignoreEvents = false;

            ShowEventCriteria(_events.Count > 0 ? _events[0] : null);
        }

        private void ShowEventCriteria(InputEvent inputEvent)
        {
            _ignoreEvents = true;

            inputCriteria.Enabled = inputEvent != null;
            if (inputEvent == null)
            {
                inputCriteria.Tag = null;
                inputCriteria.Clear();
            }
            else
            {
                inputCriteria.Tag = inputEvent;
                //inputCriteria.Value = inputEvent.criteria;
                inputCriteria.SetValue(inputEvent.criteria);
            }

            _ignoreEvents = false;
        }

        private void ShowFlags(List<Flag> flags)
        {
            flagControl.Value = flags;
            inputCriteria.SetFlagNames(flags.Select(f => f.name).ToList());
        }

        private void eventListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            var inputEvent = new InputEvent(e.name);
            _events.Insert(e.index, inputEvent);
            ItemAdded?.Invoke(this, e);
        }

        private void eventListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        {
            ItemRenamed(this, e);
        }

        private void eventListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        {
            ItemsDeleted(this, e);
        }

        private void eventListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        {
            ItemMoved(this, e);
        }

        private void eventListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        {
            ItemsMoved(this, e);
        }

        private void eventListBox_SelectionChanged(object sender, KUserListBox.ChangedItem e)
        {
            if (!_ignoreEvents)
            {
                ShowEventCriteria(e.index >= 0 ? _events[e.index] : null);
            }
        }

        private void flagControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                inputCriteria.SetFlagNames(_flags.Select(x => x.name).ToList());
                OnValueChanged();
            }
        }

        private void inputCriteria_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                //(inputCriteria.Tag as InputEvent).criteria = inputCriteria.Value;
                OnValueChanged();
            }
        }
        #region Events
        public event EventHandler<KUserListBox.ChangedItem> ItemAdded;
        private void OnItemAdded(KUserListBox.ChangedItem itemChanged)
        {
            ItemAdded?.Invoke(this, itemChanged);
        }

        public event EventHandler<KUserListBox.ChangedItem> ItemRenamed;
        private void OnItemRenamed(KUserListBox.ChangedItem itemChanged)
        {
            ItemRenamed?.Invoke(this, itemChanged);
        }

        public event EventHandler<KUserListBox.ChangedItem> ItemMoved;
        private void OnItemMoved(KUserListBox.ChangedItem itemChanged)
        {
            ItemMoved?.Invoke(this, itemChanged);
        }

        public event EventHandler<KUserListBox.ChangedItems> ItemsDeleted;
        private void OnItemsDeleted(KUserListBox.ChangedItems items)
        {
            ItemsDeleted?.Invoke(this, items);
        }

        public event EventHandler<KUserListBox.ChangedItems> ItemsMoved;
        private void OnItemsMoved(KUserListBox.ChangedItems items)
        {
            ItemsMoved?.Invoke(this, items);
        }

        #endregion
    }
}
