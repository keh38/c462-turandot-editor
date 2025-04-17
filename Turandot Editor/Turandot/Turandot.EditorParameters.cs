using System.Collections.Generic;
using System.Linq;
using System.Xml;

using KLib;
using KLib.Signals;

using Turandot.Inputs;
using Turandot.Schedules;
using Turandot.Screen;

namespace Turandot
{
    public class EditorParameters : Parameters
    {
        public EditorParameters() : base()
        {
        }

        public void Read(string path)
        {
            switch (GetFileVersion(path))
            {
                default:
                    Parameters p = KFile.XmlDeserialize<Parameters>(path);
                    FromBase(p);
                    break;
            }
        }

        private int GetFileVersion(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode node = doc.SelectSingleNode("/Parameters/version");
            if (node == null)
            {
                throw (new System.Exception("Error in parameter file format"));
            }

            int version = int.Parse(node.InnerText);
            return version;
        }

        public bool CanBeMadeAction(FlowElement fe)
        {
            bool result = true;

            if (fe == null)
            {
                result = false;
            }
            else
            {
                result = fe.sigMan == null || fe.sigMan.channels.Count == 0;
                result &= fe.inputs.Count == 0;
                result &= fe.term.Count == 0;
                result &= fe.timeOuts.Count == 1 && string.IsNullOrEmpty(fe.timeOuts[0].linkTo);
            }

            return result;
        }

        public float EstimateTime()
        {
            float responseLatency = 1;

            float trialDuration = 0;

            FlowElement fe = flowChart.Find(o => o.name == firstState);
            if (fe == null) return float.NaN;

            while (true)
            {
                string linkTo = "";
                if (fe.term.Count > 0)
                {
                    var input = fe.inputs.Find(o => o.name == "SAM");
                    if (input != null)
                    {
                        int nsam = 0;
                        SAM sam = input as SAM;
                        nsam += sam.valence.visible ? 1 : 0;
                        nsam += sam.arousal.visible ? 1 : 0;
                        nsam += sam.dominance.visible ? 1 : 0;
                        nsam += sam.loudness.visible ? 1 : 0;

                        trialDuration += nsam * responseLatency;
                    }
                    else trialDuration += responseLatency;

                    linkTo = fe.term[0].linkTo;
                }
                else
                {
                    //float[] timeOuts = Expressions.Evaluate(fe.timeOuts[0].expr);
                    //trialDuration += KMath.Max(timeOuts);

                    linkTo = fe.timeOuts[0].linkTo;
                }

                if (string.IsNullOrEmpty(linkTo)) break;

                fe = flowChart.Find(o => o.name == linkTo);
            }

            //System.Diagnostics.Debug.WriteLine("Trial time = " + trialDuration + " s");

            int numTrials = 0;

            if (schedule.mode == Mode.Adapt)
            {
                foreach (AdaptiveTrack t in adapt.tracks)
                {
                    numTrials += 10 + (t.Nup + t.Ndown) * t.Nreverse;
                }
                numTrials *= adapt.numBlocks;
            }
            else
            {
                foreach (Family f in schedule.families)
                {
                    if (f.oneEach)
                    {
                        f.Apply();
                        numTrials += f.NumTotal;
                    }
                    else numTrials += f.number;
                    }
                    numTrials *= schedule.numBlocks;
            }


            return trialDuration * numTrials;
        }


        public List<string> GetStateNames()
        {
            List<string> list = flowChart.Select(f => f.name).ToList();
            if (flags.Count > 0) list.Add("{Flag}");

            return list;
        }

        public List<string> GetChannelNames(string state)
        {
            List<string> names = new List<string>();

            if (state == "{Flag}")
            {
                names.Add("---");
            }
            else
            {
                FlowElement fe = flowChart.Find(f => f.name == state);
                if (fe != null)
                {
                    if (fe.sigMan != null)
                    {
                        names.AddRange(fe.sigMan.channels.Select(c => c.Name));
                    }
                    if (fe.cues != null && fe.cues.Count > 0 && fe.cues.Find(x => x.IsSequenceable) != null)
                    {
                        names.Add("Cues");
                    }

                    names.Add("---");
                }
            }

            return names;
        }

