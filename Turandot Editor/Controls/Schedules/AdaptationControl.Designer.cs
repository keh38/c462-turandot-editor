namespace Turandot_Editor.Controls
{
    partial class AdaptationControl
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
            this.trackListBox = new KLib.Controls.KUserListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.switchNumeric = new KLib.Controls.KNumericBox();
            this.ndownNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupNumeric = new KLib.Controls.KNumericBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nreverseNumeric = new KLib.Controls.KNumericBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastNumeric = new KLib.Controls.KNumericBox();
            this.label9 = new System.Windows.Forms.Label();
            this.startNumeric = new KLib.Controls.KNumericBox();
            this.label10 = new System.Windows.Forms.Label();
            this.minNumeric = new KLib.Controls.KNumericBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maxNumeric = new KLib.Controls.KNumericBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.switchDropDown = new KLib.Controls.EnumDropDown();
            this.computeDropDown = new KLib.Controls.EnumDropDown();
            this.stepmodeDropDown = new KLib.Controls.EnumDropDown();
            this.label16 = new System.Windows.Forms.Label();
            this.doallCheckBox = new System.Windows.Forms.CheckBox();
            this.pcatchNumeric = new KLib.Controls.KNumericBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.startwithNumeric = new KLib.Controls.KNumericBox();
            this.label19 = new System.Windows.Forms.Label();
            this.catchPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.catchDropDown = new KLib.Controls.EnumDropDown();
            this.trackPanel = new System.Windows.Forms.Panel();
            this.reversalsExprTextBox = new KLib.Controls.KTextBox();
            this.stepExprTextBox = new KLib.Controls.KTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.maxTrialsNumeric = new KLib.Controls.KNumericBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.thrExprBox = new System.Windows.Forms.TextBox();
            this.saveasTextBox = new System.Windows.Forms.TextBox();
            this.nblocksNumeric = new KLib.Controls.KNumericBox();
            this.label23 = new System.Windows.Forms.Label();
            this.switchPanel = new System.Windows.Forms.Panel();
            this.tracktypeDropDown = new KLib.Controls.EnumDropDown();
            this.label22 = new System.Windows.Forms.Label();
            this.maxextraNumeric = new KLib.Controls.KNumericBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cvNumeric = new KLib.Controls.KNumericBox();
            this.label25 = new System.Windows.Forms.Label();
            this.stimulusGridView = new Turandot_Editor.NestedPropertyGridView();
            this.catchVarsGridView = new Turandot_Editor.NestedPropertyGridView();
            this.testVarsGridView = new Turandot_Editor.NestedPropertyGridView();
            this.catchPanel.SuspendLayout();
            this.trackPanel.SuspendLayout();
            this.switchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackListBox
            // 
            this.trackListBox.DefaultName = "Track";
            this.trackListBox.Location = new System.Drawing.Point(10, 31);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.SelectedIndex = -1;
            this.trackListBox.Size = new System.Drawing.Size(129, 107);
            this.trackListBox.TabIndex = 0;
            this.trackListBox.SelectionChanged += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.trackListBox_SelectionChanged);
            this.trackListBox.ItemAdded += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.trackListBox_ItemAdded);
            this.trackListBox.ItemRenamed += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.trackListBox_ItemRenamed);
            this.trackListBox.ItemMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItem>(this.trackListBox_ItemMoved);
            this.trackListBox.ItemsDeleted += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.trackListBox_ItemsDeleted);
            this.trackListBox.ItemsMoved += new System.EventHandler<KLib.Controls.KUserListBox.ChangedItems>(this.trackListBox_ItemsMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Catch trials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stimulus";
            // 
            // switchNumeric
            // 
            this.switchNumeric.AllowInf = false;
            this.switchNumeric.AutoSize = true;
            this.switchNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchNumeric.ClearOnDisable = false;
            this.switchNumeric.FloatValue = 0F;
            this.switchNumeric.IntValue = 0;
            this.switchNumeric.IsInteger = false;
            this.switchNumeric.Location = new System.Drawing.Point(3, 23);
            this.switchNumeric.MaxCoerce = false;
            this.switchNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.switchNumeric.MaxValue = 1D;
            this.switchNumeric.MinCoerce = false;
            this.switchNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.switchNumeric.MinValue = 0D;
            this.switchNumeric.Name = "switchNumeric";
            this.switchNumeric.Size = new System.Drawing.Size(40, 20);
            this.switchNumeric.TabIndex = 8;
            this.switchNumeric.TextFormat = "K4";
            this.switchNumeric.ToolTip = "";
            this.switchNumeric.Units = "";
            this.switchNumeric.Value = 0D;
            this.switchNumeric.ValueChanged += new System.EventHandler(this.switchNumeric_ValueChanged);
            // 
            // ndownNumeric
            // 
            this.ndownNumeric.AllowInf = false;
            this.ndownNumeric.AutoSize = true;
            this.ndownNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ndownNumeric.ClearOnDisable = false;
            this.ndownNumeric.FloatValue = 1F;
            this.ndownNumeric.IntValue = 1;
            this.ndownNumeric.IsInteger = true;
            this.ndownNumeric.Location = new System.Drawing.Point(59, 12);
            this.ndownNumeric.MaxCoerce = false;
            this.ndownNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.ndownNumeric.MaxValue = 1000000D;
            this.ndownNumeric.MinCoerce = false;
            this.ndownNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.ndownNumeric.MinValue = 1D;
            this.ndownNumeric.Name = "ndownNumeric";
            this.ndownNumeric.Size = new System.Drawing.Size(76, 20);
            this.ndownNumeric.TabIndex = 9;
            this.ndownNumeric.TextFormat = "K4";
            this.ndownNumeric.ToolTip = "";
            this.ndownNumeric.Units = "";
            this.ndownNumeric.Value = 1D;
            this.ndownNumeric.ValueChanged += new System.EventHandler(this.ndownNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ndown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nup";
            // 
            // nupNumeric
            // 
            this.nupNumeric.AllowInf = false;
            this.nupNumeric.AutoSize = true;
            this.nupNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nupNumeric.ClearOnDisable = false;
            this.nupNumeric.FloatValue = 1F;
            this.nupNumeric.IntValue = 1;
            this.nupNumeric.IsInteger = true;
            this.nupNumeric.Location = new System.Drawing.Point(59, 38);
            this.nupNumeric.MaxCoerce = false;
            this.nupNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.nupNumeric.MaxValue = 1000000D;
            this.nupNumeric.MinCoerce = false;
            this.nupNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.nupNumeric.MinValue = 1D;
            this.nupNumeric.Name = "nupNumeric";
            this.nupNumeric.Size = new System.Drawing.Size(76, 20);
            this.nupNumeric.TabIndex = 11;
            this.nupNumeric.TextFormat = "K4";
            this.nupNumeric.ToolTip = "";
            this.nupNumeric.Units = "";
            this.nupNumeric.Value = 1D;
            this.nupNumeric.ValueChanged += new System.EventHandler(this.nupNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reversals";
            // 
            // nreverseNumeric
            // 
            this.nreverseNumeric.AllowInf = false;
            this.nreverseNumeric.AutoSize = true;
            this.nreverseNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nreverseNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.nreverseNumeric.ClearOnDisable = false;
            this.nreverseNumeric.Enabled = false;
            this.nreverseNumeric.FloatValue = 1F;
            this.nreverseNumeric.IntValue = 1;
            this.nreverseNumeric.IsInteger = false;
            this.nreverseNumeric.Location = new System.Drawing.Point(59, 64);
            this.nreverseNumeric.MaxCoerce = false;
            this.nreverseNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.nreverseNumeric.MaxValue = 1000000D;
            this.nreverseNumeric.MinCoerce = false;
            this.nreverseNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.nreverseNumeric.MinValue = 1D;
            this.nreverseNumeric.Name = "nreverseNumeric";
            this.nreverseNumeric.Size = new System.Drawing.Size(76, 20);
            this.nreverseNumeric.TabIndex = 13;
            this.nreverseNumeric.TextFormat = "K4";
            this.nreverseNumeric.ToolTip = "";
            this.nreverseNumeric.Units = "";
            this.nreverseNumeric.Value = 1D;
            this.nreverseNumeric.ValueChanged += new System.EventHandler(this.nreverseNumeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "of last";
            // 
            // lastNumeric
            // 
            this.lastNumeric.AllowInf = false;
            this.lastNumeric.AutoSize = true;
            this.lastNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lastNumeric.ClearOnDisable = false;
            this.lastNumeric.FloatValue = 1F;
            this.lastNumeric.IntValue = 1;
            this.lastNumeric.IsInteger = false;
            this.lastNumeric.Location = new System.Drawing.Point(59, 116);
            this.lastNumeric.MaxCoerce = false;
            this.lastNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.lastNumeric.MaxValue = 1000000D;
            this.lastNumeric.MinCoerce = false;
            this.lastNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.lastNumeric.MinValue = 1D;
            this.lastNumeric.Name = "lastNumeric";
            this.lastNumeric.Size = new System.Drawing.Size(76, 20);
            this.lastNumeric.TabIndex = 15;
            this.lastNumeric.TextFormat = "K4";
            this.lastNumeric.ToolTip = "";
            this.lastNumeric.Units = "";
            this.lastNumeric.Value = 1D;
            this.lastNumeric.ValueChanged += new System.EventHandler(this.lastNumeric_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Start value";
            // 
            // startNumeric
            // 
            this.startNumeric.AllowInf = false;
            this.startNumeric.AutoSize = true;
            this.startNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startNumeric.ClearOnDisable = false;
            this.startNumeric.FloatValue = 0F;
            this.startNumeric.IntValue = 0;
            this.startNumeric.IsInteger = false;
            this.startNumeric.Location = new System.Drawing.Point(211, 12);
            this.startNumeric.MaxCoerce = false;
            this.startNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.startNumeric.MaxValue = 2E+24D;
            this.startNumeric.MinCoerce = false;
            this.startNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.startNumeric.MinValue = -2E+24D;
            this.startNumeric.Name = "startNumeric";
            this.startNumeric.Size = new System.Drawing.Size(76, 20);
            this.startNumeric.TabIndex = 17;
            this.startNumeric.TextFormat = "K4";
            this.startNumeric.ToolTip = "";
            this.startNumeric.Units = "";
            this.startNumeric.Value = 0D;
            this.startNumeric.ValueChanged += new System.EventHandler(this.startNumeric_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Min value";
            // 
            // minNumeric
            // 
            this.minNumeric.AllowInf = false;
            this.minNumeric.AutoSize = true;
            this.minNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minNumeric.ClearOnDisable = false;
            this.minNumeric.FloatValue = 0F;
            this.minNumeric.IntValue = 0;
            this.minNumeric.IsInteger = false;
            this.minNumeric.Location = new System.Drawing.Point(211, 37);
            this.minNumeric.MaxCoerce = false;
            this.minNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.minNumeric.MaxValue = 2E+24D;
            this.minNumeric.MinCoerce = false;
            this.minNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.minNumeric.MinValue = -2E+24D;
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(76, 20);
            this.minNumeric.TabIndex = 19;
            this.minNumeric.TextFormat = "K4";
            this.minNumeric.ToolTip = "";
            this.minNumeric.Units = "";
            this.minNumeric.Value = 0D;
            this.minNumeric.ValueChanged += new System.EventHandler(this.minNumeric_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Max value";
            // 
            // maxNumeric
            // 
            this.maxNumeric.AllowInf = false;
            this.maxNumeric.AutoSize = true;
            this.maxNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxNumeric.ClearOnDisable = false;
            this.maxNumeric.FloatValue = 0F;
            this.maxNumeric.IntValue = 0;
            this.maxNumeric.IsInteger = false;
            this.maxNumeric.Location = new System.Drawing.Point(211, 60);
            this.maxNumeric.MaxCoerce = false;
            this.maxNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxNumeric.MaxValue = 2E+24D;
            this.maxNumeric.MinCoerce = false;
            this.maxNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxNumeric.MinValue = -2E+24D;
            this.maxNumeric.Name = "maxNumeric";
            this.maxNumeric.Size = new System.Drawing.Size(76, 20);
            this.maxNumeric.TabIndex = 21;
            this.maxNumeric.TextFormat = "K4";
            this.maxNumeric.ToolTip = "";
            this.maxNumeric.Units = "";
            this.maxNumeric.Value = 0D;
            this.maxNumeric.ValueChanged += new System.EventHandler(this.maxNumeric_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Step mode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Step size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Reversals";
            // 
            // switchDropDown
            // 
            this.switchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchDropDown.FormattingEnabled = true;
            this.switchDropDown.Location = new System.Drawing.Point(49, 22);
            this.switchDropDown.Name = "switchDropDown";
            this.switchDropDown.Size = new System.Drawing.Size(82, 21);
            this.switchDropDown.Sort = false;
            this.switchDropDown.TabIndex = 30;
            this.switchDropDown.ValueChanged += new System.EventHandler(this.switchDropDown_ValueChanged);
            // 
            // computeDropDown
            // 
            this.computeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.computeDropDown.FormattingEnabled = true;
            this.computeDropDown.Location = new System.Drawing.Point(59, 93);
            this.computeDropDown.Name = "computeDropDown";
            this.computeDropDown.Size = new System.Drawing.Size(76, 21);
            this.computeDropDown.Sort = false;
            this.computeDropDown.TabIndex = 31;
            this.computeDropDown.ValueChanged += new System.EventHandler(this.computeDropDown_ValueChanged);
            // 
            // stepmodeDropDown
            // 
            this.stepmodeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepmodeDropDown.FormattingEnabled = true;
            this.stepmodeDropDown.Location = new System.Drawing.Point(211, 84);
            this.stepmodeDropDown.Name = "stepmodeDropDown";
            this.stepmodeDropDown.Size = new System.Drawing.Size(76, 21);
            this.stepmodeDropDown.Sort = false;
            this.stepmodeDropDown.TabIndex = 32;
            this.stepmodeDropDown.ValueChanged += new System.EventHandler(this.stepmodeDropDown_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Compute";
            // 
            // doallCheckBox
            // 
            this.doallCheckBox.AutoSize = true;
            this.doallCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doallCheckBox.Location = new System.Drawing.Point(3, 15);
            this.doallCheckBox.Name = "doallCheckBox";
            this.doallCheckBox.Size = new System.Drawing.Size(53, 17);
            this.doallCheckBox.TabIndex = 34;
            this.doallCheckBox.Text = "Do all";
            this.doallCheckBox.UseVisualStyleBackColor = true;
            this.doallCheckBox.CheckedChanged += new System.EventHandler(this.doallCheckBox_CheckedChanged);
            // 
            // pcatchNumeric
            // 
            this.pcatchNumeric.AllowInf = false;
            this.pcatchNumeric.AutoSize = true;
            this.pcatchNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pcatchNumeric.ClearOnDisable = false;
            this.pcatchNumeric.FloatValue = 0F;
            this.pcatchNumeric.IntValue = 0;
            this.pcatchNumeric.IsInteger = false;
            this.pcatchNumeric.Location = new System.Drawing.Point(268, 12);
            this.pcatchNumeric.MaxCoerce = false;
            this.pcatchNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.pcatchNumeric.MaxValue = 1D;
            this.pcatchNumeric.MinCoerce = false;
            this.pcatchNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.pcatchNumeric.MinValue = 0D;
            this.pcatchNumeric.Name = "pcatchNumeric";
            this.pcatchNumeric.Size = new System.Drawing.Size(38, 20);
            this.pcatchNumeric.TabIndex = 35;
            this.pcatchNumeric.TextFormat = "K4";
            this.pcatchNumeric.ToolTip = "";
            this.pcatchNumeric.Units = "";
            this.pcatchNumeric.Value = 0D;
            this.pcatchNumeric.ValueChanged += new System.EventHandler(this.pcatchNumeric_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "P(catch)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Start with";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startwithNumeric
            // 
            this.startwithNumeric.AllowInf = false;
            this.startwithNumeric.AutoSize = true;
            this.startwithNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startwithNumeric.ClearOnDisable = false;
            this.startwithNumeric.FloatValue = 0F;
            this.startwithNumeric.IntValue = 0;
            this.startwithNumeric.IsInteger = true;
            this.startwithNumeric.Location = new System.Drawing.Point(366, 12);
            this.startwithNumeric.MaxCoerce = false;
            this.startwithNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.startwithNumeric.MaxValue = 1000000D;
            this.startwithNumeric.MinCoerce = false;
            this.startwithNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.startwithNumeric.MinValue = 0D;
            this.startwithNumeric.Name = "startwithNumeric";
            this.startwithNumeric.Size = new System.Drawing.Size(37, 20);
            this.startwithNumeric.TabIndex = 37;
            this.startwithNumeric.TextFormat = "K4";
            this.startwithNumeric.ToolTip = "";
            this.startwithNumeric.Units = "";
            this.startwithNumeric.Value = 0D;
            this.startwithNumeric.ValueChanged += new System.EventHandler(this.startwithNumeric_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Switch after";
            // 
            // catchPanel
            // 
            this.catchPanel.AutoSize = true;
            this.catchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.catchPanel.Controls.Add(this.label20);
            this.catchPanel.Controls.Add(this.catchDropDown);
            this.catchPanel.Controls.Add(this.pcatchNumeric);
            this.catchPanel.Controls.Add(this.doallCheckBox);
            this.catchPanel.Controls.Add(this.label18);
            this.catchPanel.Controls.Add(this.label17);
            this.catchPanel.Controls.Add(this.startwithNumeric);
            this.catchPanel.Location = new System.Drawing.Point(140, 506);
            this.catchPanel.Name = "catchPanel";
            this.catchPanel.Size = new System.Drawing.Size(406, 36);
            this.catchPanel.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(59, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "after each";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // catchDropDown
            // 
            this.catchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catchDropDown.FormattingEnabled = true;
            this.catchDropDown.Location = new System.Drawing.Point(116, 12);
            this.catchDropDown.Name = "catchDropDown";
            this.catchDropDown.Size = new System.Drawing.Size(98, 21);
            this.catchDropDown.Sort = false;
            this.catchDropDown.TabIndex = 40;
            this.catchDropDown.ValueChanged += new System.EventHandler(this.catchDropDown_ValueChanged);
            // 
            // trackPanel
            // 
            this.trackPanel.AutoSize = true;
            this.trackPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackPanel.Controls.Add(this.reversalsExprTextBox);
            this.trackPanel.Controls.Add(this.stepExprTextBox);
            this.trackPanel.Controls.Add(this.label27);
            this.trackPanel.Controls.Add(this.maxTrialsNumeric);
            this.trackPanel.Controls.Add(this.label26);
            this.trackPanel.Controls.Add(this.label21);
            this.trackPanel.Controls.Add(this.thrExprBox);
            this.trackPanel.Controls.Add(this.saveasTextBox);
            this.trackPanel.Controls.Add(this.startNumeric);
            this.trackPanel.Controls.Add(this.ndownNumeric);
            this.trackPanel.Controls.Add(this.label5);
            this.trackPanel.Controls.Add(this.label16);
            this.trackPanel.Controls.Add(this.nupNumeric);
            this.trackPanel.Controls.Add(this.stepmodeDropDown);
            this.trackPanel.Controls.Add(this.label6);
            this.trackPanel.Controls.Add(this.computeDropDown);
            this.trackPanel.Controls.Add(this.nreverseNumeric);
            this.trackPanel.Controls.Add(this.label7);
            this.trackPanel.Controls.Add(this.lastNumeric);
            this.trackPanel.Controls.Add(this.label14);
            this.trackPanel.Controls.Add(this.label8);
            this.trackPanel.Controls.Add(this.label9);
            this.trackPanel.Controls.Add(this.label13);
            this.trackPanel.Controls.Add(this.minNumeric);
            this.trackPanel.Controls.Add(this.label10);
            this.trackPanel.Controls.Add(this.label12);
            this.trackPanel.Controls.Add(this.maxNumeric);
            this.trackPanel.Controls.Add(this.label11);
            this.trackPanel.Location = new System.Drawing.Point(180, 81);
            this.trackPanel.Name = "trackPanel";
            this.trackPanel.Size = new System.Drawing.Size(355, 189);
            this.trackPanel.TabIndex = 41;
            // 
            // reversalsExprTextBox
            // 
            this.reversalsExprTextBox.AutoSize = true;
            this.reversalsExprTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reversalsExprTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.reversalsExprTextBox.IsIPAddress = false;
            this.reversalsExprTextBox.Location = new System.Drawing.Point(211, 132);
            this.reversalsExprTextBox.Name = "reversalsExprTextBox";
            this.reversalsExprTextBox.Size = new System.Drawing.Size(141, 20);
            this.reversalsExprTextBox.TabIndex = 58;
            this.reversalsExprTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reversalsExprTextBox.ValueChanged += new System.EventHandler(this.reversalsExprTextBox_ValueChanged);
            // 
            // stepExprTextBox
            // 
            this.stepExprTextBox.AutoSize = true;
            this.stepExprTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stepExprTextBox.FontColor = System.Drawing.SystemColors.WindowText;
            this.stepExprTextBox.IsIPAddress = false;
            this.stepExprTextBox.Location = new System.Drawing.Point(211, 109);
            this.stepExprTextBox.Name = "stepExprTextBox";
            this.stepExprTextBox.Size = new System.Drawing.Size(141, 20);
            this.stepExprTextBox.TabIndex = 57;
            this.stepExprTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stepExprTextBox.ValueChanged += new System.EventHandler(this.stepExprTextBox_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "Max trials";
            // 
            // maxTrialsNumeric
            // 
            this.maxTrialsNumeric.AllowInf = false;
            this.maxTrialsNumeric.AutoSize = true;
            this.maxTrialsNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxTrialsNumeric.ClearOnDisable = false;
            this.maxTrialsNumeric.FloatValue = 1F;
            this.maxTrialsNumeric.IntValue = 1;
            this.maxTrialsNumeric.IsInteger = false;
            this.maxTrialsNumeric.Location = new System.Drawing.Point(59, 141);
            this.maxTrialsNumeric.MaxCoerce = false;
            this.maxTrialsNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxTrialsNumeric.MaxValue = 1000000D;
            this.maxTrialsNumeric.MinCoerce = false;
            this.maxTrialsNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxTrialsNumeric.MinValue = 1D;
            this.maxTrialsNumeric.Name = "maxTrialsNumeric";
            this.maxTrialsNumeric.Size = new System.Drawing.Size(76, 20);
            this.maxTrialsNumeric.TabIndex = 53;
            this.maxTrialsNumeric.TextFormat = "K4";
            this.maxTrialsNumeric.ToolTip = "";
            this.maxTrialsNumeric.Units = "";
            this.maxTrialsNumeric.Value = 1D;
            this.maxTrialsNumeric.ValueChanged += new System.EventHandler(this.maxTrialsNumeric_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(182, 168);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "T =";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "Save as";
            // 
            // thrExprBox
            // 
            this.thrExprBox.Location = new System.Drawing.Point(211, 165);
            this.thrExprBox.Name = "thrExprBox";
            this.thrExprBox.Size = new System.Drawing.Size(141, 20);
            this.thrExprBox.TabIndex = 51;
            this.thrExprBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thrExprBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.threxprBox_KeyPress);
            // 
            // saveasTextBox
            // 
            this.saveasTextBox.Location = new System.Drawing.Point(59, 166);
            this.saveasTextBox.Name = "saveasTextBox";
            this.saveasTextBox.Size = new System.Drawing.Size(76, 20);
            this.saveasTextBox.TabIndex = 43;
            this.saveasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saveasTextBox_KeyPress);
            // 
            // nblocksNumeric
            // 
            this.nblocksNumeric.AllowInf = false;
            this.nblocksNumeric.AutoSize = true;
            this.nblocksNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nblocksNumeric.ClearOnDisable = false;
            this.nblocksNumeric.FloatValue = 1F;
            this.nblocksNumeric.IntValue = 1;
            this.nblocksNumeric.IsInteger = true;
            this.nblocksNumeric.Location = new System.Drawing.Point(56, 178);
            this.nblocksNumeric.MaxCoerce = false;
            this.nblocksNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.nblocksNumeric.MaxValue = 1000000D;
            this.nblocksNumeric.MinCoerce = false;
            this.nblocksNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.nblocksNumeric.MinValue = 1D;
            this.nblocksNumeric.Name = "nblocksNumeric";
            this.nblocksNumeric.Size = new System.Drawing.Size(85, 20);
            this.nblocksNumeric.TabIndex = 45;
            this.nblocksNumeric.TextFormat = "";
            this.nblocksNumeric.ToolTip = "";
            this.nblocksNumeric.Units = "";
            this.nblocksNumeric.Value = 1D;
            this.nblocksNumeric.ValueChanged += new System.EventHandler(this.nblocksNumeric_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Blocks";
            // 
            // switchPanel
            // 
            this.switchPanel.AutoSize = true;
            this.switchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchPanel.Controls.Add(this.switchNumeric);
            this.switchPanel.Controls.Add(this.switchDropDown);
            this.switchPanel.Controls.Add(this.label19);
            this.switchPanel.Location = new System.Drawing.Point(7, 126);
            this.switchPanel.Name = "switchPanel";
            this.switchPanel.Size = new System.Drawing.Size(134, 46);
            this.switchPanel.TabIndex = 42;
            // 
            // tracktypeDropDown
            // 
            this.tracktypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tracktypeDropDown.FormattingEnabled = true;
            this.tracktypeDropDown.Location = new System.Drawing.Point(418, 8);
            this.tracktypeDropDown.Name = "tracktypeDropDown";
            this.tracktypeDropDown.Size = new System.Drawing.Size(121, 21);
            this.tracktypeDropDown.Sort = false;
            this.tracktypeDropDown.TabIndex = 43;
            this.tracktypeDropDown.ValueChanged += new System.EventHandler(this.tracktypeDropDown_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(354, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Track type";
            // 
            // maxextraNumeric
            // 
            this.maxextraNumeric.AllowInf = false;
            this.maxextraNumeric.AutoSize = true;
            this.maxextraNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxextraNumeric.ClearOnDisable = false;
            this.maxextraNumeric.FloatValue = 1F;
            this.maxextraNumeric.IntValue = 1;
            this.maxextraNumeric.IsInteger = true;
            this.maxextraNumeric.Location = new System.Drawing.Point(56, 223);
            this.maxextraNumeric.MaxCoerce = false;
            this.maxextraNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxextraNumeric.MaxValue = 1000000D;
            this.maxextraNumeric.MinCoerce = false;
            this.maxextraNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxextraNumeric.MinValue = 0D;
            this.maxextraNumeric.Name = "maxextraNumeric";
            this.maxextraNumeric.Size = new System.Drawing.Size(85, 20);
            this.maxextraNumeric.TabIndex = 47;
            this.maxextraNumeric.TextFormat = "K4";
            this.maxextraNumeric.ToolTip = "";
            this.maxextraNumeric.Units = "";
            this.maxextraNumeric.Value = 1D;
            this.maxextraNumeric.ValueChanged += new System.EventHandler(this.maxextraNumeric_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 227);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Max extra";
            // 
            // cvNumeric
            // 
            this.cvNumeric.AllowInf = false;
            this.cvNumeric.AutoSize = true;
            this.cvNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvNumeric.ClearOnDisable = false;
            this.cvNumeric.FloatValue = 1F;
            this.cvNumeric.IntValue = 1;
            this.cvNumeric.IsInteger = false;
            this.cvNumeric.Location = new System.Drawing.Point(56, 200);
            this.cvNumeric.MaxCoerce = false;
            this.cvNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.cvNumeric.MaxValue = 1000000D;
            this.cvNumeric.MinCoerce = false;
            this.cvNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.cvNumeric.MinValue = 0D;
            this.cvNumeric.Name = "cvNumeric";
            this.cvNumeric.Size = new System.Drawing.Size(85, 20);
            this.cvNumeric.TabIndex = 49;
            this.cvNumeric.TextFormat = "K4";
            this.cvNumeric.ToolTip = "";
            this.cvNumeric.Units = "";
            this.cvNumeric.Value = 1D;
            this.cvNumeric.ValueChanged += new System.EventHandler(this.cvNumeric_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "CV";
            // 
            // stimulusGridView
            // 
            this.stimulusGridView.AllowUserToDeleteRows = false;
            this.stimulusGridView.Location = new System.Drawing.Point(236, 31);
            this.stimulusGridView.MaxNumberRows = 1;
            this.stimulusGridView.Name = "stimulusGridView";
            this.stimulusGridView.ShowDim = false;
            this.stimulusGridView.ShowExpr = false;
            this.stimulusGridView.Size = new System.Drawing.Size(333, 57);
            this.stimulusGridView.TabIndex = 4;
            this.stimulusGridView.Value = null;
            this.stimulusGridView.ValueChanged += new System.EventHandler(this.stimulusGridView_ValueChanged);
            // 
            // catchVarsGridView
            // 
            this.catchVarsGridView.AllowUserToDeleteRows = true;
            this.catchVarsGridView.Location = new System.Drawing.Point(15, 543);
            this.catchVarsGridView.MaxNumberRows = 0;
            this.catchVarsGridView.Name = "catchVarsGridView";
            this.catchVarsGridView.ShowDim = false;
            this.catchVarsGridView.ShowExpr = true;
            this.catchVarsGridView.Size = new System.Drawing.Size(539, 95);
            this.catchVarsGridView.TabIndex = 3;
            this.catchVarsGridView.Value = null;
            this.catchVarsGridView.ValueChanged += new System.EventHandler(this.catchVarsGridView_ValueChanged);
            // 
            // testVarsGridView
            // 
            this.testVarsGridView.AllowUserToDeleteRows = true;
            this.testVarsGridView.Location = new System.Drawing.Point(-3, 282);
            this.testVarsGridView.MaxNumberRows = 0;
            this.testVarsGridView.Name = "testVarsGridView";
            this.testVarsGridView.ShowDim = true;
            this.testVarsGridView.ShowExpr = true;
            this.testVarsGridView.Size = new System.Drawing.Size(619, 218);
            this.testVarsGridView.TabIndex = 2;
            this.testVarsGridView.Value = null;
            this.testVarsGridView.ValueChanged += new System.EventHandler(this.testVarsGridView_ValueChanged);
            // 
            // AdaptationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cvNumeric);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.maxextraNumeric);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.nblocksNumeric);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tracktypeDropDown);
            this.Controls.Add(this.switchPanel);
            this.Controls.Add(this.trackPanel);
            this.Controls.Add(this.catchPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stimulusGridView);
            this.Controls.Add(this.catchVarsGridView);
            this.Controls.Add(this.testVarsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackListBox);
            this.Name = "AdaptationControl";
            this.Size = new System.Drawing.Size(619, 649);
            this.catchPanel.ResumeLayout(false);
            this.catchPanel.PerformLayout();
            this.trackPanel.ResumeLayout(false);
            this.trackPanel.PerformLayout();
            this.switchPanel.ResumeLayout(false);
            this.switchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KUserListBox trackListBox;
        private System.Windows.Forms.Label label1;
        private NestedPropertyGridView testVarsGridView;
        private NestedPropertyGridView catchVarsGridView;
        private NestedPropertyGridView stimulusGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox switchNumeric;
        private KLib.Controls.KNumericBox ndownNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox nupNumeric;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.KNumericBox nreverseNumeric;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KNumericBox lastNumeric;
        private System.Windows.Forms.Label label9;
        private KLib.Controls.KNumericBox startNumeric;
        private System.Windows.Forms.Label label10;
        private KLib.Controls.KNumericBox minNumeric;
        private System.Windows.Forms.Label label11;
        private KLib.Controls.KNumericBox maxNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private KLib.Controls.EnumDropDown switchDropDown;
        private KLib.Controls.EnumDropDown computeDropDown;
        private KLib.Controls.EnumDropDown stepmodeDropDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox doallCheckBox;
        private KLib.Controls.KNumericBox pcatchNumeric;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private KLib.Controls.KNumericBox startwithNumeric;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel catchPanel;
        private System.Windows.Forms.Panel trackPanel;
        private System.Windows.Forms.Panel switchPanel;
        private System.Windows.Forms.Label label20;
        private KLib.Controls.EnumDropDown catchDropDown;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox saveasTextBox;
        private KLib.Controls.EnumDropDown tracktypeDropDown;
        private System.Windows.Forms.Label label22;
        private KLib.Controls.KNumericBox nblocksNumeric;
        private System.Windows.Forms.Label label23;
        private KLib.Controls.KNumericBox maxextraNumeric;
        private System.Windows.Forms.Label label24;
        private KLib.Controls.KNumericBox cvNumeric;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox thrExprBox;
        private System.Windows.Forms.Label label27;
        private KLib.Controls.KNumericBox maxTrialsNumeric;
        private KLib.Controls.KTextBox stepExprTextBox;
        private KLib.Controls.KTextBox reversalsExprTextBox;
    }
}
