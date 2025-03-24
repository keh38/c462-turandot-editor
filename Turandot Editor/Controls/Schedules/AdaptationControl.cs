extern alias KLibUnity;
using Expressions = KLibUnity.KLib.Expressions;

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
using Turandot.Schedules;

namespace Turandot_Editor.Controls
{
    public partial class AdaptationControl : KUserControl
    {
        private Adaptation _adapt;
        private AdaptiveTrack _selectedTrack = null;
        private List<Variable> _stimVar = new List<Variable>();

        public AdaptationControl()
        {
            InitializeComponent();

            tracktypeDropDown.Clear();
            tracktypeDropDown.AddItem(TrialType.GoNoGo, "Go/No go");
            tracktypeDropDown.AddItem(TrialType.CSplus, "Track CS+");
            tracktypeDropDown.AddItem(TrialType.CSminus, "Track CS-");

            switchDropDown.Fill(typeof(AdaptSwitchType));
            computeDropDown.Fill(typeof(AdaptComputation));
            stepmodeDropDown.Fill(typeof(AdaptStepMode));

            catchDropDown.Clear();
            catchDropDown.AddItem(CatchInterval.Trial, "Trial");
            catchDropDown.AddItem(CatchInterval.ValueChange, "Value change");

            stimulusGridView.Value = _stimVar;
        }

        public Adaptation Value
        {
            get { return _adapt; }
            set
            {
                _adapt = value;
                ShowAdaptation(_adapt);
            }
        }

        public void SetDataForContext(EditorParameters par)
        {
            stimulusGridView.SetDataForContext(par);
            testVarsGridView.SetDataForContext(par);
            catchVarsGridView.SetDataForContext(par);
        }

        public void UpdateAvailableStates()
        {
            stimulusGridView.UpdateAvailableStates();
            testVarsGridView.UpdateAvailableStates();
            catchVarsGridView.UpdateAvailableStates();
        }

        private void ShowAdaptation(Adaptation a)
        {
            if (a == null) return;

            _ignoreEvents = true;

            trackListBox.SetItems(a.tracks.Select(t => t.name).ToList());
            EnableTrackControls(a.tracks.Count > 0);
            switchPanel.Enabled = a.tracks.Count > 1;
            switchNumeric.IntValue = a.switchAfter;
            switchDropDown.SetEnumValue(a.switchType);
            nblocksNumeric.IntValue = a.numBlocks;
            cvNumeric.FloatValue = a.cvCriterion;
            maxextraNumeric.IntValue = a.maxExtraBlocks;

            if (a.tracks.Count > 0)
            {
                trackListBox.SelectedIndex = 0;
                _selectedTrack = a.tracks[0];
                ShowTrack(_selectedTrack);
            }

            _ignoreEvents = false;
        }

        private void EnableTrackControls(bool enable)
        {
            tracktypeDropDown.Enabled = enable;
            trackPanel.Enabled = enable;
            catchPanel.Enabled = enable;
            stimulusGridView.Enabled = enable;
            testVarsGridView.Enabled = enable;
            catchVarsGridView.Enabled = enable;
        }

        private void ShowTrack(AdaptiveTrack t)
        {
            EnableTrackControls(true);

            tracktypeDropDown.SetEnumValue(t.trackedVarType);

            _stimVar.Clear();
            _stimVar.Add(new Variable(t.state, t.chan, t.param));
            stimulusGridView.Value = _stimVar;

            ndownNumeric.IntValue = t.Ndown;
            nupNumeric.IntValue = t.Nup;
            nreverseNumeric.IntValue = t.reversalsPerStep.Sum();
            ndownNumeric.IntValue = t.Ndown;
            computeDropDown.SetEnumValue(t.computation);
            lastNumeric.IntValue = t.computeLastN;
            maxTrialsNumeric.IntValue = t.maxNumTrials;
            saveasTextBox.Text = t.storeThresholdAs;
            thrExprBox.Text = string.IsNullOrEmpty(t.thresholdExpr) ? "A" : t.thresholdExpr;

            startNumeric.FloatValue = t.startVal;
            minNumeric.FloatValue = t.minVal;
            maxNumeric.FloatValue = t.maxVal;
            stepmodeDropDown.SetEnumValue(t.stepMode);
            stepExprTextBox.Text = Expressions.ToVectorString(t.steps == null ? new float[] { 1 } : t.steps);
            reversalsExprTextBox.Text = Expressions.ToVectorString(t.reversalsPerStep);

            testVarsGridView.Value = t.variables;

            doallCheckBox.Checked = t.doAllCatches;
            catchDropDown.SetEnumValue(t.catchInterval);
            pcatchNumeric.FloatValue = t.pCatch;
            startwithNumeric.IntValue = t.startWithNcatch;

            catchVarsGridView.Value = t.catches;
            testVarsGridView.SetPropValPairs(new List<Expressions.PropVal>() { new Expressions.PropVal("AV", t.startVal) });
            _selectedTrack = t;
        }

