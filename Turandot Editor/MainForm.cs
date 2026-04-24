using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using DlgResult = System.Windows.Forms.DialogResult;

using FSMGraph;

using KLib.IO;
using KLib.Controls;
using KLib.KGraphics;
using KLib.Net;
using KLib.Signals;

using Turandot;
using Turandot.Cues;
using Turandot.Schedules;
using Turandot.Screen;

using C462.Shared;
using KLib.Drawing.Graphics;
using KLib.Expressions;
using Newtonsoft.Json;
using ScottPlot;

namespace Turandot_Editor
{
    public partial class MainForm : Form
    {
        EditorNetwork _network;
        EditorParameters _params = new EditorParameters();
        bool _setupIsDirty = false;
        string _filePath = "";
        FlowElement _selectedState = null;
        bool _ignoreEvents = false;
        Settings _settings = new Settings();

        bool _controlKeyDown = false;

        readonly float _Fs = 44100f;

        private List<string> _projectNames;
        private List<string> _transducerNames;

        public MainForm()
        {
            InitializeComponent();

            SessionContext.Initialize(AdapterMap.Default7point1Map("HD280"));
            EnumerateProjectNames();
            EnumerateTransducerNames();

            RestoreDefaults();

            if (!_settings.lastPosition.IsEmpty)
            {
                // Validate that the saved position is still visible on screen
                Rectangle savedBounds = _settings.lastPosition;
                bool isVisible = false;

                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.WorkingArea.IntersectsWith(savedBounds))
                    {
                        isVisible = true;
                        break;
                    }
                }

