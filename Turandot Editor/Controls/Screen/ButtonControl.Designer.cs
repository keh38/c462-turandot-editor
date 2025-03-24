namespace Turandot_Editor.Controls.Inputs
{
    partial class ButtonControl
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.sizeNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.styleEnum = new KLib.Controls.EnumDropDown();
            this.label6 = new System.Windows.Forms.Label();
            this.hPrompt = new System.Windows.Forms.Label();
            this.hNumeric = new KLib.Controls.KNumericBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.optionalPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.keyEnum = new KLib.Controls.EnumDropDown();
            this.xboxLinkControl = new Turandot_Editor.Controls.Screen.XboxLinkControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.optionalPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(42, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(128, 20);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Label";
            // 
            // labelBox
            // 
            this.labelBox.Location = new System.Drawing.Point(42, 29);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(128, 20);
            this.labelBox.TabIndex = 2;
            this.labelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelBox_KeyPress);
            this.labelBox.Leave += new System.EventHandler(this.labelBox_Leave);
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.AllowInf = false;
            this.sizeNumeric.AutoSize = true;
            this.sizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeNumeric.ClearOnDisable = false;
            this.sizeNumeric.FloatValue = 0F;
            this.sizeNumeric.IntValue = 0;
            this.sizeNumeric.IsInteger = true;
            this.sizeNumeric.Location = new System.Drawing.Point(42, 3);
            this.sizeNumeric.MaxCoerce = false;
            this.sizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.sizeNumeric.MaxValue = 10000000D;
            this.sizeNumeric.MinCoerce = false;
            this.sizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.sizeNumeric.MinValue = 0D;
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(50, 20);
            this.sizeNumeric.TabIndex = 4;
            this.sizeNumeric.TextFormat = "K4";
            this.sizeNumeric.ToolTip = "";
            this.sizeNumeric.Units = "";
            this.sizeNumeric.Value = 0D;
            this.sizeNumeric.ValueChanged += new System.EventHandler(this.sizeNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // xNumeric
            // 
            this.xNumeric.AllowInf = false;
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.ClearOnDisable = false;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(42, 56);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 10000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(50, 20);
            this.xNumeric.TabIndex = 6;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.ToolTip = "";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y";
            // 
            // yNumeric
            // 
            this.yNumeric.AllowInf = false;
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.ClearOnDisable = false;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(120, 56);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 10000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(50, 20);
            this.yNumeric.TabIndex = 8;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.ToolTip = "";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // styleEnum
            // 
            this.styleEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleEnum.FormattingEnabled = true;
            this.styleEnum.Location = new System.Drawing.Point(42, 29);
            this.styleEnum.Name = "styleEnum";
            this.styleEnum.Size = new System.Drawing.Size(128, 21);
            this.styleEnum.Sort = false;
            this.styleEnum.TabIndex = 10;
            this.styleEnum.ValueChanged += new System.EventHandler(this.styleEnum_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Style";
            // 
            // hPrompt
            // 
            this.hPrompt.AutoSize = true;
            this.hPrompt.Location = new System.Drawing.Point(104, 6);
            this.hPrompt.Name = "hPrompt";
            this.hPrompt.Size = new System.Drawing.Size(15, 13);
            this.hPrompt.TabIndex = 13;
            this.hPrompt.Text = "H";
            // 
            // hNumeric
            // 
            this.hNumeric.AllowInf = false;
            this.hNumeric.AutoSize = true;
            this.hNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hNumeric.ClearOnDisable = false;
            this.hNumeric.FloatValue = 0F;
            this.hNumeric.IntValue = 0;
            this.hNumeric.IsInteger = true;
            this.hNumeric.Location = new System.Drawing.Point(120, 3);
            this.hNumeric.MaxCoerce = false;
            this.hNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.hNumeric.MaxValue = 10000000D;
            this.hNumeric.MinCoerce = false;
            this.hNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.hNumeric.MinValue = 0D;
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(50, 20);
            this.hNumeric.TabIndex = 12;
            this.hNumeric.TextFormat = "K4";
            this.hNumeric.ToolTip = "";
            this.hNumeric.Units = "";
            this.hNumeric.Value = 0D;
            this.hNumeric.ValueChanged += new System.EventHandler(this.hNumeric_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.yNumeric);
            this.panel1.Controls.Add(this.xNumeric);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.styleEnum);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 79);
            this.panel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.optionalPanel);
            this.flowLayoutPanel1.Controls.Add(this.xboxLinkControl);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(177, 231);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // optionalPanel
            // 
            this.optionalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionalPanel.AutoSize = true;
            this.optionalPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionalPanel.Controls.Add(this.hNumeric);
            this.optionalPanel.Controls.Add(this.labelBox);
            this.optionalPanel.Controls.Add(this.hPrompt);
            this.optionalPanel.Controls.Add(this.label2);
            this.optionalPanel.Controls.Add(this.sizeNumeric);
            this.optionalPanel.Controls.Add(this.label3);
            this.optionalPanel.Location = new System.Drawing.Point(4, 79);
            this.optionalPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.optionalPanel.Name = "optionalPanel";
            this.optionalPanel.Size = new System.Drawing.Size(173, 52);
            this.optionalPanel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.keyEnum);
            this.panel2.Location = new System.Drawing.Point(3, 201);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 27);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Key";
            // 
            // keyEnum
            // 
            this.keyEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyEnum.FormattingEnabled = true;
            this.keyEnum.Location = new System.Drawing.Point(40, 3);
            this.keyEnum.Name = "keyEnum";
            this.keyEnum.Size = new System.Drawing.Size(128, 21);
            this.keyEnum.Sort = false;
            this.keyEnum.TabIndex = 12;
            this.keyEnum.ValueChanged += new System.EventHandler(this.keyEnum_ValueChanged);
            // 
            // xboxLinkControl
            // 
            this.xboxLinkControl.AutoSize = true;
            this.xboxLinkControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xboxLinkControl.Location = new System.Drawing.Point(3, 131);
            this.xboxLinkControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.xboxLinkControl.Name = "xboxLinkControl";
            this.xboxLinkControl.Size = new System.Drawing.Size(171, 70);
            this.xboxLinkControl.TabIndex = 17;
            this.xboxLinkControl.Value = null;
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(180, 234);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.optionalPanel.ResumeLayout(false);
            this.optionalPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelBox;
        private KLib.Controls.KNumericBox sizeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.EnumDropDown styleEnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hPrompt;
        private KLib.Controls.KNumericBox hNumeric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel optionalPanel;
        private Screen.XboxLinkControl xboxLinkControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private KLib.Controls.EnumDropDown keyEnum;
    }
}
