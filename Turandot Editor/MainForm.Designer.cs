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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.NewParamsButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileAsButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MetricsPage = new System.Windows.Forms.TabPage();
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
            this.inputsSpecifier = new Turandot_Editor.Controls.ScreenInputsSpecifier();
            this.cuesSpecifier = new Turandot_Editor.Controls.ScreenCuesSpecifier();
            this.InstructionsPage = new System.Windows.Forms.TabPage();
            this.instructionEditor = new Turandot_Editor.Controls.InstructionEditor();
            this.EventPage = new System.Windows.Forms.TabPage();
            this.eventsSpecifier = new Turandot_Editor.Controls.Events.EventsSpecifier();
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
            this.graphTabControl = new System.Windows.Forms.TabControl();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.signalGraph = new ZedGraph.ZedGraphControl();
            this.errorPage = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.audioErrorTextBox = new System.Windows.Forms.TextBox();
            this.channelListBox = new KLib.Controls.KUserListBox();
            this.channelView = new KLib.Unity.Controls.Signals.ChannelView();
            this.CuePage = new System.Windows.Forms.TabPage();
            this.stateCuesControl = new Turandot_Editor.Controls.StateCuesControl();
            this.InputPage = new System.Windows.Forms.TabPage();
            this.stateInputsControl = new Turandot_Editor.Controls.StateInputsControl();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.matlabFileBrowser = new KLib.Controls.FileBrowser();
            this.label16 = new System.Windows.Forms.Label();
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
            this.graphTabControl.SuspendLayout();
            this.graphPage.SuspendLayout();
            this.errorPage.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(1155, 27);
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
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 625F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.infoPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.graphViewer, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1155, 734);
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
            this.tabControl.Location = new System.Drawing.Point(533, 3);
            this.tabControl.Name = "tabControl";
            this.tableLayoutPanel.SetRowSpan(this.tabControl, 2);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(619, 728);
            this.tabControl.TabIndex = 1;
            // 
            // MetricsPage
            // 
            this.MetricsPage.BackColor = System.Drawing.SystemColors.Control;
            this.MetricsPage.Controls.Add(this.label20);
            this.MetricsPage.Controls.Add(this.transducerTextBox);
            this.MetricsPage.Controls.Add(this.label18);
            this.MetricsPage.Controls.Add(this.calfolderBrowser);
            this.MetricsPage.Controls.Add(this.label15);
            this.MetricsPage.Controls.Add(this.wavfolderBrowser);
            this.MetricsPage.Controls.Add(this.label12);
            this.MetricsPage.Controls.Add(this.label14);
            this.MetricsPage.Controls.Add(this.metricGridView);
            this.MetricsPage.Location = new System.Drawing.Point(4, 22);
            this.MetricsPage.Name = "MetricsPage";
            this.MetricsPage.Padding = new System.Windows.Forms.Padding(3);
            this.MetricsPage.Size = new System.Drawing.Size(611, 702);
            this.MetricsPage.TabIndex = 7;
            this.MetricsPage.Text = "General";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Transducer";
            // 
            // transducerTextBox
            // 
            this.transducerTextBox.AutoSize = true;
            this.transducerTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transducerTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.transducerTextBox.IsIPAddress = false;
            this.transducerTextBox.Location = new System.Drawing.Point(33, 145);
            this.transducerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.transducerTextBox.Name = "transducerTextBox";
            this.transducerTextBox.Size = new System.Drawing.Size(124, 20);
            this.transducerTextBox.TabIndex = 7;
            this.transducerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.transducerTextBox.ValueChanged += new System.EventHandler(this.transducerTextBox_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 13);
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
            this.calfolderBrowser.Location = new System.Drawing.Point(33, 35);
            this.calfolderBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.calfolderBrowser.Name = "calfolderBrowser";
            this.calfolderBrowser.ReadOnly = false;
            this.calfolderBrowser.ShowSaveButton = false;
            this.calfolderBrowser.Size = new System.Drawing.Size(305, 21);
            this.calfolderBrowser.TabIndex = 5;
            this.calfolderBrowser.UseEllipsis = false;
            this.calfolderBrowser.Value = "";
            this.calfolderBrowser.ValueChanged += new System.EventHandler(this.calfolderBrowser_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
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
            this.wavfolderBrowser.Location = new System.Drawing.Point(33, 88);
            this.wavfolderBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.wavfolderBrowser.Name = "wavfolderBrowser";
            this.wavfolderBrowser.ReadOnly = false;
            this.wavfolderBrowser.ShowSaveButton = false;
            this.wavfolderBrowser.Size = new System.Drawing.Size(305, 21);
            this.wavfolderBrowser.TabIndex = 3;
            this.wavfolderBrowser.UseEllipsis = false;
            this.wavfolderBrowser.Value = "";
            this.wavfolderBrowser.ValueChanged += new System.EventHandler(this.wavfolderBrowser_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Metrics";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "This table allows you to mimic the user-specific metrics\r\nstored on the tablet an" +
    "d to test their application to expressions.";
            // 
            // metricGridView
            // 
            this.metricGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metricGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metricGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metricGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metricGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metricGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MetricName,
            this.MetricValue});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metricGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.metricGridView.EnableHeadersVisualStyles = false;
            this.metricGridView.Location = new System.Drawing.Point(33, 357);
            this.metricGridView.Name = "metricGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metricGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metricGridView.RowHeadersVisible = false;
            this.metricGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metricGridView.Size = new System.Drawing.Size(222, 150);
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
            this.ScreenPage.Controls.Add(this.inputsSpecifier);
            this.ScreenPage.Controls.Add(this.cuesSpecifier);
            this.ScreenPage.Location = new System.Drawing.Point(4, 22);
            this.ScreenPage.Name = "ScreenPage";
            this.ScreenPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScreenPage.Size = new System.Drawing.Size(611, 702);
            this.ScreenPage.TabIndex = 2;
            this.ScreenPage.Text = "Screen";
            // 
            // inputsSpecifier
            // 
            this.inputsSpecifier.Location = new System.Drawing.Point(18, 339);
            this.inputsSpecifier.Margin = new System.Windows.Forms.Padding(2);
            this.inputsSpecifier.Name = "inputsSpecifier";
            this.inputsSpecifier.Size = new System.Drawing.Size(351, 318);
            this.inputsSpecifier.TabIndex = 1;
            this.inputsSpecifier.Value = null;
            this.inputsSpecifier.ValueChanged += new System.EventHandler(this.inputsSpecifier_ValueChanged);
            // 
            // cuesSpecifier
            // 
            this.cuesSpecifier.Location = new System.Drawing.Point(18, 19);
            this.cuesSpecifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuesSpecifier.Name = "cuesSpecifier";
            this.cuesSpecifier.Size = new System.Drawing.Size(351, 316);
            this.cuesSpecifier.TabIndex = 0;
            this.cuesSpecifier.Value = null;
            this.cuesSpecifier.ValueChanged += new System.EventHandler(this.cuesSpecifier_ValueChanged);
            // 
            // InstructionsPage
            // 
            this.InstructionsPage.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionsPage.Controls.Add(this.instructionEditor);
            this.InstructionsPage.Location = new System.Drawing.Point(4, 22);
            this.InstructionsPage.Name = "InstructionsPage";
            this.InstructionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.InstructionsPage.Size = new System.Drawing.Size(611, 702);
            this.InstructionsPage.TabIndex = 9;
            this.InstructionsPage.Text = "Instructions";
            // 
            // instructionEditor
            // 
            this.instructionEditor.Location = new System.Drawing.Point(34, 27);
            this.instructionEditor.Margin = new System.Windows.Forms.Padding(4);
            this.instructionEditor.Name = "instructionEditor";
            this.instructionEditor.Size = new System.Drawing.Size(424, 315);
            this.instructionEditor.TabIndex = 10;
            this.instructionEditor.Value = null;
            this.instructionEditor.ValueChanged += new System.EventHandler(this.instructionEditor_ValueChanged);
            // 
            // EventPage
            // 
            this.EventPage.BackColor = System.Drawing.SystemColors.Control;
            this.EventPage.Controls.Add(this.eventsSpecifier);
            this.EventPage.Location = new System.Drawing.Point(4, 22);
            this.EventPage.Name = "EventPage";
            this.EventPage.Size = new System.Drawing.Size(611, 702);
            this.EventPage.TabIndex = 3;
            this.EventPage.Text = "Events";
            // 
            // eventsSpecifier
            // 
            this.eventsSpecifier.AutoSize = true;
            this.eventsSpecifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventsSpecifier.Location = new System.Drawing.Point(11, 12);
            this.eventsSpecifier.Margin = new System.Windows.Forms.Padding(2);
            this.eventsSpecifier.Name = "eventsSpecifier";
            this.eventsSpecifier.Size = new System.Drawing.Size(421, 461);
            this.eventsSpecifier.TabIndex = 0;
            this.eventsSpecifier.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemAdded);
            this.eventsSpecifier.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemRenamed);
            this.eventsSpecifier.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.eventListBox_ItemMoved);
            this.eventsSpecifier.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsDeleted);
            this.eventsSpecifier.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.eventListBox_ItemsMoved);
            this.eventsSpecifier.ValueChanged += new System.EventHandler(this.eventsSpecifier_ValueChanged);
            // 
            // SchedulePage
            // 
            this.SchedulePage.BackColor = System.Drawing.SystemColors.Control;
            this.SchedulePage.Controls.Add(this.timeLabel);
            this.SchedulePage.Controls.Add(this.breakPanel);
            this.SchedulePage.Controls.Add(this.breakCheckBox);
            this.SchedulePage.Controls.Add(this.schedTabs);
            this.SchedulePage.Controls.Add(this.schedModeDropDown);
            this.SchedulePage.Location = new System.Drawing.Point(4, 22);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Size = new System.Drawing.Size(611, 702);
            this.SchedulePage.TabIndex = 4;
            this.SchedulePage.Text = "Schedule";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(15, 685);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
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
            this.breakPanel.Location = new System.Drawing.Point(235, 9);
            this.breakPanel.Name = "breakPanel";
            this.breakPanel.Size = new System.Drawing.Size(371, 27);
            this.breakPanel.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "blocks";
            // 
            // breakInstructBox
            // 
            this.breakInstructBox.Location = new System.Drawing.Point(114, 3);
            this.breakInstructBox.Multiline = true;
            this.breakInstructBox.Name = "breakInstructBox";
            this.breakInstructBox.Size = new System.Drawing.Size(254, 20);
            this.breakInstructBox.TabIndex = 3;
            this.breakInstructBox.Enter += new System.EventHandler(this.breakInstructBox_Enter);
            this.breakInstructBox.Leave += new System.EventHandler(this.breakInstructBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
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
            this.afterNumeric.Location = new System.Drawing.Point(30, 3);
            this.afterNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.afterNumeric.MaxCoerce = false;
            this.afterNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.afterNumeric.MaxValue = 100D;
            this.afterNumeric.MinCoerce = false;
            this.afterNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.afterNumeric.MinValue = 1D;
            this.afterNumeric.Name = "afterNumeric";
            this.afterNumeric.Size = new System.Drawing.Size(40, 20);
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
            this.breakCheckBox.Location = new System.Drawing.Point(177, 15);
            this.breakCheckBox.Name = "breakCheckBox";
            this.breakCheckBox.Size = new System.Drawing.Size(54, 17);
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
            this.schedTabs.Location = new System.Drawing.Point(3, 39);
            this.schedTabs.Name = "schedTabs";
            this.schedTabs.SelectedIndex = 0;
            this.schedTabs.Size = new System.Drawing.Size(627, 647);
            this.schedTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.schedTabs.TabIndex = 1;
            // 
            // schedPage
            // 
            this.schedPage.BackColor = System.Drawing.SystemColors.Control;
            this.schedPage.Controls.Add(this.scheduleControl);
            this.schedPage.Location = new System.Drawing.Point(4, 5);
            this.schedPage.Name = "schedPage";
            this.schedPage.Padding = new System.Windows.Forms.Padding(3);
            this.schedPage.Size = new System.Drawing.Size(619, 638);
            this.schedPage.TabIndex = 0;
            this.schedPage.Text = "tabPage1";
            // 
            // scheduleControl
            // 
            this.scheduleControl.Location = new System.Drawing.Point(3, 6);
            this.scheduleControl.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleControl.Name = "scheduleControl";
            this.scheduleControl.Size = new System.Drawing.Size(610, 570);
            this.scheduleControl.TabIndex = 0;
            this.scheduleControl.Value = null;
            this.scheduleControl.ValueChanged += new System.EventHandler(this.scheduleControl_ValueChanged);
            // 
            // adaptPage
            // 
            this.adaptPage.BackColor = System.Drawing.SystemColors.Control;
            this.adaptPage.Controls.Add(this.adaptControl);
            this.adaptPage.Location = new System.Drawing.Point(4, 5);
            this.adaptPage.Name = "adaptPage";
            this.adaptPage.Padding = new System.Windows.Forms.Padding(3);
            this.adaptPage.Size = new System.Drawing.Size(619, 638);
            this.adaptPage.TabIndex = 1;
            this.adaptPage.Text = "tabPage2";
            // 
            // adaptControl
            // 
            this.adaptControl.Location = new System.Drawing.Point(6, 6);
            this.adaptControl.Margin = new System.Windows.Forms.Padding(4);
            this.adaptControl.Name = "adaptControl";
            this.adaptControl.Size = new System.Drawing.Size(593, 622);
            this.adaptControl.TabIndex = 0;
            this.adaptControl.Value = null;
            this.adaptControl.ValueChanged += new System.EventHandler(this.adaptControl_ValueChanged);
            // 
            // schedModeDropDown
            // 
            this.schedModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedModeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedModeDropDown.FormattingEnabled = true;
            this.schedModeDropDown.Location = new System.Drawing.Point(18, 9);
            this.schedModeDropDown.Name = "schedModeDropDown";
            this.schedModeDropDown.Size = new System.Drawing.Size(121, 24);
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
            this.StatePage.Location = new System.Drawing.Point(4, 22);
            this.StatePage.Name = "StatePage";
            this.StatePage.Size = new System.Drawing.Size(611, 702);
            this.StatePage.TabIndex = 6;
            this.StatePage.Text = "State";
            // 
            // actionFamilyComboBox
            // 
            this.actionFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionFamilyComboBox.FormattingEnabled = true;
            this.actionFamilyComboBox.Location = new System.Drawing.Point(288, 25);
            this.actionFamilyComboBox.Name = "actionFamilyComboBox";
            this.actionFamilyComboBox.Size = new System.Drawing.Size(114, 21);
            this.actionFamilyComboBox.TabIndex = 69;
            this.actionFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.actionFamilyComboBox_SelectedIndexChanged);
            // 
            // showStateButton
            // 
            this.showStateButton.Location = new System.Drawing.Point(327, 121);
            this.showStateButton.Name = "showStateButton";
            this.showStateButton.Size = new System.Drawing.Size(75, 23);
            this.showStateButton.TabIndex = 68;
            this.showStateButton.Text = "Show";
            this.showStateButton.UseVisualStyleBackColor = true;
            this.showStateButton.Click += new System.EventHandler(this.showStateButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(76, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 67;
            this.label17.Text = "IPC command";
            // 
            // ipcTextBox
            // 
            this.ipcTextBox.AutoSize = true;
            this.ipcTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ipcTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.ipcTextBox.IsIPAddress = false;
            this.ipcTextBox.Location = new System.Drawing.Point(151, 124);
            this.ipcTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipcTextBox.Name = "ipcTextBox";
            this.ipcTextBox.Size = new System.Drawing.Size(118, 20);
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
            this.statePanel.Location = new System.Drawing.Point(76, 48);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(193, 70);
            this.statePanel.TabIndex = 15;
            // 
            // endActionLabel
            // 
            this.endActionLabel.AutoSize = true;
            this.endActionLabel.Location = new System.Drawing.Point(97, 3);
            this.endActionLabel.Name = "endActionLabel";
            this.endActionLabel.Size = new System.Drawing.Size(42, 13);
            this.endActionLabel.TabIndex = 68;
            this.endActionLabel.Text = "On end";
            // 
            // startCheckBox
            // 
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startCheckBox.Location = new System.Drawing.Point(17, 3);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(72, 17);
            this.startCheckBox.TabIndex = 7;
            this.startCheckBox.Text = "Start here";
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // decisionCheckBox
            // 
            this.decisionCheckBox.AutoSize = true;
            this.decisionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decisionCheckBox.Location = new System.Drawing.Point(6, 26);
            this.decisionCheckBox.Name = "decisionCheckBox";
            this.decisionCheckBox.Size = new System.Drawing.Size(83, 17);
            this.decisionCheckBox.TabIndex = 8;
            this.decisionCheckBox.Text = "Target state";
            this.decisionCheckBox.UseVisualStyleBackColor = true;
            this.decisionCheckBox.CheckedChanged += new System.EventHandler(this.decisionCheckBox_CheckedChanged);
            // 
            // endActionDropDown
            // 
            this.endActionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endActionDropDown.FormattingEnabled = true;
            this.endActionDropDown.Location = new System.Drawing.Point(97, 17);
            this.endActionDropDown.Name = "endActionDropDown";
            this.endActionDropDown.Size = new System.Drawing.Size(93, 21);
            this.endActionDropDown.Sort = false;
            this.endActionDropDown.TabIndex = 68;
            this.endActionDropDown.ValueChanged += new System.EventHandler(this.endActionDropDown_ValueChanged);
            // 
            // CreateAFCButton
            // 
            this.CreateAFCButton.Location = new System.Drawing.Point(95, 44);
            this.CreateAFCButton.Name = "CreateAFCButton";
            this.CreateAFCButton.Size = new System.Drawing.Size(60, 23);
            this.CreateAFCButton.TabIndex = 13;
            this.CreateAFCButton.Text = "Create";
            this.CreateAFCButton.UseVisualStyleBackColor = true;
            this.CreateAFCButton.Click += new System.EventHandler(this.CreateAFCButton_Click);
            // 
            // mAFCCheckBox
            // 
            this.mAFCCheckBox.AutoSize = true;
            this.mAFCCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mAFCCheckBox.Location = new System.Drawing.Point(35, 50);
            this.mAFCCheckBox.Name = "mAFCCheckBox";
            this.mAFCCheckBox.Size = new System.Drawing.Size(54, 17);
            this.mAFCCheckBox.TabIndex = 12;
            this.mAFCCheckBox.Text = "mAFC";
            this.mAFCCheckBox.UseVisualStyleBackColor = true;
            this.mAFCCheckBox.CheckedChanged += new System.EventHandler(this.mAFCCheckBox_CheckedChanged);
            // 
            // actionCheckBox
            // 
            this.actionCheckBox.AutoSize = true;
            this.actionCheckBox.Location = new System.Drawing.Point(186, 27);
            this.actionCheckBox.Name = "actionCheckBox";
            this.actionCheckBox.Size = new System.Drawing.Size(78, 17);
            this.actionCheckBox.TabIndex = 14;
            this.actionCheckBox.Text = "Action only";
            this.actionCheckBox.UseVisualStyleBackColor = true;
            this.actionCheckBox.CheckedChanged += new System.EventHandler(this.actionCheckBox_CheckedChanged);
            // 
            // Separator
            // 
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Location = new System.Drawing.Point(27, 153);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(375, 2);
            this.Separator.TabIndex = 11;
            this.Separator.Text = "label4";
            // 
            // TransitionTabs
            // 
            this.TransitionTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TransitionTabs.Controls.Add(this.timeoutPage);
            this.TransitionTabs.Controls.Add(this.termPage);
            this.TransitionTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.TransitionTabs.Location = new System.Drawing.Point(28, 188);
            this.TransitionTabs.Name = "TransitionTabs";
            this.TransitionTabs.SelectedIndex = 0;
            this.TransitionTabs.Size = new System.Drawing.Size(326, 308);
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
            this.timeoutPage.Name = "timeoutPage";
            this.timeoutPage.Padding = new System.Windows.Forms.Padding(3);
            this.timeoutPage.Size = new System.Drawing.Size(318, 299);
            this.timeoutPage.TabIndex = 0;
            this.timeoutPage.Text = "tabPage1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Record result as";
            // 
            // timeoutResultTextBox
            // 
            this.timeoutResultTextBox.Location = new System.Drawing.Point(11, 68);
            this.timeoutResultTextBox.Name = "timeoutResultTextBox";
            this.timeoutResultTextBox.Size = new System.Drawing.Size(162, 20);
            this.timeoutResultTextBox.TabIndex = 4;
            this.timeoutResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeoutResultTextBox_KeyPress);
            this.timeoutResultTextBox.Leave += new System.EventHandler(this.timeoutResultTextBox_Leave);
            // 
            // exprEvalResultTextBox
            // 
            this.exprEvalResultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.exprEvalResultTextBox.Location = new System.Drawing.Point(11, 94);
            this.exprEvalResultTextBox.Multiline = true;
            this.exprEvalResultTextBox.Name = "exprEvalResultTextBox";
            this.exprEvalResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprEvalResultTextBox.Size = new System.Drawing.Size(289, 188);
            this.exprEvalResultTextBox.TabIndex = 3;
            // 
            // timeoutExprLabel
            // 
            this.timeoutExprLabel.AutoSize = true;
            this.timeoutExprLabel.Location = new System.Drawing.Point(8, 10);
            this.timeoutExprLabel.Name = "timeoutExprLabel";
            this.timeoutExprLabel.Size = new System.Drawing.Size(191, 13);
            this.timeoutExprLabel.TabIndex = 2;
            this.timeoutExprLabel.Text = "State times out after this many seconds";
            // 
            // timeoutExprBox
            // 
            this.timeoutExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutExprBox.Location = new System.Drawing.Point(11, 26);
            this.timeoutExprBox.Name = "timeoutExprBox";
            this.timeoutExprBox.Size = new System.Drawing.Size(289, 20);
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
            this.termPage.Name = "termPage";
            this.termPage.Padding = new System.Windows.Forms.Padding(3);
            this.termPage.Size = new System.Drawing.Size(318, 299);
            this.termPage.TabIndex = 1;
            this.termPage.Text = "tabPage2";
            this.termPage.UseVisualStyleBackColor = true;
            // 
            // termFlagLabel
            // 
            this.termFlagLabel.AutoSize = true;
            this.termFlagLabel.Location = new System.Drawing.Point(3, 195);
            this.termFlagLabel.Name = "termFlagLabel";
            this.termFlagLabel.Size = new System.Drawing.Size(48, 13);
            this.termFlagLabel.TabIndex = 9;
            this.termFlagLabel.Text = "Set flags";
            // 
            // termFlagExprBox
            // 
            this.termFlagExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termFlagExprBox.Location = new System.Drawing.Point(6, 211);
            this.termFlagExprBox.Multiline = true;
            this.termFlagExprBox.Name = "termFlagExprBox";
            this.termFlagExprBox.Size = new System.Drawing.Size(304, 68);
            this.termFlagExprBox.TabIndex = 8;
            this.termFlagExprBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termFlagExprBox_KeyPress);
            this.termFlagExprBox.Leave += new System.EventHandler(this.termFlagExprBox_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Record result as";
            // 
            // termResultTextBox
            // 
            this.termResultTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termResultTextBox.Location = new System.Drawing.Point(6, 169);
            this.termResultTextBox.Name = "termResultTextBox";
            this.termResultTextBox.Size = new System.Drawing.Size(304, 20);
            this.termResultTextBox.TabIndex = 6;
            this.termResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termResultTextBox_KeyPress);
            this.termResultTextBox.Leave += new System.EventHandler(this.termResultTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
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
            this.inputEventComboBox.Location = new System.Drawing.Point(6, 28);
            this.inputEventComboBox.Name = "inputEventComboBox";
            this.inputEventComboBox.Size = new System.Drawing.Size(164, 21);
            this.inputEventComboBox.TabIndex = 4;
            this.inputEventComboBox.SelectedIndexChanged += new System.EventHandler(this.inputEventComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minimum latency (ms):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
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
            this.termActionComboBox.Location = new System.Drawing.Point(6, 124);
            this.termActionComboBox.Name = "termActionComboBox";
            this.termActionComboBox.Size = new System.Drawing.Size(164, 21);
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
            this.termLatencyNumeric.Location = new System.Drawing.Point(6, 75);
            this.termLatencyNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.termLatencyNumeric.MaxCoerce = false;
            this.termLatencyNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.termLatencyNumeric.MaxValue = 1000000D;
            this.termLatencyNumeric.MinCoerce = false;
            this.termLatencyNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.termLatencyNumeric.MinValue = 0D;
            this.termLatencyNumeric.Name = "termLatencyNumeric";
            this.termLatencyNumeric.Size = new System.Drawing.Size(107, 20);
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
            this.transitionLabel.Location = new System.Drawing.Point(28, 172);
            this.transitionLabel.Name = "transitionLabel";
            this.transitionLabel.Size = new System.Drawing.Size(59, 17);
            this.transitionLabel.TabIndex = 0;
            this.transitionLabel.Text = "Timeout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.Location = new System.Drawing.Point(63, 25);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateNameTextBox.TabIndex = 5;
            this.stateNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stateNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateNameTextBox_KeyPress);
            // 
            // AudioPage
            // 
            this.AudioPage.BackColor = System.Drawing.SystemColors.Control;
            this.AudioPage.Controls.Add(this.graphTabControl);
            this.AudioPage.Controls.Add(this.channelListBox);
            this.AudioPage.Controls.Add(this.channelView);
            this.AudioPage.Location = new System.Drawing.Point(4, 22);
            this.AudioPage.Name = "AudioPage";
            this.AudioPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudioPage.Size = new System.Drawing.Size(611, 702);
            this.AudioPage.TabIndex = 0;
            this.AudioPage.Text = "Audio";
            // 
            // graphTabControl
            // 
            this.graphTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.graphTabControl.Controls.Add(this.graphPage);
            this.graphTabControl.Controls.Add(this.errorPage);
            this.graphTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.graphTabControl.Location = new System.Drawing.Point(15, 505);
            this.graphTabControl.Name = "graphTabControl";
            this.graphTabControl.SelectedIndex = 0;
            this.graphTabControl.Size = new System.Drawing.Size(516, 184);
            this.graphTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.graphTabControl.TabIndex = 4;
            // 
            // graphPage
            // 
            this.graphPage.Controls.Add(this.signalGraph);
            this.graphPage.Location = new System.Drawing.Point(4, 5);
            this.graphPage.Name = "graphPage";
            this.graphPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphPage.Size = new System.Drawing.Size(508, 175);
            this.graphPage.TabIndex = 0;
            this.graphPage.Text = "tabPage1";
            this.graphPage.UseVisualStyleBackColor = true;
            // 
            // signalGraph
            // 
            this.signalGraph.BackColor = System.Drawing.SystemColors.Control;
            this.signalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalGraph.Location = new System.Drawing.Point(3, 3);
            this.signalGraph.Margin = new System.Windows.Forms.Padding(4);
            this.signalGraph.Name = "signalGraph";
            this.signalGraph.ScrollGrace = 0D;
            this.signalGraph.ScrollMaxX = 0D;
            this.signalGraph.ScrollMaxY = 0D;
            this.signalGraph.ScrollMaxY2 = 0D;
            this.signalGraph.ScrollMinX = 0D;
            this.signalGraph.ScrollMinY = 0D;
            this.signalGraph.ScrollMinY2 = 0D;
            this.signalGraph.Size = new System.Drawing.Size(502, 169);
            this.signalGraph.TabIndex = 2;
            // 
            // errorPage
            // 
            this.errorPage.BackColor = System.Drawing.SystemColors.Control;
            this.errorPage.Controls.Add(this.label21);
            this.errorPage.Controls.Add(this.audioErrorTextBox);
            this.errorPage.Location = new System.Drawing.Point(4, 5);
            this.errorPage.Name = "errorPage";
            this.errorPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorPage.Size = new System.Drawing.Size(508, 175);
            this.errorPage.TabIndex = 1;
            this.errorPage.Text = "tabPage2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Error";
            // 
            // audioErrorTextBox
            // 
            this.audioErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.audioErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audioErrorTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.audioErrorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.audioErrorTextBox.Location = new System.Drawing.Point(3, 47);
            this.audioErrorTextBox.Multiline = true;
            this.audioErrorTextBox.Name = "audioErrorTextBox";
            this.audioErrorTextBox.ReadOnly = true;
            this.audioErrorTextBox.Size = new System.Drawing.Size(502, 125);
            this.audioErrorTextBox.TabIndex = 3;
            // 
            // channelListBox
            // 
            this.channelListBox.DefaultName = "Signal";
            this.channelListBox.Location = new System.Drawing.Point(15, 11);
            this.channelListBox.Margin = new System.Windows.Forms.Padding(4);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.SelectedIndex = -1;
            this.channelListBox.Size = new System.Drawing.Size(219, 89);
            this.channelListBox.TabIndex = 1;
            this.channelListBox.SelectionChanged += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_SelectionChanged);
            this.channelListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemAdded);
            this.channelListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemRenamed);
            this.channelListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.channelListBox_ItemMoved);
            this.channelListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.channelListBox_ItemsDeleted);
            this.channelListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.channelListBox_ItemsMoved);
            // 
            // channelView
            // 
            this.channelView.AdapterMap = null;
            this.channelView.AllowExpertOptions = false;
            this.channelView.AutoScroll = true;
            this.channelView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channelView.Location = new System.Drawing.Point(273, 11);
            this.channelView.Margin = new System.Windows.Forms.Padding(4);
            this.channelView.Name = "channelView";
            this.channelView.Size = new System.Drawing.Size(258, 443);
            this.channelView.TabIndex = 0;
            this.channelView.Value = null;
            this.channelView.WavFolder = null;
            this.channelView.WaveformBecameValid += new System.EventHandler(this.channelView_WaveformBecameValid);
            this.channelView.ValueChanged += new System.EventHandler(this.channelView_ValueChanged);
            // 
            // CuePage
            // 
            this.CuePage.BackColor = System.Drawing.SystemColors.Control;
            this.CuePage.Controls.Add(this.stateCuesControl);
            this.CuePage.Location = new System.Drawing.Point(4, 22);
            this.CuePage.Name = "CuePage";
            this.CuePage.Padding = new System.Windows.Forms.Padding(3);
            this.CuePage.Size = new System.Drawing.Size(611, 702);
            this.CuePage.TabIndex = 1;
            this.CuePage.Text = "Cues";
            // 
            // stateCuesControl
            // 
            this.stateCuesControl.Location = new System.Drawing.Point(7, 7);
            this.stateCuesControl.Margin = new System.Windows.Forms.Padding(4);
            this.stateCuesControl.Name = "stateCuesControl";
            this.stateCuesControl.Size = new System.Drawing.Size(442, 491);
            this.stateCuesControl.TabIndex = 0;
            this.stateCuesControl.Value = null;
            this.stateCuesControl.CueAddRemove += new System.EventHandler<Turandot_Editor.Controls.StateCuesControl.CueAddRemoveArgs>(this.allCuesControl_CueAddRemove);
            this.stateCuesControl.ValueChanged += new System.EventHandler(this.allCuesControl_ValueChanged);
            // 
            // InputPage
            // 
            this.InputPage.BackColor = System.Drawing.SystemColors.Control;
            this.InputPage.Controls.Add(this.stateInputsControl);
            this.InputPage.Location = new System.Drawing.Point(4, 22);
            this.InputPage.Name = "InputPage";
            this.InputPage.Padding = new System.Windows.Forms.Padding(3);
            this.InputPage.Size = new System.Drawing.Size(611, 702);
            this.InputPage.TabIndex = 8;
            this.InputPage.Text = "Inputs";
            // 
            // stateInputsControl
            // 
            this.stateInputsControl.Location = new System.Drawing.Point(6, 6);
            this.stateInputsControl.Margin = new System.Windows.Forms.Padding(4);
            this.stateInputsControl.Name = "stateInputsControl";
            this.stateInputsControl.Size = new System.Drawing.Size(554, 360);
            this.stateInputsControl.TabIndex = 0;
            this.stateInputsControl.Value = null;
            this.stateInputsControl.InputAddRemove += new System.EventHandler<Turandot_Editor.Controls.StateInputsControl.InputAddRemoveArgs>(this.inputControl_InputAddRemove);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.matlabFileBrowser);
            this.infoPanel.Controls.Add(this.label16);
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
            this.infoPanel.Location = new System.Drawing.Point(3, 611);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(524, 120);
            this.infoPanel.TabIndex = 2;
            this.infoPanel.SizeChanged += new System.EventHandler(this.infoPanel_SizeChanged);
            // 
            // matlabFileBrowser
            // 
            this.matlabFileBrowser.AutoSize = true;
            this.matlabFileBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matlabFileBrowser.DefaultFolder = null;
            this.matlabFileBrowser.FileMustExist = false;
            this.matlabFileBrowser.Filter = "MATLAB files (*.m) | *.m";
            this.matlabFileBrowser.FoldersOnly = false;
            this.matlabFileBrowser.HideFolder = true;
            this.matlabFileBrowser.Location = new System.Drawing.Point(237, 59);
            this.matlabFileBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.matlabFileBrowser.Name = "matlabFileBrowser";
            this.matlabFileBrowser.ReadOnly = false;
            this.matlabFileBrowser.ShowSaveButton = false;
            this.matlabFileBrowser.Size = new System.Drawing.Size(178, 21);
            this.matlabFileBrowser.TabIndex = 17;
            this.matlabFileBrowser.UseEllipsis = false;
            this.matlabFileBrowser.Value = "";
            this.matlabFileBrowser.ValueChanged += new System.EventHandler(this.matlabFileBrowser_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "MATLAB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trial logs";
            // 
            // trialLogOptionEnum
            // 
            this.trialLogOptionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trialLogOptionEnum.FormattingEnabled = true;
            this.trialLogOptionEnum.Location = new System.Drawing.Point(70, 86);
            this.trialLogOptionEnum.Name = "trialLogOptionEnum";
            this.trialLogOptionEnum.Size = new System.Drawing.Size(99, 21);
            this.trialLogOptionEnum.Sort = false;
            this.trialLogOptionEnum.TabIndex = 14;
            this.trialLogOptionEnum.ValueChanged += new System.EventHandler(this.trialLogOptionEnum_ValueChanged);
            // 
            // expertCheckBox
            // 
            this.expertCheckBox.AutoSize = true;
            this.expertCheckBox.Location = new System.Drawing.Point(237, 88);
            this.expertCheckBox.Name = "expertCheckBox";
            this.expertCheckBox.Size = new System.Drawing.Size(85, 17);
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
            this.wavFolderTextBox.Location = new System.Drawing.Point(70, 59);
            this.wavFolderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wavFolderTextBox.Name = "wavFolderTextBox";
            this.wavFolderTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.tagTextBox.Location = new System.Drawing.Point(69, 33);
            this.tagTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagTextBox.TabIndex = 10;
            this.tagTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tagTextBox.ValueChanged += new System.EventHandler(this.tagTextBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = ".Wav folder";
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(498, 76);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(100, 19);
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
            this.linktoBrowser.Location = new System.Drawing.Point(237, 33);
            this.linktoBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.linktoBrowser.Name = "linktoBrowser";
            this.linktoBrowser.ReadOnly = false;
            this.linktoBrowser.ShowSaveButton = false;
            this.linktoBrowser.Size = new System.Drawing.Size(178, 21);
            this.linktoBrowser.TabIndex = 6;
            this.linktoBrowser.UseEllipsis = false;
            this.linktoBrowser.Value = "";
            this.linktoBrowser.ValueChanged += new System.EventHandler(this.linktoBrowser_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(196, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Link to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(46, 7);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(430, 23);
            this.pathLabel.TabIndex = 1;
            // 
            // graphViewer
            // 
            this.graphViewer.BackColor = System.Drawing.Color.Moccasin;
            this.graphViewer.CurrentScale = 1F;
            this.graphViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(4, 4);
            this.graphViewer.Margin = new System.Windows.Forms.Padding(4);
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.Size = new System.Drawing.Size(522, 600);
            this.graphViewer.TabIndex = 3;
            // 
            // ledTimer
            // 
            this.ledTimer.Interval = 2500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(950, 746);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Turandot Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
            this.graphTabControl.ResumeLayout(false);
            this.graphPage.ResumeLayout(false);
            this.errorPage.ResumeLayout(false);
            this.errorPage.PerformLayout();
            this.CuePage.ResumeLayout(false);
            this.InputPage.ResumeLayout(false);
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
        private KLib.Unity.Controls.Signals.ChannelView channelView;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private KLib.Controls.FileBrowser wavfolderBrowser;
        private System.Windows.Forms.Label label18;
        private KLib.Controls.FileBrowser calfolderBrowser;
        private System.Windows.Forms.TabPage InputPage;
        private System.Windows.Forms.TabPage InstructionsPage;
        private Controls.InstructionEditor instructionEditor;
        private KLib.Controls.FileBrowser linktoBrowser;
        private System.Windows.Forms.Label label19;
        private Controls.StateCuesControl stateCuesControl;
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
        private System.Windows.Forms.CheckBox actionCheckBox;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KTextBox wavFolderTextBox;
        private KLib.Controls.KTextBox tagTextBox;
        private System.Windows.Forms.Label termFlagLabel;
        private System.Windows.Forms.TextBox termFlagExprBox;
        private System.Windows.Forms.CheckBox expertCheckBox;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.EnumDropDown trialLogOptionEnum;
        private System.Windows.Forms.Label label17;
        private KLib.Controls.KTextBox ipcTextBox;
        private System.Windows.Forms.Label label20;
        private KLib.Controls.KTextBox transducerTextBox;
        private System.Windows.Forms.Label endActionLabel;
        private KLib.Controls.EnumDropDown endActionDropDown;
        private System.Windows.Forms.Timer ledTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricValue;
        private System.Windows.Forms.Button showStateButton;
        private System.Windows.Forms.ComboBox actionFamilyComboBox;
        private System.Windows.Forms.TabPage ScreenPage;
        private Controls.ScreenCuesSpecifier cuesSpecifier;
        private System.Windows.Forms.TabControl graphTabControl;
        private System.Windows.Forms.TabPage graphPage;
        private System.Windows.Forms.TabPage errorPage;
        private System.Windows.Forms.Label label21;
        private Controls.ScreenInputsSpecifier inputsSpecifier;
        private Controls.StateInputsControl stateInputsControl;
        private Controls.Events.EventsSpecifier eventsSpecifier;
        private KLib.Controls.FileBrowser matlabFileBrowser;
        private System.Windows.Forms.Label label16;
    }
}

