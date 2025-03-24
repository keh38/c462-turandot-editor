namespace Turandot_Editor.Controls
{
    partial class InputControl
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
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.enableCheckBox = new KLib.Controls.KCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.catPage = new System.Windows.Forms.TabPage();
            this.catApplyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.catBox = new System.Windows.Forms.TextBox();
            this.grapherPage = new System.Windows.Forms.TabPage();
            this.grapherActionControl = new Turandot_Editor.Controls.Inputs.GrapherActionControl();
            this.keypadPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.kpBackgroundColorBox = new System.Windows.Forms.PictureBox();
            this.paramSliderPage = new System.Windows.Forms.TabPage();
            this.paramSliderActionControl = new Turandot_Editor.Controls.Inputs.ParamSliderActionControl();
            this.randomProcessPage = new System.Windows.Forms.TabPage();
            this.randomProcessControl = new Turandot_Editor.Controls.Inputs.RandomProcessControl();
            this.samPage = new System.Windows.Forms.TabPage();
            this.samControl = new Turandot_Editor.Controls.AllSAMControl();
            this.scalePage = new System.Windows.Forms.TabPage();
            this.scalerControl = new Turandot_Editor.Controls.Inputs.ScalerControl();
            this.thumbSliderPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tsInitPosNumeric = new KLib.Controls.KNumericBox();
            this.buttonPage = new System.Windows.Forms.TabPage();
            this.buttonActionControl = new Turandot_Editor.Controls.Inputs.ButtonActionControl();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.generalPanel.SuspendLayout();
            this.positionPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.catPage.SuspendLayout();
            this.grapherPage.SuspendLayout();
            this.keypadPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpBackgroundColorBox)).BeginInit();
            this.paramSliderPage.SuspendLayout();
            this.randomProcessPage.SuspendLayout();
            this.samPage.SuspendLayout();
            this.scalePage.SuspendLayout();
            this.thumbSliderPage.SuspendLayout();
            this.buttonPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.startComboBox.Location = new System.Drawing.Point(82, 16);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(104, 21);
            this.startComboBox.TabIndex = 28;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Action";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "X";
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(37, 3);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 1000000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = -100000000D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(38, 20);
            this.xNumeric.TabIndex = 31;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "State end";
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.endComboBox.Location = new System.Drawing.Point(82, 42);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(104, 21);
            this.endComboBox.TabIndex = 34;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Location = new System.Drawing.Point(74, 122);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enableCheckBox.Size = new System.Drawing.Size(83, 30);
            this.enableCheckBox.TabIndex = 37;
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Y";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(101, 3);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 1000000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = -100000000D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(40, 20);
            this.yNumeric.TabIndex = 39;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // labelBox
            // 
            this.labelBox.Location = new System.Drawing.Point(82, 96);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(104, 20);
            this.labelBox.TabIndex = 40;
            this.labelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelBox_KeyPress);
            this.labelBox.Leave += new System.EventHandler(this.labelBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Label";
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.positionPanel);
            this.generalPanel.Controls.Add(this.label5);
            this.generalPanel.Controls.Add(this.startComboBox);
            this.generalPanel.Controls.Add(this.enableCheckBox);
            this.generalPanel.Controls.Add(this.label4);
            this.generalPanel.Controls.Add(this.label2);
            this.generalPanel.Controls.Add(this.labelBox);
            this.generalPanel.Controls.Add(this.endComboBox);
            this.generalPanel.Controls.Add(this.label3);
            this.generalPanel.Location = new System.Drawing.Point(161, 3);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(196, 162);
            this.generalPanel.TabIndex = 42;
            // 
            // positionPanel
            // 
            this.positionPanel.AutoSize = true;
            this.positionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.positionPanel.Controls.Add(this.yNumeric);
            this.positionPanel.Controls.Add(this.label11);
            this.positionPanel.Controls.Add(this.label1);
            this.positionPanel.Controls.Add(this.xNumeric);
            this.positionPanel.Location = new System.Drawing.Point(45, 66);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(144, 26);
            this.positionPanel.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Enabled";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.catPage);
            this.tabControl.Controls.Add(this.grapherPage);
            this.tabControl.Controls.Add(this.keypadPage);
            this.tabControl.Controls.Add(this.paramSliderPage);
            this.tabControl.Controls.Add(this.randomProcessPage);
            this.tabControl.Controls.Add(this.samPage);
            this.tabControl.Controls.Add(this.scalePage);
            this.tabControl.Controls.Add(this.thumbSliderPage);
            this.tabControl.Controls.Add(this.buttonPage);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(3, 167);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(354, 417);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 43;
            // 
            // catPage
            // 
            this.catPage.BackColor = System.Drawing.SystemColors.Control;
            this.catPage.Controls.Add(this.catApplyButton);
            this.catPage.Controls.Add(this.label7);
            this.catPage.Controls.Add(this.catBox);
            this.catPage.Location = new System.Drawing.Point(4, 5);
            this.catPage.Name = "catPage";
            this.catPage.Padding = new System.Windows.Forms.Padding(3);
            this.catPage.Size = new System.Drawing.Size(346, 408);
            this.catPage.TabIndex = 0;
            this.catPage.Text = " Categorizer";
            // 
            // catApplyButton
            // 
            this.catApplyButton.Location = new System.Drawing.Point(119, 134);
            this.catApplyButton.Name = "catApplyButton";
            this.catApplyButton.Size = new System.Drawing.Size(75, 23);
            this.catApplyButton.TabIndex = 44;
            this.catApplyButton.Text = "Apply";
            this.catApplyButton.UseVisualStyleBackColor = true;
            this.catApplyButton.Click += new System.EventHandler(this.catApplyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Categories";
            // 
            // catBox
            // 
            this.catBox.Location = new System.Drawing.Point(200, 16);
            this.catBox.Multiline = true;
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(139, 141);
            this.catBox.TabIndex = 0;
            this.catBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.catBox_KeyPress);
            // 
            // grapherPage
            // 
            this.grapherPage.Controls.Add(this.grapherActionControl);
            this.grapherPage.Location = new System.Drawing.Point(4, 5);
            this.grapherPage.Name = "grapherPage";
            this.grapherPage.Size = new System.Drawing.Size(346, 408);
            this.grapherPage.TabIndex = 6;
            this.grapherPage.Text = "Grapher";
            this.grapherPage.UseVisualStyleBackColor = true;
            // 
            // grapherActionControl
            // 
            this.grapherActionControl.Location = new System.Drawing.Point(181, 3);
            this.grapherActionControl.Name = "grapherActionControl";
            this.grapherActionControl.Size = new System.Drawing.Size(150, 49);
            this.grapherActionControl.TabIndex = 0;
            this.grapherActionControl.Value = null;
            this.grapherActionControl.ValueChanged += new System.EventHandler(this.grapherActionControl_ValueChanged);
            // 
            // keypadPage
            // 
            this.keypadPage.Controls.Add(this.label10);
            this.keypadPage.Controls.Add(this.kpBackgroundColorBox);
            this.keypadPage.Location = new System.Drawing.Point(4, 5);
            this.keypadPage.Name = "keypadPage";
            this.keypadPage.Size = new System.Drawing.Size(346, 408);
            this.keypadPage.TabIndex = 4;
            this.keypadPage.Text = "keypad";
            this.keypadPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Background color";
            // 
            // kpBackgroundColorBox
            // 
            this.kpBackgroundColorBox.BackColor = System.Drawing.Color.Yellow;
            this.kpBackgroundColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpBackgroundColorBox.Location = new System.Drawing.Point(236, 12);
            this.kpBackgroundColorBox.Name = "kpBackgroundColorBox";
            this.kpBackgroundColorBox.Size = new System.Drawing.Size(104, 21);
            this.kpBackgroundColorBox.TabIndex = 35;
            this.kpBackgroundColorBox.TabStop = false;
            this.kpBackgroundColorBox.Click += new System.EventHandler(this.kpBackgroundColorBox_Click);
            // 
            // paramSliderPage
            // 
            this.paramSliderPage.Controls.Add(this.paramSliderActionControl);
            this.paramSliderPage.Location = new System.Drawing.Point(4, 5);
            this.paramSliderPage.Name = "paramSliderPage";
            this.paramSliderPage.Size = new System.Drawing.Size(346, 408);
            this.paramSliderPage.TabIndex = 7;
            this.paramSliderPage.Text = "Param slider";
            this.paramSliderPage.UseVisualStyleBackColor = true;
            // 
            // paramSliderActionControl
            // 
            this.paramSliderActionControl.AutoSize = true;
            this.paramSliderActionControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paramSliderActionControl.Location = new System.Drawing.Point(11, 3);
            this.paramSliderActionControl.Name = "paramSliderActionControl";
            this.paramSliderActionControl.Size = new System.Drawing.Size(329, 266);
            this.paramSliderActionControl.TabIndex = 0;
            this.paramSliderActionControl.Value = null;
            this.paramSliderActionControl.ValueChanged += new System.EventHandler(this.paramSliderActionControl_ValueChanged);
            // 
            // randomProcessPage
            // 
            this.randomProcessPage.Controls.Add(this.randomProcessControl);
            this.randomProcessPage.Location = new System.Drawing.Point(4, 5);
            this.randomProcessPage.Name = "randomProcessPage";
            this.randomProcessPage.Size = new System.Drawing.Size(346, 408);
            this.randomProcessPage.TabIndex = 8;
            this.randomProcessPage.Text = "Random process";
            this.randomProcessPage.UseVisualStyleBackColor = true;
            // 
            // randomProcessControl
            // 
            this.randomProcessControl.Location = new System.Drawing.Point(54, 13);
            this.randomProcessControl.Name = "randomProcessControl";
            this.randomProcessControl.Size = new System.Drawing.Size(286, 65);
            this.randomProcessControl.TabIndex = 0;
            this.randomProcessControl.Value = null;
            this.randomProcessControl.ValueChanged += new System.EventHandler(this.randomProcessControl_ValueChanged);
            // 
            // samPage
            // 
            this.samPage.Controls.Add(this.samControl);
            this.samPage.Location = new System.Drawing.Point(4, 5);
            this.samPage.Name = "samPage";
            this.samPage.Padding = new System.Windows.Forms.Padding(3);
            this.samPage.Size = new System.Drawing.Size(346, 408);
            this.samPage.TabIndex = 3;
            this.samPage.Text = "sam";
            this.samPage.UseVisualStyleBackColor = true;
            // 
            // samControl
            // 
            this.samControl.AutoSize = true;
            this.samControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.samControl.Location = new System.Drawing.Point(0, 6);
            this.samControl.Name = "samControl";
            this.samControl.Size = new System.Drawing.Size(348, 190);
            this.samControl.TabIndex = 0;
            this.samControl.Value = null;
            this.samControl.ValueChanged += new System.EventHandler(this.samControl_ValueChanged);
            // 
            // scalePage
            // 
            this.scalePage.BackColor = System.Drawing.SystemColors.Control;
            this.scalePage.Controls.Add(this.scalerControl);
            this.scalePage.Location = new System.Drawing.Point(4, 5);
            this.scalePage.Name = "scalePage";
            this.scalePage.Padding = new System.Windows.Forms.Padding(3);
            this.scalePage.Size = new System.Drawing.Size(346, 408);
            this.scalePage.TabIndex = 1;
            this.scalePage.Text = "scaler";
            // 
            // scalerControl
            // 
            this.scalerControl.AutoSize = true;
            this.scalerControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scalerControl.Location = new System.Drawing.Point(126, 3);
            this.scalerControl.Name = "scalerControl";
            this.scalerControl.Size = new System.Drawing.Size(223, 390);
            this.scalerControl.TabIndex = 0;
            this.scalerControl.Value = null;
            this.scalerControl.ValueChanged += new System.EventHandler(this.scalerControl_ValueChanged);
            // 
            // thumbSliderPage
            // 
            this.thumbSliderPage.Controls.Add(this.label14);
            this.thumbSliderPage.Controls.Add(this.tsInitPosNumeric);
            this.thumbSliderPage.Location = new System.Drawing.Point(4, 5);
            this.thumbSliderPage.Name = "thumbSliderPage";
            this.thumbSliderPage.Size = new System.Drawing.Size(346, 408);
            this.thumbSliderPage.TabIndex = 5;
            this.thumbSliderPage.Text = "Thumb slider";
            this.thumbSliderPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Initial position (0-1)";
            // 
            // tsInitPosNumeric
            // 
            this.tsInitPosNumeric.AutoSize = true;
            this.tsInitPosNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tsInitPosNumeric.FloatValue = 0F;
            this.tsInitPosNumeric.IntValue = 0;
            this.tsInitPosNumeric.IsInteger = false;
            this.tsInitPosNumeric.Location = new System.Drawing.Point(236, 12);
            this.tsInitPosNumeric.MaxCoerce = false;
            this.tsInitPosNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.tsInitPosNumeric.MaxValue = 1D;
            this.tsInitPosNumeric.MinCoerce = false;
            this.tsInitPosNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.tsInitPosNumeric.MinValue = 0D;
            this.tsInitPosNumeric.Name = "tsInitPosNumeric";
            this.tsInitPosNumeric.Size = new System.Drawing.Size(104, 20);
            this.tsInitPosNumeric.TabIndex = 46;
            this.tsInitPosNumeric.TextFormat = "K4";
            this.tsInitPosNumeric.Units = "";
            this.tsInitPosNumeric.Value = 0D;
            this.tsInitPosNumeric.ValueChanged += new System.EventHandler(this.tsInitPosNumeric_ValueChanged);
            // 
            // buttonPage
            // 
            this.buttonPage.Controls.Add(this.buttonActionControl);
            this.buttonPage.Location = new System.Drawing.Point(4, 5);
            this.buttonPage.Name = "buttonPage";
            this.buttonPage.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPage.Size = new System.Drawing.Size(346, 408);
            this.buttonPage.TabIndex = 2;
            this.buttonPage.Text = "tabPage1";
            this.buttonPage.UseVisualStyleBackColor = true;
            // 
            // buttonActionControl
            // 
            this.buttonActionControl.AutoSize = true;
            this.buttonActionControl.Location = new System.Drawing.Point(188, 6);
            this.buttonActionControl.Name = "buttonActionControl";
            this.buttonActionControl.Size = new System.Drawing.Size(157, 193);
            this.buttonActionControl.TabIndex = 32;
            this.buttonActionControl.Value = null;
            this.buttonActionControl.ValueChanged += new System.EventHandler(this.buttonActionControl_ValueChanged);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.IntegralHeight = false;
            this.listBox.Items.AddRange(new object[] {
            "Categorizer",
            "Keypad",
            "SAM",
            "Scaler",
            "Thumb slider"});
            this.listBox.Location = new System.Drawing.Point(3, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(152, 162);
            this.listBox.TabIndex = 44;
            this.listBox.ThreeDCheckBoxes = true;
            this.listBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_ItemCheck);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.generalPanel);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(360, 587);
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.positionPanel.ResumeLayout(false);
            this.positionPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.catPage.ResumeLayout(false);
            this.catPage.PerformLayout();
            this.grapherPage.ResumeLayout(false);
            this.keypadPage.ResumeLayout(false);
            this.keypadPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpBackgroundColorBox)).EndInit();
            this.paramSliderPage.ResumeLayout(false);
            this.paramSliderPage.PerformLayout();
            this.randomProcessPage.ResumeLayout(false);
            this.samPage.ResumeLayout(false);
            this.samPage.PerformLayout();
            this.scalePage.ResumeLayout(false);
            this.scalePage.PerformLayout();
            this.thumbSliderPage.ResumeLayout(false);
            this.thumbSliderPage.PerformLayout();
            this.buttonPage.ResumeLayout(false);
            this.buttonPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox endComboBox;
        private KLib.Controls.KCheckBox enableCheckBox;
        private System.Windows.Forms.Label label1;
        private KLib.Controls.KNumericBox yNumeric;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage catPage;
        private System.Windows.Forms.TabPage scalePage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox catBox;
        private System.Windows.Forms.Button catApplyButton;
        private System.Windows.Forms.TabPage buttonPage;
        private System.Windows.Forms.Panel positionPanel;
        private System.Windows.Forms.TabPage samPage;
        private AllSAMControl samControl;
        private System.Windows.Forms.TabPage keypadPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox kpBackgroundColorBox;
        private System.Windows.Forms.TabPage thumbSliderPage;
        private System.Windows.Forms.Label label14;
        private KLib.Controls.KNumericBox tsInitPosNumeric;
        private System.Windows.Forms.TabPage grapherPage;
        private Inputs.GrapherActionControl grapherActionControl;
        private System.Windows.Forms.TabPage paramSliderPage;
        private Inputs.ParamSliderActionControl paramSliderActionControl;
        private Inputs.ButtonActionControl buttonActionControl;
        private Inputs.ScalerControl scalerControl;
        private System.Windows.Forms.TabPage randomProcessPage;
        private Inputs.RandomProcessControl randomProcessControl;
    }
}
