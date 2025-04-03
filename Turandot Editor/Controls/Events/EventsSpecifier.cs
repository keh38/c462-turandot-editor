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
                inputCriteria.Value = inputEvent.criteria;
            }

            _ignoreEvents = false;
        }

        private void ShowFlags(List<Flag> flags)
        {
            flagControl.Value = flags;
            //inputCriteria.FlagNames = _params.flags.Select(f => f.name).ToArray();
        }

        private void eventListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            InputEvent inputEvent = new InputEvent(e.name);
            _events.Insert(e.index, inputEvent);
            ShowEventCriteria(inputEvent);
        }

        //private void eventListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        //{
        //    string oldName = _params.RenameEvent(e.name, e.index);
        //    graphViewer.RenameEvent(oldName, e.name);
        //    SetDirty();
        //}

        //private void eventListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        //{
        //    _params.DeleteEvents(e.names);
        //    graphViewer.DeleteEvents(e.names);
        //    SetDirty();
        //}

        //private void eventListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        //{
        //    _params.MoveEvent(e.name, e.index);
        //    SetDirty();
        //}

        //private void eventListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        //{
        //    _params.MoveEvents(e.names);
        //    SetDirty();
        //}

        //private void eventListBox_SelectionChanged(object sender, KUserListBox.ChangedItem e)
        //{
        //    if (!_ignoreEvents)
        //    {
        //        ShowEventCriteria(e.index >= 0 ? _params.inputEvents[e.index] : null);
        //    }
        //}

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

    }
}
