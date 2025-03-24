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

        public InputCriteria()
        {
            InitializeComponent();
            _criterionControls = new List<InputCriterionControl>();
            _criterionControls.Add(inputCriterion);
            _numActiveRows = 0;

            _digitalInputs = new List<string>();
            _flagNames = new List<string>();
            _scalarNames = new List<string>();
        }

        public string[] DigitalInputs
        {
            set
            {
                _digitalInputs.Clear();
                _digitalInputs.AddRange(value);

                foreach (InputCriterionControl c in _criterionControls)
                {
                    c.DigitalInputs = value;
                }
            }
        }

        public string[] FlagNames
        {
            set
            {
                _flagNames.Clear();
                _flagNames.AddRange(value);

                foreach (InputCriterionControl c in _criterionControls)
                {
                    c.FlagNames = value;
                }
            }
        }

        public string[] ScalarNames
        {
            set
            {
                _scalarNames.Clear();
                _scalarNames.AddRange(value);

                foreach (InputCriterionControl c in _criterionControls)
                {
                    c.ScalarNames = value;
                }
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


        public List<InputCriterion> Value
        {
            set { SetValue(value); }
            get { return GetValue(); }
        } 

        private void SetValue(List<InputCriterion> criteria)
        {
            _ignoreEvents = true;

            Clear();
            foreach (InputCriterion crit in criteria)
            {
                ActivateNextRow().Value = crit;
            }

            _ignoreEvents = false;
        }

        private List<InputCriterion> GetValue()
        {
            List<InputCriterion> newValue = new List<InputCriterion>();

            for (int k=0; k<_numActiveRows; k++)
            {
                if (_criterionControls[k].IsValid)
                    newValue.Add(_criterionControls[k].Value);
                else
                    break;
            }

            return newValue;
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
            c.Location = new Point(inputCriterion.Location.X, inputCriterion.Location.Y + newRowNum * (inputCriterion.Height+5));
            c.DigitalInputs = _digitalInputs.ToArray();
            c.FlagNames = _flagNames.ToArray();
            c.ValueChanged += inputCriterion_ValueChanged;
            c.OperatorChanged += inputCriterion_OperatorChanged;
            c.RowBecameValid += inputCriterion_RowBecameValid;
            c.Clear();

            _criterionControls.Add(c);
            this.Controls.Add(c);

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
                            this.Controls.Remove(c);
                            _criterionControls.Remove(c);
                        }

                        _numActiveRows = index + 1;
                    }
                }
                OnValueChanged();
            }
        }
    }
}
