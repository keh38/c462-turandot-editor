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

using Turandot.Inputs;
using Turandot.Screen;

using KLib.ExtensionMethods;
using KLib.Signals;

namespace Turandot_Editor.Controls
{
    public partial class StateInputsControl : KUserControl
    {
        private List<Input> _value = null;
        private List<InputLayout> _available;
        private List<ChannelProperties> _validProperties;

        public StateInputsControl()
        {
            InitializeComponent();
        }

        public List<Input> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ApplyContextData();
                ShowInputs();
            }
        }

        private void ApplyContextData()
        {
            if (_value == null) return;

            foreach (var i in _value)
            {
                if (i is ParamSliderAction && _validProperties != null)
                {
                    (i as ParamSliderAction).SetDataForContext(_validProperties);
                }
            }
        }

        public void SetAvailableInputs(List<InputLayout> available)
        {
            // don't want the sort to change the original list
            _available = new List<InputLayout>();
            _available.AddRange(available);

            _available.Sort((x, y) => x.Name.CompareTo(y.Name));

            inputDropDown.Items.Clear();
            foreach (var a in _available) inputDropDown.Items.Add(a.Name);
            KLib.Controls.Utilities.SetCueBanner(inputDropDown.Handle, "Add input");

            ShowInputs();
        }

        public void SetDataForContext(List<ChannelProperties> channelProperties)
        {
            _validProperties = channelProperties;
        }

        private void ShowInputs()
        {
            if (_value == null) return;

            inputListBox.Items.Clear();
            inputListBox.Items.AddRange(_value.Select(x => x.Target).ToArray());
            if (_value.Count > 0)
            {
                inputListBox.SelectedIndex = 0;
            }
            else
            {
                propertyGrid.SelectedObject = null;
            }
        }

        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputListBox.SelectedIndex < 0) return;

            propertyGrid.SelectedObject = _value[inputListBox.SelectedIndex];
        }

        #region Events
        public event EventHandler<InputAddRemoveArgs> InputAddRemove;
        protected virtual void OnInputAddRemove(InputAddRemoveArgs args) { InputAddRemove?.Invoke(this, args); }
        public class InputAddRemoveArgs : EventArgs
        {
            public string type;
            public bool added;
            public InputAddRemoveArgs(string type, bool added) { this.type = type; this.added = added; }
        }
        #endregion

        private void inputDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputDropDown.SelectedIndex < 0) return;
            if (inputListBox.Items.Contains(inputDropDown.SelectedItem.ToString())) return;

            var i = _available[inputDropDown.SelectedIndex];
            inputListBox.Items.Add(i.Name);
            if (i is ButtonLayout)
            {
                _value.Add(new Turandot.Inputs.Button());
            }
            else if (i is ChecklistLayout)
            {
               _value.Add(new Turandot.Inputs.Input("Checklist"));
            }
            else if (i is ManikinLayout)
            {
                _value.Add(new Turandot.Inputs.Input("Manikins"));
            }
            else if (i is ParamSliderLayout)
            {
                var psa = new Turandot.Inputs.ParamSliderAction();
                if (_validProperties != null)
                {
                    psa.SetDataForContext(_validProperties);
                }
                _value.Add(psa);
            }
            else if (i is ScalerLayout)
            {
                _value.Add(new Turandot.Inputs.ScalerAction());
            }

            _value[_value.Count - 1].Target = i.Name;

            inputListBox.SelectedItem = _value.Count - 1;
            inputDropDown.SelectedIndex = -1;

            ShowInputs();
            OnValueChanged();
            OnInputAddRemove(new InputAddRemoveArgs(i.Name, true));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (inputListBox.SelectedIndex < 0) return;
            var toDelete = _value.Find(x => x.Target.Equals(inputListBox.SelectedItem.ToString()));
            if (toDelete != null) _value.Remove(toDelete);

            ShowInputs();
            OnValueChanged();
            OnInputAddRemove(new InputAddRemoveArgs(toDelete.Target, false));
        }
   }
}
