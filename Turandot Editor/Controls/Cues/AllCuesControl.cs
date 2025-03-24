using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
        private List<Cue> _value = null;
        private List<CueLayout> _available;

        public AllCuesControl()
        {
            InitializeComponent();
        }

        public List<Cue> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowCues();
            }
        }

        public void SetAvailableCues(List<CueLayout> available)
        {
            _available = available;
            _available.Sort();

            cueDropDown.Items.Clear();
            foreach (var a in _available) cueDropDown.Items.Add(a.Name);
            KLib.Controls.Utilities.SetCueBanner(cueDropDown.Handle, "Add cue");

            ShowCues();
        }

        private void ShowCues()
        {
            if (_value == null) return;

            cueListBox.Items.Clear();
            cueListBox.Items.AddRange(_value.Select(x => x.Name).ToArray());
            if (_value.Count > 0)
            {
                cueListBox.SelectedIndex = 0;
            }
            else
            {
                propertyGrid.SelectedObject = null;
            }
        }

        private void cueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = _value[cueListBox.SelectedIndex];
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

        private void cueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cueListBox.Items.Contains(cueDropDown.SelectedText)) return;

            var c = _available[cueDropDown.SelectedIndex];
            if (c is MessageLayout)
            {
                cueListBox.Items.Add(c.Name);
                _value.Add((c as MessageLayout).GetDefaultCue());
                cueListBox.SelectedItem = _value.Count - 1;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

    }
}