        public List<string> GetActiveInputControls()
        {
            List<string> active = new List<string>();
            foreach (FlowElement fe in flowChart)
            {
                foreach (var input in fe.inputs)
                {
                    if (!input.name.Equals("Random process") && active.Find(a => a == input.Target) == null) active.Add(input.Target);
                }
            }

            //foreach (ButtonSpec b in buttons)
            //{
            //    if (active.Find(a => a == b.name) == null) active.Add(b.name);
            //}

            if (flowChart.Find(o => o.nI_mAFC) != null)
            {
                active.Add("AFC Correct");
                active.Add("AFC Incorrect");
            }

            active.Sort();

            return active;
        }

        public List<string> GetActiveScalarControls()
        {
            var active = new List<string>();
            //if (screen.inputs.elements.Contains("pupillometer"))
            //{
            //    active.Add("Pupil");
            //}

            foreach (FlowElement fe in flowChart)
            {
                if (fe.inputs.Find(x => x.name == "Random process") != null)
                {
                    active.Add("Random process");
                    break;
                }
            }

            active.Sort();

            return active;
        }

        public List<string> GetChannelProperties(string state, string chan)
        {
            List<string> props = new List<string>();

            if (state == "{Flag}")
            {
                props.AddRange(flags.Select(f => f.name).ToList());
            }
            else
            {
                FlowElement fe = flowChart.Find(f => f.name == state);
                if (fe != null)
                {
                    if (chan == "---")
                    {
                        props.Add("Timeout");
                        if (fe.nI_mAFC) props.Add("TestInterval");
                    }
                    else if (chan == "Cues")
                    {
                        foreach (var c in fe.cues)
                        {
                            props.AddRange(c.GetPropertyNames());
                        }
                    }
                    else
                    {
                        Channel ch = fe.sigMan != null ? fe.sigMan.GetChannel(chan) : null;
                        if (ch != null) props.AddRange(ch.GetValidParameters());
                    }
                }
            }

            return props;
        }

        public static TermType StringToTermType(string s)
        {
            TermType termType = TermType.Any;
            if (s == "CS+") termType = TermType.CSplus;
            if (s == "CS-") termType = TermType.CSminus;
            return termType;
        }

        public static string TermTypeToString(TermType termType)
        {
            string s = "Any";
            if (termType == TermType.CSplus) s = "CS+";
            if (termType == TermType.CSminus) s = "CS-";
            return s;
        }

        public void RemoveCue(string cueName)
        {
            foreach (var fe in flowChart)
            {
                var c = fe.cues.Find(o => o.Name.ToLower().Equals(cueName.ToLower()));
                if (c != null) fe.cues.Remove(c);
            }
        }

        public void RemoveInput(string inputName)
        {
            foreach (var fe in flowChart)
            {
                var inp = fe.inputs.Find(o => o.Target.ToLower().Equals(inputName.ToLower()));
                if (inp != null) fe.inputs.Remove(inp);
            }
        }

        public Parameters ToBase()
        {
            Parameters p = new Parameters();

            p.instructions = instructions;
            p.screen = screen;
            p.inputEvents = inputEvents;
            p.flowChart = flowChart;
            foreach (FlowElement f in flowChart)
            {
                if (f.sigMan != null)
                {
                    foreach (Channel ch in f.sigMan.channels) ch.ContraSide = null;
                }
            }

            p.firstState = firstState;
            p.flags = flags;
            p.schedule = schedule;
            p.adapt = adapt;
            p.tag = tag;
            p.linkTo = linkTo;
            p.wavFolder = wavFolder;
            p.trialLogOption = trialLogOption;
            p.allowExpertOptions = allowExpertOptions;

            return p;
        }

        public void FromBase(Parameters p)
        {
            instructions = p.instructions;
            screen = p.screen;
            inputEvents = p.inputEvents;
            flowChart = p.flowChart;
            firstState = p.firstState;
            flags = p.flags;
            schedule = p.schedule;
            adapt = p.adapt;
            tag = p.tag;
            linkTo = p.linkTo;
            wavFolder = p.wavFolder;
            trialLogOption = p.trialLogOption;
            allowExpertOptions = p.allowExpertOptions;
        }

