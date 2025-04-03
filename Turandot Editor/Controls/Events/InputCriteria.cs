using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    public partial class InputCriteria : KUserControl
    {
        private List<InputCriterionControl> _criterionControls;
        private List<string> _digitalInputs;
        private List<string> _flagNames;
        private List<string> _scalarNames;

        private int _numActiveRows;

        private List<InputCriterion> _value;
        public List<InputCriterion> Value
        {
            get { return _value; }
            set
            {
                _value = value;
                ShowValue();
            }
        }

        public InputCriteria()
        {
            InitializeComponent();

            _criterionControls = new List<InputCriterionControl>();
            AddRow();
            _numActiveRows = 0;

            _digitalInputs = new List<string>();
            _flagNames = new List<string>();
            _scalarNames = new List<string>();
        }

        public void SetDigitalInputs(List<string> digitalInputs)
        {
            _digitalInputs.Clear();
            _digitalInputs.AddRange(digitalInputs);

            foreach (InputCriterionControl c in _criterionControls)
            {
                c.SetDigitalInputs(digitalInputs);
            }
        }

        public void SetFlagNames(List<string> flagNames)
        {
            _flagNames.Clear();
            _flagNames.AddRange(flagNames);

            foreach (InputCriterionControl c in _criterionControls)
            {
                c.SetFlagNames(flagNames);
            }
        }

        public void SetScalarNames(List<string> scalarNames)
        {
            _scalarNames.Clear();
            _scalarNames.AddRange(scalarNames);

            foreach (InputCriterionControl c in _criterionControls)
            {
                c.SetScalarNames(scalarNames);
            }
        }

        public void Clear()
        {
            _numActiveRows = 0;
            HideUnused();
            _criterionControls[0].Clear();
        }

        private void inputCriterion_RowBecameValid(object sender, EventArgs e)
        {
            if (_numActiveRows == 0) _numActiveRows++;
        }
        
        private void ShowValue()
        {
            _ignoreEvents = true;

            Clear();
            foreach (var crit in _value)
            {
                ActivateNextRow().Value = crit;
            }

            _ignoreEvents = false;
        }

        private void UpdateValue()
        {
            _value.Clear();

            for (int k=0; k<_numActiveRows; k++)
            {
                if (_criterionControls[k].IsValid)
                {
                    _value.Add(_criterionControls[k].Value);
                }
                else
                {
                    break;
                }
            }
        }

        public void AddCriterion(InputCriterion crit)
        {
            InputCriterionControl inputCriterion = ActivateNextRow();
            if (crit != null) inputCriterion.Value = crit;
        }

        private InputCriterionControl ActivateNextRow()
        {
            InputCriterionControl inputCriterion = null;

            ++_numActiveRows;
            if (_numActiveRows <= _criterionControls.Count)
            {
                _criterionControls[_numActiveRows - 1].Visible = true;
                inputCriterion = _criterionControls[_numActiveRows - 1];
            }
            else
            {
                inputCriterion = AddRow();
            }
            return inputCriterion;
        }

        private InputCriterionControl AddRow()
        {
            int newRowNum = _criterionControls.Count;

            InputCriterionControl c = new InputCriterionControl();
            c.SetDigitalInputs(_digitalInputs);
            c.SetFlagNames(_flagNames);
            c.ValueChanged += inputCriterion_ValueChanged;
            c.OperatorChanged += inputCriterion_OperatorChanged;
            c.RowBecameValid += inputCriterion_RowBecameValid;
            c.Clear();

            _criterionControls.Add(c);
            flowLayoutPanel.Controls.Add(c);

            return c;
        }
        
        void HideUnused()
        {
            for (int k=Math.Max(1, _numActiveRows); k<_criterionControls.Count; k++)
            {
                _criterionControls[k].Visible = false;
            }
        }

        private void inputCriterion_ValueChanged(object sender, EventArgs e)
        {
            UpdateValue();
            OnValueChanged();
        }

        private void inputCriterion_OperatorChanged(object sender, InputCriterionControl.OperatorChangedArgs e)
        {
            if (!_ignoreEvents)
            {
                int index = _criterionControls.FindIndex(o => o == sender);

                if (e.op != InputOperator.None)
                {
                    if (++_numActiveRows <= _criterionControls.Count)
                    {
                        _criterionControls[_numActiveRows - 1].Visible = true;
                        _criterionControls[_numActiveRows - 1].Clear();
                    }
                    else
                        AddRow();
                }
                else
                {
                    if (index < _criterionControls.Count - 1)
                    {
                        for (int k = index + 1; k < _numActiveRows; k++)
                        {
                            InputCriterionControl c = _criterionControls[_criterionControls.Count - 1];
                            flowLayoutPanel.Controls.Remove(c);
                            _criterionControls.Remove(c);
                        }

                        _numActiveRows = index + 1;
                    }
                }
                UpdateValue();
                OnValueChanged();
            }
        }

    }
}
