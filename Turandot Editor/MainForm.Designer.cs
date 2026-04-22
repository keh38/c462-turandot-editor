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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            toolStrip = new System.Windows.Forms.ToolStrip();
            NewParamsButton = new System.Windows.Forms.ToolStripButton();
            OpenFileButton = new System.Windows.Forms.ToolStripButton();
            SaveFileButton = new System.Windows.Forms.ToolStripButton();
            SaveFileAsButton = new System.Windows.Forms.ToolStripButton();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tabControl = new System.Windows.Forms.TabControl();
            MetricsPage = new System.Windows.Forms.TabPage();
            transducerComboBox = new System.Windows.Forms.ComboBox();
            projectComboBox = new System.Windows.Forms.ComboBox();
            label20 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            metricGridView = new System.Windows.Forms.DataGridView();
            MetricName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MetricValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ScreenPage = new System.Windows.Forms.TabPage();
            customScreenColorCheckBox = new KLib.Controls.KCheckBox();
            overrideColorCheckBox = new KLib.Controls.KCheckBox();
            screenColorBox = new KLib.Controls.KColorBox();
            inputsSpecifier = new Turandot_Editor.Controls.ScreenInputsSpecifier();
            cuesSpecifier = new Turandot_Editor.Controls.ScreenCuesSpecifier();
            Instructions = new System.Windows.Forms.TabPage();
            showInstructionsButton = new System.Windows.Forms.Button();
            instructionEditor = new Turandot_Editor.Controls.InstructionEditor();
            EventPage = new System.Windows.Forms.TabPage();
            eventsSpecifier = new Turandot_Editor.Controls.Events.EventsSpecifier();
            SchedulePage = new System.Windows.Forms.TabPage();
            timeLabel = new System.Windows.Forms.Label();
            breakPanel = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            breakInstructBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            afterNumeric = new KLib.Controls.KNumericBox();
            breakCheckBox = new System.Windows.Forms.CheckBox();
            schedTabs = new System.Windows.Forms.TabControl();
            schedPage = new System.Windows.Forms.TabPage();
            scheduleControl = new Turandot_Editor.Controls.ScheduleControl();
            adaptPage = new System.Windows.Forms.TabPage();
            adaptControl = new Turandot_Editor.Controls.AdaptationControl();
            schedModeDropDown = new KLib.Controls.EnumDropDown();
            StatePage = new System.Windows.Forms.TabPage();
            actionPropertyGrid = new System.Windows.Forms.PropertyGrid();
            hideCursorCheckBox = new System.Windows.Forms.CheckBox();
            showStateButton = new System.Windows.Forms.Button();
            statePanel = new System.Windows.Forms.Panel();
            endActionLabel = new System.Windows.Forms.Label();
            startCheckBox = new System.Windows.Forms.CheckBox();
            decisionCheckBox = new System.Windows.Forms.CheckBox();
            endActionDropDown = new KLib.Controls.EnumDropDown();
            actionCheckBox = new System.Windows.Forms.CheckBox();
            Separator = new System.Windows.Forms.Label();
            TransitionTabs = new System.Windows.Forms.TabControl();
            timeoutPage = new System.Windows.Forms.TabPage();
            label11 = new System.Windows.Forms.Label();
            timeoutResultTextBox = new System.Windows.Forms.TextBox();
            exprEvalResultTextBox = new System.Windows.Forms.TextBox();
            timeoutExprLabel = new System.Windows.Forms.Label();
            timeoutExprBox = new System.Windows.Forms.TextBox();
            termPage = new System.Windows.Forms.TabPage();
            termFlagLabel = new System.Windows.Forms.Label();
            termFlagExprBox = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            termResultTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            inputEventComboBox = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            termActionComboBox = new System.Windows.Forms.ComboBox();
            termLatencyNumeric = new KLib.Controls.KNumericBox();
            transitionLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            stateNameTextBox = new System.Windows.Forms.TextBox();
            AudioPage = new System.Windows.Forms.TabPage();
            channelPropertyGrid = new System.Windows.Forms.PropertyGrid();
            graphTabControl = new System.Windows.Forms.TabControl();
            graphPage = new System.Windows.Forms.TabPage();
            signalGraph = new ScottPlot.WinForms.FormsPlot();
            errorPage = new System.Windows.Forms.TabPage();
            label21 = new System.Windows.Forms.Label();
            audioErrorTextBox = new System.Windows.Forms.TextBox();
            channelListBox = new KLib.Controls.KUserListBox();
            CuePage = new System.Windows.Forms.TabPage();
            stateCuesControl = new Turandot_Editor.Controls.StateCuesControl();
            InputPage = new System.Windows.Forms.TabPage();
            stateInputsControl = new Turandot_Editor.Controls.StateInputsControl();
            infoPanel = new System.Windows.Forms.Panel();
            matlabFileBrowser = new KLib.Controls.FileBrowser();
            label16 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            trialLogOptionEnum = new KLib.Controls.EnumDropDown();
            expertCheckBox = new System.Windows.Forms.CheckBox();
            wavFolderTextBox = new KLib.Controls.KTextBox();
            tagTextBox = new KLib.Controls.KTextBox();
            label8 = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pathLabel = new System.Windows.Forms.Label();
            graphViewer = new Turandot.GraphViewer();
            ledTimer = new System.Windows.Forms.Timer(components);
            disableInputsCheckBox = new System.Windows.Forms.CheckBox();
            toolStrip.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tabControl.SuspendLayout();
            MetricsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)metricGridView).BeginInit();
            ScreenPage.SuspendLayout();
            Instructions.SuspendLayout();
            EventPage.SuspendLayout();
            SchedulePage.SuspendLayout();
            breakPanel.SuspendLayout();
            schedTabs.SuspendLayout();
            schedPage.SuspendLayout();
            adaptPage.SuspendLayout();
            StatePage.SuspendLayout();
            statePanel.SuspendLayout();
            TransitionTabs.SuspendLayout();
            timeoutPage.SuspendLayout();
            termPage.SuspendLayout();
            AudioPage.SuspendLayout();
            graphTabControl.SuspendLayout();
            graphPage.SuspendLayout();
            errorPage.SuspendLayout();
            CuePage.SuspendLayout();
            InputPage.SuspendLayout();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { NewParamsButton, OpenFileButton, SaveFileButton, SaveFileAsButton });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(1348, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // NewParamsButton
            // 
            NewParamsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NewParamsButton.Image = (System.Drawing.Image)resources.GetObject("NewParamsButton.Image");
            NewParamsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NewParamsButton.Name = "NewParamsButton";
            NewParamsButton.Size = new System.Drawing.Size(24, 24);
            NewParamsButton.Text = "New";
            NewParamsButton.Click += NewParamsButton_Click;
            // 
            // OpenFileButton
            // 
            OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            OpenFileButton.Image = (System.Drawing.Image)resources.GetObject("OpenFileButton.Image");
            OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new System.Drawing.Size(24, 24);
            OpenFileButton.Text = "Open parameter file";
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // SaveFileButton
            // 
            SaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveFileButton.Image = (System.Drawing.Image)resources.GetObject("SaveFileButton.Image");
            SaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new System.Drawing.Size(24, 24);
            SaveFileButton.Text = "Save parameter file";
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // SaveFileAsButton
            // 
            SaveFileAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveFileAsButton.Image = (System.Drawing.Image)resources.GetObject("SaveFileAsButton.Image");
            SaveFileAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveFileAsButton.Name = "SaveFileAsButton";
            SaveFileAsButton.Size = new System.Drawing.Size(24, 24);
            SaveFileAsButton.Text = "Save parameter file as...";
            SaveFileAsButton.Click += SaveFileAsButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 729F));
            tableLayoutPanel.Controls.Add(tabControl, 1, 0);
            tableLayoutPanel.Controls.Add(infoPanel, 0, 1);
            tableLayoutPanel.Controls.Add(graphViewer, 0, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 27);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            tableLayoutPanel.Size = new System.Drawing.Size(1348, 851);
            tableLayoutPanel.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl.Controls.Add(MetricsPage);
            tabControl.Controls.Add(ScreenPage);
            tabControl.Controls.Add(Instructions);
            tabControl.Controls.Add(EventPage);
            tabControl.Controls.Add(SchedulePage);
            tabControl.Controls.Add(StatePage);
            tabControl.Controls.Add(AudioPage);
            tabControl.Controls.Add(CuePage);
            tabControl.Controls.Add(InputPage);
            tabControl.Location = new System.Drawing.Point(623, 3);
            tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tableLayoutPanel.SetRowSpan(tabControl, 2);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(721, 845);
            tabControl.TabIndex = 1;
            // 
            // MetricsPage
            // 
            MetricsPage.BackColor = System.Drawing.SystemColors.Control;
            MetricsPage.Controls.Add(transducerComboBox);
            MetricsPage.Controls.Add(projectComboBox);
            MetricsPage.Controls.Add(label20);
            MetricsPage.Controls.Add(label18);
            MetricsPage.Controls.Add(label12);
            MetricsPage.Controls.Add(label14);
            MetricsPage.Controls.Add(metricGridView);
            MetricsPage.Location = new System.Drawing.Point(4, 24);
            MetricsPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MetricsPage.Name = "MetricsPage";
            MetricsPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MetricsPage.Size = new System.Drawing.Size(713, 817);
            MetricsPage.TabIndex = 7;
            MetricsPage.Text = "General";
            // 
            // transducerComboBox
            // 
            transducerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            transducerComboBox.FormattingEnabled = true;
            transducerComboBox.Location = new System.Drawing.Point(41, 111);
            transducerComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            transducerComboBox.Name = "transducerComboBox";
            transducerComboBox.Size = new System.Drawing.Size(140, 23);
            transducerComboBox.TabIndex = 10;
            transducerComboBox.SelectedIndexChanged += transducerComboBox_SelectedIndexChanged;
            // 
            // projectComboBox
            // 
            projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new System.Drawing.Point(41, 40);
            projectComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new System.Drawing.Size(140, 23);
            projectComboBox.TabIndex = 9;
            projectComboBox.SelectedIndexChanged += projectComboBox_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(37, 92);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(64, 15);
            label20.TabIndex = 8;
            label20.Text = "Transducer";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(35, 22);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(44, 15);
            label18.TabIndex = 6;
            label18.Text = "Project";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(35, 393);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(46, 15);
            label12.TabIndex = 2;
            label12.Text = "Metrics";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(328, 412);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(339, 30);
            label14.TabIndex = 1;
            label14.Text = "This table allows you to mimic the user-specific metrics\r\nstored on the tablet and to test their application to expressions.";
            // 
            // metricGridView
            // 
            metricGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            metricGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            metricGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            metricGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            metricGridView.ColumnHeadersHeight = 29;
            metricGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            metricGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { MetricName, MetricValue });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            metricGridView.DefaultCellStyle = dataGridViewCellStyle5;
            metricGridView.EnableHeadersVisualStyles = false;
            metricGridView.Location = new System.Drawing.Point(38, 412);
            metricGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            metricGridView.Name = "metricGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            metricGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            metricGridView.RowHeadersVisible = false;
            metricGridView.RowHeadersWidth = 51;
            metricGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            metricGridView.Size = new System.Drawing.Size(259, 173);
            metricGridView.TabIndex = 0;
            metricGridView.CellContentClick += metricGridView_CellContentClick;
            metricGridView.CellValueChanged += metricGridView_CellValueChanged;
            metricGridView.UserDeletingRow += metricGridView_UserDeletingRow;
            // 
            // MetricName
            // 
            MetricName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            MetricName.HeaderText = "Name";
            MetricName.MinimumWidth = 6;
            MetricName.Name = "MetricName";
            MetricName.Width = 125;
            // 
            // MetricValue
            // 
            MetricValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            MetricValue.HeaderText = "Value";
            MetricValue.MinimumWidth = 6;
            MetricValue.Name = "MetricValue";
            MetricValue.Width = 75;
            // 
            // ScreenPage
            // 
            ScreenPage.BackColor = System.Drawing.SystemColors.Control;
            ScreenPage.Controls.Add(customScreenColorCheckBox);
            ScreenPage.Controls.Add(overrideColorCheckBox);
            ScreenPage.Controls.Add(screenColorBox);
            ScreenPage.Controls.Add(inputsSpecifier);
            ScreenPage.Controls.Add(cuesSpecifier);
            ScreenPage.Location = new System.Drawing.Point(4, 24);
            ScreenPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ScreenPage.Name = "ScreenPage";
            ScreenPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ScreenPage.Size = new System.Drawing.Size(714, 812);
            ScreenPage.TabIndex = 2;
            ScreenPage.Text = "Screen";
            // 
            // customScreenColorCheckBox
            // 
            customScreenColorCheckBox.AutoSize = true;
            customScreenColorCheckBox.Location = new System.Drawing.Point(458, 54);
            customScreenColorCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            customScreenColorCheckBox.Name = "customScreenColorCheckBox";
            customScreenColorCheckBox.Size = new System.Drawing.Size(167, 19);
            customScreenColorCheckBox.TabIndex = 2;
            customScreenColorCheckBox.Text = "Apply custom screen color";
            customScreenColorCheckBox.UseVisualStyleBackColor = true;
            customScreenColorCheckBox.CheckedChanged += customScreenColorCheckBox_CheckedChanged;
            // 
            // overrideColorCheckBox
            // 
            overrideColorCheckBox.AutoSize = true;
            overrideColorCheckBox.Location = new System.Drawing.Point(458, 90);
            overrideColorCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            overrideColorCheckBox.Name = "overrideColorCheckBox";
            overrideColorCheckBox.Size = new System.Drawing.Size(138, 19);
            overrideColorCheckBox.TabIndex = 3;
            overrideColorCheckBox.Text = "Override screen color";
            overrideColorCheckBox.UseVisualStyleBackColor = true;
            overrideColorCheckBox.CheckedChanged += overrideColorCheckBox_CheckedChanged;
            // 
            // screenColorBox
            // 
            screenColorBox.Location = new System.Drawing.Point(467, 126);
            screenColorBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            screenColorBox.Name = "screenColorBox";
            screenColorBox.Size = new System.Drawing.Size(160, 23);
            screenColorBox.TabIndex = 2;
            screenColorBox.Value = System.Drawing.Color.FromArgb(255, 255, 255);
            screenColorBox.ValueAsUInt = uint.MaxValue;
            screenColorBox.ValueChanged += screenColorBox_ValueChanged;
            // 
            // inputsSpecifier
            // 
            inputsSpecifier.Location = new System.Drawing.Point(21, 391);
            inputsSpecifier.Margin = new System.Windows.Forms.Padding(2);
            inputsSpecifier.Name = "inputsSpecifier";
            inputsSpecifier.Size = new System.Drawing.Size(410, 367);
            inputsSpecifier.TabIndex = 1;
            inputsSpecifier.Value = null;
            inputsSpecifier.ValueChanged += inputsSpecifier_ValueChanged;
            // 
            // cuesSpecifier
            // 
            cuesSpecifier.Location = new System.Drawing.Point(21, 22);
            cuesSpecifier.Margin = new System.Windows.Forms.Padding(2);
            cuesSpecifier.Name = "cuesSpecifier";
            cuesSpecifier.Size = new System.Drawing.Size(432, 373);
            cuesSpecifier.TabIndex = 0;
            cuesSpecifier.Value = null;
            cuesSpecifier.ValueChanged += cuesSpecifier_ValueChanged;
            // 
            // Instructions
            // 
            Instructions.BackColor = System.Drawing.SystemColors.Control;
            Instructions.Controls.Add(showInstructionsButton);
            Instructions.Controls.Add(instructionEditor);
            Instructions.Location = new System.Drawing.Point(4, 24);
            Instructions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Instructions.Name = "Instructions";
            Instructions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Instructions.Size = new System.Drawing.Size(714, 812);
            Instructions.TabIndex = 9;
            Instructions.Text = "Instructions";
            // 
            // showInstructionsButton
            // 
            showInstructionsButton.Location = new System.Drawing.Point(386, 222);
            showInstructionsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            showInstructionsButton.Name = "showInstructionsButton";
            showInstructionsButton.Size = new System.Drawing.Size(88, 27);
            showInstructionsButton.TabIndex = 69;
            showInstructionsButton.Text = "Show";
            showInstructionsButton.UseVisualStyleBackColor = true;
            showInstructionsButton.Click += showInstructionsButton_Click;
            // 
            // instructionEditor
            // 
            instructionEditor.Location = new System.Drawing.Point(7, 7);
            instructionEditor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            instructionEditor.Name = "instructionEditor";
            instructionEditor.Size = new System.Drawing.Size(371, 515);
            instructionEditor.TabIndex = 0;
            instructionEditor.Value = null;
            instructionEditor.ValueChanged += instructionEditor_ValueChanged;
            // 
            // EventPage
            // 
            EventPage.BackColor = System.Drawing.SystemColors.Control;
            EventPage.Controls.Add(eventsSpecifier);
            EventPage.Location = new System.Drawing.Point(4, 24);
            EventPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EventPage.Name = "EventPage";
            EventPage.Size = new System.Drawing.Size(714, 812);
            EventPage.TabIndex = 3;
            EventPage.Text = "Events";
            // 
            // eventsSpecifier
            // 
            eventsSpecifier.AutoSize = true;
            eventsSpecifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            eventsSpecifier.Location = new System.Drawing.Point(13, 14);
            eventsSpecifier.Margin = new System.Windows.Forms.Padding(2);
            eventsSpecifier.Name = "eventsSpecifier";
            eventsSpecifier.Size = new System.Drawing.Size(493, 534);
            eventsSpecifier.TabIndex = 0;
            eventsSpecifier.ItemAdded += eventListBox_ItemAdded;
            eventsSpecifier.ItemRenamed += eventListBox_ItemRenamed;
            eventsSpecifier.ItemMoved += eventListBox_ItemMoved;
            eventsSpecifier.ItemsDeleted += eventListBox_ItemsDeleted;
            eventsSpecifier.ItemsMoved += eventListBox_ItemsMoved;
            eventsSpecifier.ValueChanged += eventsSpecifier_ValueChanged;
            // 
            // SchedulePage
            // 
            SchedulePage.BackColor = System.Drawing.SystemColors.Control;
            SchedulePage.Controls.Add(timeLabel);
            SchedulePage.Controls.Add(breakPanel);
            SchedulePage.Controls.Add(breakCheckBox);
            SchedulePage.Controls.Add(schedTabs);
            SchedulePage.Controls.Add(schedModeDropDown);
            SchedulePage.Location = new System.Drawing.Point(4, 24);
            SchedulePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SchedulePage.Name = "SchedulePage";
            SchedulePage.Size = new System.Drawing.Size(714, 812);
            SchedulePage.TabIndex = 4;
            SchedulePage.Text = "Schedule";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(18, 790);
            timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(0, 15);
            timeLabel.TabIndex = 3;
            // 
            // breakPanel
            // 
            breakPanel.AutoSize = true;
            breakPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            breakPanel.Controls.Add(label10);
            breakPanel.Controls.Add(breakInstructBox);
            breakPanel.Controls.Add(label9);
            breakPanel.Controls.Add(afterNumeric);
            breakPanel.Location = new System.Drawing.Point(274, 10);
            breakPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakPanel.Name = "breakPanel";
            breakPanel.Size = new System.Drawing.Size(433, 35);
            breakPanel.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(85, 8);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(41, 15);
            label10.TabIndex = 6;
            label10.Text = "blocks";
            // 
            // breakInstructBox
            // 
            breakInstructBox.Location = new System.Drawing.Point(133, 3);
            breakInstructBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakInstructBox.Multiline = true;
            breakInstructBox.Name = "breakInstructBox";
            breakInstructBox.Size = new System.Drawing.Size(296, 22);
            breakInstructBox.TabIndex = 3;
            breakInstructBox.Enter += breakInstructBox_Enter;
            breakInstructBox.Leave += breakInstructBox_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(2, 8);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 15);
            label9.TabIndex = 5;
            label9.Text = "after";
            // 
            // afterNumeric
            // 
            afterNumeric.AllowInf = false;
            afterNumeric.AutoSize = true;
            afterNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            afterNumeric.ClearOnDisable = false;
            afterNumeric.FloatValue = 0F;
            afterNumeric.IntValue = 0;
            afterNumeric.IsInteger = true;
            afterNumeric.Location = new System.Drawing.Point(35, 3);
            afterNumeric.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            afterNumeric.MaxCoerce = false;
            afterNumeric.MaximumSize = new System.Drawing.Size(23333, 27);
            afterNumeric.MaxValue = 100D;
            afterNumeric.MinCoerce = false;
            afterNumeric.MinimumSize = new System.Drawing.Size(12, 27);
            afterNumeric.MinValue = 1D;
            afterNumeric.Name = "afterNumeric";
            afterNumeric.Size = new System.Drawing.Size(47, 27);
            afterNumeric.TabIndex = 4;
            afterNumeric.TextFormat = "K4";
            afterNumeric.ToolTip = "";
            afterNumeric.Units = "";
            afterNumeric.Value = 0D;
            afterNumeric.ValueChanged += afterNumeric_ValueChanged;
            // 
            // breakCheckBox
            // 
            breakCheckBox.AutoSize = true;
            breakCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            breakCheckBox.Location = new System.Drawing.Point(206, 17);
            breakCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakCheckBox.Name = "breakCheckBox";
            breakCheckBox.Size = new System.Drawing.Size(55, 19);
            breakCheckBox.TabIndex = 2;
            breakCheckBox.Text = "Break";
            breakCheckBox.UseVisualStyleBackColor = true;
            breakCheckBox.CheckedChanged += breakCheckBox_CheckedChanged;
            // 
            // schedTabs
            // 
            schedTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            schedTabs.Controls.Add(schedPage);
            schedTabs.Controls.Add(adaptPage);
            schedTabs.ItemSize = new System.Drawing.Size(0, 1);
            schedTabs.Location = new System.Drawing.Point(4, 45);
            schedTabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            schedTabs.Name = "schedTabs";
            schedTabs.SelectedIndex = 0;
            schedTabs.Size = new System.Drawing.Size(732, 747);
            schedTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            schedTabs.TabIndex = 1;
            // 
            // schedPage
            // 
            schedPage.BackColor = System.Drawing.SystemColors.Control;
            schedPage.Controls.Add(scheduleControl);
            schedPage.Location = new System.Drawing.Point(4, 5);
            schedPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            schedPage.Name = "schedPage";
            schedPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            schedPage.Size = new System.Drawing.Size(724, 738);
            schedPage.TabIndex = 0;
            schedPage.Text = "tabPage1";
            // 
            // scheduleControl
            // 
            scheduleControl.Location = new System.Drawing.Point(4, 7);
            scheduleControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            scheduleControl.Name = "scheduleControl";
            scheduleControl.Size = new System.Drawing.Size(712, 658);
            scheduleControl.TabIndex = 0;
            scheduleControl.Value = null;
            scheduleControl.ValueChanged += scheduleControl_ValueChanged;
            // 
            // adaptPage
            // 
            adaptPage.BackColor = System.Drawing.SystemColors.Control;
            adaptPage.Controls.Add(adaptControl);
            adaptPage.Location = new System.Drawing.Point(4, 5);
            adaptPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            adaptPage.Name = "adaptPage";
            adaptPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            adaptPage.Size = new System.Drawing.Size(724, 738);
            adaptPage.TabIndex = 1;
            adaptPage.Text = "tabPage2";
            // 
            // adaptControl
            // 
            adaptControl.Location = new System.Drawing.Point(7, 7);
            adaptControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            adaptControl.Name = "adaptControl";
            adaptControl.Size = new System.Drawing.Size(692, 718);
            adaptControl.TabIndex = 0;
            adaptControl.Value = null;
            adaptControl.ValueChanged += adaptControl_ValueChanged;
            // 
            // schedModeDropDown
            // 
            schedModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            schedModeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            schedModeDropDown.FormattingEnabled = true;
            schedModeDropDown.Location = new System.Drawing.Point(21, 10);
            schedModeDropDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            schedModeDropDown.Name = "schedModeDropDown";
            schedModeDropDown.Size = new System.Drawing.Size(140, 24);
            schedModeDropDown.Sort = false;
            schedModeDropDown.TabIndex = 0;
            schedModeDropDown.ValueChanged += schedModeDropDown_ValueChanged;
            // 
            // StatePage
            // 
            StatePage.BackColor = System.Drawing.SystemColors.Control;
            StatePage.Controls.Add(disableInputsCheckBox);
            StatePage.Controls.Add(actionPropertyGrid);
            StatePage.Controls.Add(hideCursorCheckBox);
            StatePage.Controls.Add(showStateButton);
            StatePage.Controls.Add(statePanel);
            StatePage.Controls.Add(actionCheckBox);
            StatePage.Controls.Add(Separator);
            StatePage.Controls.Add(TransitionTabs);
            StatePage.Controls.Add(transitionLabel);
            StatePage.Controls.Add(label3);
            StatePage.Controls.Add(stateNameTextBox);
            StatePage.Location = new System.Drawing.Point(4, 24);
            StatePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StatePage.Name = "StatePage";
            StatePage.Size = new System.Drawing.Size(713, 817);
            StatePage.TabIndex = 6;
            StatePage.Text = "State";
            // 
            // actionPropertyGrid
            // 
            actionPropertyGrid.HelpVisible = false;
            actionPropertyGrid.Location = new System.Drawing.Point(327, 37);
            actionPropertyGrid.Margin = new System.Windows.Forms.Padding(2);
            actionPropertyGrid.Name = "actionPropertyGrid";
            actionPropertyGrid.Size = new System.Drawing.Size(259, 126);
            actionPropertyGrid.TabIndex = 71;
            actionPropertyGrid.ToolbarVisible = false;
            // 
            // hideCursorCheckBox
            // 
            hideCursorCheckBox.AutoSize = true;
            hideCursorCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            hideCursorCheckBox.Location = new System.Drawing.Point(99, 126);
            hideCursorCheckBox.Margin = new System.Windows.Forms.Padding(2);
            hideCursorCheckBox.Name = "hideCursorCheckBox";
            hideCursorCheckBox.Size = new System.Drawing.Size(87, 19);
            hideCursorCheckBox.TabIndex = 70;
            hideCursorCheckBox.Text = "Hide cursor";
            hideCursorCheckBox.UseVisualStyleBackColor = true;
            hideCursorCheckBox.CheckedChanged += hideCursorCheckBox_CheckedChanged;
            // 
            // showStateButton
            // 
            showStateButton.Location = new System.Drawing.Point(225, 137);
            showStateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            showStateButton.Name = "showStateButton";
            showStateButton.Size = new System.Drawing.Size(88, 27);
            showStateButton.TabIndex = 68;
            showStateButton.Text = "Show";
            showStateButton.UseVisualStyleBackColor = true;
            showStateButton.Click += showStateButton_Click;
            // 
            // statePanel
            // 
            statePanel.AutoSize = true;
            statePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            statePanel.Controls.Add(endActionLabel);
            statePanel.Controls.Add(startCheckBox);
            statePanel.Controls.Add(decisionCheckBox);
            statePanel.Controls.Add(endActionDropDown);
            statePanel.Location = new System.Drawing.Point(89, 55);
            statePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            statePanel.Name = "statePanel";
            statePanel.Size = new System.Drawing.Size(225, 52);
            statePanel.TabIndex = 15;
            // 
            // endActionLabel
            // 
            endActionLabel.AutoSize = true;
            endActionLabel.Location = new System.Drawing.Point(113, 3);
            endActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endActionLabel.Name = "endActionLabel";
            endActionLabel.Size = new System.Drawing.Size(46, 15);
            endActionLabel.TabIndex = 68;
            endActionLabel.Text = "On end";
            // 
            // startCheckBox
            // 
            startCheckBox.AutoSize = true;
            startCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            startCheckBox.Location = new System.Drawing.Point(20, 3);
            startCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startCheckBox.Name = "startCheckBox";
            startCheckBox.Size = new System.Drawing.Size(76, 19);
            startCheckBox.TabIndex = 7;
            startCheckBox.Text = "Start here";
            startCheckBox.UseVisualStyleBackColor = true;
            startCheckBox.CheckedChanged += startCheckBox_CheckedChanged;
            // 
            // decisionCheckBox
            // 
            decisionCheckBox.AutoSize = true;
            decisionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            decisionCheckBox.Location = new System.Drawing.Point(7, 30);
            decisionCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            decisionCheckBox.Name = "decisionCheckBox";
            decisionCheckBox.Size = new System.Drawing.Size(86, 19);
            decisionCheckBox.TabIndex = 8;
            decisionCheckBox.Text = "Target state";
            decisionCheckBox.UseVisualStyleBackColor = true;
            decisionCheckBox.CheckedChanged += decisionCheckBox_CheckedChanged;
            // 
            // endActionDropDown
            // 
            endActionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            endActionDropDown.FormattingEnabled = true;
            endActionDropDown.Location = new System.Drawing.Point(113, 20);
            endActionDropDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            endActionDropDown.Name = "endActionDropDown";
            endActionDropDown.Size = new System.Drawing.Size(108, 23);
            endActionDropDown.Sort = false;
            endActionDropDown.TabIndex = 68;
            endActionDropDown.ValueChanged += endActionDropDown_ValueChanged;
            // 
            // actionCheckBox
            // 
            actionCheckBox.AutoSize = true;
            actionCheckBox.Location = new System.Drawing.Point(217, 31);
            actionCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            actionCheckBox.Name = "actionCheckBox";
            actionCheckBox.Size = new System.Drawing.Size(87, 19);
            actionCheckBox.TabIndex = 14;
            actionCheckBox.Text = "Action only";
            actionCheckBox.UseVisualStyleBackColor = true;
            actionCheckBox.CheckedChanged += actionCheckBox_CheckedChanged;
            // 
            // Separator
            // 
            Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Separator.Location = new System.Drawing.Point(31, 177);
            Separator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Separator.Name = "Separator";
            Separator.Size = new System.Drawing.Size(554, 2);
            Separator.TabIndex = 11;
            Separator.Text = "label4";
            // 
            // TransitionTabs
            // 
            TransitionTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            TransitionTabs.Controls.Add(timeoutPage);
            TransitionTabs.Controls.Add(termPage);
            TransitionTabs.ItemSize = new System.Drawing.Size(0, 1);
            TransitionTabs.Location = new System.Drawing.Point(33, 217);
            TransitionTabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TransitionTabs.Name = "TransitionTabs";
            TransitionTabs.SelectedIndex = 0;
            TransitionTabs.Size = new System.Drawing.Size(380, 355);
            TransitionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            TransitionTabs.TabIndex = 9;
            // 
            // timeoutPage
            // 
            timeoutPage.BackColor = System.Drawing.SystemColors.Control;
            timeoutPage.Controls.Add(label11);
            timeoutPage.Controls.Add(timeoutResultTextBox);
            timeoutPage.Controls.Add(exprEvalResultTextBox);
            timeoutPage.Controls.Add(timeoutExprLabel);
            timeoutPage.Controls.Add(timeoutExprBox);
            timeoutPage.Location = new System.Drawing.Point(4, 5);
            timeoutPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            timeoutPage.Name = "timeoutPage";
            timeoutPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            timeoutPage.Size = new System.Drawing.Size(372, 346);
            timeoutPage.TabIndex = 0;
            timeoutPage.Text = "tabPage1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(9, 60);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(90, 15);
            label11.TabIndex = 5;
            label11.Text = "Record result as";
            // 
            // timeoutResultTextBox
            // 
            timeoutResultTextBox.Location = new System.Drawing.Point(13, 78);
            timeoutResultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            timeoutResultTextBox.Name = "timeoutResultTextBox";
            timeoutResultTextBox.Size = new System.Drawing.Size(188, 23);
            timeoutResultTextBox.TabIndex = 4;
            timeoutResultTextBox.KeyPress += timeoutResultTextBox_KeyPress;
            timeoutResultTextBox.Leave += timeoutResultTextBox_Leave;
            // 
            // exprEvalResultTextBox
            // 
            exprEvalResultTextBox.BackColor = System.Drawing.SystemColors.Control;
            exprEvalResultTextBox.Location = new System.Drawing.Point(13, 108);
            exprEvalResultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            exprEvalResultTextBox.Multiline = true;
            exprEvalResultTextBox.Name = "exprEvalResultTextBox";
            exprEvalResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            exprEvalResultTextBox.Size = new System.Drawing.Size(336, 216);
            exprEvalResultTextBox.TabIndex = 3;
            // 
            // timeoutExprLabel
            // 
            timeoutExprLabel.AutoSize = true;
            timeoutExprLabel.Location = new System.Drawing.Point(9, 12);
            timeoutExprLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeoutExprLabel.Name = "timeoutExprLabel";
            timeoutExprLabel.Size = new System.Drawing.Size(214, 15);
            timeoutExprLabel.TabIndex = 2;
            timeoutExprLabel.Text = "State times out after this many seconds";
            // 
            // timeoutExprBox
            // 
            timeoutExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            timeoutExprBox.Location = new System.Drawing.Point(13, 30);
            timeoutExprBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            timeoutExprBox.Name = "timeoutExprBox";
            timeoutExprBox.Size = new System.Drawing.Size(336, 20);
            timeoutExprBox.TabIndex = 1;
            timeoutExprBox.Text = "expression";
            timeoutExprBox.KeyPress += timeoutExprBox_KeyPress;
            timeoutExprBox.Leave += timeoutExprBox_Leave;
            // 
            // termPage
            // 
            termPage.Controls.Add(termFlagLabel);
            termPage.Controls.Add(termFlagExprBox);
            termPage.Controls.Add(label13);
            termPage.Controls.Add(termResultTextBox);
            termPage.Controls.Add(label6);
            termPage.Controls.Add(inputEventComboBox);
            termPage.Controls.Add(label5);
            termPage.Controls.Add(label4);
            termPage.Controls.Add(termActionComboBox);
            termPage.Controls.Add(termLatencyNumeric);
            termPage.Location = new System.Drawing.Point(4, 5);
            termPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            termPage.Name = "termPage";
            termPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            termPage.Size = new System.Drawing.Size(372, 346);
            termPage.TabIndex = 1;
            termPage.Text = "tabPage2";
            termPage.UseVisualStyleBackColor = true;
            // 
            // termFlagLabel
            // 
            termFlagLabel.AutoSize = true;
            termFlagLabel.Location = new System.Drawing.Point(4, 225);
            termFlagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            termFlagLabel.Name = "termFlagLabel";
            termFlagLabel.Size = new System.Drawing.Size(51, 15);
            termFlagLabel.TabIndex = 9;
            termFlagLabel.Text = "Set flags";
            // 
            // termFlagExprBox
            // 
            termFlagExprBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            termFlagExprBox.Location = new System.Drawing.Point(7, 243);
            termFlagExprBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            termFlagExprBox.Multiline = true;
            termFlagExprBox.Name = "termFlagExprBox";
            termFlagExprBox.Size = new System.Drawing.Size(354, 78);
            termFlagExprBox.TabIndex = 8;
            termFlagExprBox.KeyPress += termFlagExprBox_KeyPress;
            termFlagExprBox.Leave += termFlagExprBox_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(4, 177);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(90, 15);
            label13.TabIndex = 7;
            label13.Text = "Record result as";
            // 
            // termResultTextBox
            // 
            termResultTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            termResultTextBox.Location = new System.Drawing.Point(7, 195);
            termResultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            termResultTextBox.Name = "termResultTextBox";
            termResultTextBox.Size = new System.Drawing.Size(354, 20);
            termResultTextBox.TabIndex = 6;
            termResultTextBox.KeyPress += termResultTextBox_KeyPress;
            termResultTextBox.Leave += termResultTextBox_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 14);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Event";
            // 
            // inputEventComboBox
            // 
            inputEventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            inputEventComboBox.FormattingEnabled = true;
            inputEventComboBox.Items.AddRange(new object[] { "let state finish", "end state immediately" });
            inputEventComboBox.Location = new System.Drawing.Point(7, 32);
            inputEventComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            inputEventComboBox.Name = "inputEventComboBox";
            inputEventComboBox.Size = new System.Drawing.Size(191, 23);
            inputEventComboBox.TabIndex = 4;
            inputEventComboBox.SelectedIndexChanged += inputEventComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 68);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 15);
            label5.TabIndex = 3;
            label5.Text = "Minimum latency (ms):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 125);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(167, 15);
            label4.TabIndex = 1;
            label4.Text = "When this event becomes true";
            // 
            // termActionComboBox
            // 
            termActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            termActionComboBox.FormattingEnabled = true;
            termActionComboBox.Items.AddRange(new object[] { "let state finish", "end state immediately" });
            termActionComboBox.Location = new System.Drawing.Point(7, 143);
            termActionComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            termActionComboBox.Name = "termActionComboBox";
            termActionComboBox.Size = new System.Drawing.Size(191, 23);
            termActionComboBox.TabIndex = 0;
            termActionComboBox.SelectedIndexChanged += termActionComboBox_SelectedIndexChanged;
            // 
            // termLatencyNumeric
            // 
            termLatencyNumeric.AllowInf = false;
            termLatencyNumeric.AutoSize = true;
            termLatencyNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            termLatencyNumeric.ClearOnDisable = false;
            termLatencyNumeric.FloatValue = 0F;
            termLatencyNumeric.IntValue = 0;
            termLatencyNumeric.IsInteger = false;
            termLatencyNumeric.Location = new System.Drawing.Point(7, 87);
            termLatencyNumeric.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            termLatencyNumeric.MaxCoerce = false;
            termLatencyNumeric.MaximumSize = new System.Drawing.Size(23333, 27);
            termLatencyNumeric.MaxValue = 1000000D;
            termLatencyNumeric.MinCoerce = false;
            termLatencyNumeric.MinimumSize = new System.Drawing.Size(12, 27);
            termLatencyNumeric.MinValue = 0D;
            termLatencyNumeric.Name = "termLatencyNumeric";
            termLatencyNumeric.Size = new System.Drawing.Size(125, 27);
            termLatencyNumeric.TabIndex = 2;
            termLatencyNumeric.TextFormat = "K4";
            termLatencyNumeric.ToolTip = "";
            termLatencyNumeric.Units = "";
            termLatencyNumeric.Value = 0D;
            termLatencyNumeric.ValueChanged += termLatencyNumeric_ValueChanged;
            // 
            // transitionLabel
            // 
            transitionLabel.AutoSize = true;
            transitionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            transitionLabel.Location = new System.Drawing.Point(33, 198);
            transitionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            transitionLabel.Name = "transitionLabel";
            transitionLabel.Size = new System.Drawing.Size(59, 17);
            transitionLabel.TabIndex = 0;
            transitionLabel.Text = "Timeout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 32);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // stateNameTextBox
            // 
            stateNameTextBox.Location = new System.Drawing.Point(74, 29);
            stateNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            stateNameTextBox.Name = "stateNameTextBox";
            stateNameTextBox.Size = new System.Drawing.Size(116, 23);
            stateNameTextBox.TabIndex = 5;
            stateNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            stateNameTextBox.KeyPress += stateNameTextBox_KeyPress;
            // 
            // AudioPage
            // 
            AudioPage.BackColor = System.Drawing.SystemColors.Control;
            AudioPage.Controls.Add(channelPropertyGrid);
            AudioPage.Controls.Add(graphTabControl);
            AudioPage.Controls.Add(channelListBox);
            AudioPage.Location = new System.Drawing.Point(4, 24);
            AudioPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AudioPage.Name = "AudioPage";
            AudioPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AudioPage.Size = new System.Drawing.Size(714, 812);
            AudioPage.TabIndex = 0;
            AudioPage.Text = "Audio";
            // 
            // channelPropertyGrid
            // 
            channelPropertyGrid.Location = new System.Drawing.Point(303, 42);
            channelPropertyGrid.Margin = new System.Windows.Forms.Padding(2);
            channelPropertyGrid.Name = "channelPropertyGrid";
            channelPropertyGrid.Size = new System.Drawing.Size(312, 537);
            channelPropertyGrid.TabIndex = 5;
            channelPropertyGrid.ToolbarVisible = false;
            channelPropertyGrid.PropertyValueChanged += channelPropertyGrid_PropertyValueChanged;
            // 
            // graphTabControl
            // 
            graphTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            graphTabControl.Controls.Add(graphPage);
            graphTabControl.Controls.Add(errorPage);
            graphTabControl.ItemSize = new System.Drawing.Size(0, 1);
            graphTabControl.Location = new System.Drawing.Point(18, 583);
            graphTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            graphTabControl.Name = "graphTabControl";
            graphTabControl.SelectedIndex = 0;
            graphTabControl.Size = new System.Drawing.Size(602, 212);
            graphTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            graphTabControl.TabIndex = 4;
            // 
            // graphPage
            // 
            graphPage.Controls.Add(signalGraph);
            graphPage.Location = new System.Drawing.Point(4, 5);
            graphPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            graphPage.Name = "graphPage";
            graphPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            graphPage.Size = new System.Drawing.Size(594, 203);
            graphPage.TabIndex = 0;
            graphPage.Text = "tabPage1";
            graphPage.UseVisualStyleBackColor = true;
            // 
            // signalGraph
            // 
            signalGraph.DisplayScale = 0F;
            signalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            signalGraph.Location = new System.Drawing.Point(4, 3);
            signalGraph.Margin = new System.Windows.Forms.Padding(2);
            signalGraph.Name = "signalGraph";
            signalGraph.Size = new System.Drawing.Size(586, 197);
            signalGraph.TabIndex = 0;
            // 
            // errorPage
            // 
            errorPage.BackColor = System.Drawing.SystemColors.Control;
            errorPage.Controls.Add(label21);
            errorPage.Controls.Add(audioErrorTextBox);
            errorPage.Location = new System.Drawing.Point(4, 5);
            errorPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            errorPage.Name = "errorPage";
            errorPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            errorPage.Size = new System.Drawing.Size(594, 203);
            errorPage.TabIndex = 1;
            errorPage.Text = "tabPage2";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(7, 36);
            label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(32, 15);
            label21.TabIndex = 4;
            label21.Text = "Error";
            // 
            // audioErrorTextBox
            // 
            audioErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            audioErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            audioErrorTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            audioErrorTextBox.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            audioErrorTextBox.Location = new System.Drawing.Point(4, 56);
            audioErrorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            audioErrorTextBox.Multiline = true;
            audioErrorTextBox.Name = "audioErrorTextBox";
            audioErrorTextBox.ReadOnly = true;
            audioErrorTextBox.Size = new System.Drawing.Size(586, 144);
            audioErrorTextBox.TabIndex = 3;
            // 
            // channelListBox
            // 
            channelListBox.DefaultName = "Signal";
            channelListBox.Location = new System.Drawing.Point(18, 13);
            channelListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            channelListBox.Name = "channelListBox";
            channelListBox.SelectedIndex = -1;
            channelListBox.Size = new System.Drawing.Size(255, 165);
            channelListBox.TabIndex = 1;
            channelListBox.SelectionChanged += channelListBox_SelectionChanged;
            channelListBox.ItemAdded += channelListBox_ItemAdded;
            channelListBox.ItemRenamed += channelListBox_ItemRenamed;
            channelListBox.ItemMoved += channelListBox_ItemMoved;
            channelListBox.ItemsDeleted += channelListBox_ItemsDeleted;
            channelListBox.ItemsMoved += channelListBox_ItemsMoved;
            // 
            // CuePage
            // 
            CuePage.BackColor = System.Drawing.SystemColors.Control;
            CuePage.Controls.Add(stateCuesControl);
            CuePage.Location = new System.Drawing.Point(4, 24);
            CuePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CuePage.Name = "CuePage";
            CuePage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CuePage.Size = new System.Drawing.Size(714, 812);
            CuePage.TabIndex = 1;
            CuePage.Text = "Cues";
            // 
            // stateCuesControl
            // 
            stateCuesControl.Location = new System.Drawing.Point(8, 8);
            stateCuesControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            stateCuesControl.Name = "stateCuesControl";
            stateCuesControl.Size = new System.Drawing.Size(516, 567);
            stateCuesControl.TabIndex = 0;
            stateCuesControl.Value = null;
            stateCuesControl.CueAddRemove += allCuesControl_CueAddRemove;
            stateCuesControl.ValueChanged += allCuesControl_ValueChanged;
            // 
            // InputPage
            // 
            InputPage.BackColor = System.Drawing.SystemColors.Control;
            InputPage.Controls.Add(stateInputsControl);
            InputPage.Location = new System.Drawing.Point(4, 24);
            InputPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InputPage.Name = "InputPage";
            InputPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InputPage.Size = new System.Drawing.Size(714, 812);
            InputPage.TabIndex = 8;
            InputPage.Text = "Inputs";
            // 
            // stateInputsControl
            // 
            stateInputsControl.Location = new System.Drawing.Point(7, 7);
            stateInputsControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            stateInputsControl.Name = "stateInputsControl";
            stateInputsControl.Size = new System.Drawing.Size(646, 415);
            stateInputsControl.TabIndex = 0;
            stateInputsControl.Value = null;
            stateInputsControl.InputAddRemove += inputControl_InputAddRemove;
            stateInputsControl.ValueChanged += stateInputsControl_ValueChanged;
            // 
            // infoPanel
            // 
            infoPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            infoPanel.Controls.Add(matlabFileBrowser);
            infoPanel.Controls.Add(label16);
            infoPanel.Controls.Add(label7);
            infoPanel.Controls.Add(trialLogOptionEnum);
            infoPanel.Controls.Add(expertCheckBox);
            infoPanel.Controls.Add(wavFolderTextBox);
            infoPanel.Controls.Add(tagTextBox);
            infoPanel.Controls.Add(label8);
            infoPanel.Controls.Add(versionLabel);
            infoPanel.Controls.Add(label2);
            infoPanel.Controls.Add(label1);
            infoPanel.Controls.Add(pathLabel);
            infoPanel.Location = new System.Drawing.Point(4, 709);
            infoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new System.Drawing.Size(611, 139);
            infoPanel.TabIndex = 2;
            infoPanel.SizeChanged += infoPanel_SizeChanged;
            // 
            // matlabFileBrowser
            // 
            matlabFileBrowser.AutoSize = true;
            matlabFileBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            matlabFileBrowser.DefaultFolder = null;
            matlabFileBrowser.FileMustExist = false;
            matlabFileBrowser.Filter = "MATLAB files (*.m) | *.m";
            matlabFileBrowser.FoldersOnly = false;
            matlabFileBrowser.HideFolder = true;
            matlabFileBrowser.Location = new System.Drawing.Point(327, 68);
            matlabFileBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            matlabFileBrowser.Name = "matlabFileBrowser";
            matlabFileBrowser.ReadOnly = false;
            matlabFileBrowser.ShowSaveButton = false;
            matlabFileBrowser.Size = new System.Drawing.Size(208, 24);
            matlabFileBrowser.TabIndex = 17;
            matlabFileBrowser.UseEllipsis = false;
            matlabFileBrowser.Value = "";
            matlabFileBrowser.ValueChanged += matlabFileBrowser_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(265, 73);
            label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(52, 15);
            label16.TabIndex = 16;
            label16.Text = "MATLAB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 104);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 15);
            label7.TabIndex = 15;
            label7.Text = "Trial logs";
            // 
            // trialLogOptionEnum
            // 
            trialLogOptionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            trialLogOptionEnum.FormattingEnabled = true;
            trialLogOptionEnum.Location = new System.Drawing.Point(82, 99);
            trialLogOptionEnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trialLogOptionEnum.Name = "trialLogOptionEnum";
            trialLogOptionEnum.Size = new System.Drawing.Size(160, 23);
            trialLogOptionEnum.Sort = false;
            trialLogOptionEnum.TabIndex = 14;
            trialLogOptionEnum.ValueChanged += trialLogOptionEnum_ValueChanged;
            // 
            // expertCheckBox
            // 
            expertCheckBox.AutoSize = true;
            expertCheckBox.Location = new System.Drawing.Point(327, 102);
            expertCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expertCheckBox.Name = "expertCheckBox";
            expertCheckBox.Size = new System.Drawing.Size(93, 19);
            expertCheckBox.TabIndex = 13;
            expertCheckBox.Text = "Expert mode";
            expertCheckBox.UseVisualStyleBackColor = true;
            expertCheckBox.CheckedChanged += expertCheckBox_CheckedChanged;
            // 
            // wavFolderTextBox
            // 
            wavFolderTextBox.AutoSize = true;
            wavFolderTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            wavFolderTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            wavFolderTextBox.IsIPAddress = false;
            wavFolderTextBox.Location = new System.Drawing.Point(82, 68);
            wavFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            wavFolderTextBox.Name = "wavFolderTextBox";
            wavFolderTextBox.Size = new System.Drawing.Size(161, 23);
            wavFolderTextBox.TabIndex = 11;
            wavFolderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            wavFolderTextBox.ValueChanged += wavFolderTextBox_ValueChanged;
            // 
            // tagTextBox
            // 
            tagTextBox.AutoSize = true;
            tagTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tagTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            tagTextBox.IsIPAddress = false;
            tagTextBox.Location = new System.Drawing.Point(80, 38);
            tagTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            tagTextBox.Name = "tagTextBox";
            tagTextBox.Size = new System.Drawing.Size(162, 23);
            tagTextBox.TabIndex = 10;
            tagTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tagTextBox.ValueChanged += tagTextBox_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 73);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 15);
            label8.TabIndex = 9;
            label8.Text = ".Wav folder";
            // 
            // versionLabel
            // 
            versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            versionLabel.Location = new System.Drawing.Point(581, 88);
            versionLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(117, 22);
            versionLabel.TabIndex = 7;
            versionLabel.Text = "version";
            versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 42);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "Tag";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Path:";
            // 
            // pathLabel
            // 
            pathLabel.Location = new System.Drawing.Point(54, 8);
            pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(502, 27);
            pathLabel.TabIndex = 1;
            // 
            // graphViewer
            // 
            graphViewer.BackColor = System.Drawing.Color.Moccasin;
            graphViewer.CurrentScale = 1F;
            graphViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            graphViewer.Graph = null;
            graphViewer.Location = new System.Drawing.Point(5, 5);
            graphViewer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            graphViewer.Name = "graphViewer";
            graphViewer.Size = new System.Drawing.Size(609, 696);
            graphViewer.TabIndex = 3;
            // 
            // ledTimer
            // 
            ledTimer.Interval = 2500;
            // 
            // disableInputsCheckBox
            // 
            disableInputsCheckBox.AutoSize = true;
            disableInputsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            disableInputsCheckBox.Location = new System.Drawing.Point(86, 145);
            disableInputsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            disableInputsCheckBox.Name = "disableInputsCheckBox";
            disableInputsCheckBox.Size = new System.Drawing.Size(100, 19);
            disableInputsCheckBox.TabIndex = 72;
            disableInputsCheckBox.Text = "Disable inputs";
            disableInputsCheckBox.UseVisualStyleBackColor = true;
            disableInputsCheckBox.CheckedChanged += disableInputsCheckBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1348, 878);
            Controls.Add(tableLayoutPanel);
            Controls.Add(toolStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1106, 847);
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "Turandot Editor";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            KeyDown += MainForm_KeyDown;
            KeyPress += MainForm_KeyPress;
            KeyUp += MainForm_KeyUp;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            MetricsPage.ResumeLayout(false);
            MetricsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)metricGridView).EndInit();
            ScreenPage.ResumeLayout(false);
            ScreenPage.PerformLayout();
            Instructions.ResumeLayout(false);
            EventPage.ResumeLayout(false);
            EventPage.PerformLayout();
            SchedulePage.ResumeLayout(false);
            SchedulePage.PerformLayout();
            breakPanel.ResumeLayout(false);
            breakPanel.PerformLayout();
            schedTabs.ResumeLayout(false);
            schedPage.ResumeLayout(false);
            adaptPage.ResumeLayout(false);
            StatePage.ResumeLayout(false);
            StatePage.PerformLayout();
            statePanel.ResumeLayout(false);
            statePanel.PerformLayout();
            TransitionTabs.ResumeLayout(false);
            timeoutPage.ResumeLayout(false);
            timeoutPage.PerformLayout();
            termPage.ResumeLayout(false);
            termPage.PerformLayout();
            AudioPage.ResumeLayout(false);
            graphTabControl.ResumeLayout(false);
            graphPage.ResumeLayout(false);
            errorPage.ResumeLayout(false);
            errorPage.PerformLayout();
            CuePage.ResumeLayout(false);
            InputPage.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private KLib.Controls.KUserListBox channelListBox;
        private System.Windows.Forms.TabControl schedTabs;
        private System.Windows.Forms.TabPage schedPage;
        private System.Windows.Forms.TabPage adaptPage;
        private KLib.Controls.EnumDropDown schedModeDropDown;
        private Controls.ScheduleControl scheduleControl;
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage InputPage;
        private System.Windows.Forms.TabPage Instructions;
        private Controls.StateCuesControl stateCuesControl;
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label endActionLabel;
        private KLib.Controls.EnumDropDown endActionDropDown;
        private System.Windows.Forms.Timer ledTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetricValue;
        private System.Windows.Forms.Button showStateButton;
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
        private KLib.Controls.KCheckBox customScreenColorCheckBox;
        private System.Windows.Forms.CheckBox hideCursorCheckBox;
        private KLib.Controls.KCheckBox overrideColorCheckBox;
        private KLib.Controls.KColorBox screenColorBox;
        private Controls.InstructionEditor instructionEditor;
        private System.Windows.Forms.Button showInstructionsButton;
        private System.Windows.Forms.PropertyGrid actionPropertyGrid;
        private System.Windows.Forms.PropertyGrid channelPropertyGrid;
        private ScottPlot.WinForms.FormsPlot signalGraph;
        private System.Windows.Forms.ComboBox transducerComboBox;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.CheckBox disableInputsCheckBox;
    }
}

