extern alias KLibUnity;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib;
using KLib.Controls;

using Expressions = KLibUnity.KLib.Expressions;

namespace Turandot_Editor.Controls
{
    public partial class ExpressionEditor : KResizableControl
    {
        bool _valueChanged = false;
        string _value = "";
        List<Expressions.PropVal> _propVals;

        public ExpressionEditor()
        {
            InitializeComponent();
        }

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                _valueChanged = false;
                ShowValue();
            }
        }

        public List<Expressions.PropVal> PropValPairs
        {
            get { return _propVals; }
            set { _propVals = value; }
        }

        public string XVector { set; get; }
        public string YVector { set; get; }

        private void ShowValue()
        {
            expressionBox.Text = _value;
            Evaluate();
        }

        private void Evaluate()
        {
            if (string.IsNullOrEmpty(_value))
            {
                resultBox.Text = "";
                return;
            }

            float[] vals;
            try
            {
                string expr = _value;
                if (_value.Contains("X") && !string.IsNullOrEmpty(XVector)) expr = expr.Replace("X", XVector);
                if (_value.Contains("Y") && !string.IsNullOrEmpty(YVector)) expr = expr.Replace("Y", YVector);

                vals = Expressions.Evaluate(expr);
                resultBox.Text = Expressions.ToVectorString(vals);
            }
            catch (Exception ex)
            {
                resultBox.Text = ex.Message;
                resultBox.ForeColor = Color.Red;
            }
        }

        private void expressionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                if (_valueChanged) OnValueChanged();
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _value = expressionBox.Text;
                _valueChanged = true;
                Evaluate();
                e.Handled = true;
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void ExpressionEditor_Leave(object sender, EventArgs e)
        {
            if (_valueChanged) OnValueChanged();

            this.Visible = false;
        }

    }
}
