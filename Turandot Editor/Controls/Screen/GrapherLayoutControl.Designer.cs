namespace Turandot_Editor.Controls.Screen
{
    partial class GrapherLayoutControl
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
            this.ylabel = new System.Windows.Forms.Label();
            this.stylusXNumeric = new KLib.Controls.KNumericBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedNumeric = new KLib.Controls.KNumericBox();
            this.inkColorBox = new KLib.Controls.KColorBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wNumeric = new KLib.Controls.KNumericBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hNumeric = new KLib.Controls.KNumericBox();
            this.contactCheckbox = new KLib.Controls.KCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fixedCheckbox = new KLib.Controls.KCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sizeNumeric = new KLib.Controls.KNumericBox();
            this.SuspendLayout();
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(164, 61);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(39, 13);
            this.ylabel.TabIndex = 73;
            this.ylabel.Text = "Start X";
            // 
            // stylusXNumeric
            // 
            this.stylusXNumeric.AutoSize = true;
            this.stylusXNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stylusXNumeric.FloatValue = 0F;
            this.stylusXNumeric.IntValue = 0;
            this.stylusXNumeric.IsInteger = false;
            this.stylusXNumeric.Location = new System.Drawing.Point(206, 59);
            this.stylusXNumeric.MaxCoerce = false;
            this.stylusXNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.stylusXNumeric.MaxValue = 1000000000D;
            this.stylusXNumeric.MinCoerce = false;
            this.stylusXNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.stylusXNumeric.MinValue = 0D;
            this.stylusXNumeric.Name = "stylusXNumeric";
            this.stylusXNumeric.Size = new System.Drawing.Size(90, 20);
            this.stylusXNumeric.TabIndex = 74;
            this.stylusXNumeric.TextFormat = "K4";
            this.stylusXNumeric.Units = "";
            this.stylusXNumeric.Value = 0D;
            this.stylusXNumeric.ValueChanged += new System.EventHandler(this.stylusXNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Y";
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = false;
            this.yNumeric.Location = new System.Drawing.Point(32, 60);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 1000000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(90, 20);
            this.yNumeric.TabIndex = 72;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Speed";
            // 
            // speedNumeric
            // 
            this.speedNumeric.AutoSize = true;
            this.speedNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speedNumeric.FloatValue = 0.01F;
            this.speedNumeric.IntValue = 0;
            this.speedNumeric.IsInteger = false;
            this.speedNumeric.Location = new System.Drawing.Point(206, 83);
            this.speedNumeric.MaxCoerce = false;
            this.speedNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.speedNumeric.MaxValue = 1000000000D;
            this.speedNumeric.MinCoerce = true;
            this.speedNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.speedNumeric.MinValue = 0.01D;
            this.speedNumeric.Name = "speedNumeric";
            this.speedNumeric.Size = new System.Drawing.Size(90, 20);
            this.speedNumeric.TabIndex = 76;
            this.speedNumeric.TextFormat = "K4";
            this.speedNumeric.Units = "";
            this.speedNumeric.Value = 0.01D;
            this.speedNumeric.ValueChanged += new System.EventHandler(this.speedNumeric_ValueChanged);
            // 
            // inkColorBox
            // 
            this.inkColorBox.Location = new System.Drawing.Point(206, 105);
            this.inkColorBox.Name = "inkColorBox";
            this.inkColorBox.Size = new System.Drawing.Size(90, 21);
            this.inkColorBox.TabIndex = 78;
            this.inkColorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inkColorBox.ValueAsUInt = ((uint)(4294967295u));
            this.inkColorBox.ValueChanged += new System.EventHandler(this.inkColorBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ink color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "X";
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = false;
            this.xNumeric.Location = new System.Drawing.Point(32, 34);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 1000000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(90, 20);
            this.xNumeric.TabIndex = 80;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "W";
            // 
            // wNumeric
            // 
            this.wNumeric.AutoSize = true;
            this.wNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wNumeric.FloatValue = 0F;
            this.wNumeric.IntValue = 0;
            this.wNumeric.IsInteger = false;
            this.wNumeric.Location = new System.Drawing.Point(32, 86);
            this.wNumeric.MaxCoerce = false;
            this.wNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.wNumeric.MaxValue = 1000000000D;
            this.wNumeric.MinCoerce = false;
            this.wNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.wNumeric.MinValue = 0D;
            this.wNumeric.Name = "wNumeric";
            this.wNumeric.Size = new System.Drawing.Size(90, 20);
            this.wNumeric.TabIndex = 84;
            this.wNumeric.TextFormat = "K4";
            this.wNumeric.Units = "";
            this.wNumeric.Value = 0D;
            this.wNumeric.ValueChanged += new System.EventHandler(this.wNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "H";
            // 
            // hNumeric
            // 
            this.hNumeric.AutoSize = true;
            this.hNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hNumeric.FloatValue = 0F;
            this.hNumeric.IntValue = 0;
            this.hNumeric.IsInteger = false;
            this.hNumeric.Location = new System.Drawing.Point(32, 112);
            this.hNumeric.MaxCoerce = false;
            this.hNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.hNumeric.MaxValue = 1000000000D;
            this.hNumeric.MinCoerce = false;
            this.hNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.hNumeric.MinValue = 0D;
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(90, 20);
            this.hNumeric.TabIndex = 82;
            this.hNumeric.TextFormat = "K4";
            this.hNumeric.Units = "";
            this.hNumeric.Value = 0D;
            this.hNumeric.ValueChanged += new System.EventHandler(this.hNumeric_ValueChanged);
            // 
            // contactCheckbox
            // 
            this.contactCheckbox.AutoSize = true;
            this.contactCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contactCheckbox.Location = new System.Drawing.Point(197, 129);
            this.contactCheckbox.Name = "contactCheckbox";
            this.contactCheckbox.Size = new System.Drawing.Size(88, 17);
            this.contactCheckbox.TabIndex = 85;
            this.contactCheckbox.Text = "Must contact";
            this.contactCheckbox.UseVisualStyleBackColor = true;
            this.contactCheckbox.CheckedChanged += new System.EventHandler(this.contactCheckbox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(30, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Graph";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(202, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Stylus";
            // 
            // fixedCheckbox
            // 
            this.fixedCheckbox.AutoSize = true;
            this.fixedCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fixedCheckbox.Location = new System.Drawing.Point(197, 154);
            this.fixedCheckbox.Name = "fixedCheckbox";
            this.fixedCheckbox.Size = new System.Drawing.Size(90, 17);
            this.fixedCheckbox.TabIndex = 88;
            this.fixedCheckbox.Text = "Fixed position";
            this.fixedCheckbox.UseVisualStyleBackColor = true;
            this.fixedCheckbox.CheckedChanged += new System.EventHandler(this.fixedCheckbox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Size";
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.AutoSize = true;
            this.sizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeNumeric.FloatValue = 0F;
            this.sizeNumeric.IntValue = 0;
            this.sizeNumeric.IsInteger = false;
            this.sizeNumeric.Location = new System.Drawing.Point(206, 36);
            this.sizeNumeric.MaxCoerce = false;
            this.sizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.sizeNumeric.MaxValue = 1000000000D;
            this.sizeNumeric.MinCoerce = false;
            this.sizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.sizeNumeric.MinValue = 0D;
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.sizeNumeric.TabIndex = 90;
            this.sizeNumeric.TextFormat = "K4";
            this.sizeNumeric.Units = "";
            this.sizeNumeric.Value = 0D;
            this.sizeNumeric.ValueChanged += new System.EventHandler(this.sizeNumeric_ValueChanged);
            // 
            // GrapherLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sizeNumeric);
            this.Controls.Add(this.fixedCheckbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contactCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xNumeric);
            this.Controls.Add(this.inkColorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedNumeric);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.stylusXNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yNumeric);
            this.Name = "GrapherLayoutControl";
            this.Size = new System.Drawing.Size(323, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ylabel;
        private KLib.Controls.KNumericBox stylusXNumeric;
        private System.Windows.Forms.Label label3;
        private KLib.Controls.KNumericBox yNumeric;
        private System.Windows.Forms.Label label1;
        private KLib.Controls.KNumericBox speedNumeric;
        private KLib.Controls.KColorBox inkColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.KNumericBox wNumeric;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KNumericBox hNumeric;
        private KLib.Controls.KCheckBox contactCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private KLib.Controls.KCheckBox fixedCheckbox;
        private System.Windows.Forms.Label label9;
        private KLib.Controls.KNumericBox sizeNumeric;
    }
}
