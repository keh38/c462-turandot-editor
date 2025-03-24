namespace Turandot_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Turandot.Screen.GrapherLayout grapherLayout1 = new Turandot.Screen.GrapherLayout();
            Turandot.Optimizations.AnnealAFC annealAFC1 = new Turandot.Optimizations.AnnealAFC();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.NewParamsButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileAsButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MetricsPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.subjectDropdown = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.projectDropdown = new System.Windows.Forms.ComboBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.pingLED = new KLib.Controls.LedBulb();
            this.pingButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.transducerTextBox = new KLib.Controls.KTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.calfolderBrowser = new KLib.Controls.FileBrowser();
            this.label15 = new System.Windows.Forms.Label();
            this.wavfolderBrowser = new KLib.Controls.FileBrowser();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.metricGridView = new System.Windows.Forms.DataGridView();
            this.MetricName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetricValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenPage = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.finalPromptTextBox = new KLib.Controls.KTextBox();
            this.inputsList = new Turandot_Editor.Controls.Screen.CheckBoxList();
            this.cuesList = new Turandot_Editor.Controls.Screen.CheckBoxList();
            this.screenInputsTab = new System.Windows.Forms.TabControl();
            this.buttonsPage = new System.Windows.Forms.TabPage();
            this.allButtonControl = new Turandot_Editor.Controls.Inputs.AllButtonControl();
            this.grapherLayoutPage = new System.Windows.Forms.TabPage();
            this.grapherLayoutControl = new Turandot_Editor.Controls.Screen.GrapherLayoutControl();
            this.paramSliderPage = new System.Windows.Forms.TabPage();
            this.paramSliderLayoutControl = new Turandot_Editor.Controls.Screen.ParamSliderLayoutControl();
            this.thumbSliderPage = new System.Windows.Forms.TabPage();
            this.thumbSliderLayoutControl = new Turandot_Editor.Controls.Screen.ThumbSliderLayoutControl();
            this.screenCuesTab = new System.Windows.Forms.TabControl();
            this.counterPage = new System.Windows.Forms.TabPage();
            this.counterProperties = new Turandot_Editor.Controls.Screen.CounterProperties();
            this.fixationPtPage = new System.Windows.Forms.TabPage();
            this.fixationPointControl = new Turandot_Editor.Controls.FixationPointControl();
            this.messagePage = new System.Windows.Forms.TabPage();
            this.messageLayoutControl = new Turandot_Editor.Controls.Screen.MessageLayoutControl();
            this.progressBarPage = new System.Windows.Forms.TabPage();
            this.progressBarLayoutControl = new Turandot_Editor.Controls.Screen.ProgressBarLayoutControl();
            this.scoreboardPage = new System.Windows.Forms.TabPage();
            this.scoreboardProperties = new Turandot_Editor.Controls.Screen.ScoreboardProperties();
            this.InstructionsPage = new System.Windows.Forms.TabPage();
            this.instructionEditor = new Turandot_Editor.Controls.InstructionEditor();
            this.EventPage = new System.Windows.Forms.TabPage();
            this.flagControl = new Turandot_Editor.Controls.FlagControl();
            this.label16 = new System.Windows.Forms.Label();
            this.eventListBox = new KLib.Controls.KUserListBox();
            this.inputCriteria = new Turandot_Editor.InputCriteria();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.timeLabel = new System.Windows.Forms.Label();
            this.breakPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.breakInstructBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.afterNumeric = new KLib.Controls.KNumericBox();
            this.breakCheckBox = new System.Windows.Forms.CheckBox();
            this.schedTabs = new System.Windows.Forms.TabControl();
            this.schedPage = new System.Windows.Forms.TabPage();
            this.scheduleControl = new Turandot_Editor.Controls.ScheduleControl();
            this.adaptPage = new System.Windows.Forms.TabPage();
            this.adaptControl = new Turandot_Editor.Controls.AdaptationControl();
            this.schedModeDropDown = new KLib.Controls.EnumDropDown();
            this.StatePage = new System.Windows.Forms.TabPage();
            this.actionFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.showStateButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ipcTextBox = new KLib.Controls.KTextBox();
            this.statePanel = new System.Windows.Forms.Panel();
            this.endActionLabel = new System.Windows.Forms.Label();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.decisionCheckBox = new System.Windows.Forms.CheckBox();
            this.endActionDropDown = new KLib.Controls.EnumDropDown();
            this.CreateAFCButton = new System.Windows.Forms.Button();
            this.mAFCCheckBox = new System.Windows.Forms.CheckBox();
            this.actionCheckBox = new System.Windows.Forms.CheckBox();
            this.Separator = new System.Windows.Forms.Label();
            this.TransitionTabs = new System.Windows.Forms.TabControl();
            this.timeoutPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.timeoutResultTextBox = new System.Windows.Forms.TextBox();
            this.exprEvalResultTextBox = new System.Windows.Forms.TextBox();
            this.timeoutExprLabel = new System.Windows.Forms.Label();
            this.timeoutExprBox = new System.Windows.Forms.TextBox();
            this.termPage = new System.Windows.Forms.TabPage();
            this.termFlagLabel = new System.Windows.Forms.Label();
            this.termFlagExprBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.termResultTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputEventComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.termActionComboBox = new System.Windows.Forms.ComboBox();
            this.termLatencyNumeric = new KLib.Controls.KNumericBox();
            this.transitionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.AudioPage = new System.Windows.Forms.TabPage();
            this.normalizeCheckBox = new KLib.Controls.KCheckBox();
            this.audioErrorTextBox = new System.Windows.Forms.TextBox();
            this.signalGraph = new ZedGraph.ZedGraphControl();
            this.channelListBox = new KLib.Controls.KUserListBox();
            this.channelView = new KLib.Unity.Controls.Signals.ChannelView();
            this.CuePage = new System.Windows.Forms.TabPage();
            this.allCuesControl = new Turandot_Editor.Controls.AllCuesControl();
            this.InputPage = new System.Windows.Forms.TabPage();
            this.inputControl = new Turandot_Editor.Controls.InputControl();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.bypassIPCCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trialLogOptionEnum = new KLib.Controls.EnumDropDown();
            this.expertCheckBox = new System.Windows.Forms.CheckBox();
            this.wavFolderTextBox = new KLib.Controls.KTextBox();
            this.tagTextBox = new KLib.Controls.KTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.linktoBrowser = new KLib.Controls.FileBrowser();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.graphViewer = new Turandot.GraphViewer();
            this.ledTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.MetricsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metricGridView)).BeginInit();
            this.ScreenPage.SuspendLayout();
            this.screenInputsTab.SuspendLayout();
            this.buttonsPage.SuspendLayout();
            this.grapherLayoutPage.SuspendLayout();
            this.paramSliderPage.SuspendLayout();
            this.thumbSliderPage.SuspendLayout();
            this.screenCuesTab.SuspendLayout();
            this.counterPage.SuspendLayout();
            this.fixationPtPage.SuspendLayout();
            this.messagePage.SuspendLayout();
            this.progressBarPage.SuspendLayout();
            this.scoreboardPage.SuspendLayout();
            this.InstructionsPage.SuspendLayout();
            this.EventPage.SuspendLayout();
            this.SchedulePage.SuspendLayout();
            this.breakPanel.SuspendLayout();
            this.schedTabs.SuspendLayout();
            this.schedPage.SuspendLayout();
            this.adaptPage.SuspendLayout();
            this.StatePage.SuspendLayout();
            this.statePanel.SuspendLayout();
            this.TransitionTabs.SuspendLayout();
            this.timeoutPage.SuspendLayout();
            this.termPage.SuspendLayout();
            this.AudioPage.SuspendLayout();
            this.CuePage.SuspendLayout();
            this.InputPage.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewParamsButton,
            this.OpenFileButton,
            this.SaveFileButton,
            this.SaveFileAsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1645, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // NewParamsButton
            // 
            this.NewParamsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewParamsButton.Image = ((System.Drawing.Image)(resources.GetObject("NewParamsButton.Image")));
            this.NewParamsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewParamsButton.Name = "NewParamsButton";
            this.NewParamsButton.Size = new System.Drawing.Size(24, 24);
            this.NewParamsButton.Text = "New";
            this.NewParamsButton.Click += new System.EventHandler(this.NewParamsButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(24, 24);
            this.OpenFileButton.Text = "Open parameter file";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileButton.Image")));
            this.SaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(24, 24);
            this.SaveFileButton.Text = "Save parameter file";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SaveFileAsButton
            // 
            this.SaveFileAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileAsButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileAsButton.Image")));
            this.SaveFileAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileAsButton.Name = "SaveFileAsButton";
            this.SaveFileAsButton.Size = new System.Drawing.Size(24, 24);
            this.SaveFileAsButton.Text = "Save parameter file as...";
            this.SaveFileAsButton.Click += new System.EventHandler(this.SaveFileAsButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 833F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.infoPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.graphViewer, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1645, 924);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.MetricsPage);
            this.tabControl.Controls.Add(this.ScreenPage);
            this.tabControl.Controls.Add(this.InstructionsPage);
            this.tabControl.Controls.Add(this.EventPage);
            this.tabControl.Controls.Add(this.SchedulePage);
            this.tabControl.Controls.Add(this.StatePage);
            this.tabControl.Controls.Add(this.AudioPage);
            this.tabControl.Controls.Add(this.CuePage);
            this.tabControl.Controls.Add(this.InputPage);
            this.tabControl.Location = new System.Drawing.Point(816, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tableLayoutPanel.SetRowSpan(this.tabControl, 2);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(825, 916);
            this.tabControl.TabIndex = 1;
            // 
            // MetricsPage
            // 
            this.MetricsPage.BackColor = System.Drawing.SystemColors.Control;
            this.MetricsPage.Controls.Add(this.applyButton);
            this.MetricsPage.Controls.Add(this.label24);
            this.MetricsPage.Controls.Add(this.subjectDropdown);
            this.MetricsPage.Controls.Add(this.label23);
            this.MetricsPage.Controls.Add(this.projectDropdown);
            this.MetricsPage.Controls.Add(this.serverTextBox);
            this.MetricsPage.Controls.Add(this.runButton);
            this.MetricsPage.Controls.Add(this.pingLED);
            this.MetricsPage.Controls.Add(this.pingButton);
            this.MetricsPage.Controls.Add(this.label21);
            this.MetricsPage.Controls.Add(this.label20);
            this.MetricsPage.Controls.Add(this.transducerTextBox);
            this.MetricsPage.Controls.Add(this.label18);
            this.MetricsPage.Controls.Add(this.calfolderBrowser);
            this.MetricsPage.Controls.Add(this.label15);
            this.MetricsPage.Controls.Add(this.wavfolderBrowser);
            this.MetricsPage.Controls.Add(this.label12);
            this.MetricsPage.Controls.Add(this.label14);
            this.MetricsPage.Controls.Add(this.metricGridView);
            this.MetricsPage.Location = new System.Drawing.Point(4, 25);
            this.MetricsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MetricsPage.Name = "MetricsPage";
            this.MetricsPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MetricsPage.Size = new System.Drawing.Size(817, 887);
            this.MetricsPage.TabIndex = 7;
            this.MetricsPage.Text = "General";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(413, 366);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 19;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(240, 346);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 17);
            this.label24.TabIndex = 18;
            this.label24.Text = "Subjects";
            // 
            // subjectDropdown
            // 
            this.subjectDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectDropdown.FormattingEnabled = true;
            this.subjectDropdown.Location = new System.Drawing.Point(244, 366);
            this.subjectDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjectDropdown.Name = "subjectDropdown";
            this.subjectDropdown.Size = new System.Drawing.Size(160, 24);
            this.subjectDropdown.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 346);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "Projects";
            // 
            // projectDropdown
            // 
            this.projectDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectDropdown.FormattingEnabled = true;
            this.projectDropdown.Location = new System.Drawing.Point(44, 366);
            this.projectDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectDropdown.Name = "projectDropdown";
            this.projectDropdown.Size = new System.Drawing.Size(191, 24);
            this.projectDropdown.TabIndex = 15;
            this.projectDropdown.SelectedIndexChanged += new System.EventHandler(this.projectDropdown_SelectedIndexChanged);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(200, 257);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.ReadOnly = true;
            this.serverTextBox.Size = new System.Drawing.Size(204, 22);
            this.serverTextBox.TabIndex = 14;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(44, 292);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 28);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // pingLED
            // 
            this.pingLED.Location = new System.Drawing.Point(152, 257);
            this.pingLED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pingLED.Name = "pingLED";
            this.pingLED.On = false;
            this.pingLED.Size = new System.Drawing.Size(40, 25);
            this.pingLED.TabIndex = 12;
            this.pingLED.Text = "ledBulb1";
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(44, 256);
            this.pingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(100, 28);
            this.pingButton.TabIndex = 11;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 236);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "Server";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 159);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "Transducer";
            // 
            // transducerTextBox
            // 
            this.transducerTextBox.AutoSize = true;
            this.transducerTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transducerTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.transducerTextBox.IsIPAddress = false;
            this.transducerTextBox.Location = new System.Drawing.Point(44, 178);
            this.transducerTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.transducerTextBox.Name = "transducerTextBox";
            this.transducerTextBox.Size = new System.Drawing.Size(165, 22);
            this.transducerTextBox.TabIndex = 7;
            this.transducerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.transducerTextBox.ValueChanged += new System.EventHandler(this.transducerTextBox_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 23);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Default calibration folder";
            // 
            // calfolderBrowser
            // 
            this.calfolderBrowser.AutoSize = true;
            this.calfolderBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calfolderBrowser.DefaultFolder = null;
            this.calfolderBrowser.FileMustExist = false;
            this.calfolderBrowser.Filter = null;
            this.calfolderBrowser.FoldersOnly = true;
            this.calfolderBrowser.HideFolder = false;
            this.calfolderBrowser.Location = new System.Drawing.Point(44, 43);
            this.calfolderBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.calfolderBrowser.Name = "calfolderBrowser";
            this.calfolderBrowser.ReadOnly = false;
            this.calfolderBrowser.ShowSaveButton = false;
            this.calfolderBrowser.Size = new System.Drawing.Size(407, 26);
            this.calfolderBrowser.TabIndex = 5;
            this.calfolderBrowser.UseEllipsis = false;
            this.calfolderBrowser.Value = "";
            this.calfolderBrowser.ValueChanged += new System.EventHandler(this.calfolderBrowser_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 89);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Default .wav folder";
            // 
            // wavfolderBrowser
            // 
            this.wavfolderBrowser.AutoSize = true;
            this.wavfolderBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wavfolderBrowser.DefaultFolder = null;
            this.wavfolderBrowser.FileMustExist = false;
            this.wavfolderBrowser.Filter = null;
            this.wavfolderBrowser.FoldersOnly = true;
            this.wavfolderBrowser.HideFolder = false;
            this.wavfolderBrowser.Location = new System.Drawing.Point(44, 108);
            this.wavfolderBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.wavfolderBrowser.Name = "wavfolderBrowser";
            this.wavfolderBrowser.ReadOnly = false;
            this.wavfolderBrowser.ShowSaveButton = false;
            this.wavfolderBrowser.Size = new System.Drawing.Size(407, 26);
            this.wavfolderBrowser.TabIndex = 3;
            this.wavfolderBrowser.UseEllipsis = false;
            this.wavfolderBrowser.Value = "";
            this.wavfolderBrowser.ValueChanged += new System.EventHandler(this.wavfolderBrowser_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 420);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Metrics";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 439);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(405, 34);
            this.label14.TabIndex = 1;
            this.label14.Text = "This table allows you to mimic the user-specific metrics\r\nstored on the tablet an" +
    "d to test their application to expressions.";
            // 
            // metricGridView
            // 
            this.metricGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metricGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metricGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metricGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metricGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metricGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MetricName,
            this.MetricValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metricGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.metricGridView.EnableHeadersVisualStyles = false;
            this.metricGridView.Location = new System.Drawing.Point(44, 439);
            this.metricGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metricGridView.Name = "metricGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metricGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metricGridView.RowHeadersVisible = false;
            this.metricGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metricGridView.Size = new System.Drawing.Size(296, 185);
            this.metricGridView.TabIndex = 0;
            this.metricGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metricGridView_CellContentClick);
            this.metricGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.metricGridView_CellValueChanged);
            this.metricGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.metricGridView_UserDeletingRow);
            // 
            // MetricName
            // 
            this.MetricName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MetricName.HeaderText = "Name";
            this.MetricName.Name = "MetricName";
            this.MetricName.Width = 125;
            // 
            // MetricValue
            // 
            this.MetricValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MetricValue.HeaderText = "Value";
            this.MetricValue.Name = "MetricValue";
            this.MetricValue.Width = 75;
            // 
            // ScreenPage
            // 
            this.ScreenPage.BackColor = System.Drawing.SystemColors.Control;
            this.ScreenPage.Controls.Add(this.label22);
            this.ScreenPage.Controls.Add(this.finalPromptTextBox);
            this.ScreenPage.Controls.Add(this.inputsList);
            this.ScreenPage.Controls.Add(this.cuesList);
            this.ScreenPage.Controls.Add(this.screenInputsTab);
            this.ScreenPage.Controls.Add(this.screenCuesTab);
            this.ScreenPage.Location = new System.Drawing.Point(4, 25);
            this.ScreenPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScreenPage.Name = "ScreenPage";
            this.ScreenPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScreenPage.Size = new System.Drawing.Size(817, 869);
            this.ScreenPage.TabIndex = 2;
            this.ScreenPage.Text = "Screen";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(184, 713);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 17);
            this.label22.TabIndex = 23;
            this.label22.Text = "Final prompt";
            // 
            // finalPromptTextBox
            // 
            this.finalPromptTextBox.AutoSize = true;
            this.finalPromptTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finalPromptTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.finalPromptTextBox.IsIPAddress = false;
            this.finalPromptTextBox.Location = new System.Drawing.Point(272, 709);
            this.finalPromptTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.finalPromptTextBox.Name = "finalPromptTextBox";
            this.finalPromptTextBox.Size = new System.Drawing.Size(501, 22);
            this.finalPromptTextBox.TabIndex = 22;
            this.finalPromptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalPromptTextBox.ValueChanged += new System.EventHandler(this.finalPromptTextBox_ValueChanged);
            // 
            // inputsList
            // 
            this.inputsList.ListName = "Inputs";
            this.inputsList.Location = new System.Drawing.Point(21, 347);
            this.inputsList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputsList.Name = "inputsList";
            this.inputsList.Size = new System.Drawing.Size(224, 330);
            this.inputsList.TabIndex = 21;
            this.inputsList.ItemCheckedChanged += new System.EventHandler<Turandot_Editor.Controls.Screen.CheckBoxList.CheckedItem>(this.inputsList_ItemCheckedChanged);
            // 
            // cuesList
            // 
            this.cuesList.ListName = "Cues";
            this.cuesList.Location = new System.Drawing.Point(21, 41);
            this.cuesList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cuesList.Name = "cuesList";
            this.cuesList.Size = new System.Drawing.Size(224, 276);
            this.cuesList.TabIndex = 20;
            this.cuesList.ItemCheckedChanged += new System.EventHandler<Turandot_Editor.Controls.Screen.CheckBoxList.CheckedItem>(this.cuesList_ItemCheckedChanged);
            // 
            // screenInputsTab
            // 
            this.screenInputsTab.Controls.Add(this.buttonsPage);
            this.screenInputsTab.Controls.Add(this.grapherLayoutPage);
            this.screenInputsTab.Controls.Add(this.paramSliderPage);
            this.screenInputsTab.Controls.Add(this.thumbSliderPage);
            this.screenInputsTab.Location = new System.Drawing.Point(267, 338);
            this.screenInputsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.screenInputsTab.Name = "screenInputsTab";
            this.screenInputsTab.SelectedIndex = 0;
            this.screenInputsTab.Size = new System.Drawing.Size(512, 343);
            this.screenInputsTab.TabIndex = 17;
            // 
            // buttonsPage
            // 
            this.buttonsPage.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsPage.Controls.Add(this.allButtonControl);
            this.buttonsPage.Location = new System.Drawing.Point(4, 25);
            this.buttonsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsPage.Name = "buttonsPage";
            this.buttonsPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsPage.Size = new System.Drawing.Size(504, 314);
            this.buttonsPage.TabIndex = 0;
            this.buttonsPage.Text = "Buttons";
            // 
            // allButtonControl
            // 
            this.allButtonControl.AutoSize = true;
            this.allButtonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allButtonControl.Location = new System.Drawing.Point(7, 6);
            this.allButtonControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.allButtonControl.Name = "allButtonControl";
            this.allButtonControl.Size = new System.Drawing.Size(483, 292);
            this.allButtonControl.TabIndex = 13;
            this.allButtonControl.Value = null;
            this.allButtonControl.ItemAdded += new System.EventHandler<Turandot_Editor.Controls.Inputs.AllButtonControl.ChangedItem>(this.allButtonControl_ItemAdded);
            this.allButtonControl.ItemRenamed += new System.EventHandler<Turandot_Editor.Controls.Inputs.AllButtonControl.ChangedItem>(this.allButtonControl_ItemRenamed);
            this.allButtonControl.ItemsDeleted += new System.EventHandler<Turandot_Editor.Controls.Inputs.AllButtonControl.ChangedItems>(this.allButtonControl_ItemsDeleted);
            // 
            // grapherLayoutPage
            // 
            this.grapherLayoutPage.BackColor = System.Drawing.SystemColors.Control;
            this.grapherLayoutPage.Controls.Add(this.grapherLayoutControl);
            this.grapherLayoutPage.Location = new System.Drawing.Point(4, 25);
            this.grapherLayoutPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grapherLayoutPage.Name = "grapherLayoutPage";
            this.grapherLayoutPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grapherLayoutPage.Size = new System.Drawing.Size(504, 314);
            this.grapherLayoutPage.TabIndex = 2;
            this.grapherLayoutPage.Text = "Grapher";
            // 
            // grapherLayoutControl
            // 
            this.grapherLayoutControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grapherLayoutControl.Location = new System.Drawing.Point(8, 7);
            this.grapherLayoutControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grapherLayoutControl.Name = "grapherLayoutControl";
            this.grapherLayoutControl.Size = new System.Drawing.Size(416, 238);
            this.grapherLayoutControl.TabIndex = 0;
            this.grapherLayoutControl.Value = grapherLayout1;
            this.grapherLayoutControl.ValueChanged += new System.EventHandler(this.grapherLayoutControl_ValueChanged);
            // 
            // paramSliderPage
            // 
            this.paramSliderPage.BackColor = System.Drawing.SystemColors.Control;
            this.paramSliderPage.Controls.Add(this.paramSliderLayoutControl);
            this.paramSliderPage.Location = new System.Drawing.Point(4, 25);
            this.paramSliderPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramSliderPage.Name = "paramSliderPage";
            this.paramSliderPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramSliderPage.Size = new System.Drawing.Size(504, 314);
            this.paramSliderPage.TabIndex = 3;
            this.paramSliderPage.Text = "Param slider";
            // 
            // paramSliderLayoutControl
            // 
            this.paramSliderLayoutControl.AutoSize = true;
            this.paramSliderLayoutControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paramSliderLayoutControl.Location = new System.Drawing.Point(92, 7);
            this.paramSliderLayoutControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.paramSliderLayoutControl.Name = "paramSliderLayoutControl";
            this.paramSliderLayoutControl.Size = new System.Drawing.Size(229, 63);
            this.paramSliderLayoutControl.TabIndex = 0;
            this.paramSliderLayoutControl.Value = null;
            // 
            // thumbSliderPage
            // 
            this.thumbSliderPage.BackColor = System.Drawing.SystemColors.Control;
            this.thumbSliderPage.Controls.Add(this.thumbSliderLayoutControl);
            this.thumbSliderPage.Location = new System.Drawing.Point(4, 25);
            this.thumbSliderPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thumbSliderPage.Name = "thumbSliderPage";
            this.thumbSliderPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thumbSliderPage.Size = new System.Drawing.Size(504, 314);
            this.thumbSliderPage.TabIndex = 1;
            this.thumbSliderPage.Text = "Thumb slider";
            // 
            // thumbSliderLayoutControl
            // 
            this.thumbSliderLayoutControl.AutoSize = true;
            this.thumbSliderLayoutControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thumbSliderLayoutControl.Location = new System.Drawing.Point(92, 7);
            this.thumbSliderLayoutControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.thumbSliderLayoutControl.Name = "thumbSliderLayoutControl";
            this.thumbSliderLayoutControl.Size = new System.Drawing.Size(202, 90);
            this.thumbSliderLayoutControl.TabIndex = 0;
            this.thumbSliderLayoutControl.Value = null;
            this.thumbSliderLayoutControl.ValueChanged += new System.EventHandler(this.thumbSliderLayoutControl_ValueChanged);
            // 
            // screenCuesTab
            // 
            this.screenCuesTab.Controls.Add(this.counterPage);
            this.screenCuesTab.Controls.Add(this.fixationPtPage);
            this.screenCuesTab.Controls.Add(this.messagePage);
            this.screenCuesTab.Controls.Add(this.progressBarPage);
            this.screenCuesTab.Controls.Add(this.scoreboardPage);
            this.screenCuesTab.Location = new System.Drawing.Point(267, 34);
            this.screenCuesTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.screenCuesTab.Name = "screenCuesTab";
            this.screenCuesTab.SelectedIndex = 0;
            this.screenCuesTab.Size = new System.Drawing.Size(517, 282);
            this.screenCuesTab.TabIndex = 16;
            // 
            // counterPage
            // 
            this.counterPage.BackColor = System.Drawing.SystemColors.Control;
            this.counterPage.Controls.Add(this.counterProperties);
            this.counterPage.Location = new System.Drawing.Point(4, 25);
            this.counterPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.counterPage.Name = "counterPage";
            this.counterPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.counterPage.Size = new System.Drawing.Size(509, 253);
            this.counterPage.TabIndex = 2;
            this.counterPage.Text = "Counter";
            // 
            // counterProperties
            // 
            this.counterProperties.AutoSize = true;
            this.counterProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.counterProperties.Location = new System.Drawing.Point(109, 7);
            this.counterProperties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.counterProperties.Name = "counterProperties";
            this.counterProperties.Size = new System.Drawing.Size(173, 123);
            this.counterProperties.TabIndex = 0;
            this.counterProperties.Value = null;
            this.counterProperties.ValueChanged += new System.EventHandler(this.counterProperties_ValueChanged);
            // 
            // fixationPtPage
            // 
            this.fixationPtPage.BackColor = System.Drawing.SystemColors.Control;
            this.fixationPtPage.Controls.Add(this.fixationPointControl);
            this.fixationPtPage.Location = new System.Drawing.Point(4, 25);
            this.fixationPtPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixationPtPage.Name = "fixationPtPage";
            this.fixationPtPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixationPtPage.Size = new System.Drawing.Size(509, 253);
            this.fixationPtPage.TabIndex = 1;
            this.fixationPtPage.Text = "Fixation point";
            // 
            // fixationPointControl
            // 
            this.fixationPointControl.AutoSize = true;
            this.fixationPointControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fixationPointControl.Location = new System.Drawing.Point(16, 15);
            this.fixationPointControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fixationPointControl.Name = "fixationPointControl";
            this.fixationPointControl.Size = new System.Drawing.Size(204, 211);
            this.fixationPointControl.TabIndex = 11;
            this.fixationPointControl.Value = null;
            this.fixationPointControl.ValueChanged += new System.EventHandler(this.fixationPointControl_ValueChanged);
            // 
            // messagePage
            // 
            this.messagePage.BackColor = System.Drawing.SystemColors.Control;
            this.messagePage.Controls.Add(this.messageLayoutControl);
            this.messagePage.Location = new System.Drawing.Point(4, 25);
            this.messagePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messagePage.Name = "messagePage";
            this.messagePage.Size = new System.Drawing.Size(509, 253);
            this.messagePage.TabIndex = 4;
            this.messagePage.Text = "Message";
            // 
            // messageLayoutControl
            // 
            this.messageLayoutControl.AutoSize = true;
            this.messageLayoutControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messageLayoutControl.Location = new System.Drawing.Point(59, 16);
            this.messageLayoutControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.messageLayoutControl.Name = "messageLayoutControl";
            this.messageLayoutControl.Size = new System.Drawing.Size(230, 89);
            this.messageLayoutControl.TabIndex = 0;
            this.messageLayoutControl.Value = null;
            this.messageLayoutControl.ValueChanged += new System.EventHandler(this.messageLayout_ValueChanged);
            // 
            // progressBarPage
            // 
            this.progressBarPage.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarPage.Controls.Add(this.progressBarLayoutControl);
            this.progressBarPage.Location = new System.Drawing.Point(4, 25);
            this.progressBarPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarPage.Name = "progressBarPage";
            this.progressBarPage.Size = new System.Drawing.Size(509, 253);
            this.progressBarPage.TabIndex = 5;
            this.progressBarPage.Text = "Progress bar";
            // 
            // progressBarLayoutControl
            // 
            this.progressBarLayoutControl.AutoSize = true;
            this.progressBarLayoutControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progressBarLayoutControl.Location = new System.Drawing.Point(177, 12);
            this.progressBarLayoutControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.progressBarLayoutControl.Name = "progressBarLayoutControl";
            this.progressBarLayoutControl.Size = new System.Drawing.Size(158, 121);
            this.progressBarLayoutControl.TabIndex = 0;
            this.progressBarLayoutControl.Value = null;
            this.progressBarLayoutControl.ValueChanged += new System.EventHandler(this.progressBarLayoutControl_ValueChanged);
            // 
            // scoreboardPage
            // 
            this.scoreboardPage.BackColor = System.Drawing.SystemColors.Control;
            this.scoreboardPage.Controls.Add(this.scoreboardProperties);
            this.scoreboardPage.Location = new System.Drawing.Point(4, 25);
            this.scoreboardPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scoreboardPage.Name = "scoreboardPage";
            this.scoreboardPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scoreboardPage.Size = new System.Drawing.Size(509, 253);
            this.scoreboardPage.TabIndex = 3;
            this.scoreboardPage.Text = "Scoreboard";
            // 
            // scoreboardProperties
            // 
            this.scoreboardProperties.AutoSize = true;
            this.scoreboardProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreboardProperties.Location = new System.Drawing.Point(177, 7);
            this.scoreboardProperties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scoreboardProperties.Name = "scoreboardProperties";
            this.scoreboardProperties.Size = new System.Drawing.Size(180, 154);
            this.scoreboardProperties.TabIndex = 0;
            this.scoreboardProperties.Value = null;
            this.scoreboardProperties.ValueChanged += new System.EventHandler(this.scoreboardProperties_ValueChanged);
            // 
            // InstructionsPage
            // 
            this.InstructionsPage.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionsPage.Controls.Add(this.instructionEditor);
            this.InstructionsPage.Location = new System.Drawing.Point(4, 25);
            this.InstructionsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstructionsPage.Name = "InstructionsPage";
            this.InstructionsPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstructionsPage.Size = new System.Drawing.Size(817, 869);
            this.InstructionsPage.TabIndex = 9;
            this.InstructionsPage.Text = "Instructions";
            // 
            // instructionEditor
            // 
            this.instructionEditor.Location = new System.Drawing.Point(45, 33);
            this.instructionEditor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.instructionEditor.Name = "instructionEditor";
            this.instructionEditor.Size = new System.Drawing.Size(565, 388);
            this.instructionEditor.TabIndex = 10;
            this.instructionEditor.Value = null;
            this.instructionEditor.ValueChanged += new System.EventHandler(this.instructionEditor_ValueChanged);
            // 
            // EventPage
            // 
            this.EventPage.BackColor = System.Drawing.SystemColors.Control;
            this.EventPage.Controls.Add(this.flagControl);
            this.EventPage.Controls.Add(this.label16);
            this.EventPage.Controls.Add(this.eventListBox);
            this.EventPage.Controls.Add(this.inputCriteria);
            this.EventPage.Location = new System.Drawing.Point(4, 25);
            this.EventPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EventPage.Name = "EventPage";
            this.EventPage.Size = new System.Drawing.Size(817, 869);
            this.EventPage.TabIndex = 3;
            this.EventPage.Text = "Events";
            // 
            // flagControl
            // 
            this.flagControl.Location = new System.Drawing.Point(284, 57);
            this.flagControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flagControl.Name = "flagControl";
            this.flagControl.Size = new System.Drawing.Size(297, 172);
            this.flagControl.TabIndex = 7;
            this.flagControl.Value = null;
            this.flagControl.ValueChanged += new System.EventHandler(this.flagControl_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Flags";
            // 
            // eventListBox
            // 
            this.eventListBox.DefaultName = "Event";
            this.eventListBox.Location = new System.Drawing.Point(32, 38);
            this.eventListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.SelectedIndex = -1;
            this.eventListBox.Size = new System.Drawing.Size(225, 207);
            this.eventListBox.TabIndex = 4;
            this.eventListBox.SelectionChanged += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_SelectionChanged);
            this.eventListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemAdded);
            this.eventListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemRenamed);
            this.eventListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemMoved);
            this.eventListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsDeleted);
            this.eventListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsMoved);
            // 
            // inputCriteria
            // 
            this.inputCriteria.AutoSize = true;
            this.inputCriteria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputCriteria.Location = new System.Drawing.Point(32, 252);
            this.inputCriteria.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputCriteria.Name = "inputCriteria";
            this.inputCriteria.Size = new System.Drawing.Size(533, 37);
            this.inputCriteria.TabIndex = 3;
            this.inputCriteria.ValueChanged += new System.EventHandler(this.inputCriteria_ValueChanged);
            // 
            // SchedulePage
            // 
            this.SchedulePage.BackColor = System.Drawing.SystemColors.Control;
            this.SchedulePage.Controls.Add(this.timeLabel);
            this.SchedulePage.Controls.Add(this.breakPanel);
            this.SchedulePage.Controls.Add(this.breakCheckBox);
            this.SchedulePage.Controls.Add(this.schedTabs);
            this.SchedulePage.Controls.Add(this.schedModeDropDown);
            this.SchedulePage.Location = new System.Drawing.Point(4, 25);
            this.SchedulePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Size = new System.Drawing.Size(817, 869);
            this.SchedulePage.TabIndex = 4;
            this.SchedulePage.Text = "Schedule";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(20, 843);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 3;
            // 
            // breakPanel
            // 
            this.breakPanel.AutoSize = true;
            this.breakPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.breakPanel.Controls.Add(this.label10);
            this.breakPanel.Controls.Add(this.breakInstructBox);
            this.breakPanel.Controls.Add(this.label9);
            this.breakPanel.Controls.Add(this.afterNumeric);
            this.breakPanel.Location = new System.Drawing.Point(313, 11);
            this.breakPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakPanel.Name = "breakPanel";
            this.breakPanel.Size = new System.Drawing.Size(493, 36);
            this.breakPanel.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "blocks";
            // 
            // breakInstructBox
            // 
            this.breakInstructBox.Location = new System.Drawing.Point(152, 4);
            this.breakInstructBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakInstructBox.Multiline = true;
            this.breakInstructBox.Name = "breakInstructBox";
            this.breakInstructBox.Size = new System.Drawing.Size(337, 24);
            this.breakInstructBox.TabIndex = 3;
            this.breakInstructBox.Enter += new System.EventHandler(this.breakInstructBox_Enter);
            this.breakInstructBox.Leave += new System.EventHandler(this.breakInstructBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "after";
            // 
            // afterNumeric
            // 
            this.afterNumeric.AllowInf = false;
            this.afterNumeric.AutoSize = true;
            this.afterNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.afterNumeric.ClearOnDisable = false;
            this.afterNumeric.FloatValue = 0F;
            this.afterNumeric.IntValue = 0;
            this.afterNumeric.IsInteger = true;
            this.afterNumeric.Location = new System.Drawing.Point(40, 4);
            this.afterNumeric.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.afterNumeric.MaxCoerce = false;
            this.afterNumeric.MaximumSize = new System.Drawing.Size(26667, 27);
            this.afterNumeric.MaxValue = 100D;
            this.afterNumeric.MinCoerce = false;
            this.afterNumeric.MinimumSize = new System.Drawing.Size(13, 27);
            this.afterNumeric.MinValue = 1D;
            this.afterNumeric.Name = "afterNumeric";
            this.afterNumeric.Size = new System.Drawing.Size(53, 27);
            this.afterNumeric.TabIndex = 4;
            this.afterNumeric.TextFormat = "K4";
            this.afterNumeric.ToolTip = "";
            this.afterNumeric.Units = "";
            this.afterNumeric.Value = 0D;
            this.afterNumeric.ValueChanged += new System.EventHandler(this.afterNumeric_ValueChanged);
            // 
            // breakCheckBox
            // 
            this.breakCheckBox.AutoSize = true;
            this.breakCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.breakCheckBox.Location = new System.Drawing.Point(236, 18);
            this.breakCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakCheckBox.Name = "breakCheckBox";
            this.breakCheckBox.Size = new System.Drawing.Size(67, 21);
            this.breakCheckBox.TabIndex = 2;
            this.breakCheckBox.Text = "Break";
            this.breakCheckBox.UseVisualStyleBackColor = true;
            this.breakCheckBox.CheckedChanged += new System.EventHandler(this.breakCheckBox_CheckedChanged);
            // 
            // schedTabs
            // 
            this.schedTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.schedTabs.Controls.Add(this.schedPage);
            this.schedTabs.Controls.Add(this.adaptPage);
            this.schedTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.schedTabs.Location = new System.Drawing.Point(4, 48);
            this.schedTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedTabs.Name = "schedTabs";
            this.schedTabs.SelectedIndex = 0;
            this.schedTabs.Size = new System.Drawing.Size(836, 796);
            this.schedTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.schedTabs.TabIndex = 1;
            // 
            // schedPage
            // 
            this.schedPage.BackColor = System.Drawing.SystemColors.Control;
            this.schedPage.Controls.Add(this.scheduleControl);
            this.schedPage.Location = new System.Drawing.Point(4, 5);
            this.schedPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedPage.Name = "schedPage";
            this.schedPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedPage.Size = new System.Drawing.Size(828, 787);
            this.schedPage.TabIndex = 0;
            this.schedPage.Text = "tabPage1";
            // 
            // scheduleControl
            // 
            this.scheduleControl.Location = new System.Drawing.Point(4, 7);
            this.scheduleControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scheduleControl.Name = "scheduleControl";
            this.scheduleControl.Size = new System.Drawing.Size(813, 702);
            this.scheduleControl.TabIndex = 0;
            this.scheduleControl.Value = null;
            this.scheduleControl.ValueChanged += new System.EventHandler(this.scheduleControl_ValueChanged);
            // 
            // adaptPage
            // 
            this.adaptPage.BackColor = System.Drawing.SystemColors.Control;
            this.adaptPage.Controls.Add(this.adaptControl);
            this.adaptPage.Location = new System.Drawing.Point(4, 5);
            this.adaptPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adaptPage.Name = "adaptPage";
            this.adaptPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adaptPage.Size = new System.Drawing.Size(828, 787);
            this.adaptPage.TabIndex = 1;
            this.adaptPage.Text = "tabPage2";
            // 
            // adaptControl
            // 
            this.adaptControl.Location = new System.Drawing.Point(8, 7);
            this.adaptControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adaptControl.Name = "adaptControl";
            this.adaptControl.Size = new System.Drawing.Size(791, 766);
            this.adaptControl.TabIndex = 0;
            this.adaptControl.Value = null;
            this.adaptControl.ValueChanged += new System.EventHandler(this.adaptControl_ValueChanged);
            // 
            // schedModeDropDown
            // 
            this.schedModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedModeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedModeDropDown.FormattingEnabled = true;
            this.schedModeDropDown.Location = new System.Drawing.Point(24, 11);
            this.schedModeDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedModeDropDown.Name = "schedModeDropDown";
            this.schedModeDropDown.Size = new System.Drawing.Size(160, 28);
            this.schedModeDropDown.Sort = false;
            this.schedModeDropDown.TabIndex = 0;
            this.schedModeDropDown.ValueChanged += new System.EventHandler(this.schedModeDropDown_ValueChanged);
            // 
            // StatePage
            // 
            this.StatePage.BackColor = System.Drawing.SystemColors.Control;
            this.StatePage.Controls.Add(this.actionFamilyComboBox);
            this.StatePage.Controls.Add(this.showStateButton);
            this.StatePage.Controls.Add(this.label17);
            this.StatePage.Controls.Add(this.ipcTextBox);
            this.StatePage.Controls.Add(this.statePanel);
            this.StatePage.Controls.Add(this.actionCheckBox);
            this.StatePage.Controls.Add(this.Separator);
            this.StatePage.Controls.Add(this.TransitionTabs);
            this.StatePage.Controls.Add(this.transitionLabel);
            this.StatePage.Controls.Add(this.label3);
            this.StatePage.Controls.Add(this.stateNameTextBox);
            this.StatePage.Location = new System.Drawing.Point(4, 25);
            this.StatePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatePage.Name = "StatePage";
            this.StatePage.Size = new System.Drawing.Size(817, 869);
            this.StatePage.TabIndex = 6;
            this.StatePage.Text = "State";
            // 
            // actionFamilyComboBox
            // 
            this.actionFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionFamilyComboBox.FormattingEnabled = true;
            this.actionFamilyComboBox.Location = new System.Drawing.Point(384, 31);
            this.actionFamilyComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionFamilyComboBox.Name = "actionFamilyComboBox";
            this.actionFamilyComboBox.Size = new System.Drawing.Size(151, 24);
            this.actionFamilyComboBox.TabIndex = 69;
            this.actionFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.actionFamilyComboBox_SelectedIndexChanged);
            // 
            // showStateButton
            // 
            this.showStateButton.Location = new System.Drawing.Point(436, 149);
            this.showStateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showStateButton.Name = "showStateButton";
            this.showStateButton.Size = new System.Drawing.Size(100, 28);
            this.showStateButton.TabIndex = 68;
            this.showStateButton.Text = "Show";
            this.showStateButton.UseVisualStyleBackColor = true;
            this.showStateButton.Click += new System.EventHandler(this.showStateButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 156);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 67;
            this.label17.Text = "IPC command";
            // 
            // ipcTextBox
            // 
            this.ipcTextBox.AutoSize = true;
            this.ipcTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ipcTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.ipcTextBox.IsIPAddress = false;
            this.ipcTextBox.Location = new System.Drawing.Point(201, 153);
            this.ipcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipcTextBox.Name = "ipcTextBox";
            this.ipcTextBox.Size = new System.Drawing.Size(157, 22);
            this.ipcTextBox.TabIndex = 66;
            this.ipcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipcTextBox.ValueChanged += new System.EventHandler(this.ipcTextBox_ValueChanged);
            // 
            // statePanel
            // 
            this.statePanel.AutoSize = true;
            this.statePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statePanel.Controls.Add(this.endActionLabel);
            this.statePanel.Controls.Add(this.startCheckBox);
            this.statePanel.Controls.Add(this.decisionCheckBox);
            this.statePanel.Controls.Add(this.endActionDropDown);
            this.statePanel.Controls.Add(this.CreateAFCButton);
            this.statePanel.Controls.Add(this.mAFCCheckBox);
            this.statePanel.Location = new System.Drawing.Point(101, 59);
            this.statePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(256, 87);
            this.statePanel.TabIndex = 15;
            // 
            // endActionLabel
            // 
            this.endActionLabel.AutoSize = true;
            this.endActionLabel.Location = new System.Drawing.Point(129, 4);
            this.endActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endActionLabel.Name = "endActionLabel";
            this.endActionLabel.Size = new System.Drawing.Size(55, 17);
            this.endActionLabel.TabIndex = 68;
            this.endActionLabel.Text = "On end";
            // 
            // startCheckBox
            // 
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startCheckBox.Location = new System.Drawing.Point(23, 4);
            this.startCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(93, 21);
            this.startCheckBox.TabIndex = 7;
            this.startCheckBox.Text = "Start here";
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // decisionCheckBox
            // 
            this.decisionCheckBox.AutoSize = true;
            this.decisionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decisionCheckBox.Location = new System.Drawing.Point(8, 32);
            this.decisionCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decisionCheckBox.Name = "decisionCheckBox";
            this.decisionCheckBox.Size = new System.Drawing.Size(107, 21);
            this.decisionCheckBox.TabIndex = 8;
            this.decisionCheckBox.Text = "Target state";
            this.decisionCheckBox.UseVisualStyleBackColor = true;
            this.decisionCheckBox.CheckedChanged += new System.EventHandler(this.decisionCheckBox_CheckedChanged);
            // 
            // endActionDropDown
            // 
            this.endActionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endActionDropDown.FormattingEnabled = true;
            this.endActionDropDown.Location = new System.Drawing.Point(129, 21);
            this.endActionDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endActionDropDown.Name = "endActionDropDown";
            this.endActionDropDown.Size = new System.Drawing.Size(123, 24);
            this.endActionDropDown.Sort = false;
            this.endActionDropDown.TabIndex = 68;
            this.endActionDropDown.ValueChanged += new System.EventHandler(this.endActionDropDown_ValueChanged);
            // 
            // CreateAFCButton
            // 
            this.CreateAFCButton.Location = new System.Drawing.Point(127, 54);
            this.CreateAFCButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateAFCButton.Name = "CreateAFCButton";
            this.CreateAFCButton.Size = new System.Drawing.Size(80, 28);
            this.CreateAFCButton.TabIndex = 13;
            this.CreateAFCButton.Text = "Create";
            this.CreateAFCButton.UseVisualStyleBackColor = true;
            this.CreateAFCButton.Click += new System.EventHandler(this.CreateAFCButton_Click);
            // 
            // mAFCCheckBox
            // 
            this.mAFCCheckBox.AutoSize = true;
            this.mAFCCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mAFCCheckBox.Location = new System.Drawing.Point(47, 62);
            this.mAFCCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAFCCheckBox.Name = "mAFCCheckBox";
            this.mAFCCheckBox.Size = new System.Drawing.Size(67, 21);
            this.mAFCCheckBox.TabIndex = 12;
            this.mAFCCheckBox.Text = "mAFC";
            this.mAFCCheckBox.UseVisualStyleBackColor = true;
            this.mAFCCheckBox.CheckedChanged += new System.EventHandler(this.mAFCCheckBox_CheckedChanged);
            // 
            // actionCheckBox
            // 
            this.actionCheckBox.AutoSize = true;
            this.actionCheckBox.Location = new System.Drawing.Point(248, 33);
            this.actionCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionCheckBox.Name = "actionCheckBox";
            this.actionCheckBox.Size = new System.Drawing.Size(99, 21);
            this.actionCheckBox.TabIndex = 14;
            this.actionCheckBox.Text = "Action only";
            this.actionCheckBox.UseVisualStyleBackColor = true;
            this.actionCheckBox.CheckedChanged += new System.EventHandler(this.actionCheckBox_CheckedChanged);
            // 
            // Separator
            // 
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Location = new System.Drawing.Point(36, 188);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(500, 2);
            this.Separator.TabIndex = 11;
            this.Separator.Text = "label4";
            // 
            // TransitionTabs
            // 
            this.TransitionTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TransitionTabs.Controls.Add(this.timeoutPage);
            this.TransitionTabs.Controls.Add(this.termPage);
            this.TransitionTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.TransitionTabs.Location = new System.Drawing.Point(37, 231);
            this.TransitionTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransitionTabs.Name = "TransitionTabs";
            this.TransitionTabs.SelectedIndex = 0;
            this.TransitionTabs.Size = new System.Drawing.Size(435, 379);
            this.TransitionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TransitionTabs.TabIndex = 9;
            // 
            // timeoutPage
            // 
            this.timeoutPage.BackColor = System.Drawing.SystemColors.Control;
            this.timeoutPage.Controls.Add(this.label11);
            this.timeoutPage.Controls.Add(this.timeoutResultTextBox);
            this.timeoutPage.Controls.Add(this.exprEvalResultTextBox);
            this.timeoutPage.Controls.Add(this.timeoutExprLabel);
            this.timeoutPage.Controls.Add(this.timeoutExprBox);
            this.timeoutPage.Location = new System.Drawing.Point(4, 5);
            this.timeoutPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeoutPage.Name = "timeoutPage";
            this.timeoutPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeoutPage.Size = new System.Drawing.Size(427, 370);
            this.timeoutPage.TabIndex = 0;
            this.timeoutPage.Text = "tabPage1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Record result as";
            // 
            // timeoutResultTextBox
            // 
            this.timeoutResultTextBox.Location = new System.Drawing.Point(15, 84);
            this.timeoutResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeoutResultTextBox.Name = "timeoutResultTextBox";
            this.timeoutResultTextBox.Size = new System.Drawing.Size(215, 22);
            this.timeoutResultTextBox.TabIndex = 4;
            this.timeoutResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeoutResultTextBox_KeyPress);
            this.timeoutResultTextBox.Leave += new System.EventHandler(this.timeoutResultTextBox_Leave);
            // 
            // exprEvalResultTextBox
            // 
            this.exprEvalResultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.exprEvalResultTextBox.Location = new System.Drawing.Point(15, 116);
            this.exprEvalResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exprEvalResultTextBox.Multiline = true;
            this.exprEvalResultTextBox.Name = "exprEvalResultTextBox";
            this.exprEvalResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprEvalResultTextBox.Size = new System.Drawing.Size(384, 230);
            this.exprEvalResultTextBox.TabIndex = 3;
            // 
            // timeoutExprLabel
            // 
            this.timeoutExprLabel.AutoSize = true;
            this.timeoutExprLabel.Location = new System.Drawing.Point(11, 12);
            this.timeoutExprLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeoutExprLabel.Name = "timeoutExprLabel";
            this.timeoutExprLabel.Size = new System.Drawing.Size(256, 17);
            this.timeoutExprLabel.TabIndex = 2;
            this.timeoutExprLabel.Text = "State times out after this many seconds";
            // 
            // timeoutExprBox
            // 
            this.timeoutExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutExprBox.Location = new System.Drawing.Point(15, 32);
            this.timeoutExprBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeoutExprBox.Name = "timeoutExprBox";
            this.timeoutExprBox.Size = new System.Drawing.Size(384, 23);
            this.timeoutExprBox.TabIndex = 1;
            this.timeoutExprBox.Text = "expression";
            this.timeoutExprBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeoutExprBox_KeyPress);
            this.timeoutExprBox.Leave += new System.EventHandler(this.timeoutExprBox_Leave);
            // 
            // termPage
            // 
            this.termPage.Controls.Add(this.termFlagLabel);
            this.termPage.Controls.Add(this.termFlagExprBox);
            this.termPage.Controls.Add(this.label13);
            this.termPage.Controls.Add(this.termResultTextBox);
            this.termPage.Controls.Add(this.label6);
            this.termPage.Controls.Add(this.inputEventComboBox);
            this.termPage.Controls.Add(this.label5);
            this.termPage.Controls.Add(this.label4);
            this.termPage.Controls.Add(this.termActionComboBox);
            this.termPage.Controls.Add(this.termLatencyNumeric);
            this.termPage.Location = new System.Drawing.Point(4, 5);
            this.termPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termPage.Name = "termPage";
            this.termPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termPage.Size = new System.Drawing.Size(427, 370);
            this.termPage.TabIndex = 1;
            this.termPage.Text = "tabPage2";
            this.termPage.UseVisualStyleBackColor = true;
            // 
            // termFlagLabel
            // 
            this.termFlagLabel.AutoSize = true;
            this.termFlagLabel.Location = new System.Drawing.Point(4, 240);
            this.termFlagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.termFlagLabel.Name = "termFlagLabel";
            this.termFlagLabel.Size = new System.Drawing.Size(63, 17);
            this.termFlagLabel.TabIndex = 9;
            this.termFlagLabel.Text = "Set flags";
            // 
            // termFlagExprBox
            // 
            this.termFlagExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termFlagExprBox.Location = new System.Drawing.Point(8, 260);
            this.termFlagExprBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termFlagExprBox.Multiline = true;
            this.termFlagExprBox.Name = "termFlagExprBox";
            this.termFlagExprBox.Size = new System.Drawing.Size(404, 83);
            this.termFlagExprBox.TabIndex = 8;
            this.termFlagExprBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termFlagExprBox_KeyPress);
            this.termFlagExprBox.Leave += new System.EventHandler(this.termFlagExprBox_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Record result as";
            // 
            // termResultTextBox
            // 
            this.termResultTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termResultTextBox.Location = new System.Drawing.Point(8, 208);
            this.termResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termResultTextBox.Name = "termResultTextBox";
            this.termResultTextBox.Size = new System.Drawing.Size(404, 23);
            this.termResultTextBox.TabIndex = 6;
            this.termResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termResultTextBox_KeyPress);
            this.termResultTextBox.Leave += new System.EventHandler(this.termResultTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event";
            // 
            // inputEventComboBox
            // 
            this.inputEventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputEventComboBox.FormattingEnabled = true;
            this.inputEventComboBox.Items.AddRange(new object[] {
            "let state finish",
            "end state immediately"});
            this.inputEventComboBox.Location = new System.Drawing.Point(8, 34);
            this.inputEventComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputEventComboBox.Name = "inputEventComboBox";
            this.inputEventComboBox.Size = new System.Drawing.Size(217, 24);
            this.inputEventComboBox.TabIndex = 4;
            this.inputEventComboBox.SelectedIndexChanged += new System.EventHandler(this.inputEventComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minimum latency (ms):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "When this event becomes true";
            // 
            // termActionComboBox
            // 
            this.termActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termActionComboBox.FormattingEnabled = true;
            this.termActionComboBox.Items.AddRange(new object[] {
            "let state finish",
            "end state immediately"});
            this.termActionComboBox.Location = new System.Drawing.Point(8, 153);
            this.termActionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termActionComboBox.Name = "termActionComboBox";
            this.termActionComboBox.Size = new System.Drawing.Size(217, 24);
            this.termActionComboBox.TabIndex = 0;
            this.termActionComboBox.SelectedIndexChanged += new System.EventHandler(this.termActionComboBox_SelectedIndexChanged);
            // 
            // termLatencyNumeric
            // 
            this.termLatencyNumeric.AllowInf = false;
            this.termLatencyNumeric.AutoSize = true;
            this.termLatencyNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.termLatencyNumeric.ClearOnDisable = false;
            this.termLatencyNumeric.FloatValue = 0F;
            this.termLatencyNumeric.IntValue = 0;
            this.termLatencyNumeric.IsInteger = false;
            this.termLatencyNumeric.Location = new System.Drawing.Point(8, 92);
            this.termLatencyNumeric.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.termLatencyNumeric.MaxCoerce = false;
            this.termLatencyNumeric.MaximumSize = new System.Drawing.Size(26667, 27);
            this.termLatencyNumeric.MaxValue = 1000000D;
            this.termLatencyNumeric.MinCoerce = false;
            this.termLatencyNumeric.MinimumSize = new System.Drawing.Size(13, 27);
            this.termLatencyNumeric.MinValue = 0D;
            this.termLatencyNumeric.Name = "termLatencyNumeric";
            this.termLatencyNumeric.Size = new System.Drawing.Size(143, 27);
            this.termLatencyNumeric.TabIndex = 2;
            this.termLatencyNumeric.TextFormat = "K4";
            this.termLatencyNumeric.ToolTip = "";
            this.termLatencyNumeric.Units = "";
            this.termLatencyNumeric.Value = 0D;
            this.termLatencyNumeric.ValueChanged += new System.EventHandler(this.termLatencyNumeric_ValueChanged);
            // 
            // transitionLabel
            // 
            this.transitionLabel.AutoSize = true;
            this.transitionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionLabel.Location = new System.Drawing.Point(37, 212);
            this.transitionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transitionLabel.Name = "transitionLabel";
            this.transitionLabel.Size = new System.Drawing.Size(69, 20);
            this.transitionLabel.TabIndex = 0;
            this.transitionLabel.Text = "Timeout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.Location = new System.Drawing.Point(84, 31);
            this.stateNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.stateNameTextBox.TabIndex = 5;
            this.stateNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stateNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateNameTextBox_KeyPress);
            // 
            // AudioPage
            // 
            this.AudioPage.BackColor = System.Drawing.SystemColors.Control;
            this.AudioPage.Controls.Add(this.normalizeCheckBox);
            this.AudioPage.Controls.Add(this.audioErrorTextBox);
            this.AudioPage.Controls.Add(this.signalGraph);
            this.AudioPage.Controls.Add(this.channelListBox);
            this.AudioPage.Controls.Add(this.channelView);
            this.AudioPage.Location = new System.Drawing.Point(4, 25);
            this.AudioPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AudioPage.Name = "AudioPage";
            this.AudioPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AudioPage.Size = new System.Drawing.Size(817, 869);
            this.AudioPage.TabIndex = 0;
            this.AudioPage.Text = "Audio";
            // 
            // normalizeCheckBox
            // 
            this.normalizeCheckBox.AutoSize = true;
            this.normalizeCheckBox.Location = new System.Drawing.Point(4, 554);
            this.normalizeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normalizeCheckBox.Name = "normalizeCheckBox";
            this.normalizeCheckBox.Size = new System.Drawing.Size(93, 21);
            this.normalizeCheckBox.TabIndex = 4;
            this.normalizeCheckBox.Text = "Normalize";
            this.normalizeCheckBox.UseVisualStyleBackColor = true;
            this.normalizeCheckBox.CheckedChanged += new System.EventHandler(this.normalizeCheckBox_CheckedChanged);
            // 
            // audioErrorTextBox
            // 
            this.audioErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.audioErrorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.audioErrorTextBox.Location = new System.Drawing.Point(20, 132);
            this.audioErrorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.audioErrorTextBox.Multiline = true;
            this.audioErrorTextBox.Name = "audioErrorTextBox";
            this.audioErrorTextBox.ReadOnly = true;
            this.audioErrorTextBox.Size = new System.Drawing.Size(291, 197);
            this.audioErrorTextBox.TabIndex = 3;
            // 
            // signalGraph
            // 
            this.signalGraph.BackColor = System.Drawing.SystemColors.Control;
            this.signalGraph.Location = new System.Drawing.Point(4, 598);
            this.signalGraph.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.signalGraph.Name = "signalGraph";
            this.signalGraph.ScrollGrace = 0D;
            this.signalGraph.ScrollMaxX = 0D;
            this.signalGraph.ScrollMaxY = 0D;
            this.signalGraph.ScrollMaxY2 = 0D;
            this.signalGraph.ScrollMinX = 0D;
            this.signalGraph.ScrollMinY = 0D;
            this.signalGraph.ScrollMinY2 = 0D;
            this.signalGraph.Size = new System.Drawing.Size(807, 262);
            this.signalGraph.TabIndex = 2;
            // 
            // channelListBox
            // 
            this.channelListBox.DefaultName = "Signal";
            this.channelListBox.Location = new System.Drawing.Point(20, 14);
            this.channelListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.SelectedIndex = -1;
            this.channelListBox.Size = new System.Drawing.Size(292, 110);
            this.channelListBox.TabIndex = 1;
            this.channelListBox.SelectionChanged += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_SelectionChanged);
            this.channelListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemAdded);
            this.channelListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemRenamed);
            this.channelListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemMoved);
            this.channelListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.channelListBox_ItemsDeleted);
            this.channelListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.channelListBox_ItemsMoved);
            //this.channelListBox.Load += new System.EventHandler(this.channelListBox_Load);
            // 
            // channelView
            // 
            this.channelView.AllowExpertOptions = false;
            this.channelView.AutoScroll = true;
            this.channelView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channelView.Location = new System.Drawing.Point(364, 14);
            this.channelView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.channelView.Name = "channelView";
            this.channelView.Size = new System.Drawing.Size(344, 545);
            this.channelView.TabIndex = 0;
            this.channelView.Value = null;
            this.channelView.WavFolder = null;
            this.channelView.WaveformBecameValid += new System.EventHandler(this.channelView_WaveformBecameValid);
            this.channelView.ValueChanged += new System.EventHandler(this.channelView_ValueChanged);
            // 
            // CuePage
            // 
            this.CuePage.BackColor = System.Drawing.SystemColors.Control;
            this.CuePage.Controls.Add(this.allCuesControl);
            this.CuePage.Location = new System.Drawing.Point(4, 25);
            this.CuePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CuePage.Name = "CuePage";
            this.CuePage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CuePage.Size = new System.Drawing.Size(817, 869);
            this.CuePage.TabIndex = 1;
            this.CuePage.Text = "Cues";
            // 
            // allCuesControl
            // 
            this.allCuesControl.Location = new System.Drawing.Point(28, 15);
            this.allCuesControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.allCuesControl.Name = "allCuesControl";
            this.allCuesControl.Size = new System.Drawing.Size(589, 604);
            this.allCuesControl.TabIndex = 0;
            this.allCuesControl.Value = null;
            this.allCuesControl.CueAddRemove += new System.EventHandler<Turandot_Editor.Controls.AllCuesControl.CueAddRemoveArgs>(this.allCuesControl_CueAddRemove);
            this.allCuesControl.ValueChanged += new System.EventHandler(this.allCuesControl_ValueChanged);
            // 
            // InputPage
            // 
            this.InputPage.BackColor = System.Drawing.SystemColors.Control;
            this.InputPage.Controls.Add(this.inputControl);
            this.InputPage.Location = new System.Drawing.Point(4, 25);
            this.InputPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputPage.Name = "InputPage";
            this.InputPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputPage.Size = new System.Drawing.Size(817, 869);
            this.InputPage.TabIndex = 8;
            this.InputPage.Text = "Inputs";
            // 
            // inputControl
            // 
            this.inputControl.AutoSize = true;
            this.inputControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputControl.Location = new System.Drawing.Point(40, 32);
            this.inputControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputControl.Name = "inputControl";
            this.inputControl.Size = new System.Drawing.Size(209, 206);
            this.inputControl.TabIndex = 0;
            this.inputControl.Value = null;
            this.inputControl.InputAddRemove += new System.EventHandler<Turandot_Editor.Controls.InputControl.InputAddRemoveArgs>(this.inputControl_InputAddRemove);
            this.inputControl.ValueChanged += new System.EventHandler(this.inputControl_ValueChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.bypassIPCCheckBox);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.trialLogOptionEnum);
            this.infoPanel.Controls.Add(this.expertCheckBox);
            this.infoPanel.Controls.Add(this.wavFolderTextBox);
            this.infoPanel.Controls.Add(this.tagTextBox);
            this.infoPanel.Controls.Add(this.label8);
            this.infoPanel.Controls.Add(this.versionLabel);
            this.infoPanel.Controls.Add(this.linktoBrowser);
            this.infoPanel.Controls.Add(this.label19);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.pathLabel);
            this.infoPanel.Location = new System.Drawing.Point(4, 805);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(804, 115);
            this.infoPanel.TabIndex = 2;
            this.infoPanel.SizeChanged += new System.EventHandler(this.infoPanel_SizeChanged);
            // 
            // bypassIPCCheckBox
            // 
            this.bypassIPCCheckBox.AutoSize = true;
            this.bypassIPCCheckBox.Location = new System.Drawing.Point(645, 76);
            this.bypassIPCCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bypassIPCCheckBox.Name = "bypassIPCCheckBox";
            this.bypassIPCCheckBox.Size = new System.Drawing.Size(101, 21);
            this.bypassIPCCheckBox.TabIndex = 16;
            this.bypassIPCCheckBox.Text = "Bypass IPC";
            this.bypassIPCCheckBox.UseVisualStyleBackColor = true;
            this.bypassIPCCheckBox.CheckedChanged += new System.EventHandler(this.bypassIPCCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trial logs";
            // 
            // trialLogOptionEnum
            // 
            this.trialLogOptionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trialLogOptionEnum.FormattingEnabled = true;
            this.trialLogOptionEnum.Location = new System.Drawing.Point(625, 39);
            this.trialLogOptionEnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trialLogOptionEnum.Name = "trialLogOptionEnum";
            this.trialLogOptionEnum.Size = new System.Drawing.Size(113, 24);
            this.trialLogOptionEnum.Sort = false;
            this.trialLogOptionEnum.TabIndex = 14;
            this.trialLogOptionEnum.ValueChanged += new System.EventHandler(this.trialLogOptionEnum_ValueChanged);
            // 
            // expertCheckBox
            // 
            this.expertCheckBox.AutoSize = true;
            this.expertCheckBox.Location = new System.Drawing.Point(525, 76);
            this.expertCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expertCheckBox.Name = "expertCheckBox";
            this.expertCheckBox.Size = new System.Drawing.Size(109, 21);
            this.expertCheckBox.TabIndex = 13;
            this.expertCheckBox.Text = "Expert mode";
            this.expertCheckBox.UseVisualStyleBackColor = true;
            this.expertCheckBox.CheckedChanged += new System.EventHandler(this.expertCheckBox_CheckedChanged);
            // 
            // wavFolderTextBox
            // 
            this.wavFolderTextBox.AutoSize = true;
            this.wavFolderTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wavFolderTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.wavFolderTextBox.IsIPAddress = false;
            this.wavFolderTextBox.Location = new System.Drawing.Point(327, 41);
            this.wavFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.wavFolderTextBox.Name = "wavFolderTextBox";
            this.wavFolderTextBox.Size = new System.Drawing.Size(133, 22);
            this.wavFolderTextBox.TabIndex = 11;
            this.wavFolderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wavFolderTextBox.ValueChanged += new System.EventHandler(this.wavFolderTextBox_ValueChanged);
            // 
            // tagTextBox
            // 
            this.tagTextBox.AutoSize = true;
            this.tagTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tagTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.tagTextBox.IsIPAddress = false;
            this.tagTextBox.Location = new System.Drawing.Point(65, 41);
            this.tagTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(133, 22);
            this.tagTextBox.TabIndex = 10;
            this.tagTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tagTextBox.ValueChanged += new System.EventHandler(this.tagTextBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = ".Wav folder";
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(664, 94);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(133, 23);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "version";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linktoBrowser
            // 
            this.linktoBrowser.AutoSize = true;
            this.linktoBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linktoBrowser.DefaultFolder = null;
            this.linktoBrowser.FileMustExist = false;
            this.linktoBrowser.Filter = "XML files | *.xml";
            this.linktoBrowser.FoldersOnly = false;
            this.linktoBrowser.HideFolder = true;
            this.linktoBrowser.Location = new System.Drawing.Point(65, 75);
            this.linktoBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.linktoBrowser.Name = "linktoBrowser";
            this.linktoBrowser.ReadOnly = false;
            this.linktoBrowser.ShowSaveButton = true;
            this.linktoBrowser.Size = new System.Drawing.Size(436, 26);
            this.linktoBrowser.TabIndex = 6;
            this.linktoBrowser.UseEllipsis = false;
            this.linktoBrowser.Value = "";
            this.linktoBrowser.ValueChanged += new System.EventHandler(this.linktoBrowser_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "Link to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(61, 9);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(573, 28);
            this.pathLabel.TabIndex = 1;
            // 
            // graphViewer
            // 
            this.graphViewer.BackColor = System.Drawing.Color.Moccasin;
            this.graphViewer.CurrentScale = 1F;
            this.graphViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(5, 5);
            this.graphViewer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.Size = new System.Drawing.Size(802, 791);
            this.graphViewer.TabIndex = 3;
            // 
            // ledTimer
            // 
            this.ledTimer.Interval = 2500;
            this.ledTimer.Tick += new System.EventHandler(this.ledTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 951);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1261, 974);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Turandot Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.MetricsPage.ResumeLayout(false);
            this.MetricsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metricGridView)).EndInit();
            this.ScreenPage.ResumeLayout(false);
            this.ScreenPage.PerformLayout();
            this.screenInputsTab.ResumeLayout(false);
            this.buttonsPage.ResumeLayout(false);
            this.buttonsPage.PerformLayout();
            this.grapherLayoutPage.ResumeLayout(false);
            this.paramSliderPage.ResumeLayout(false);
            this.paramSliderPage.PerformLayout();
            this.thumbSliderPage.ResumeLayout(false);
            this.thumbSliderPage.PerformLayout();
            this.screenCuesTab.ResumeLayout(false);
            this.counterPage.ResumeLayout(false);
            this.counterPage.PerformLayout();
            this.fixationPtPage.ResumeLayout(false);
            this.fixationPtPage.PerformLayout();
            this.messagePage.ResumeLayout(false);
            this.messagePage.PerformLayout();
            this.progressBarPage.ResumeLayout(false);
            this.progressBarPage.PerformLayout();
            this.scoreboardPage.ResumeLayout(false);
            this.scoreboardPage.PerformLayout();
            this.InstructionsPage.ResumeLayout(false);
            this.EventPage.ResumeLayout(false);
            this.EventPage.PerformLayout();
            this.SchedulePage.ResumeLayout(false);
            this.SchedulePage.PerformLayout();
            this.breakPanel.ResumeLayout(false);
            this.breakPanel.PerformLayout();
            this.schedTabs.ResumeLayout(false);
            this.schedPage.ResumeLayout(false);
            this.adaptPage.ResumeLayout(false);
            this.StatePage.ResumeLayout(false);
            this.StatePage.PerformLayout();
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            this.TransitionTabs.ResumeLayout(false);
            this.timeoutPage.ResumeLayout(false);
            this.timeoutPage.PerformLayout();
            this.termPage.ResumeLayout(false);
            this.termPage.PerformLayout();
            this.AudioPage.ResumeLayout(false);
            this.AudioPage.PerformLayout();
            this.CuePage.ResumeLayout(false);
            this.InputPage.ResumeLayout(false);
            this.InputPage.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton NewParamsButton;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveFileButton;
        private System.Windows.Forms.ToolStripButton SaveFileAsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ScreenPage;
        private System.Windows.Forms.TabPage EventPage;
        private System.Windows.Forms.TabPage SchedulePage;
        private System.Windows.Forms.TabPage StatePage;
        private System.Windows.Forms.CheckBox decisionCheckBox;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.TabPage AudioPage;
        private System.Windows.Forms.TabPage CuePage;
        private KLib.Controls.FSMGraphViewer fsmGraphViewer;
        private Turandot.GraphViewer graphViewer;
        private System.Windows.Forms.TabControl TransitionTabs;
        private System.Windows.Forms.TabPage timeoutPage;
        private System.Windows.Forms.Label timeoutExprLabel;
        private System.Windows.Forms.TextBox timeoutExprBox;
        private System.Windows.Forms.Label transitionLabel;
        private System.Windows.Forms.TabPage termPage;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.ComboBox termActionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.KNumericBox termLatencyNumeric;
        private System.Windows.Forms.TextBox exprEvalResultTextBox;
        private Turandot_Editor.InputCriteria inputCriteria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputEventComboBox;
        private Controls.CueControl cueControl1;
        private KLib.Unity.Controls.Signals.ChannelView channelView;
        private KLib.Controls.KUserListBox eventListBox;
        private KLib.Controls.KUserListBox channelListBox;
        private System.Windows.Forms.TabControl schedTabs;
        private System.Windows.Forms.TabPage schedPage;
        private System.Windows.Forms.TabPage adaptPage;
        private KLib.Controls.EnumDropDown schedModeDropDown;
        private Controls.ScheduleControl scheduleControl;
        private ZedGraph.ZedGraphControl signalGraph;
        private System.Windows.Forms.TextBox audioErrorTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeoutResultTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox termResultTextBox;
        private System.Windows.Forms.TabPage MetricsPage;
        private System.Windows.Forms.DataGridView metricGridView;
        private System.Windows.Forms.Label label14;
        private Controls.AdaptationControl adaptControl;
        private KLib.Controls.KCheckBox normalizeCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private KLib.Controls.FileBrowser wavfolderBrowser;
        private Controls.FixationPointControl fixationPointControl;
        private System.Windows.Forms.Label label18;
        private KLib.Controls.FileBrowser calfolderBrowser;
        private System.Windows.Forms.TabPage InputPage;
        private System.Windows.Forms.TabPage InstructionsPage;
        private Controls.InstructionEditor instructionEditor;
        private Controls.InputControl inputControl;
        private System.Windows.Forms.Label label16;
        private Controls.FlagControl flagControl;
        private KLib.Controls.FileBrowser linktoBrowser;
        private System.Windows.Forms.Label label19;
        private Controls.AllCuesControl allCuesControl;
        private Controls.Inputs.AllButtonControl allButtonControl;
        private System.Windows.Forms.Button CreateAFCButton;
        private System.Windows.Forms.CheckBox mAFCCheckBox;
        private System.Windows.Forms.TextBox breakInstructBox;
        private System.Windows.Forms.CheckBox breakCheckBox;
        private System.Windows.Forms.Panel breakPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private KLib.Controls.KNumericBox afterNumeric;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TabControl screenCuesTab;
        private System.Windows.Forms.TabPage buttonsPage;
        private System.Windows.Forms.TabPage fixationPtPage;
        private System.Windows.Forms.TabPage counterPage;
        private System.Windows.Forms.TabPage scoreboardPage;
        private Controls.Screen.CounterProperties counterProperties;
        private Controls.Screen.ScoreboardProperties scoreboardProperties;
        private System.Windows.Forms.CheckBox actionCheckBox;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KTextBox wavFolderTextBox;
        private KLib.Controls.KTextBox tagTextBox;
        private System.Windows.Forms.TabControl screenInputsTab;
        private System.Windows.Forms.TabPage thumbSliderPage;
        private Controls.Screen.CheckBoxList cuesList;
        private Controls.Screen.CheckBoxList inputsList;
        private Controls.Screen.ThumbSliderLayoutControl thumbSliderLayoutControl;
        private System.Windows.Forms.Label termFlagLabel;
        private System.Windows.Forms.TextBox termFlagExprBox;
        private System.Windows.Forms.CheckBox expertCheckBox;
        private System.Windows.Forms.TabPage grapherLayoutPage;
        private Controls.Screen.GrapherLayoutControl grapherLayoutControl;
        private System.Windows.Forms.TabPage messagePage;
        private Controls.Screen.MessageLayoutControl messageLayoutControl;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.EnumDropDown trialLogOptionEnum;
        private System.Windows.Forms.TabPage paramSliderPage;
        private Controls.Screen.ParamSliderLayoutControl paramSliderLayoutControl;
        private System.Windows.Forms.Label label17;
        private KLib.Controls.KTextBox ipcTextBox;
        private System.Windows.Forms.TabPage progressBarPage;
        private Controls.Screen.ProgressBarLayoutControl progressBarLayoutControl;
        private System.Windows.Forms.Label label20;
        private KLib.Controls.KTextBox transducerTextBox;
        private System.Windows.Forms.Label endActionLabel;
        private KLib.Controls.EnumDropDown endActionDropDown;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button pingButton;
        private KLib.Controls.LedBulb pingLED;
        private System.Windows.Forms.Timer ledTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricValue;
        private System.Windows.Forms.Button showStateButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ComboBox actionFamilyComboBox;
        private System.Windows.Forms.CheckBox bypassIPCCheckBox;
        private System.Windows.Forms.Label label22;
        private KLib.Controls.KTextBox finalPromptTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox subjectDropdown;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox projectDropdown;
    }
}

