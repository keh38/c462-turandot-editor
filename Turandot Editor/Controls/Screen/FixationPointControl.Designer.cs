namespace Turandot_Editor.Controls
{
    partial class FixationPointControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sizeNumeric = new KLib.Controls.KNumericBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barwidthNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barangleNumeric = new KLib.Controls.KNumericBox();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.styleDropDown = new KLib.Controls.EnumDropDown();
            this.label6 = new System.Windows.Forms.Label();
            this.colorBox = new KLib.Controls.KColorBox();
            this.barcolorBox = new KLib.Controls.KColorBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Size";
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.AutoSize = true;
            this.sizeNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeNumeric.FloatValue = 0F;
            this.sizeNumeric.IntValue = 0;
            this.sizeNumeric.IsInteger = true;
            this.sizeNumeric.Location = new System.Drawing.Point(59, 28);
            this.sizeNumeric.MaxCoerce = false;
            this.sizeNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.sizeNumeric.MaxValue = 1000000000D;
            this.sizeNumeric.MinCoerce = false;
            this.sizeNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.sizeNumeric.MinValue = 0D;
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(90, 20);
            this.sizeNumeric.TabIndex = 36;
            this.sizeNumeric.TextFormat = "K4";
            this.sizeNumeric.Units = "";
            this.sizeNumeric.Value = 0D;
            this.sizeNumeric.ValueChanged += new System.EventHandler(this.sizeNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Bar color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Bar width";
            // 
            // barwidthNumeric
            // 
            this.barwidthNumeric.AutoSize = true;
            this.barwidthNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barwidthNumeric.FloatValue = 0F;
            this.barwidthNumeric.IntValue = 0;
            this.barwidthNumeric.IsInteger = true;
            this.barwidthNumeric.Location = new System.Drawing.Point(59, 77);
            this.barwidthNumeric.MaxCoerce = false;
            this.barwidthNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.barwidthNumeric.MaxValue = 1000000000D;
            this.barwidthNumeric.MinCoerce = false;
            this.barwidthNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.barwidthNumeric.MinValue = 0D;
            this.barwidthNumeric.Name = "barwidthNumeric";
            this.barwidthNumeric.Size = new System.Drawing.Size(90, 20);
            this.barwidthNumeric.TabIndex = 40;
            this.barwidthNumeric.TextFormat = "K4";
            this.barwidthNumeric.Units = "";
            this.barwidthNumeric.Value = 0D;
            this.barwidthNumeric.ValueChanged += new System.EventHandler(this.barwidthNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Bar angle";
            // 
            // barangleNumeric
            // 
            this.barangleNumeric.AutoSize = true;
            this.barangleNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barangleNumeric.FloatValue = 0F;
            this.barangleNumeric.IntValue = 0;
            this.barangleNumeric.IsInteger = false;
            this.barangleNumeric.Location = new System.Drawing.Point(59, 126);
            this.barangleNumeric.MaxCoerce = false;
            this.barangleNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.barangleNumeric.MaxValue = 360D;
            this.barangleNumeric.MinCoerce = false;
            this.barangleNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.barangleNumeric.MinValue = 0D;
            this.barangleNumeric.Name = "barangleNumeric";
            this.barangleNumeric.Size = new System.Drawing.Size(90, 20);
            this.barangleNumeric.TabIndex = 44;
            this.barangleNumeric.TextFormat = "K4";
            this.barangleNumeric.Units = "deg";
            this.barangleNumeric.Value = 0D;
            this.barangleNumeric.ValueChanged += new System.EventHandler(this.barangleNumeric_ValueChanged);
            // 
            // labelBox
            // 
            this.labelBox.Location = new System.Drawing.Point(59, 150);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(90, 20);
            this.labelBox.TabIndex = 45;
            this.labelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelBox_KeyPress);
            this.labelBox.Leave += new System.EventHandler(this.labelBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Label";
            // 
            // styleDropDown
            // 
            this.styleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleDropDown.FormattingEnabled = true;
            this.styleDropDown.Location = new System.Drawing.Point(59, 2);
            this.styleDropDown.Name = "styleDropDown";
            this.styleDropDown.Size = new System.Drawing.Size(90, 21);
            this.styleDropDown.Sort = false;
            this.styleDropDown.TabIndex = 47;
            this.styleDropDown.ValueChanged += new System.EventHandler(this.styleDropDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Style";
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(59, 52);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(90, 21);
            this.colorBox.TabIndex = 49;
            this.colorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorBox.ValueAsUInt = ((uint)(4294967295u));
            this.colorBox.ValueChanged += new System.EventHandler(this.colorBox_ValueChanged);
            // 
            // barcolorBox
            // 
            this.barcolorBox.Location = new System.Drawing.Point(59, 101);
            this.barcolorBox.Name = "barcolorBox";
            this.barcolorBox.Size = new System.Drawing.Size(90, 21);
            this.barcolorBox.TabIndex = 50;
            this.barcolorBox.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barcolorBox.ValueAsUInt = ((uint)(4294967295u));
            this.barcolorBox.ValueChanged += new System.EventHandler(this.barcolorBox_ValueChanged);
            // 
            // FixationPointControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.barcolorBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.styleDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barangleNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barwidthNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sizeNumeric);
            this.Name = "FixationPointControl";
            this.Size = new System.Drawing.Size(152, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private KLib.Controls.KNumericBox sizeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KLib.Controls.KNumericBox barwidthNumeric;
        private System.Windows.Forms.Label label4;
        private KLib.Controls.KNumericBox barangleNumeric;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.Label label5;
        private KLib.Controls.EnumDropDown styleDropDown;
        private System.Windows.Forms.Label label6;
        private KLib.Controls.KColorBox colorBox;
        private KLib.Controls.KColorBox barcolorBox;
    }
}
