namespace Turandot_Editor.Controls.Cues
{
    partial class ScoreboardActionControl
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
            this.changePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deltaExprTextBox = new System.Windows.Forms.TextBox();
            this.rateNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tmaxNumeric = new KLib.Controls.KNumericBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.changePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionEnum
            // 
            this.actionEnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionEnum.FormattingEnabled = true;
            this.actionEnum.Location = new System.Drawing.Point(80, 63);
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
            this.panel1.Location = new System.Drawing.Point(18, 3);
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
            // changePanel
            // 
            this.changePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePanel.AutoSize = true;
            this.changePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changePanel.Controls.Add(this.label1);
            this.changePanel.Controls.Add(this.deltaExprTextBox);
            this.changePanel.Controls.Add(this.rateNumeric);
            this.changePanel.Controls.Add(this.label6);
            this.changePanel.Controls.Add(this.tmaxNumeric);
            this.changePanel.Controls.Add(this.label8);
            this.changePanel.Location = new System.Drawing.Point(3, 90);
            this.changePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(170, 118);
            this.changePanel.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Expression";
            // 
            // deltaExprTextBox
            // 
            this.deltaExprTextBox.Location = new System.Drawing.Point(4, 19);
            this.deltaExprTextBox.Multiline = true;
            this.deltaExprTextBox.Name = "deltaExprTextBox";
            this.deltaExprTextBox.Size = new System.Drawing.Size(163, 44);
            this.deltaExprTextBox.TabIndex = 53;
            this.deltaExprTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deltaExprTextBox_KeyPress);
            this.deltaExprTextBox.Leave += new System.EventHandler(this.deltaExprTextBox_Leave);
            // 
            // rateNumeric
            // 
            this.rateNumeric.AutoSize = true;
            this.rateNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rateNumeric.FloatValue = 0F;
            this.rateNumeric.IntValue = 0;
            this.rateNumeric.IsInteger = true;
            this.rateNumeric.Location = new System.Drawing.Point(77, 69);
            this.rateNumeric.MaxCoerce = false;
            this.rateNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.rateNumeric.MaxValue = 360D;
            this.rateNumeric.MinCoerce = false;
            this.rateNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.rateNumeric.MinValue = 0D;
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(90, 20);
            this.rateNumeric.TabIndex = 52;
            this.rateNumeric.TextFormat = "K4";
            this.rateNumeric.Units = "pts/s";
            this.rateNumeric.Value = 0D;
            this.rateNumeric.ValueChanged += new System.EventHandler(this.rateNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Animation rate";
            // 
            // tmaxNumeric
            // 
            this.tmaxNumeric.AutoSize = true;
            this.tmaxNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tmaxNumeric.FloatValue = 0F;
            this.tmaxNumeric.IntValue = 0;
            this.tmaxNumeric.IsInteger = false;
            this.tmaxNumeric.Location = new System.Drawing.Point(77, 95);
            this.tmaxNumeric.MaxCoerce = false;
            this.tmaxNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.tmaxNumeric.MaxValue = 360D;
            this.tmaxNumeric.MinCoerce = false;
            this.tmaxNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.tmaxNumeric.MinValue = 0D;
            this.tmaxNumeric.Name = "tmaxNumeric";
            this.tmaxNumeric.Size = new System.Drawing.Size(90, 20);
            this.tmaxNumeric.TabIndex = 48;
            this.tmaxNumeric.TextFormat = "K4";
            this.tmaxNumeric.Units = "s";
            this.tmaxNumeric.Value = 0D;
            this.tmaxNumeric.ValueChanged += new System.EventHandler(this.tmaxNumeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Max time";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.actionEnum);
            this.flowLayoutPanel1.Controls.Add(this.changePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(176, 208);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // ScoreboardActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScoreboardActionControl";
            this.Size = new System.Drawing.Size(182, 214);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
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
        private System.Windows.Forms.Panel changePanel;
        private KLib.Controls.KNumericBox rateNumeric;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox tmaxNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deltaExprTextBox;
    }
}