        public void CreateAFC(FlowElement state, int numIntervals, float ISI_ms)
        {
            state.nI_mAFC = true;

            if (state.sigMan != null && state.sigMan["Test"] != null)
            {
                state.timeOuts[0].expr = (numIntervals * ISI_ms / 1000).ToString();

                state.sigMan.channels[0].Name = "Test";
                state.sigMan["Test"].gate.Period_ms = numIntervals * ISI_ms;
                for (int k = 1; k < numIntervals; k++)
                {
                    Channel ch = Channel.FromProtoBuf(state.sigMan["Test"].ToProtoBuf());
                    //ch.Destination = state.sigMan["Test"].Destination;
                    //ch.level.Value = state.sigMan["Test"].level.Value;
                    ch.Name = "Ref" + k;
                    ch.gate.Delay_ms = k * ISI_ms;
                    state.sigMan.channels.Add(ch);
                }
            }
            if (flags.Find(f => f.name == "TestInterval") == null) flags.Add(new Flag("TestInterval"));

            if (inputEvents.Find(o => o.name == "AFC Correct") == null)
            {
                InputEvent ie = new InputEvent("AFC Correct");
                ie.criteria.Add(new InputCriterion() { control = "AFC Correct" });
                inputEvents.Add(ie);
            }

            if (inputEvents.Find(o => o.name == "AFC Incorrect") == null)
            {
                InputEvent ie = new InputEvent("AFC Incorrect");
                ie.criteria.Add(new InputCriterion() { control = "AFC Incorrect" });
                inputEvents.Add(ie);
            }

            if (schedule.mode == Mode.Adapt)
            {
                if (adapt.tracks.Count == 0) adapt.tracks.Add(new AdaptiveTrack("Track"));
                foreach (AdaptiveTrack t in adapt.tracks)
                {
                    Variable v = t.variables.Find(o => o.dim == VarDimension.Ind && o.state == state.name && o.chan == "---" && o.property == "TestInterval");
                    if (v == null)
                    {
                        v = new Variable(state.name, "---", "TestInterval");
                        v.dim = VarDimension.Ind;
                        t.variables.Add(v);
                    }
                    v.expression = "[ ";
                    for (int k = 0; k < numIntervals; k++) v.expression += (k + 1).ToString() + " ";
                    v.expression += "]";
                }
            }
            else
            {
                if (schedule.families.Count == 0) schedule.families.Add(new Family("Group"));
                foreach (Family f in schedule.families)
                {
                    Variable v = f.variables.Find(o => o.dim == VarDimension.Ind && o.state == state.name && o.chan == "---" && o.property == "TestInterval");
                    if (v == null)
                    {
                        v = new Variable(state.name, "---", "TestInterval");
                        v.dim = VarDimension.Ind;
                        f.variables.Add(v);
                    }
                    v.expression = "[ ";
                    for (int k = 0; k < numIntervals; k++) v.expression += (k + 1).ToString() + " ";
                    v.expression += "]";
                }
            }

            // Buttons
            FlowElement startState = flowChart.Find(o => o.name == firstState);
            FlowElement nextState = flowChart.Find(o => o.name == state.timeOuts[0].linkTo);
            //foreach (ButtonSpec b in buttons.FindAll(o => o.style == ButtonSpec.ButtonStyle.Square)) buttons.Remove(b);

            int dx = 1160 / (numIntervals - 1);
            int x = -580;
            for (int k=0; k<numIntervals; k++)
            {
                //ButtonSpec b = new ButtonSpec("Button" + (k + 1).ToString(), (k + 1).ToString());
                //b.style = ButtonSpec.ButtonStyle.Square;
                //b.x = x;
                //buttons.Add(b);
                //x += dx;

                //Button i = new Button(b.name);
                //i.startVisible = true;
                //i.endVisible = true;
                //i.numFlash = 0;
                //i.enabled = false;
                //startState.inputs.Add(i);

                //i = new Button(b.name);
                //i.startVisible = true;
                //i.numFlash = 1;
                //i.delay_ms = k * ISI_ms;
                //i.duration_ms = ISI_ms - 100; // state.sigMan["Test"].gate.Duration_ms;
                //i.interval_ms = float.PositiveInfinity;
                //i.enabled = false;
                //i.tweenScale = true;
                //i.scaleTo = 1.25f;
                //state.inputs.Add(i);

                //i = new Button(b.name);
                //i.startVisible = true;
                //i.numFlash = 0;
                //nextState.inputs.Add(i);
            }
        }


