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
using Turandot.Screen;

using KLib.ExtensionMethods;

namespace Turandot_Editor.Controls
{
    public partial class AllCuesControl : KUserControl
    {
        private List<Cue> _cues = null;
        private List<string> _tabNames = new List<string>();

        public AllCuesControl()
        {
            InitializeComponent();

            foreach (TabPage p in cueTabs.TabPages) _tabNames.Add(p.Text.ToLower());
        }

        public List<Cue> Value
        {
            get { return _cues; }
            set
            {
                _cues = value;
                ShowCues();
            }
        }

        public void SetAvailableCues(List<string> available)
        {
            listBox.Items.Clear();
            available.Sort();
            foreach (var a in available) listBox.Items.Add(a.FirstLetterToUpperCase());
            ShowCues();
        }

        private void ShowCues()
        {
            _ignoreEvents = true;

            if (_cues == null || _cues.Count == 0)
            {
                cueTabs.Visible = false;
                for (int k = 0; k < listBox.Items.Count; k++) listBox.SetItemChecked(k, false);
                return;
            }

            cueTabs.Visible = true;

            int select = 0;
            for (int k = 0; k < listBox.Items.Count; k++)
            {
                Cue c = _cues.Find(v => v.Name == listBox.Items[k] as string);
                listBox.SetItemChecked(k, c != null);

                if (select == 0 && c != null) select = k;
            }

            foreach (Cue c in _cues)
            {
                if (c is Turandot.Cues.Message)
                    messageControl.Value = c as Turandot.Cues.Message;
                else if (c is FixationPointAction)
                    fixationPointActionCtl.Value = c as FixationPointAction;
                else if (c is Turandot.Cues.Image)
                    imageControl.Value = c as Turandot.Cues.Image;
                else if (c is ProgressBarAction)
                    progressBarActionCtl.Value = c;
                else if (c is Turandot.Cues.Help)
                    helpControl.Value = c;
                else if (c is CounterAction)
                    counterActionControl.Value = c as CounterAction;
                else if (c is ScoreboardAction)
                    scoreboardActionControl.Value = c as ScoreboardAction;
                else
                    ledControl.Value = c;
            }

            if (listBox.Items.Count > 0)
            {
                listBox.SelectedIndex = select;
                ShowSelected();
            }

            _ignoreEvents = false;
        }

        private void ShowSelected()
        {
            _ignoreEvents = true;

            string item = listBox.SelectedItem as string;
            Cue c = _cues.Find(v => v.Name == item);

            cueTabs.Visible = c != null;
            cueTabs.SelectedIndex = _tabNames.IndexOf(item.ToLower());

            _ignoreEvents = false;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelected();
        }

        private void listBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_ignoreEvents) return;

            string item = listBox.SelectedItem as string;
            Cue c = _cues.Find(v => v.Name == item);

            if (e.NewValue == CheckState.Unchecked)
            {
                if (c != null)
                {
                    _cues.Remove(c);
                    OnCueAddRemove(new CueAddRemoveArgs(c.Name, false));
                }
            }
            else if (c == null)
            {
                if (item == "Fixation point")
                {
                    c = new FixationPointAction();
                    fixationPointActionCtl.Value = c;
                }
                else if (item == "LED")
                {
                    c = DefaultCue();
                    ledControl.Value = c;
                }
                else if (item == "Help")
                {
                    c = DefaultHelpCue();
                    helpControl.Value = c;
                }
                else if (item == "Image")
                {
                    c = DefaultImageCue();
                    imageControl.Value = c as Turandot.Cues.Image;
                }
                else if (item == "Message")
                {
                    c = DefaultMessageCue();
                    messageControl.Value = c;
                }
                else if (item == "Progress bar")
                {
                    c = new ProgressBarAction();
                    progressBarActionCtl.Value = c;
                }
                else if (item == "Counter")
                {
                    c = new CounterAction();
                    counterActionControl.Value = c as CounterAction;
                }
                else if (item == "Scoreboard")
                {
                    c = new ScoreboardAction();
                    scoreboardActionControl.Value = c as ScoreboardAction;
                }

                _cues.Add(c);
                OnValueChanged();
                OnCueAddRemove(new CueAddRemoveArgs(c.Name, true));
            }
            ShowSelected();
        }

        private void fixationPointActionCtl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void imageControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void ledControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void messageControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void progressBarActionCtl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void helpControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void counterActionControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
        private void scoreboardActionControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private Cue DefaultCue()
        {
            Cue c = new Cue();
            c.startVisible = true;
            c.duration_ms = 200;
            c.interval_ms = 500;
            c.color = Color.Green.ToArgb();
            c.endVisible = false;
            return c;
        }

        private Turandot.Cues.Message DefaultMessageCue()
        {
            Turandot.Cues.Message c = new Turandot.Cues.Message();
            c.startVisible = true;
            c.duration_ms = 200;
            c.interval_ms = 500;
            c.color = Color.White.ToArgb();
            c.endVisible = false;
            c.fontSize = 32;
            c.text = "Message to display";
            return c;
        }

        private Turandot.Cues.Help DefaultHelpCue()
        {
            Turandot.Cues.Help c = new Turandot.Cues.Help();
            c.startVisible = true;
            c.duration_ms = 200;
            c.interval_ms = 500;
            c.color = Color.Black.ToArgb();
            c.endVisible = false;
            c.text = "Help message";
            return c;
        }

        private Turandot.Cues.Image DefaultImageCue()
        {
            Turandot.Cues.Image image = new Turandot.Cues.Image();
            image.startVisible = true;
            image.duration_ms = 200;
            image.interval_ms = 500;
            image.endVisible = false;
            return image;
        }


        #region Events
        public event EventHandler<CueAddRemoveArgs> CueAddRemove;
        protected virtual void OnCueAddRemove(CueAddRemoveArgs args)
        {
            if (this.CueAddRemove != null) CueAddRemove(this, args);
        }
        public class CueAddRemoveArgs : EventArgs
        {
            public string type;
            public bool added;
            public CueAddRemoveArgs(string type, bool added) { this.type = type; this.added = added; }
        }
        #endregion

    }
}