        private void trackListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            AdaptiveTrack newTrack = null;
            if (_adapt.tracks.Count > 0)
                newTrack = _adapt.tracks[0].Clone(e.name);
            else
                newTrack = new AdaptiveTrack(e.name);

            _adapt.tracks.Insert(e.index, newTrack);

            switchPanel.Enabled = _adapt.tracks.Count > 1;

            _ignoreEvents = true;
            ShowTrack(newTrack);
            _ignoreEvents = false;

            OnValueChanged();
        }

        private void trackListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        {
        }

        private void trackListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        {
            _adapt.tracks[e.index].name = e.name;
            OnValueChanged();
        }

        private void trackListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        {
            List<AdaptiveTrack> toDelete = new List<AdaptiveTrack>();
            foreach (string name in e.names) toDelete.Add(_adapt.tracks.Find(t => t.name == name));
            foreach (AdaptiveTrack track in toDelete) _adapt.tracks.Remove(track);

            switchPanel.Enabled = _adapt.tracks.Count > 1;

            OnValueChanged();
        }

        private void trackListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        {

        }

        private void trackListBox_SelectionChanged(object sender, KUserListBox.ChangedItem e)
        {
            if (e.index >= 0)
            {
                _selectedTrack = _adapt.tracks[e.index];
                ShowTrack(_selectedTrack);
            }
            else
            {
                _selectedTrack = null;
                EnableTrackControls(false);
            }

        }

        private void stimulusGridView_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.state = stimulusGridView.Value[0].state;
                _selectedTrack.chan = stimulusGridView.Value[0].chan;
                _selectedTrack.param = stimulusGridView.Value[0].property;
                OnValueChanged();
            }
        }

        private void ndownNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.Ndown = ndownNumeric.IntValue;
                OnValueChanged();
            }
        }
        private void nupNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.Nup = nupNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void nreverseNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.Nreverse = nreverseNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void computeDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.computation = (AdaptComputation) computeDropDown.Value;
                OnValueChanged();
            }
        }

        private void lastNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.computeLastN = lastNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void startNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.startVal = startNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void minNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.minVal = minNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void maxNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.maxVal = maxNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void stepmodeDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.stepMode = (AdaptStepMode) stepmodeDropDown.Value;
                OnValueChanged();
            }
        }

        private void switchNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _adapt != null)
            {
                _adapt.switchAfter = switchNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void switchDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _adapt != null)
            {
                _adapt.switchType = (AdaptSwitchType) switchDropDown.Value;
                OnValueChanged();
            }
        }

        private void doallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.doAllCatches = doallCheckBox.Checked;
                OnValueChanged();
            }
        }

        private void catchDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.catchInterval = (CatchInterval) catchDropDown.Value;
                OnValueChanged();
            }
        }

        private void pcatchNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.pCatch = pcatchNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void startwithNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedTrack != null)
            {
                _selectedTrack.startWithNcatch = startwithNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void testVarsGridView_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void catchVarsGridView_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) OnValueChanged();
        }

        private void saveasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (e.KeyChar == (char)27)
            {
                box.Text = _selectedTrack.storeThresholdAs;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _selectedTrack.storeThresholdAs = box.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void tracktypeDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _selectedTrack.trackedVarType = (TrialType) tracktypeDropDown.Value;
                OnValueChanged();
            }
        }

        private void nblocksNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _adapt != null)
            {
                _adapt.numBlocks = nblocksNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void cvNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _adapt != null)
            {
                _adapt.cvCriterion = cvNumeric.FloatValue;
                OnValueChanged();
            }
        }

        private void maxextraNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _adapt != null)
            {
                _adapt.maxExtraBlocks = maxextraNumeric.IntValue;
                OnValueChanged();
            }
        }

        private void threxprBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (e.KeyChar == (char)27)
            {
                box.Text = _selectedTrack.thresholdExpr;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                _selectedTrack.thresholdExpr = box.Text;
                e.Handled = true;
                OnValueChanged();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void maxTrialsNumeric_ValueChanged(object sender, EventArgs e)
        {
            _selectedTrack.maxNumTrials = maxTrialsNumeric.IntValue;
            OnValueChanged();
        }

        private void stepExprTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (_ignoreEvents || _selectedTrack == null) return;

            var expressionOK = Expressions.TryEvaluate(stepExprTextBox.Text);
            stepExprTextBox.BackColor = Color.Red;

            if (expressionOK)
            {
                _selectedTrack.steps = Expressions.Evaluate(stepExprTextBox.Text);
                OnValueChanged();
            }
        }

        private void reversalsExprTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (_ignoreEvents || _selectedTrack == null) return;

            var expressionOK = Expressions.TryEvaluate(reversalsExprTextBox.Text);
            stepExprTextBox.BackColor = Color.Red;

            if (expressionOK)
            {
                _selectedTrack.reversalsPerStep = Expressions.EvaluateToInt(reversalsExprTextBox.Text);
                _selectedTrack.Nreverse = _selectedTrack.reversalsPerStep.Sum();
                nreverseNumeric.IntValue = _selectedTrack.Nreverse;
                OnValueChanged();
            }
        }
    }
}