        #region States
        public FlowElement FindState(string name)
        {
            return flowChart.Find(f => f.name == name);
        }

        public FlowElement AddState(string name)
        {
            FlowElement fe = new FlowElement(name);

            if (flowChart.Count == 0) firstState = name;
            flowChart.Add(fe);

            return fe;
        }

        public void DuplicateState(string name)
        {
            var fe = flowChart.Find(f => f.name == name);
            FlowElement copy = new FlowElement(name + " copy");

            copy.timeOuts[0].expr = fe.timeOuts[0].expr;

            string xml = KFile.ToXMLString(fe.sigMan);
            copy.sigMan = KFile.FromXMLString<SignalManager>(xml);

            foreach (var c in fe.cues)
            {
                xml = KFile.ToXMLString(c);
                Cues.Cue cc = KFile.FromXMLString<Cues.Cue>(xml);
                copy.cues.Add(cc);
            }
            foreach (var i in fe.inputs) copy.inputs.Add(i);

            flowChart.Add(copy);
        }

        public List<string> GetActions()
        {
            return flowChart.FindAll(o => o.isAction).Select(o => o.name).ToList();
        }

        public void RemoveStatesFromSchedule()
        {
            List<Variable> toDelete = new List<Variable>();
            foreach (Family f in schedule.families)
            {
                toDelete.Clear();
                foreach (Variable v in f.variables)
                {
                    if (GetStateNames().Find(s => s == v.state) == null) toDelete.Add(v);
                }
                foreach (Variable v in toDelete) f.variables.Remove(v);
            }
        }

        public void RenameState(string oldname, string newname)
        {
            foreach (FlowElement fe in flowChart)
            {
                foreach (Timeout to in fe.timeOuts.FindAll(t => t.linkTo == oldname)) to.linkTo = newname;
                foreach (Termination term in fe.term.FindAll(t => t.linkTo == oldname)) term.linkTo = newname;
            }
        }

        public void RenameStateInSchedule(string oldname, string newname)
        {
            foreach (Family f in schedule.families)
            {
                foreach (Variable variable in f.variables.FindAll(v => v.state == oldname))
                {
                    variable.state = newname;
                }
            }

            foreach (AdaptiveTrack t in adapt.tracks)
            {
                if (t.state == oldname) t.state = newname;
                foreach (Variable v in t.variables.FindAll(o => o.state == oldname)) v.state = newname;
                foreach (Variable v in t.catches.FindAll(o => o.state == oldname)) v.state = newname;
            }
        }

        public void RemoveStates(List<string> names)
        {
            foreach (string name in names)
            {
                flowChart.Remove(flowChart.Find(f => f.name == name));
            }

            foreach (string name in names)
            {
                foreach (FlowElement fe in flowChart)
                {
                    Timeout to = fe.timeOuts.Find(t => t.linkTo == name);
                    if (to != null)
                    {
                        if (to.termType == TermType.Any) to.linkTo = "";
                        else fe.timeOuts.Remove(to);
                    }
                    Termination term = fe.term.Find(t => t.linkTo == name);
                    if (term != null) fe.term.Remove(term);
                }
            }

            RemoveStatesFromSchedule();
        }

        public int NumStates
        {
            get { return flowChart.Count; }
        }

        public bool IsStateNameTaken(string name)
        {
            return flowChart.Find(fe => fe.name == name) != null;
        }

        public void ApplySignalNameChangeToSchedule(string stateName, string oldname, string newname)
        {
            foreach (Family f in schedule.families)
            {
                foreach (Variable variable in f.variables.FindAll(v => v.state == stateName))
                {
                    if (variable.chan == oldname) variable.chan = newname;
                }
            }
        }

