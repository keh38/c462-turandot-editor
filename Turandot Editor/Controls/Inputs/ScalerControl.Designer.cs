namespace Turandot_Editor.Controls.Inputs
{
    partial class ScalerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scaleBGColorBox = new KLib.Controls.KColorBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lengthNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.posNumeric = new KLib.Controls.KNumericBox();
            this.thumbCheckBox = new System.Windows.Forms.CheckBox();
            this.tickTypeEnum = new KLib.Controls.EnumDropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tickTabs = new System.Windows.Forms.TabControl();
            this.nonePage = new System.Windows.Forms.TabPage();
            this.linearPage = new System.Windows.Forms.TabPage();
            this.minNumeric = new KLib.Controls.KNumericBox();
            this.stepNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arbitraryPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TickLabels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.referenceEnum = new KLib.Controls.EnumDropDown();
            this.refTabs = new System.Windows.Forms.TabControl();
            this.noRefPage = new System.Windows.Forms.TabPage();
            this.refStartAtCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.refLocationTextBox = new KLib.Controls.KTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.refLabelTextBox = new KLib.Controls.KTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.refColorBox = new KLib.Controls.KColorBox();
            this.tickRefPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tickTabs.SuspendLayout();
            this.linearPage.SuspendLayout();
            this.arbitraryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.refTabs.SuspendLayout();
            this.tickRefPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scaleBGColorBox
            // 
            this.scaleBGColorBox.Location = new System.Drawing.Point(104, 53);
            this.scaleBGColorBox.Name = "scaleBGColorBox";
            this.scaleBGColorBox.Size = new System.Drawing.Size(104, 21);
            this.scaleBGColorBox.TabIndex = 59;
            this.scaleBGColorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scaleBGColorBox.ValueAsUInt = ((uint)(4294967295u));
            this.scaleBGColorBox.ValueChanged += new System.EventHandler(this.scaleBGColorBox_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Background color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Length (pixels)";
            // 
            // lengthNumeric
            // 
            this.lengthNumeric.AutoSize = true;
            this.lengthNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lengthNumeric.FloatValue = 0F;
            this.lengthNumeric.IntValue = 0;
            this.lengthNumeric.IsInteger = true;
            this.lengthNumeric.Location = new System.Drawing.Point(104, 28);
            this.lengthNumeric.MaxCoerce = false;
            this.lengthNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.lengthNumeric.MaxValue = 1D;
            this.lengthNumeric.MinCoerce = true;
            this.lengthNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.lengthNumeric.MinValue = 0D;
            this.lengthNumeric.Name = "lengthNumeric";
            this.lengthNumeric.Size = new System.Drawing.Size(104, 20);
            this.lengthNumeric.TabIndex = 56;
            this.lengthNumeric.TextFormat = "K4";
            this.lengthNumeric.Units = "";
            this.lengthNumeric.Value = 0D;
            this.lengthNumeric.ValueChanged += new System.EventHandler(this.lengthNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Initial position (0-1)";
            // 
            // posNumeric
            // 
            this.posNumeric.AutoSize = true;
            this.posNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.posNumeric.FloatValue = 0F;
            this.posNumeric.IntValue = 0;
            this.posNumeric.IsInteger = false;
            this.posNumeric.Location = new System.Drawing.Point(104, 3);
            this.posNumeric.MaxCoerce = false;
            this.posNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.posNumeric.MaxValue = 1D;
            this.posNumeric.MinCoerce = false;
            this.posNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.posNumeric.MinValue = 0D;
            this.posNumeric.Name = "posNumeric";
            this.posNumeric.Size = new System.Drawing.Size(104, 20);
            this.posNumeric.TabIndex = 54;
            this.posNumeric.TextFormat = "K4";
            this.posNumeric.Units = "";
            this.posNumeric.Value = 0D;
            this.posNumeric.ValueChanged += new System.EventHandler(this.posNumeric_ValueChanged);
            // 
            // thumbCheckBox
            // 
            this.thumbCheckBox.AutoSize = true;
            this.thumbCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thumbCheckBox.Location = new System.Drawing.Point(32, 80);
            this.thumbCheckBox.Name = "thumbCheckBox";
            this.thumbCheckBox.Size = new System.Drawing.Size(85, 17);
            this.thumbCheckBox.TabIndex = 64;
            this.thumbCheckBox.Text = "Show thumb";
            this.thumbCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thumbCheckBox.UseVisualStyleBackColor = true;
            this.thumbCheckBox.CheckedChanged += new System.EventHandler(this.thumbCheckBox_ValueChanged);
            // 
            // tickTypeEnum
            // 
            this.tickTypeEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tickTypeEnum.FormattingEnabled = true;
            this.tickTypeEnum.Location = new System.Drawing.Point(104, 101);
            this.tickTypeEnum.Name = "tickTypeEnum";
            this.tickTypeEnum.Size = new System.Drawing.Size(104, 21);
            this.tickTypeEnum.Sort = false;
            this.tickTypeEnum.TabIndex = 65;
            this.tickTypeEnum.ValueChanged += new System.EventHandler(this.tickTypeEnum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tick marks";
            // 
            // tickTabs
            // 
            this.tickTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tickTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tickTabs.Controls.Add(this.nonePage);
            this.tickTabs.Controls.Add(this.linearPage);
            this.tickTabs.Controls.Add(this.arbitraryPage);
            this.tickTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.tickTabs.Location = new System.Drawing.Point(24, 128);
            this.tickTabs.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tickTabs.Multiline = true;
            this.tickTabs.Name = "tickTabs";
            this.tickTabs.Padding = new System.Drawing.Point(0, 3);
            this.tickTabs.SelectedIndex = 0;
            this.tickTabs.Size = new System.Drawing.Size(193, 133);
            this.tickTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tickTabs.TabIndex = 67;
            // 
            // nonePage
            // 
            this.nonePage.BackColor = System.Drawing.SystemColors.Control;
            this.nonePage.Location = new System.Drawing.Point(4, 5);
            this.nonePage.Name = "nonePage";
            this.nonePage.Padding = new System.Windows.Forms.Padding(3);
            this.nonePage.Size = new System.Drawing.Size(185, 124);
            this.nonePage.TabIndex = 0;
            this.nonePage.Text = "tabPage1";
            // 
            // linearPage
            // 
            this.linearPage.BackColor = System.Drawing.SystemColors.Control;
            this.linearPage.Controls.Add(this.minNumeric);
            this.linearPage.Controls.Add(this.stepNumeric);
            this.linearPage.Controls.Add(this.label4);
            this.linearPage.Controls.Add(this.maxNumeric);
            this.linearPage.Controls.Add(this.label3);
            this.linearPage.Controls.Add(this.label2);
            this.linearPage.Location = new System.Drawing.Point(4, 5);
            this.linearPage.Name = "linearPage";
            this.linearPage.Padding = new System.Windows.Forms.Padding(3);
            this.linearPage.Size = new System.Drawing.Size(185, 124);
            this.linearPage.TabIndex = 1;
            this.linearPage.Text = "tabPage2";
            // 
            // minNumeric
            // 
            this.minNumeric.AutoSize = true;
            this.minNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minNumeric.FloatValue = 0F;
            this.minNumeric.IntValue = 0;
            this.minNumeric.IsInteger = false;
            this.minNumeric.Location = new System.Drawing.Point(79, 6);
            this.minNumeric.MaxCoerce = false;
            this.minNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.minNumeric.MaxValue = 1D;
            this.minNumeric.MinCoerce = false;
            this.minNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.minNumeric.MinValue = 0D;
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(68, 20);
            this.minNumeric.TabIndex = 68;
            this.minNumeric.TextFormat = "K4";
            this.minNumeric.Units = "";
            this.minNumeric.Value = 0D;
            this.minNumeric.ValueChanged += new System.EventHandler(this.minNumeric_ValueChanged);
            // 
            // stepNumeric
            // 
            this.stepNumeric.AutoSize = true;
            this.stepNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stepNumeric.FloatValue = 0F;
            this.stepNumeric.IntValue = 0;
            this.stepNumeric.IsInteger = false;
            this.stepNumeric.Location = new System.Drawing.Point(79, 57);
            this.stepNumeric.MaxCoerce = false;
            this.stepNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.stepNumeric.MaxValue = 1D;
            this.stepNumeric.MinCoerce = false;
            this.stepNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.stepNumeric.MinValue = 0D;
            this.stepNumeric.Name = "stepNumeric";
            this.stepNumeric.Size = new System.Drawing.Size(68, 20);
            this.stepNumeric.TabIndex = 72;
            this.stepNumeric.TextFormat = "K4";
            this.stepNumeric.Units = "";
            this.stepNumeric.Value = 0D;
            this.stepNumeric.ValueChanged += new System.EventHandler(this.stepNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Step";
            // 
            // maxNumeric
            // 
            this.maxNumeric.AutoSize = true;
            this.maxNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxNumeric.FloatValue = 0F;
            this.maxNumeric.IntValue = 0;
            this.maxNumeric.IsInteger = false;
            this.maxNumeric.Location = new System.Drawing.Point(79, 31);
            this.maxNumeric.MaxCoerce = false;
            this.maxNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxNumeric.MaxValue = 1D;
            this.maxNumeric.MinCoerce = false;
            this.maxNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxNumeric.MinValue = 0D;
            this.maxNumeric.Name = "maxNumeric";
            this.maxNumeric.Size = new System.Drawing.Size(68, 20);
            this.maxNumeric.TabIndex = 70;
            this.maxNumeric.TextFormat = "K4";
            this.maxNumeric.Units = "";
            this.maxNumeric.Value = 0D;
            this.maxNumeric.ValueChanged += new System.EventHandler(this.maxNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Min";
            // 
            // arbitraryPage
            // 
            this.arbitraryPage.BackColor = System.Drawing.SystemColors.Control;
            this.arbitraryPage.Controls.Add(this.dataGridView);
            this.arbitraryPage.Location = new System.Drawing.Point(4, 5);
            this.arbitraryPage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.arbitraryPage.Name = "arbitraryPage";
            this.arbitraryPage.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.arbitraryPage.Size = new System.Drawing.Size(185, 124);
            this.arbitraryPage.TabIndex = 2;
            this.arbitraryPage.Text = "tabPage1";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TickLabels});
            this.dataGridView.Location = new System.Drawing.Point(41, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(143, 113);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // TickLabels
            // 
            this.TickLabels.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TickLabels.DefaultCellStyle = dataGridViewCellStyle6;
            this.TickLabels.HeaderText = "Labels";
            this.TickLabels.Name = "TickLabels";
            this.TickLabels.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Reference";
            // 
            // referenceEnum
            // 
            this.referenceEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referenceEnum.FormattingEnabled = true;
            this.referenceEnum.Location = new System.Drawing.Point(73, 3);
            this.referenceEnum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.referenceEnum.Name = "referenceEnum";
            this.referenceEnum.Size = new System.Drawing.Size(104, 21);
            this.referenceEnum.Sort = false;
            this.referenceEnum.TabIndex = 68;
            this.referenceEnum.ValueChanged += new System.EventHandler(this.referenceEnum_ValueChanged);
            // 
            // refTabs
            // 
            this.refTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.refTabs.Controls.Add(this.noRefPage);
            this.refTabs.Controls.Add(this.tickRefPage);
            this.refTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.refTabs.Location = new System.Drawing.Point(3, 285);
            this.refTabs.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.refTabs.Name = "refTabs";
            this.refTabs.SelectedIndex = 0;
            this.refTabs.Size = new System.Drawing.Size(214, 99);
            this.refTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.refTabs.TabIndex = 70;
            // 
            // noRefPage
            // 
            this.noRefPage.BackColor = System.Drawing.SystemColors.Control;
            this.noRefPage.Location = new System.Drawing.Point(4, 5);
            this.noRefPage.Name = "noRefPage";
            this.noRefPage.Padding = new System.Windows.Forms.Padding(3);
            this.noRefPage.Size = new System.Drawing.Size(206, 90);
            this.noRefPage.TabIndex = 0;
            this.noRefPage.Text = "None";
            // 
            // refStartAtCheckBox
            // 
            this.refStartAtCheckBox.AutoSize = true;
            this.refStartAtCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refStartAtCheckBox.Location = new System.Drawing.Point(43, 73);
            this.refStartAtCheckBox.Name = "refStartAtCheckBox";
            this.refStartAtCheckBox.Size = new System.Drawing.Size(72, 17);
            this.refStartAtCheckBox.TabIndex = 73;
            this.refStartAtCheckBox.Text = "Start here";
            this.refStartAtCheckBox.UseVisualStyleBackColor = true;
            this.refStartAtCheckBox.CheckedChanged += new System.EventHandler(this.refStartAtCheckBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Position";
            // 
            // refLocationTextBox
            // 
            this.refLocationTextBox.AutoSize = true;
            this.refLocationTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refLocationTextBox.Location = new System.Drawing.Point(101, 50);
            this.refLocationTextBox.Name = "refLocationTextBox";
            this.refLocationTextBox.Size = new System.Drawing.Size(103, 20);
            this.refLocationTextBox.TabIndex = 71;
            this.refLocationTextBox.ValueChanged += new System.EventHandler(this.refLocationTextBox_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Label";
            // 
            // refLabelTextBox
            // 
            this.refLabelTextBox.AutoSize = true;
            this.refLabelTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refLabelTextBox.Location = new System.Drawing.Point(102, 1);
            this.refLabelTextBox.Name = "refLabelTextBox";
            this.refLabelTextBox.Size = new System.Drawing.Size(103, 20);
            this.refLabelTextBox.TabIndex = 69;
            this.refLabelTextBox.ValueChanged += new System.EventHandler(this.refLabelTextBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Color";
            // 
            // refColorBox
            // 
            this.refColorBox.Location = new System.Drawing.Point(102, 25);
            this.refColorBox.Name = "refColorBox";
            this.refColorBox.Size = new System.Drawing.Size(102, 21);
            this.refColorBox.TabIndex = 68;
            this.refColorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refColorBox.ValueAsUInt = ((uint)(4294967295u));
            this.refColorBox.ValueChanged += new System.EventHandler(this.refColorBox_ValueChanged);
            // 
            // tickRefPage
            // 
            this.tickRefPage.BackColor = System.Drawing.SystemColors.Control;
            this.tickRefPage.Controls.Add(this.refStartAtCheckBox);
            this.tickRefPage.Controls.Add(this.refLocationTextBox);
            this.tickRefPage.Controls.Add(this.refColorBox);
            this.tickRefPage.Controls.Add(this.label10);
            this.tickRefPage.Controls.Add(this.label11);
            this.tickRefPage.Controls.Add(this.refLabelTextBox);
            this.tickRefPage.Controls.Add(this.label8);
            this.tickRefPage.Location = new System.Drawing.Point(4, 5);
            this.tickRefPage.Name = "tickRefPage";
            this.tickRefPage.Padding = new System.Windows.Forms.Padding(3);
            this.tickRefPage.Size = new System.Drawing.Size(206, 90);
            this.tickRefPage.TabIndex = 1;
            this.tickRefPage.Text = "Tick";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.posNumeric);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lengthNumeric);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scaleBGColorBox);
            this.panel1.Controls.Add(this.tickTypeEnum);
            this.panel1.Controls.Add(this.thumbCheckBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 125);
            this.panel1.TabIndex = 71;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.tickTabs);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.refTabs);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 384);
            this.flowLayoutPanel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.referenceEnum);
            this.panel2.Location = new System.Drawing.Point(34, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 24);
            this.panel2.TabIndex = 73;
            // 
            // ScalerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScalerControl";
            this.Size = new System.Drawing.Size(223, 390);
            this.tickTabs.ResumeLayout(false);
            this.linearPage.ResumeLayout(false);
            this.linearPage.PerformLayout();
            this.arbitraryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.refTabs.ResumeLayout(false);
            this.tickRefPage.ResumeLayout(false);
            this.tickRefPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KColorBox scaleBGColorBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private KLib.Controls.KNumericBox lengthNumeric;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox posNumeric;
        private System.Windows.Forms.CheckBox thumbCheckBox;
        private KLib.Controls.EnumDropDown tickTypeEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tickTabs;
        private System.Windows.Forms.TabPage nonePage;
        private System.Windows.Forms.TabPage linearPage;
        private System.Windows.Forms.TabPage arbitraryPage;
        private KLib.Controls.KNumericBox minNumeric;
        private KLib.Controls.KNumericBox stepNumeric;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox maxNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TickLabels;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.EnumDropDown referenceEnum;
        private System.Windows.Forms.TabControl refTabs;
        private System.Windows.Forms.TabPage noRefPage;
        private System.Windows.Forms.TabPage tickRefPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox refStartAtCheckBox;
        private System.Windows.Forms.Label label11;
        private KLib.Controls.KTextBox refLocationTextBox;
        private System.Windows.Forms.Label label10;
        private KLib.Controls.KTextBox refLabelTextBox;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KColorBox refColorBox;
    }
}
