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

namespace Turandot_Editor
{
    public partial class InputCriterionControl : KUserControl
    {
        private List<string> _inputs;
        private List<string> _flags;
        private List<string> _scalars;

        private bool _isValid;

        private InputCriterion _data;

        public InputCriterionControl()
        {
            InitializeComponent();

            _inputs = new List<string>();
            _flags = new List<string>();
            _scalars = new List<string>();
            _isValid = false;

            stateDropDown.Fill(typeof(InputState));

            opDropDown.Clear();
            opDropDown.AddItem(InputOperator.None, "");
            opDropDown.AddItem(InputOperator.AND, "AND");
            opDropDown.AddItem(InputOperator.OR, "OR");

            comparisonEnum.Clear();
            comparisonEnum.AddItem(Comparison.LE, "<=");
            comparisonEnum.AddItem(Comparison.LT, "<");
            comparisonEnum.AddItem(Comparison.EQ, "==");
            comparisonEnum.AddItem(Comparison.NE, "!=");
            comparisonEnum.AddItem(Comparison.GT, ">");
            comparisonEnum.AddItem(Comparison.GE, ">=");
        }

        public string[] DigitalInputs
        {   
            set
            {
                _inputs.Clear();
                _inputs.AddRange(value);

                controlList.Items.Clear();
                controlList.Items.AddRange(value);
                if (_flags.Count > 0) controlList.Items.AddRange(_flags.ToArray());
                if (_scalars.Count > 0) controlList.Items.AddRange(_scalars.ToArray());
                SetValue(_data);
            }
        }

        public string[] FlagNames
        {
            set
            {
                _flags.Clear();
                _flags.AddRange(value);

                controlList.Items.Clear();
                if (_inputs.Count > 0) controlList.Items.AddRange(_inputs.ToArray());
                controlList.Items.AddRange(value);
                if (_scalars.Count > 0) controlList.Items.AddRange(_scalars.ToArray());
                SetValue(_data);
            }
        }

        public string[] ScalarNames
        {
            set
            {
                _scalars.Clear();
                _scalars.AddRange(value);

                controlList.Items.Clear();
                if (_inputs.Count > 0) controlList.Items.AddRange(_inputs.ToArray());
                if (_flags.Count > 0) controlList.Items.AddRange(_flags.ToArray());
                controlList.Items.AddRange(value);
                SetValue(_data);
            }
        }

        public InputCriterion Value
        {
            get { return _data; }
            set
            {
                _data = value;
                SetValue(value);
            }
        }

        public void Clear()
        {
            _data = new InputCriterion("", InputState.Rising, 10, InputOperator.None, Comparison.EQ);
            _isValid = false;
            opDropDown.Enabled = false;

            _ignoreEvents = true;

            controlList.SelectedIndex = -1;
            stateDropDown.SetEnumValue(_data.state);
            durationNumeric.FloatValue = _data.time_ms;
            opDropDown.SetEnumValue(_data.op);
            comparisonEnum.SetEnumValue(_data.comparison);

            durationNumeric.Visible = false;
            stateDropDown.Visible = false;
            comparisonEnum.Visible = false;

            forLabel.Visible = durationNumeric.Visible;

            _ignoreEvents = false;
        }

        public bool IsValid
        {
            get { return _isValid; }
        }

        public void SetValue(InputCriterion crit)
        {
            if (crit == null) return;

            int index = controlList.Items.IndexOf(crit.control);
            if (index < 0) return;

            _ignoreEvents = true;

            controlList.SelectedIndex = Math.Max(0, index);
            _isValid = controlList.SelectedIndex >= 0;

            stateDropDown.SetEnumValue(crit.state);
            comparisonEnum.SetEnumValue(crit.comparison);
            durationNumeric.Value = crit.time_ms;

            if (controlList.SelectedIndex < _inputs.Count)
            {
                stateDropDown.Visible = true;
                comparisonEnum.Visible = false;
                durationNumeric.Visible = (crit.state == InputState.High || crit.state == InputState.Low);
                forLabel.Visible = durationNumeric.Visible;
                durationNumeric.Units = "ms";
            }
            else
            {
                forLabel.Visible = false;
                stateDropDown.Visible = false;
                comparisonEnum.Visible = true;
                durationNumeric.Visible = true;
                durationNumeric.Units = "";
            }

            opDropDown.SetEnumValue(crit.op);
            opDropDown.Enabled = _isValid;

            _ignoreEvents = false;
        }

        private void controlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                if (!_isValid) OnRowBecameValid();

                _data.control = (string)controlList.SelectedItem;
                _isValid = true;
                opDropDown.Enabled = true;

                OnValueChanged();
            }

            if (controlList.SelectedIndex < _inputs.Count)
            {
                stateDropDown.Visible = true;
                comparisonEnum.Visible = false;
                forLabel.Visible = stateDropDown.SelectedIndex < 2;
                durationNumeric.Visible = stateDropDown.SelectedIndex < 2;
                durationNumeric.Units = "ms";
            }
            else
            {
                forLabel.Visible = false;
                stateDropDown.Visible = false;
                comparisonEnum.Visible = true;
                durationNumeric.Visible = true;
                durationNumeric.Units = "";
            }
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _isValid)
            {
                _data.state = (InputState)stateDropDown.Value;
                OnValueChanged();
            }

            durationNumeric.Visible = stateDropDown.SelectedIndex < 2;
            forLabel.Visible = stateDropDown.SelectedIndex < 2;
        }

        private void durationBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _isValid)
            {
                _data.time_ms = durationNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void operatorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _data.op = (InputOperator)opDropDown.Value;
                OnOperatorChanged(new OperatorChangedArgs(_data.op));
            }
        }

        private void comparisonEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _data.comparison = (Comparison)comparisonEnum.Value;
            }
        }

        #region Events
        public event EventHandler RowBecameValid;
        protected virtual void OnRowBecameValid()
        {
            if (this.RowBecameValid != null) RowBecameValid(this, null);
        }

        public event EventHandler<OperatorChangedArgs> OperatorChanged;
        protected virtual void OnOperatorChanged(OperatorChangedArgs opChangeArgs)
        {
            if (this.OperatorChanged != null)
            {
                OperatorChanged(this, opChangeArgs);
            }
        }
        public class OperatorChangedArgs : EventArgs
        {
            public InputOperator op;
            public OperatorChangedArgs(InputOperator op) { this.op = op; }
        }
        #endregion

        private void controlList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color foreColor = e.ForeColor;
            Color backColor = e.BackColor;
            Color typeColor = Color.Black;

            string name = "";
            if (e.Index < 0)
            {
            }
            else if (e.Index < _inputs.Count)
            {
                name = _inputs[e.Index];
            }
            else if (e.Index < _inputs.Count + _flags.Count)
            {
                foreColor = Color.Blue;
                typeColor = foreColor;
                name = _flags[e.Index - _inputs.Count];
            }
            else
            {
                foreColor = Color.DarkRed;
                typeColor = foreColor;
                name = _scalars[e.Index - _inputs.Count - _flags.Count];
            }

            if ((e.State & DrawItemState.ComboBoxEdit) > 0)
            {
                backColor = SystemColors.Control;
                foreColor = typeColor;
            }

            e.Graphics.DrawRectangle(new Pen(backColor), e.Bounds);
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
            e.Graphics.DrawString(name, e.Font, new SolidBrush(foreColor), e.Bounds.Location);
        }
    }
}