        public void ApplyChannelChangeToSchedule(string stateName, Channel chan)
        {
            List<string> validProps = chan.GetValidParameters();
            foreach (Family f in schedule.families)
            {
                foreach (Variable variable in f.variables.FindAll(v => v.state == stateName && v.chan == chan.Name))
                {
                    if (!validProps.Contains(variable.property)) variable.property = "";
                }
            }
        }

        #endregion

        #region Transitions
        public void AddTransition(string from, string to, string evt, TermType termType)
        {
            FlowElement source = flowChart.Find(f => f.name == from);

            if (string.IsNullOrEmpty(evt)) //time out
            {
                if (termType == TermType.Any)
                    source.timeOuts[0].linkTo = to;
                else
                    source.timeOuts.Add(new Timeout("1", to, termType));
            }
            else
            {
                source.term.Add(new Termination(evt, to, termType));
            }
        }

        public void RemoveTransition(string from, string to, string evt, TermType termType)
        {
            FlowElement source = flowChart.Find(f => f.name == from);

            if (string.IsNullOrEmpty(evt)) //time out
            {
                if (termType == TermType.Any)
                    source.timeOuts[0].linkTo = "";
                else
                {
                    Timeout timeout = source.timeOuts.Find(t => t.termType == termType);
                    if (timeout != null) source.timeOuts.Remove(timeout);
                }
            }
            else
            {
                Termination term = source.term.Find(t => t.linkTo == to && t.source == evt && t.type == termType);
                if (term != null) source.term.Remove(term);
            }
        }

        public Timeout FindTimeout(string source, TermType termType)
        {
            Timeout timeout = null;

            FlowElement state = FindState(source);
            if (state != null)
                timeout = state.timeOuts.Find(to => to.termType == termType);

            return timeout;
        }

        public Termination FindTermination(string source, string target, string evt, TermType termType)
        {
            Termination term = null;

            FlowElement state = FindState(source);
            if (state != null)
                term = state.term.Find(t => t.linkTo == target && t.source == evt && t.type == termType);

            return term;
        }
        #endregion

        #region Input Events
        public List<string> GetInputEventNames()
        {
            return inputEvents.Select(i => i.name).ToList();
        }

        public string RenameEvent(string name, int index)
        {
            string oldname = inputEvents[index].name;
            inputEvents[index].name = name;
            foreach (FlowElement fe in flowChart)
            {
                foreach (Termination term in fe.term.FindAll(t => t.source == oldname)) term.source = name;
            }

            return oldname;
        }

        public void DeleteEvents(List<string> names)
        {
            foreach (string name in names)
            {
                foreach (FlowElement state in flowChart)
                {
                    foreach (Termination term in state.term.FindAll(t => t.source == name)) term.source = "???";
                }
                InputEvent evt = inputEvents.Find(e => e.name == name);
                inputEvents.Remove(evt);
            }

        }

        public void MoveEvent(string name, int moveTo)
        {
            InputEvent inputEvent = inputEvents.Find(e => e.name == name);
            inputEvents.Remove(inputEvent);
            inputEvents.Insert(moveTo, inputEvent);
        }

        public void MoveEvents(List<string> names)
        {
            List<InputEvent> reorderedList = new List<InputEvent>();
            foreach (string name in names) reorderedList.Add(inputEvents.Find(e => e.name == name));
            inputEvents = reorderedList;
        }

        #endregion

        #region Buttons
        public void RenameButton(string name, string oldName, int index)
        {
            foreach (FlowElement f in flowChart)
            {
                foreach (Input i in f.inputs.FindAll(o => o.name == oldName)) i.name = name;
            }

            foreach (InputEvent ie in inputEvents)
            {
                foreach (InputCriterion c in ie.criteria.FindAll(o => o.control == oldName)) c.control = name;
            }
        }

        public void RemoveButtons(List<string> names)
        {
            //foreach (FlowElement f in flowChart)
            //{
            //    foreach (Input i in f.inputs.FindAll(o => o.name == oldName)) i.name = name;
            //}

            //foreach (InputEvent ie in inputEvents)
            //{
            //    foreach (InputCriterion c in ie.criteria.FindAll(o => o.control == oldName)) c.control = name;
            //}
        }

        #endregion
    }

}