namespace Turandot_Editor.Controls.Cues
{
    partial class CounterActionControl
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
            this.actionEnum = new KLib.Controls.EnumDropDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.valueNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minNumeric = new KLib.Controls.KNumericBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorBox = new KLib.Controls.KColorBox();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.startPanel = new System.Windows.Forms.Panel();
            this.incrementNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.intervalNumeric = new KLib.Controls.KNumericBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.delayNumeric = new KLib.Controls.KNumericBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionEnum
            // 
            this.actionEnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionEnum.FormattingEnabled = true;
            this.actionEnum.Location = new System.Drawing.Point(102, 63);
            this.actionEnum.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.actionEnum.Name = "actionEnum";
            this.actionEnum.Size = new System.Drawing.Size(90, 21);
            this.actionEnum.Sort = false;
            this.actionEnum.TabIndex = 0;
            this.actionEnum.ValueChanged += new System.EventHandler(this.actionEnum_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.endComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 54);
            this.panel1.TabIndex = 54;
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.endComboBox.Location = new System.Drawing.Point(62, 30);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(90, 21);
            this.endComboBox.TabIndex = 51;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "End";
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Items.AddRange(new object[] {
            "Turn ON",
            "Turn OFF"});
            this.startComboBox.Location = new System.Drawing.Point(62, 3);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(90, 21);
            this.startComboBox.TabIndex = 49;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Start";
            // 
            // resetPanel
            // 
            this.resetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPanel.AutoSize = true;
            this.resetPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetPanel.Controls.Add(this.valueNumeric);
            this.resetPanel.Controls.Add(this.label5);
            this.resetPanel.Controls.Add(this.minNumeric);
            this.resetPanel.Controls.Add(this.label1);
            this.resetPanel.Controls.Add(this.maxNumeric);
            this.resetPanel.Controls.Add(this.label4);
            this.resetPanel.Location = new System.Drawing.Point(25, 90);
            this.resetPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(170, 79);
            this.resetPanel.TabIndex = 55;
            // 
            // valueNumeric
            // 
            this.valueNumeric.AutoSize = true;
            this.valueNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valueNumeric.FloatValue = 0F;
            this.valueNumeric.IntValue = 0;
            this.valueNumeric.IsInteger = true;
            this.valueNumeric.Location = new System.Drawing.Point(77, 4);
            this.valueNumeric.MaxCoerce = false;
            this.valueNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.valueNumeric.MaxValue = 360D;
            this.valueNumeric.MinCoerce = false;
            this.valueNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.valueNumeric.MinValue = 0D;
            this.valueNumeric.Name = "valueNumeric";
            this.valueNumeric.Size = new System.Drawing.Size(90, 20);
            this.valueNumeric.TabIndex = 52;
            this.valueNumeric.TextFormat = "K4";
            this.valueNumeric.Units = "";
            this.valueNumeric.Value = 0D;
            this.valueNumeric.ValueChanged += new System.EventHandler(this.valueNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Start at";
            // 
            // minNumeric
            // 
            this.minNumeric.AutoSize = true;
            this.minNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minNumeric.FloatValue = 0F;
            this.minNumeric.IntValue = 0;
            this.minNumeric.IsInteger = true;
            this.minNumeric.Location = new System.Drawing.Point(77, 56);
            this.minNumeric.MaxCoerce = false;
            this.minNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.minNumeric.MaxValue = 360D;
            this.minNumeric.MinCoerce = false;
            this.minNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.minNumeric.MinValue = 0D;
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(90, 20);
            this.minNumeric.TabIndex = 50;
            this.minNumeric.TextFormat = "K4";
            this.minNumeric.Units = "";
            this.minNumeric.Value = 0D;
            this.minNumeric.ValueChanged += new System.EventHandler(this.minNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Min value";
            // 
            // maxNumeric
            // 
            this.maxNumeric.AutoSize = true;
            this.maxNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxNumeric.FloatValue = 0F;
            this.maxNumeric.IntValue = 0;
            this.maxNumeric.IsInteger = true;
            this.maxNumeric.Location = new System.Drawing.Point(77, 30);
            this.maxNumeric.MaxCoerce = false;
            this.maxNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.maxNumeric.MaxValue = 360D;
            this.maxNumeric.MinCoerce = false;
            this.maxNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.maxNumeric.MinValue = 0D;
            this.maxNumeric.Name = "maxNumeric";
            this.maxNumeric.Size = new System.Drawing.Size(90, 20);
            this.maxNumeric.TabIndex = 48;
            this.maxNumeric.TextFormat = "K4";
            this.maxNumeric.Units = "";
            this.maxNumeric.Value = 0D;
            this.maxNumeric.ValueChanged += new System.EventHandler(this.maxNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Max value";
            // 
            // colorPanel
            // 
            this.colorPanel.AutoSize = true;
            this.colorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanel.Controls.Add(this.colorBox);
            this.colorPanel.Controls.Add(this.colorCheckBox);
            this.colorPanel.Location = new System.Drawing.Point(3, 254);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(192, 27);
            this.colorPanel.TabIndex = 56;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(99, 3);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(90, 21);
            this.colorBox.TabIndex = 57;
            this.colorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorBox.ValueAsUInt = ((uint)(4294967295u));
            this.colorBox.ValueChanged += new System.EventHandler(this.colorBox_ValueChanged);
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.colorCheckBox.Location = new System.Drawing.Point(4, 7);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(89, 17);
            this.colorCheckBox.TabIndex = 0;
            this.colorCheckBox.Text = "Change color";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            this.colorCheckBox.CheckedChanged += new System.EventHandler(this.colorCheckBox_CheckedChanged);
            // 
            // startPanel
            // 
            this.startPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPanel.AutoSize = true;
            this.startPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startPanel.Controls.Add(this.delayNumeric);
            this.startPanel.Controls.Add(this.label7);
            this.startPanel.Controls.Add(this.incrementNumeric);
            this.startPanel.Controls.Add(this.label6);
            this.startPanel.Controls.Add(this.intervalNumeric);
            this.startPanel.Controls.Add(this.label8);
            this.startPanel.Location = new System.Drawing.Point(25, 172);
            this.startPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(170, 79);
            this.startPanel.TabIndex = 57;
            // 
            // incrementNumeric
            // 
            this.incrementNumeric.AutoSize = true;
            this.incrementNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.incrementNumeric.FloatValue = 0F;
            this.incrementNumeric.IntValue = 0;
            this.incrementNumeric.IsInteger = true;
            this.incrementNumeric.Location = new System.Drawing.Point(77, 30);
            this.incrementNumeric.MaxCoerce = false;
            this.incrementNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.incrementNumeric.MaxValue = 360D;
            this.incrementNumeric.MinCoerce = false;
            this.incrementNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.incrementNumeric.MinValue = 0D;
            this.incrementNumeric.Name = "incrementNumeric";
            this.incrementNumeric.Size = new System.Drawing.Size(90, 20);
            this.incrementNumeric.TabIndex = 52;
            this.incrementNumeric.TextFormat = "K4";
            this.incrementNumeric.Units = "";
            this.incrementNumeric.Value = 0D;
            this.incrementNumeric.ValueChanged += new System.EventHandler(this.incrementNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Increment by";
            // 
            // intervalNumeric
            // 
            this.intervalNumeric.AutoSize = true;
            this.intervalNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intervalNumeric.FloatValue = 0F;
            this.intervalNumeric.IntValue = 0;
            this.intervalNumeric.IsInteger = false;
            this.intervalNumeric.Location = new System.Drawing.Point(77, 56);
            this.intervalNumeric.MaxCoerce = false;
            this.intervalNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.intervalNumeric.MaxValue = 360D;
            this.intervalNumeric.MinCoerce = false;
            this.intervalNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.intervalNumeric.MinValue = 0D;
            this.intervalNumeric.Name = "intervalNumeric";
            this.intervalNumeric.Size = new System.Drawing.Size(90, 20);
            this.intervalNumeric.TabIndex = 48;
            this.intervalNumeric.TextFormat = "K4";
            this.intervalNumeric.Units = "seconds";
            this.intervalNumeric.Value = 0D;
            this.intervalNumeric.ValueChanged += new System.EventHandler(this.intervalNumeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "every";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.actionEnum);
            this.flowLayoutPanel1.Controls.Add(this.resetPanel);
            this.flowLayoutPanel1.Controls.Add(this.startPanel);
            this.flowLayoutPanel1.Controls.Add(this.colorPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 284);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // delayNumeric
            // 
            this.delayNumeric.AutoSize = true;
            this.delayNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delayNumeric.FloatValue = 0F;
            this.delayNumeric.IntValue = 0;
            this.delayNumeric.IsInteger = false;
            this.delayNumeric.Location = new System.Drawing.Point(77, 5);
            this.delayNumeric.MaxCoerce = false;
            this.delayNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.delayNumeric.MaxValue = 360D;
            this.delayNumeric.MinCoerce = false;
            this.delayNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.delayNumeric.MinValue = 0D;
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(90, 20);
            this.delayNumeric.TabIndex = 54;
            this.delayNumeric.TextFormat = "K4";
            this.delayNumeric.Units = "seconds";
            this.delayNumeric.Value = 0D;
            this.delayNumeric.ValueChanged += new System.EventHandler(this.delayNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Delay";
            // 
            // CounterActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CounterActionControl";
            this.Size = new System.Drawing.Size(204, 290);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.EnumDropDown actionEnum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel resetPanel;
        private KLib.Controls.KNumericBox maxNumeric;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox valueNumeric;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.KNumericBox minNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.CheckBox colorCheckBox;
        private KLib.Controls.KColorBox colorBox;
        private System.Windows.Forms.Panel startPanel;
        private KLib.Controls.KNumericBox incrementNumeric;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox intervalNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private KLib.Controls.KNumericBox delayNumeric;
        private System.Windows.Forms.Label label7;
    }
}
