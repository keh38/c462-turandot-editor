namespace Turandot_Editor.Controls.Screen
{
    partial class XboxLinkControl
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
            this.sourceEnum = new KLib.Controls.EnumDropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.showCheckBox = new System.Windows.Forms.CheckBox();
            this.yNumeric = new KLib.Controls.KNumericBox();
            this.xNumeric = new KLib.Controls.KNumericBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.positionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceEnum
            // 
            this.sourceEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceEnum.FormattingEnabled = true;
            this.sourceEnum.Location = new System.Drawing.Point(42, 3);
            this.sourceEnum.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.sourceEnum.Name = "sourceEnum";
            this.sourceEnum.Size = new System.Drawing.Size(128, 21);
            this.sourceEnum.Sort = false;
            this.sourceEnum.TabIndex = 0;
            this.sourceEnum.ValueChanged += new System.EventHandler(this.sourceEnum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xbox";
            // 
            // showCheckBox
            // 
            this.showCheckBox.AutoSize = true;
            this.showCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showCheckBox.Location = new System.Drawing.Point(2, 28);
            this.showCheckBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.showCheckBox.Name = "showCheckBox";
            this.showCheckBox.Size = new System.Drawing.Size(53, 17);
            this.showCheckBox.TabIndex = 2;
            this.showCheckBox.Text = "Show";
            this.showCheckBox.UseVisualStyleBackColor = true;
            this.showCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
            // 
            // yNumeric
            // 
            this.yNumeric.AutoSize = true;
            this.yNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yNumeric.FloatValue = 0F;
            this.yNumeric.IntValue = 0;
            this.yNumeric.IsInteger = true;
            this.yNumeric.Location = new System.Drawing.Point(98, 3);
            this.yNumeric.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.yNumeric.MaxCoerce = false;
            this.yNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.yNumeric.MaxValue = 10000000D;
            this.yNumeric.MinCoerce = false;
            this.yNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.yNumeric.MinValue = 0D;
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(50, 20);
            this.yNumeric.TabIndex = 12;
            this.yNumeric.TextFormat = "K4";
            this.yNumeric.Units = "";
            this.yNumeric.Value = 0D;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // xNumeric
            // 
            this.xNumeric.AutoSize = true;
            this.xNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xNumeric.FloatValue = 0F;
            this.xNumeric.IntValue = 0;
            this.xNumeric.IsInteger = true;
            this.xNumeric.Location = new System.Drawing.Point(18, 3);
            this.xNumeric.MaxCoerce = false;
            this.xNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.xNumeric.MaxValue = 10000000D;
            this.xNumeric.MinCoerce = false;
            this.xNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.xNumeric.MinValue = 0D;
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(50, 20);
            this.xNumeric.TabIndex = 10;
            this.xNumeric.TextFormat = "K4";
            this.xNumeric.Units = "";
            this.xNumeric.Value = 0D;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // positionPanel
            // 
            this.positionPanel.AutoSize = true;
            this.positionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.positionPanel.Controls.Add(this.yNumeric);
            this.positionPanel.Controls.Add(this.label5);
            this.positionPanel.Controls.Add(this.xNumeric);
            this.positionPanel.Controls.Add(this.label4);
            this.positionPanel.Location = new System.Drawing.Point(23, 44);
            this.positionPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(148, 26);
            this.positionPanel.TabIndex = 14;
            // 
            // XboxLinkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.positionPanel);
            this.Controls.Add(this.showCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceEnum);
            this.Name = "XboxLinkControl";
            this.Size = new System.Drawing.Size(171, 70);
            this.positionPanel.ResumeLayout(false);
            this.positionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.EnumDropDown sourceEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showCheckBox;
        private KLib.Controls.KNumericBox yNumeric;
        private KLib.Controls.KNumericBox xNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel positionPanel;
    }
}