                if (isVisible)
                {
                    StartPosition = FormStartPosition.Manual;
                    Location = new Point(savedBounds.X, savedBounds.Y);
                    Width = savedBounds.Width;
                    Height = savedBounds.Height;
                }
                else
                {
                    // Position is off-screen, use default positioning
                    StartPosition = FormStartPosition.CenterScreen;
                    // Optionally clear the invalid position
                    _settings.lastPosition = Rectangle.Empty;
                }
            }

            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                _settings.lastFile = args[1];
            }

            _params.flowChart = new List<FlowElement>();

            trialLogOptionEnum.Fill<TrialLogOption>();

            cuesSpecifier.NameChange = cuesSpecifier_NameChanged;
            inputsSpecifier.NameChange = inputsSpecifier_NameChanged;

            tabControl.TabPages.Remove(StatePage);
            tabControl.TabPages.Remove(AudioPage);
            tabControl.TabPages.Remove(CuePage);
            tabControl.TabPages.Remove(InputPage);

            graphViewer.InsertToolStrip(toolStrip);
            graphViewer.Graph = new FSMGraph.Graph();

            graphViewer.OnNodeAdded += OnNodeAdded;
            graphViewer.OnNodeSelected += OnNodeSelected;
            graphViewer.OnNodesDeleted += OnNodesDeleted;
            graphViewer.OnNodesDuplicated += OnNodesDuplicated;
            graphViewer.OnEdgeAdded += OnEdgeAdded;
            graphViewer.OnEdgeSelected += OnEdgeSelected;
            graphViewer.OnEdgeDeleted += OnEdgeDeleted;
            graphViewer.OnGetAvailableTransitions = GetAvailableTransitions;

            endActionDropDown.Clear();
            endActionDropDown.AddItem(EndAction.None, "None");
            endActionDropDown.AddItem(EndAction.EndRun, "End run");
            endActionDropDown.AddItem(EndAction.AbortAll, "Abort all");

            schedModeDropDown.Clear();
            schedModeDropDown.AddItem(Mode.Sequence, "Sequence");
            schedModeDropDown.AddItem(Mode.CS, "CS+/CS-");
            schedModeDropDown.AddItem(Mode.Adapt, "Adaptive");
            schedModeDropDown.AddItem(Mode.Optimize, "Optimization");

            // Hide axis label and tick
            signalGraph.Plot.Axes.Left.TickLabelStyle.IsVisible = false;
            signalGraph.Plot.Axes.Left.MajorTickStyle.Length = 0;
            signalGraph.Plot.Axes.Left.MinorTickStyle.Length = 0;
            signalGraph.Plot.XLabel("Time (s)");

            // Hide axis edge line
            signalGraph.Plot.Axes.Left.FrameLineStyle.Width = 0;
            signalGraph.Plot.Axes.Right.FrameLineStyle.Width = 0;
            signalGraph.Plot.Axes.Top.FrameLineStyle.Width = 0;
            signalGraph.Plot.Axes.Bottom.MinorTickStyle.Length = 0;

            signalGraph.Plot.Axes.Bottom.Label.Bold = false;
            signalGraph.Plot.Axes.Bottom.Label.FontSize = 12;
            signalGraph.Plot.Axes.Bottom.TickLabelStyle.FontSize = 12;

            signalGraph.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;
            var padding = new PixelPadding(
                left: 0,
                right: 0,
                bottom: 50, // keep some bottom padding for x-axis labels
                top: 0);
            signalGraph.Plot.Layout.Fixed(padding);
            signalGraph.Refresh();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Version currentVersion = assembly.GetName().Version;
            versionLabel.Text = $"v{currentVersion.Major}.{currentVersion.Minor}.{currentVersion.Build}";

            KLib.Signals.Editor.LevelUnitsConverter.Allowable = new LevelUnits[] { LevelUnits.dB_attenuation, LevelUnits.dB_SPL, LevelUnits.dB_Vrms, LevelUnits.dB_SL, LevelUnits.PercentDR };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _network = new EditorNetwork();
            _network.RemoteMessageHandler = HandleRemoteMessage;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _network.StartListener();

            if (!string.IsNullOrEmpty(_settings.lastFile) && File.Exists(_settings.lastFile))
            {
                _filePath = _settings.lastFile;
                LoadParameterFile(_settings.lastFile);
            }

            ShowParameters(_params);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _network.Disconnect();
            e.Cancel = !PassesDirtyCheck();
            _settings.lastPosition.X = Location.X;
            _settings.lastPosition.Y = Location.Y;
            _settings.lastPosition.Width = Width;
            _settings.lastPosition.Height = Height;
            SaveDefaults();
        }

        private void EnumerateProjectNames()
        {
            _projectNames = SharedFileLocations.EnumerateHtsProjects();
            projectComboBox.Items.Clear();
            foreach (var p in _projectNames) projectComboBox.Items.Add(p);
        }

        private void EnumerateTransducerNames()
        {
            _transducerNames = SharedFileLocations.EnumerateTransducers();
            transducerComboBox.Items.Clear();
            foreach (var t in _transducerNames) transducerComboBox.Items.Add(t);
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.project = projectComboBox.SelectedItem.ToString();
            SaveDefaults();
            SharedFileLocations.SetHtsProject(_settings.project);
            KLib.Signals.Editor.WavFileNameEditor.WavFolder = Path.Combine(SharedFileLocations.HtsResourcesFolder, "Wav Files");
        }

        bool LoadParameterFile(string path)
        {
            bool ok = true;

            try
            {
                _params.Read(path);

                string fsmPath = path.Replace(".xml", ".fsm");
                if (File.Exists(fsmPath))
                {
                    int version = graphViewer.Read(path.Replace(".xml", ".fsm"));
                    if (version < FSMGraphContainer.Version)
                    {
                        RefreshLayout();
                    }
                }
                else Turandot.Layout.CreateGraph(_params, graphViewer);
                _setupIsDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ok = false;
            }

            return ok;
        }

        bool SaveParameterFile(string path)
        {
            if (!ValidateInputEvents())
            {
                System.Windows.Forms.MessageBox.Show("One or more Events have become invalid. Go to the Events tab to correct it.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ok = true;
            try
            {
                Files.XmlSerialize(_params.ToBase(), path);
                graphViewer.Write(path.Replace(".xml", ".fsm"));

                _setupIsDirty = false;
                _filePath = path;
                pathLabel.Text = Tools.CompactPath(_filePath, pathLabel.Width, pathLabel.Font, TextFormatFlags.PathEllipsis);
            }
            catch (Exception ex)
            {
                ok = false;
                MessageBox.Show(ex.Message);
            }

            return ok;
        }

        private void NewParamsButton_Click(object sender, EventArgs e)
        {
            if (PassesDirtyCheck())
            {
                _params = new EditorParameters();
                graphViewer.Graph = new FSMGraph.Graph();

                SelectNothing();
                _filePath = "";
                ShowParameters(_params);

                _setupIsDirty = false;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (!PassesDirtyCheck()) return;

            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter options and filter index.
            dlg.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            dlg.InitialDirectory = SharedFileLocations.HtsConfigFolder;
            dlg.FilterIndex = 1;
            dlg.Multiselect = false;
            dlg.CheckFileExists = true;

            // Call the ShowDialog method to show the dialog box.
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _settings.lastFolder = Path.GetDirectoryName(dlg.FileName);
                SaveDefaults();
                if (LoadParameterFile(dlg.FileName))
                {
                    _settings.lastFile = dlg.FileName;

                    _filePath = dlg.FileName;
                    _setupIsDirty = false;
                    ShowParameters(_params);
                    SelectNothing();

                    SaveDefaults();
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (string.IsNullOrEmpty(_filePath))
            {
                SaveFileAsButton_Click(null, e);
            }
            else
            {
                SaveParameterFile(_filePath);
            }
        }

        private void SaveFileAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            // Set filter options and filter index.
            dlg.Filter = "XML Files (.xml)|Turandot.*.xml|All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.OverwritePrompt = true;
            dlg.InitialDirectory = SharedFileLocations.HtsConfigFolder;

            if (File.Exists(_filePath))
            {
                FileInfo fi = new FileInfo(_filePath);
                dlg.FileName = Path.GetFileName(_filePath);
            }
            else
            {
                dlg.FileName = "Untitled.xml";
            }

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = Path.GetDirectoryName(dlg.FileName);
                var fn = Path.GetFileName(dlg.FileName);
                if (!(fn.StartsWith("Turandot.")))
                {
                    dlg.FileName = Path.Combine(folder, $"Turandot.{fn}");
                }

                SaveParameterFile(dlg.FileName);

                // FIX ME: channelView.WavFolder = GetWavFolder();

                _settings.lastFolder = Path.GetDirectoryName(dlg.FileName);
                _settings.lastFile = dlg.FileName;
                SaveDefaults();
            }
        }

        void ShowParameters(EditorParameters p)
        {
            _ignoreEvents = true;

            pathLabel.Text = Tools.CompactPath(_filePath, pathLabel.Width, pathLabel.Font, TextFormatFlags.PathEllipsis);
            tagTextBox.Text = p.tag ?? "";
            wavFolderTextBox.Text = p.wavFolder;

            trialLogOptionEnum.SetEnumValue(p.trialLogOption);

            expertCheckBox.Checked = p.allowExpertOptions;
            termFlagLabel.Visible = _params.allowExpertOptions;
            termFlagExprBox.Visible = _params.allowExpertOptions;

            matlabFileBrowser.DefaultFolder = FileLocations.MATLABFolder;
            matlabFileBrowser.Value = p.matlabFunction;

            customScreenColorCheckBox.Checked = p.screen.ApplyCustomScreenColor;
            cuesSpecifier.Value = p.screen.Cues;
            inputsSpecifier.Value = p.screen.Inputs;

            overrideColorCheckBox.Checked = p.screen.ApplyParamSpecificScreenColor;
            screenColorBox.ValueAsUInt = (uint)p.screen.Color;

            stateCuesControl.SetAvailableCues(p.screen.Cues);
            stateInputsControl.SetAvailableInputs(p.screen.Inputs);

            UpdateAllowableLevelUnits();
            ShowInstructions(p.instructions);

            _ignoreEvents = false;
            
            eventsSpecifier.UpdateInputSources(p.screen.Inputs.Select(x => x.Name).ToList(), null);
            eventsSpecifier.SetData(p.inputEvents, p.flags);

            ShowScheduleParameters(p.schedule, p.adapt);
        }

        void ShowInstructions(Instructions instructions)
        {
            instructionEditor.Value = instructions;
        }

        private void ShowScheduleParameters(Schedule sched, Adaptation adapt)
        {
            schedModeDropDown.SetEnumValue(sched.mode);
            SelectScheduleTab(sched.mode);

            scheduleControl.SetDataForContext(_params);
            scheduleControl.Value = sched;

            adaptControl.SetDataForContext(_params);
            adaptControl.Value = adapt;

            _ignoreEvents = true;
            breakCheckBox.Checked = sched.offerBreakAfter > 0;
            afterNumeric.IntValue = sched.offerBreakAfter;
            breakInstructBox.Text = sched.breakInstructions;
            _ignoreEvents = false;
        }

        private void SelectScheduleTab(Mode mode)
        {
            switch (mode)
            {
                case Mode.CS:
                case Mode.Sequence:
                    schedTabs.SelectedIndex = 0;
                    break;
                case Mode.Adapt:
                    schedTabs.SelectedIndex = 1;
                    break;
                case Mode.Optimize:
                    schedTabs.SelectedIndex = 2;
                    break;
            }
        }

        private void RefreshNodes()
        {
            graphViewer.RefreshNodes(_params.firstState, _params.schedule.decisionState, _params.GetActions());
        }


        private void OnNodeAdded(string name)
        {
            _params.AddState(name);
            if (_params.NumStates == 1)
            {
                _params.firstState = name;
                RefreshNodes();
            }

            scheduleControl.UpdateAvailableStates();
            adaptControl.UpdateAvailableStates();

            SetDirty();
        }

        void SetDirty()
        {
            _setupIsDirty = true;
            if (string.IsNullOrEmpty(_filePath)) pathLabel.Text = "Untitled*";
            else if (pathLabel.Text[pathLabel.Text.Length - 1] != '*') pathLabel.Text += "*";
        }

        void OnEdgeAdded(string source, string target, string label, object userData)
        {
            _params.AddTransition(source, target, label, (TermType)userData);
            if (_params[source].endAction != EndAction.None)
            {
                _params[source].endAction = EndAction.None;
                Turandot.Layout.AddBadges(_params[source], graphViewer);
            }

            RefreshNodes();
            SetDirty();
        }

        void OnEdgeSelected(string source, string target, string label, object userData)
        {
            if (string.IsNullOrEmpty(label))
            {
                SelectTimeout(_params.FindTimeout(source, (TermType)userData));
            }
            else
            {
                SelectTermination(_params.FindTermination(source, target, label, (TermType)userData));
            }
            SelectState(_params.FindState(source));
        }

        void OnEdgeDeleted(string source, string target, string label, object userData)
        {
            _params.RemoveTransition(source, target, label, (TermType)userData);
            RefreshNodes();
            SetDirty();
        }

        private void OnNodeSelected(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                transitionLabel.Visible = false;
                TransitionTabs.Visible = false;

                FlowElement state = _params.FindState(name);
                SelectState(state);
                if (string.IsNullOrEmpty(state.timeOuts[0].linkTo) || state.timeOuts[0].termType == TermType.Any)
                    SelectTimeout(state.timeOuts[0]);
            }
            else
            {
                SelectNothing();
            }
        }

        private void OnNodesDeleted(List<string> names)
        {
            _params.RemoveStates(names);
            scheduleControl.UpdateAvailableStates();
            adaptControl.UpdateAvailableStates();
            SetDirty();
        }

        private void OnNodesDuplicated(List<string> names)
        {
            foreach (var n in names) _params.DuplicateState(n);
            SetDirty();
        }

        AvailableTransitions GetAvailableTransitions(string name)
        {
            FlowElement fe = _params.flowChart.Find(f => f.name == name);

            List<string> sources = _params.GetInputEventNames();

            if (fe.isAction) sources.Clear();

            bool usesCS = _params.schedule.mode == Mode.CS || (_params.schedule.mode == Mode.Adapt && _params.adapt.UsesCS);

            AvailableTransitions available = new AvailableTransitions(sources, usesCS);

            bool usedAny = !string.IsNullOrEmpty(fe.timeOuts[0].linkTo);
            bool usedCSplus = fe.timeOuts.Find(t => t.termType == TermType.CSplus) != null;
            bool usedCSminus = fe.timeOuts.Find(t => t.termType == TermType.CSminus) != null;

            if (usesCS)
            {
                if ((usedCSplus && usedCSminus) || usedAny) available.ExcludeTO(TermType.Any);
                else if (usedAny && usedCSplus) available.ExcludeTO(TermType.CSminus);
                else if (usedAny && usedCSminus) available.ExcludeTO(TermType.CSplus);
            }
            else
            {
                if (!string.IsNullOrEmpty(fe.timeOuts[0].linkTo)) available.ExcludeTO();
            }

            usedAny = fe.term.Find(t => t.type == TermType.Any) != null;
            usedCSplus = fe.term.Find(t => t.type == TermType.CSplus) != null;
            usedCSminus = fe.term.Find(t => t.type == TermType.CSminus) != null;

            if (usesCS)
            {
                if (usedCSplus && usedCSminus) available.Exclude(TermType.Any);
                else if (usedAny && usedCSplus) available.Exclude(TermType.CSminus);
                else if (usedAny && usedCSminus) available.Exclude(TermType.CSplus);
            }

            foreach (string src in sources)
            {
                Termination term = fe.term.Find(t => t.source == src);
                if (term != null)
                {
                    available.Exclude(src);
                }
            }

            return available;
        }

        void SelectState(FlowElement state)
        {
            _ignoreEvents = true;

            actionCheckBox.Checked = state.isAction;
            actionPropertyGrid.Visible = state.isAction;
            TransitionTabs.Visible = !state.isAction;
            transitionLabel.Visible = !state.isAction;
            statePanel.Visible = !state.isAction;

            if (state.isAction)
            {
                actionPropertyGrid.SelectedObject = state.action;
            }

            stateNameTextBox.Text = state.name;
            startCheckBox.Checked = state.name == _params.firstState;
            startCheckBox.Enabled = !startCheckBox.Checked;
            hideCursorCheckBox.Checked = state.hideCursor;
            disableInputsCheckBox.Checked = state.disableInputs;

            bool endActionVisible = _params.allowExpertOptions && state.term.Count == 0 && state.timeOuts.Count == 1 && string.IsNullOrEmpty(state.timeOuts[0].linkTo);

            endActionLabel.Visible = endActionVisible;
            endActionDropDown.Visible = endActionVisible;

            endActionDropDown.SetEnumValue(state.endAction);

            actionCheckBox.Enabled = !startCheckBox.Checked;
            decisionCheckBox.Checked = state.name == _params.schedule.decisionState;

            stateCuesControl.Value = state.cues;
            stateInputsControl.SetDataForContext(state.sigMan?.GetValidSweepables());
            stateInputsControl.Value = state.inputs;

            if (state.sigMan != null)
            {
                channelListBox.SetItems(state.sigMan.Channels.Select(c => c.Name).ToList());

                if (state.sigMan.Channels.Count > 0)
                {
                    channelListBox.SelectedIndex = 0;
                    ShowSignalChannel(state.sigMan.Channels[0]);
                    signalGraph.Visible = true;
                    PlotSignals(state.sigMan, state.timeOuts[0]);
                }
            }
            else
            {
                signalGraph.Visible = false;
                audioErrorTextBox.Text = "";
                channelListBox.Clear();
                ShowSignalChannel(null);
            }

            _ignoreEvents = false;

            InsertTabPage(tabControl, StatePage);

            //if (state.isAction) RemoveTabPage(tabControl, AudioPage);
            //else InsertTabPage(tabControl, AudioPage);
            InsertTabPage(tabControl, AudioPage);

            InsertTabPage(tabControl, CuePage);
            InsertTabPage(tabControl, InputPage);

            if (tabControl.SelectedTab != AudioPage && tabControl.SelectedTab != CuePage && tabControl.SelectedTab != InputPage)
                tabControl.SelectedTab = StatePage;

            _selectedState = state;
        }

        void ShowSignalChannel(Channel chan)
        {
            channelPropertyGrid.SelectedObject = chan;
            channelPropertyGrid.ExpandAllGridItems();
        }

        private static readonly HashSet<string> _expandTriggers = new HashSet<string>
        {
            "Gate", "Bursted", "BurstRate", "Modulation", "Filter", "BandMode", "Filename", "Modality", "Waveform"
        };

        private void channelPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (_expandTriggers.Contains(e.ChangedItem.Label))
            {
                channelPropertyGrid.ExpandAllGridItems();
                channelPropertyGrid.Refresh();
            }

            scheduleControl.UpdateAvailableStates();
            adaptControl.UpdateAvailableStates();
            PlotSignals(_selectedState.sigMan, _selectedState.timeOuts[0]);
            SetDirty();
        }

        void SelectTimeout(Timeout t)
        {
            _ignoreEvents = true;
            timeoutExprBox.Text = t.expr;
            timeoutPage.Tag = t;
            timeoutResultTextBox.Text = t.result;
            _ignoreEvents = false;

            EvaluateTimeoutExpression(t.expr);

            transitionLabel.Visible = _selectedState != null && !_selectedState.isAction;
            transitionLabel.Text = (t.termType != TermType.Any ? (EditorParameters.TermTypeToString(t.termType) + " ") : "") + "Timeout";
            transitionLabel.ForeColor = GraphViewer.GetEdgeColor(t.termType);
            TransitionTabs.Visible = _selectedState != null && !_selectedState.isAction;

            TransitionTabs.SelectedTab = timeoutPage;
        }

        void SelectTermination(Termination t)
        {
            if (t == null) return;

            _ignoreEvents = true;
            termLatencyNumeric.Value = t.latency_ms;
            termActionComboBox.SelectedIndex = (int)t.action;
            termResultTextBox.Text = t.result;
            termFlagExprBox.Text = t.flagExpr;

            termPage.Tag = t;

            inputEventComboBox.Items.Clear();
            if (t.source == "???") inputEventComboBox.Items.Add("???");
            inputEventComboBox.Items.AddRange(_params.GetInputEventNames().ToArray());
            inputEventComboBox.SelectedItem = t.source;

            transitionLabel.Visible = true;
            TransitionTabs.Visible = true;

            transitionLabel.Text = (t.type != TermType.Any ? (EditorParameters.TermTypeToString(t.type) + " ") : "") + t.source;
            transitionLabel.ForeColor = GraphViewer.GetEdgeColor(t.type);

            TransitionTabs.SelectedTab = termPage;
            _ignoreEvents = false;
        }

        void SelectNothing()
        {
            RemoveTabPage(tabControl, StatePage);
            RemoveTabPage(tabControl, AudioPage);
            RemoveTabPage(tabControl, CuePage);
            RemoveTabPage(tabControl, InputPage);

            tabControl.SelectedTab = SchedulePage;
            _selectedState = null;
        }

        void InsertTabPage(TabControl tab, TabPage page, int insertAt = -1)
        {
            if (!tab.TabPages.Contains(page))
                tab.TabPages.Insert(insertAt < 0 ? tabControl.TabPages.Count : insertAt, page);
        }

        void RemoveTabPage(TabControl tab, TabPage page)
        {
            if (tab.TabPages.Contains(page))
                tab.TabPages.Remove(page);
        }

        void ShowScreenElementTabPage(TabControl tab, TabPage page, bool show)
        {
            if (!show)
            {
                RemoveTabPage(tab, page);
            }
            else if (!tab.TabPages.Contains(page))
            {
                var names = new List<string>();
                foreach (TabPage p in tab.TabPages) names.Add(p.Name);
                names.Add(page.Name);
                names.Sort();
                tab.TabPages.Insert(names.IndexOf(page.Name), page);
            }
        }

        private void infoPanel_SizeChanged(object sender, EventArgs e)
        {
            pathLabel.Width = infoPanel.Right - pathLabel.Left - 5;
            pathLabel.Text = Tools.CompactPath(_filePath, pathLabel.Width, pathLabel.Font, TextFormatFlags.PathEllipsis);
            versionLabel.Location = new Point(infoPanel.Width - versionLabel.Width, infoPanel.Height - versionLabel.Height);
        }

        private void actionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedState != null && _selectedState.name != _params.firstState)
            {
                if (!_params.CanBeMadeAction(_selectedState) && !_selectedState.isAction)
                {
                    DlgResult result = System.Windows.Forms.MessageBox.Show("Converting this state to an action will delete its downstream connections.\nContinue?",
                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DlgResult.No) return;

                    _selectedState.term.Clear();
                    _selectedState.timeOuts.Clear();
                    _selectedState.timeOuts.Add(new Timeout());
                    _selectedState.endAction = EndAction.None;

                    graphViewer.ClearNodeOutgoing(_selectedState.name);
                    Turandot.Layout.AddBadges(_selectedState, graphViewer);
                }

                _selectedState.isAction = actionCheckBox.Checked;
                _selectedState.endAction = EndAction.None;
                _selectedState.action = new TurandotAction();
                Turandot.Layout.AddBadges(_selectedState, graphViewer);
                TransitionTabs.Visible = !_selectedState.isAction;
                transitionLabel.Visible = !_selectedState.isAction;
                statePanel.Visible = !_selectedState.isAction;

                RefreshNodes();
                SelectState(_selectedState);

                SetDirty();
            }
        }

        private void startCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && startCheckBox.Checked && _selectedState != null && _selectedState.name != _params.firstState)
            {
                _params.firstState = _selectedState.name;
                RefreshNodes();
                startCheckBox.Enabled = false;
                actionCheckBox.Enabled = false;
                SetDirty();
            }
        }

        private void endActionDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _selectedState.endAction = (EndAction)endActionDropDown.Value;
                Turandot.Layout.AddBadges(_selectedState, graphViewer);

                SetDirty();
            }
        }

        private void decisionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedState != null)
            {
                string decisionState = decisionCheckBox.Checked ? _selectedState.name : "";
                _params.schedule.decisionState = decisionState;
                RefreshNodes();
                SetDirty();
            }
        }

        private void ValidateStateName(string newName)
        {
            if (!_ignoreEvents && _selectedState != null && newName != _selectedState.name)
            {
                if (_params.IsStateNameTaken(newName))
                {
                    System.Windows.Forms.MessageBox.Show("The name '" + stateNameTextBox.Text +
                        "' is already in use. State names must be unique. Choose another name.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    stateNameTextBox.Text = _selectedState.name;
                }
                else
                {
                    if (_params.firstState == _selectedState.name)
                        _params.firstState = newName;
                    if (_params.schedule.decisionState == _selectedState.name)
                        _params.schedule.decisionState = newName;

                    string oldName = _selectedState.name;
                    _selectedState.name = newName;

                    graphViewer.RenameNode(oldName, newName);
                    _params.RenameState(oldName, newName);
                    _params.RenameStateInSchedule(oldName, newName);

                    ShowScheduleParameters(_params.schedule, _params.adapt);

                    SetDirty();
                }
            }
        }

        private void stateNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                stateNameTextBox.Text = _selectedState.name;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                ValidateStateName(stateNameTextBox.Text);
                StatePage.Focus();
                e.Handled = true;
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void timeoutExprBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Timeout timeOut = timeoutPage.Tag as Timeout;
            if (e.KeyChar == (char)27)
            {
                timeoutExprBox.Text = timeOut.expr;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                timeOut.expr = timeoutExprBox.Text;
                EvaluateTimeoutExpression(timeoutExprBox.Text);
                StatePage.Focus();
                e.Handled = true;
                SetDirty();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void timeoutExprBox_Leave(object sender, EventArgs e)
        {
            (timeoutPage.Tag as Timeout).expr = timeoutExprBox.Text;
            EvaluateTimeoutExpression(timeoutExprBox.Text);
            SetDirty();
        }

        private void timeoutResultTextBox_Leave(object sender, EventArgs e)
        {
            (timeoutPage.Tag as Timeout).result = timeoutResultTextBox.Text;
            SetDirty();
        }

        private void timeoutResultTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Timeout timeOut = timeoutPage.Tag as Timeout;
            if (e.KeyChar == (char)27)
            {
                timeoutResultTextBox.Text = timeOut.result;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                timeOut.result = timeoutResultTextBox.Text;
                StatePage.Focus();
                e.Handled = true;
                SetDirty();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void termResultTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Termination term = termPage.Tag as Termination;
            if (e.KeyChar == (char)27)
            {
                termResultTextBox.Text = term.result;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                term.result = termResultTextBox.Text;
                StatePage.Focus();
                e.Handled = true;
                SetDirty();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void termResultTextBox_Leave(object sender, EventArgs e)
        {
            (termPage.Tag as Termination).result = termResultTextBox.Text;
            SetDirty();
        }

        private void termFlagExprBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Termination term = termPage.Tag as Termination;
            if (e.KeyChar == (char)27)
            {
                termFlagExprBox.Text = term.flagExpr;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                base.OnKeyPress(e);
                term.flagExpr = termFlagExprBox.Text;
                e.Handled = true;
                SetDirty();
            }
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void termFlagExprBox_Leave(object sender, EventArgs e)
        {
            (termPage.Tag as Termination).flagExpr = termFlagExprBox.Text;
            SetDirty();
        }

        private void termLatencyNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (termPage.Tag as Termination).latency_ms = termLatencyNumeric.FloatValue;
                SetDirty();
            }
        }

        private void termActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                (termPage.Tag as Termination).action = (TerminationAction)termActionComboBox.SelectedIndex;
                SetDirty();
            }
        }

        private void inputEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                Termination term = termPage.Tag as Termination;
                string oldName = term.source;
                term.source = (string)inputEventComboBox.SelectedItem;
                inputEventComboBox.Items.Remove("???");
                graphViewer.ChangeTerminationSource(_selectedState.name, term.linkTo, oldName, term.source);
                SetDirty();
            }
        }

        private void eventListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            SetDirty();
        }

        private void eventListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        {
            string oldName = _params.RenameEvent(e.name, e.index);
            graphViewer.RenameEvent(oldName, e.name);
            SetDirty();
        }

        private void eventListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        {
            _params.DeleteEvents(e.names);
            graphViewer.DeleteEvents(e.names);
            SetDirty();
        }

        private void eventListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        {
            _params.MoveEvent(e.name, e.index);
            SetDirty();
        }

        private void eventListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        {
            _params.MoveEvents(e.names);
            SetDirty();
        }


        private bool PassesDirtyCheck()
        {
            bool result = true;
            if (_setupIsDirty)
            {
                DlgResult dlgResult = MsgBox.Show("There are unsaved changes to the parameters.\nDo you want to save them?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, this.Handle);
                switch (dlgResult)
                {
                    case DlgResult.No:
                        result = true;
                        break;
                    case DlgResult.Yes:
                        result = SaveParameterFile(_filePath);
                        break;
                    default:
                        result = false;
                        break;
                }
            }

            return result;

        }

        private void EvaluateTimeoutExpression(string expr)
        {
            if (Expressions.TryEvaluate(expr))
            {
                exprEvalResultTextBox.ForeColor = System.Drawing.Color.Black;
                exprEvalResultTextBox.Text = "Expression OK.";
            }
            else
            {
                exprEvalResultTextBox.ForeColor = System.Drawing.Color.Red;
                exprEvalResultTextBox.Text = "Expression error:" + Environment.NewLine + Environment.NewLine + Expressions.LastError;
            }
        }

        private void allCuesControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }

        private void allCuesControl_CueAddRemove(object sender, Controls.StateCuesControl.CueAddRemoveArgs e)
        {
            Turandot.Layout.AddBadges(_selectedState, graphViewer);
        }

        private void channelListBox_ItemAdded(object sender, KUserListBox.ChangedItem e)
        {
            Channel ch = new Channel(e.name, new KLib.Signals.Waveform());
            ch.Modality = Modality.Audio;
            ch.Laterality = Laterality.Diotic;

            ShowSignalChannel(ch);

            if (_selectedState.sigMan == null)
            {
                _selectedState.sigMan = new SignalManager();
            }
            _selectedState.sigMan.Channels.Insert(e.index, ch);
            Turandot.Layout.AddBadges(_selectedState, graphViewer);
            scheduleControl.UpdateAvailableStates();
            adaptControl.UpdateAvailableStates();

            ShowSignalChannel(ch);

            SetDirty();
        }

        private void channelView_WaveformBecameValid(object sender, EventArgs e)
        {
            //if (_selectedState.sigMan == null) _selectedState.sigMan = new SignalManager();
            //_selectedState.sigMan.Channels.Insert(channelListBox.SelectedIndex, channelView.Data);
        }

        private void channelListBox_ItemMoved(object sender, KUserListBox.ChangedItem e)
        {
            if (_ignoreEvents || _selectedState == null || _selectedState.sigMan == null) return;

            Channel ch = _selectedState.sigMan.GetChannel(e.name);
            if (ch != null)
            {
                _selectedState.sigMan.Channels.Remove(ch);
                _selectedState.sigMan.Channels.Insert(e.index, ch);
            }
            SetDirty();
        }

        private void channelListBox_ItemRenamed(object sender, KUserListBox.ChangedItem e)
        {
            if (_ignoreEvents || _selectedState == null || _selectedState.sigMan == null) return;

            Channel ch = _selectedState.sigMan.Channels[e.index];

            if (ch != null)
            {
                string oldname = ch.Name;
                ch.Name = e.name;

                ShowSignalChannel(ch);

                _params.ApplySignalNameChangeToSchedule(_selectedState.name, oldname, e.name);
                scheduleControl.UpdateAvailableStates();
                adaptControl.UpdateAvailableStates();
            }
            SetDirty();
        }

        private void channelListBox_ItemsDeleted(object sender, KUserListBox.ChangedItems e)
        {
            if (_ignoreEvents || _selectedState == null || _selectedState.sigMan == null) return;

            foreach (string name in e.names)
            {
                Channel ch = _selectedState.sigMan.GetChannel(name);
                if (ch != null) _selectedState.sigMan.Channels.Remove(ch);
            }

            if (_selectedState.sigMan.Channels.Count == 0)
            {
                _selectedState.sigMan = null;
                Turandot.Layout.AddBadges(_selectedState, graphViewer);
            }
            SetDirty();
        }

        private void channelListBox_ItemsMoved(object sender, KUserListBox.ChangedItems e)
        {
            if (_ignoreEvents || _selectedState == null || _selectedState.sigMan == null) return;

            List<Channel> tmp = new List<Channel>();
            foreach (string name in e.names)
            {
                Channel ch = _selectedState.sigMan.GetChannel(name);
                if (ch != null) tmp.Add(ch);
            }

            _selectedState.sigMan.Channels = tmp;
            SetDirty();
        }

        private void channelListBox_SelectionChanged(object sender, KUserListBox.ChangedItem e)
        {
            if (!_ignoreEvents && _selectedState != null)
            {
                Channel ch = null;
                if (_selectedState.sigMan != null) ch = _selectedState.sigMan.GetChannel(e.name);
                if (ch == null)
                {
                    ch = new Channel(e.name);
                }
                ShowSignalChannel(ch);
            }
        }

        private void PlotSignals(SignalManager sigman, Timeout to)
        {
            SessionContext.SetWavFolder(Path.Combine(SharedFileLocations.HtsResourcesFolder, "Wav Files"));

            audioErrorTextBox.Text = "";

            string chanName = "";
            int npts = 0;
            double[] time;
            try
            {
                signalGraph.Plot.Clear();

                float T = Expressions.Evaluate(to.expr).Min();
                if (T <= 0) T = 0.001f * sigman.GetMaxInterval(1000);
                T = Math.Min(T, 5);

                npts = (int)(_Fs * T);

                sigman.Initialize(_Fs, npts, SessionContext.Signal);

                time = new double[npts];
            }
            catch (Exception ex)
            {
                audioErrorTextBox.Text = ex.Message;
                signalGraph.Refresh();
                graphTabControl.SelectedTab = errorPage;

                return;
            }

            int irow = 0;
            foreach (Channel ch in sigman.Channels)
            {
                try
                {
                    chanName = ch.Name;
                    ch.Create();

                    double[] y = new double[npts];
                    double scaleFactor = 1 / ch.Data.Max();

                    for (int k = 0; k < npts; k++)
                    {
                        time[k] = k / _Fs;
                        y[k] = ch.Data[k] * scaleFactor + 2 * irow;
                    }
                    signalGraph.Plot.Add.SignalXY(time, y);
                }
                catch (Exception ex)
                {
                    audioErrorTextBox.Text += chanName + ": " + ex.Message + System.Environment.NewLine;
                    graphTabControl.SelectedTab = errorPage;
                }
                --irow;
            }

            signalGraph.Visible = true;
            signalGraph.Plot.Axes.AutoScale();
            signalGraph.Refresh();
            channelPropertyGrid.Refresh();  

            graphTabControl.SelectedTab = string.IsNullOrEmpty(audioErrorTextBox.Text) ? graphPage : errorPage;
        }

        private void schedModeDropDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.schedule.mode = (Mode)schedModeDropDown.Value;
                scheduleControl.UpdateMode();
                SelectScheduleTab(_params.schedule.mode);
                SetDirty();
            }
        }

        private void scheduleControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }

        private void ShowMetrics()
        {
            _settings.metrics.Sort();
            metricGridView.Rows.Clear();
            foreach (var entry in _settings.metrics.entries)
            {
                metricGridView.Rows.Add(entry.key, entry.value);
            }
        }

        private void metricGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_ignoreEvents || metricGridView.CurrentCell == null) return;

            int rowIndex = metricGridView.CurrentCell.RowIndex;
            var cells = metricGridView.Rows[rowIndex].Cells;
            string metricName = cells["MetricName"].Value as string;

            if (metricGridView.CurrentCell.ColumnIndex == 0)
            {
                if (rowIndex == _settings.metrics.entries.Count)
                {
                    _settings.metrics[metricName] = "";
                }
                else
                {
                    _settings.metrics.RenameKey(rowIndex, metricName);
                }
            }
            else if (metricGridView.CurrentCell.ColumnIndex == 1)
            {
                _settings.metrics[metricName] = cells["MetricValue"].Value.ToString();
            }
            SaveDefaults();
        }

        private void metricGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var metricName = e.Row.Cells["MetricName"].Value.ToString();
            _settings.metrics.RemoveKey(metricName);

            SaveDefaults();
        }

        private void SaveDefaults()
        {
            Files.XmlSerialize(_settings, GetDefaultsFileName());
        }

        private string GetDefaultsFileName()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "EPL", "Turandot Editor.xml");
        }

        private void RestoreDefaults()
        {
            string fn = GetDefaultsFileName();

            if (File.Exists(fn))
            {
                _settings = Files.XmlDeserialize<Settings>(fn);
            }
            else _settings = new Settings();

            int index = _projectNames.IndexOf(_settings.project);
            if (index < 0)
            {
                index = 0;
                _settings.project = _projectNames[0];
            }
            projectComboBox.SelectedIndexChanged -= projectComboBox_SelectedIndexChanged;
            projectComboBox.SelectedIndex = index;
            projectComboBox.SelectedIndexChanged += projectComboBox_SelectedIndexChanged;
            SharedFileLocations.SetHtsProject(_settings.project);
            KLib.Signals.Editor.WavFileNameEditor.WavFolder = Path.Combine(SharedFileLocations.HtsResourcesFolder, "Wav Files");

            if (_transducerNames.Count > 0)
            {
                index = _transducerNames.IndexOf(_settings.transducer);
                if (index < 0)
                {
                    index = 0;
                    _settings.transducer = _transducerNames[0];
                }
                transducerComboBox.SelectedIndexChanged -= transducerComboBox_SelectedIndexChanged;
                transducerComboBox.SelectedIndex = index;
                transducerComboBox.SelectedIndexChanged += transducerComboBox_SelectedIndexChanged;
            }
            SessionContext.SetTransducer(_settings.transducer);

            Expressions.Metrics = _settings.metrics;
            ShowMetrics();
            ApplyAudiogramDataToExpressions();
        }

        private void ApplyAudiogramDataToExpressions()
        {
            Expressions.Audiogram = Audiograms.AudiogramData.Load(Path.Combine(SharedFileLocations.SharedFolder, "Calibration", "agram.xml"));
            Expressions.LDL = Audiograms.AudiogramData.Load(Path.Combine(SharedFileLocations.SharedFolder, "Calibration", "ldlgram.xml"));
        }

        private void adaptControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }

        private void fixationPointControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) SetDirty();
        }

        private void messageLayout_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) SetDirty();
        }

        private void counterProperties_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) SetDirty();
        }

        private void scoreboardProperties_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents) SetDirty();
        }

        private void instructionEditor_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }

        private void inputControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }

        private void inputControl_InputAddRemove(object sender, Controls.StateInputsControl.InputAddRemoveArgs e)
        {
            Turandot.Layout.AddBadges(_selectedState, graphViewer);

            if (!ValidateInputEvents())
            {
                System.Windows.Forms.MessageBox.Show("One or more Events have become invalid. Go to the Events tab to correct it.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputEvents()
        {
            // Called after list of active input controls is changed. Nulls criteria for which the inputs have disappeared.
            // User needs to be warned that the event has become invalid--I see no good way to correct it automatically.

            bool isOK = true;

            var activeControls = _params.GetActiveInputControls();
            var scalarControls = _params.GetActiveScalarControls();

            foreach (var ev in _params.inputEvents)
            {
                foreach (var crit in ev.criteria)
                {
                    if (!string.IsNullOrEmpty(crit.control) && activeControls.Find(o => o == crit.control) == null && _params.flags.Find(f => f.name == crit.control) == null && scalarControls.Find(x => x == crit.control) == null)
                    {
                        crit.control = "";
                        isOK = false;
                    }
                }
            }

            return isOK;
        }

        private void matlabFileBrowser_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.matlabFunction = Path.GetFileName(matlabFileBrowser.Value);
                SetDirty();
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_controlKeyDown)
            {
                if (e.KeyChar == 4)
                {
                    var copied = graphViewer.DuplicateSelectedNodes();
                    foreach (var n in copied) _params.DuplicateState(n);
                    e.Handled = true;
                }
                else if (e.KeyChar == 18)
                {
                    RefreshLayout();
                    e.Handled = true;
                }
                else if (e.KeyChar == 19)
                {
                    if (string.IsNullOrEmpty(_filePath))
                    {
                        SaveFileAsButton_Click(null, e);
                    }
                    else
                    {
                        SaveParameterFile(_filePath);
                    }
                    e.Handled = true;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            _controlKeyDown = e.Control;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            _controlKeyDown = e.Control;
        }

        private void breakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                breakPanel.Visible = breakCheckBox.Checked;
                if (breakCheckBox.Checked)
                {
                    _params.schedule.offerBreakAfter = 1;
                    afterNumeric.IntValue = 1;
                }
                else
                {
                    _params.schedule.offerBreakAfter = 0;
                }
                SetDirty();
            }
        }

        private void afterNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.schedule.offerBreakAfter = afterNumeric.IntValue;
                SetDirty();
            }
        }

        private void breakInstructBox_Enter(object sender, EventArgs e)
        {
            breakInstructBox.Height = 80;
        }

        private void breakInstructBox_Leave(object sender, EventArgs e)
        {
            breakInstructBox.Height = 20;
            _params.schedule.breakInstructions = breakInstructBox.Text;
        }

        private void RefreshLayout()
        {
            RefreshNodes();
            Turandot.Layout.RefreshBadges(_params.flowChart, graphViewer);
        }

        private void tagTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.tag = tagTextBox.Text;
                SetDirty();
            }
        }
        private void wavFolderTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.wavFolder = wavFolderTextBox.Text;
                // FIX ME: channelView.WavFolder = GetWavFolder();
                SetDirty();
            }
        }

        private void trialLogOptionEnum_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.trialLogOption = (TrialLogOption)trialLogOptionEnum.Value;
                SetDirty();
            }
        }

        private void expertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.allowExpertOptions = expertCheckBox.Checked;

                termFlagLabel.Visible = _params.allowExpertOptions;
                termFlagExprBox.Visible = _params.allowExpertOptions;

                if (!_params.allowExpertOptions) _params.ClearExpertOptions();
                UpdateAllowableLevelUnits();

                SetDirty();
            }
        }

        private void UpdateAllowableLevelUnits()
        {
            var units = new List<LevelUnits> { LevelUnits.dB_attenuation, LevelUnits.dB_SPL, LevelUnits.dB_Vrms, LevelUnits.dB_SL, LevelUnits.PercentDR };
            if (_params.allowExpertOptions)
                units.Add(LevelUnits.dB_SPL_noLDL);

            KLib.Signals.Editor.LevelUnitsConverter.Allowable = units.ToArray();
        }

        private void metricGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void transducerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.transducer = transducerComboBox.SelectedItem.ToString();
            SaveDefaults();
            SessionContext.SetTransducer(_settings.transducer);
        }

        private void showStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _network.SendMessageToHTS("SetParams", _params.ToBase());
                _network.SendMessageToHTS("ShowState", _selectedState.name);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleRemoteMessage(TcpMessage message)
        {
            switch (message.Command)
            {
                case "OpenFile":
                    var filePath = message.GetPayload<string>();
                    Debug.WriteLine($"filepath = {filePath}");
                    RpcOpenFile(filePath);
                    break;
                    //case "SetMetrics":
                    //    Invoke(new Action(() => { RpcSetMetrics(parts[1]); }));
                    //    break;
                    //case "SetSubjectFolder":
                    //    FileLocations.SubjectDataFolder = parts[1];
                    //    ApplyAudiogramDataToExpressions(Path.Combine(FileLocations.SubjectDataFolder, "meta"));
                    //    break;
            }
        }

        private void RpcOpenFile(string filePath)
        {
            if (!PassesDirtyCheck()) return;
            if (LoadParameterFile(filePath))
            {
                _filePath = filePath;
                _setupIsDirty = false;
                Invoke(new Action(() =>
                {
                    ShowParameters(_params);
                    SelectNothing();
                }));
            }
        }

        private void RpcSetMetrics(string data)
        {
            _settings.metrics = Files.FromXMLString<SerializeableDictionary<string>>(data);
            Expressions.Metrics = _settings.metrics;
            ShowMetrics();
        }

        private void cuesSpecifier_ValueChanged(object sender, EventArgs e)
        {
            foreach (var fe in _params.flowChart)
            {
                CurateCues(fe, _params.screen.Cues);
            }
            stateCuesControl.SetAvailableCues(_params.screen.Cues);
            SetDirty();
        }

        private void CurateCues(FlowElement flowElement, List<CueLayout> screenCues)
        {
            var toDelete = new List<Cue>();
            foreach (var c in flowElement.cues)
            {
                if (screenCues.Find(x => x.Name.Equals(c.Target)) == null)
                {
                    toDelete.Add(c);
                }
            }

            foreach (var c in toDelete) flowElement.cues.Remove(c);
        }

        private void cuesSpecifier_NameChanged(string oldName, string newName)
        {
            foreach (var fe in _params.flowChart)
            {
                var c = fe.cues.Find(x => x.Target == oldName);
                if (c != null)
                {
                    c.Target = newName;
                }
            }
            stateCuesControl.SetAvailableCues(_params.screen.Cues);
            SetDirty();
        }

        private void inputsSpecifier_ValueChanged(object sender, EventArgs e)
        {
            foreach (var fe in _params.flowChart)
            {
                CurateInputs(fe, _params.screen.Inputs);
            }
            stateInputsControl.SetAvailableInputs(_params.screen.Inputs);
            eventsSpecifier.UpdateInputSources(_params.GetActiveInputControls(), _params.GetActiveScalarControls());
            SetDirty();
        }

        private void CurateInputs(FlowElement flowElement, List<InputLayout> screenInputs)
        {
            var toDelete = new List<Turandot.Inputs.Input>();
            foreach (var i in flowElement.inputs)
            {
                if (screenInputs.Find(x => x.Name.Equals(i.Target)) == null)
                {
                    toDelete.Add(i);
                }
            }

            foreach (var i in toDelete) flowElement.inputs.Remove(i);
        }

        private void inputsSpecifier_NameChanged(string oldName, string newName)
        {
            foreach (var fe in _params.flowChart)
            {
                var i = fe.inputs.Find(x => x.Target == oldName);
                if (i != null)
                {
                    i.Target = newName;
                }
            }
            stateInputsControl.SetAvailableInputs(_params.screen.Inputs);
            eventsSpecifier.UpdateInputSources(_params.GetActiveInputControls(), _params.GetActiveScalarControls());
            SetDirty();
        }

        private void eventsSpecifier_ValueChanged(object sender, EventArgs e)
        {
            SetDirty();
        }

        private void customScreenColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.screen.ApplyCustomScreenColor = customScreenColorCheckBox.Checked;
                SetDirty();
            }
        }

        private void hideCursorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedState != null)
            {
                _selectedState.hideCursor = hideCursorCheckBox.Checked;
                SetDirty();
            }
        }


        private void disableInputsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents && _selectedState != null)
            {
                _selectedState.disableInputs = disableInputsCheckBox.Checked;
                SetDirty();
            }

        }

        private void overrideColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.screen.ApplyParamSpecificScreenColor = overrideColorCheckBox.Checked;
                SetDirty();
            }
        }

        private void screenColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                _params.screen.Color = (int)screenColorBox.ValueAsUInt;
                SetDirty();
            }
        }

        private void showInstructionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                _network.SendMessageToHTS("SetParams", _params.ToBase());
                _network.SendMessageToHTS("ShowInstructions");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stateInputsControl_ValueChanged(object sender, EventArgs e)
        {
            if (!_ignoreEvents)
            {
                SetDirty();
            }
        }
    }
}
