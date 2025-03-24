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
using KLib.ExtensionMethods;

using Turandot.Inputs;
using Button = Turandot.Inputs.Button;
using TKeypad = Turandot.Inputs.Keypad;

using DlgResult = System.Windows.Forms.DialogResult;

namespace Turandot_Editor.Controls
{
    public partial class InputControl : KUserControl
    {
        private List<Input> _value = null;
        private int _numNonButton = 0;
        private List<string> _tabNames = new List<string>();

        public InputControl()
        {
            InitializeComponent();

            foreach (TabPage p in tabControl.TabPages) _tabNames.Add(p.Text.ToLower());
        }

        public List<Input> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public void SetAvailableInputs(List<string> items, List<string> buttonNames)
        {
            listBox.Items.Clear();
            _numNonButton = 0;
            items.Sort();
            foreach (string s in items)
            {
                if (buttonNames.Find(o => o.ToLower().Equals(s)) == null && !s.ToLower().Equals("pupillometer"))
                {
                    listBox.Items.Add(s == "sam" ? "SAM" : s.FirstLetterToUpperCase());
                    _numNonButton++;
                }
            }
            foreach (string n in buttonNames) listBox.Items.Add(n);
        }

        private void ShowValue()
        {
            _ignoreEvents = true;

            if (_value == null || _value.Count == 0)
            {
                generalPanel.Visible = false;
                tabControl.Visible = false;
                for (int k = 0; k < listBox.Items.Count; k++) listBox.SetItemChecked(k, false);
                return;
            }

            generalPanel.Visible = true;
            tabControl.Visible = true;

            int select = 0;
            for (int k=0; k<listBox.Items.Count; k++)
            {
                Input i = _value.Find(v => v.name == listBox.Items[k] as string);
                listBox.SetItemChecked(k, i != null);

                if (select == 0 && i != null) select = k;
            }

            listBox.SelectedIndex = select;
            ShowSelected();

            _ignoreEvents = false;
        }

        private void ShowSelected()
        {
            _ignoreEvents = true;

            string item = listBox.SelectedItem as string;
            Input i = _value.Find(v => v.name == item);

            generalPanel.Visible = i != null && !(i is RandomProcess);
            tabControl.Visible = i != null;

            if (i != null)
            {
                startComboBox.SelectedIndex = i.startVisible ? 0 : 1;
                endComboBox.SelectedIndex = i.endVisible ? 0 : 1;
                xNumeric.IntValue = i.X;
                yNumeric.IntValue = i.Y;
                labelBox.Text = i.label;
                enableCheckBox.Checked = i.enabled;
            }
            tabControl.SelectedIndex = listBox.SelectedIndex < _numNonButton ? _tabNames.IndexOf(item.ToLower()) : _tabNames.Count-1;

            if (i is Categorizer)
            {
                catBox.Text = "";
                foreach (string s in (i as Categorizer).categories)
                    catBox.Text += s + Environment.NewLine;

                catApplyButton.Enabled = false;
                positionPanel.Visible = true;
            }
            else if (i is GrapherAction)
            {
                positionPanel.Visible = false;
                grapherActionControl.Value = i as GrapherAction;
            }
            else if (i is TKeypad)
            {
                kpBackgroundColorBox.BackColor = Color.FromArgb((i as TKeypad).backgroundColor);
            }
            else if (i is ParamSliderAction)
            {
                paramSliderActionControl.Value = i as ParamSliderAction;
            }
            else if (i is RandomProcess)
            {
                randomProcessControl.Value = i as RandomProcess;
            }
            else if (i is SAM)
            {
                positionPanel.Visible = true;
                samControl.Value = i as SAM;
            }
            else if (i is Scaler)
            {
                positionPanel.Visible = true;
                scalerControl.Value = (i as Scaler);
            }
            else if (i is ThumbSliderAction)
            {
                tsInitPosNumeric.FloatValue = i.value;
            }
            else if (i is Button)
            {
                buttonActionControl.Value = i as Button;
                positionPanel.Visible = false;
            }

            _ignoreEvents = false;
        }

        private void listBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_ignoreEvents) return;

            string item = listBox.SelectedItem as string;
            Input i = _value.Find(v => v.name == item);

            if (e.NewValue == CheckState.Unchecked)
            {
                _value.Remove(i);
                OnInputAddRemove(new InputAddRemoveArgs(false));
            }
            else if (i == null)
            {
                if (item == "Categorizer")
                {
                    _value.Add(new Categorizer());
                }
                else if (item == "Grapher")
                {
                    _value.Add(new GrapherAction());
                }
                else if (item == "Keypad")
                {
                    _value.Add(new TKeypad());
                }
                else if (item == "Param slider")
                {
                    _value.Add(new ParamSliderAction());
                }
                else if (item == "Random process")
                {
                    _value.Add(new RandomProcess());
                }
                else if (item == "SAM")
                {
                    SAM sam = new SAM();
                    sam.color = Color.LightGray.ToArgb();
                    _value.Add(sam);
                }
                else if (item == "Scaler")
                {
                    _value.Add(new Scaler());
                }
                else if (item == "Thumb slider")
                {
                    _value.Add(new ThumbSliderAction());
                }
                else
                {
                    _value.Add(new Button(item));
                }
                OnValueChanged();
                OnInputAddRemove(new InputAddRemoveArgs(true));
            }
            ShowSelected();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelected();
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.startVisible = startComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.endVisible = endComboBox.SelectedIndex == 0;
                OnValueChanged();
            }
        }

        private void xNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.X = xNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void yNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.Y = yNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.enabled = enableCheckBox.Checked;
                OnValueChanged();
            }
        }

        private void labelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
                i.label = labelBox.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else base.OnKeyPress(e);
        }

        private void labelBox_Leave(object sender, EventArgs e)
        {
            Input i = _value.Find(v => v.name == listBox.SelectedItem as string);
            i.label = labelBox.Text;
            OnValueChanged();
        }

        #region Events
        public event EventHandler<InputAddRemoveArgs> InputAddRemove;
        protected virtual void OnInputAddRemove(InputAddRemoveArgs args)
        {
            if (this.InputAddRemove != null) InputAddRemove(this, args);
        }
        public class InputAddRemoveArgs : EventArgs
        {
            public bool added;
            public InputAddRemoveArgs(bool added) { this.added = added; }
        }

        #endregion

        private void catBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            catApplyButton.Enabled = true;
        }

        private void catApplyButton_Click(object sender, EventArgs e)
        {
            Categorizer i = _value.Find(v => v.GetType() == typeof(Categorizer)) as Categorizer;
            i.categories = catBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            catApplyButton.Enabled = false;
        }

        private void samControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                OnValueChanged();
            }
        }

        private void kpBackgroundColorBox_Click(object sender, EventArgs e)
        {
            TKeypad i = _value.Find(v => v.GetType() == typeof(TKeypad)) as TKeypad;

            ColorDialog dlg = new ColorDialog();
            dlg.Color = Color.FromArgb(i.backgroundColor);

            if (dlg.ShowDialog() == DlgResult.OK)
            {
                i.backgroundColor = dlg.Color.ToArgb();
                kpBackgroundColorBox.BackColor = Color.FromArgb(i.backgroundColor);
                OnValueChanged();
            }
        }

        private void tsInitPosNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                var i = _value.Find(v => v.GetType() == typeof(ThumbSliderAction)) as ThumbSliderAction;
                i.value = tsInitPosNumeric.FloatValue;
                OnValueChanged();
            }

        }

        private void grapherActionControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void paramSliderActionControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void buttonActionControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void scalerControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void randomProcessControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }
    }
}
