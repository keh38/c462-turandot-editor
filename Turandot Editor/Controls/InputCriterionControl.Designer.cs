namespace Turandot_Editor
{
    partial class InputCriterionControl
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
            this.controlList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forLabel = new System.Windows.Forms.Label();
            this.durationNumeric = new KLib.Controls.KNumericBox();
            this.stateDropDown = new KLib.Controls.EnumDropDown();
            this.opDropDown = new KLib.Controls.EnumDropDown();
            this.comparisonEnum = new KLib.Controls.EnumDropDown();
            this.SuspendLayout();
            // 
            // controlList
            // 
            this.controlList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.controlList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlList.FormattingEnabled = true;
            this.controlList.Location = new System.Drawing.Point(0, 0);
            this.controlList.Name = "controlList";
            this.controlList.Size = new System.Drawing.Size(125, 21);
            this.controlList.TabIndex = 0;
            this.controlList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.controlList_DrawItem);
            this.controlList.SelectedIndexChanged += new System.EventHandler(this.controlList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(125, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "is";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forLabel
            // 
            this.forLabel.Location = new System.Drawing.Point(215, 3);
            this.forLabel.Name = "forLabel";
            this.forLabel.Size = new System.Drawing.Size(25, 13);
            this.forLabel.TabIndex = 4;
            this.forLabel.Text = "for";
            this.forLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // durationNumeric
            // 
            this.durationNumeric.AutoSize = true;
            this.durationNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.durationNumeric.FloatValue = 0F;
            this.durationNumeric.IntValue = 0;
            this.durationNumeric.IsInteger = true;
            this.durationNumeric.Location = new System.Drawing.Point(240, 0);
            this.durationNumeric.MaxCoerce = false;
            this.durationNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.durationNumeric.MaxValue = 1000000D;
            this.durationNumeric.MinCoerce = false;
            this.durationNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.durationNumeric.MinValue = 0D;
            this.durationNumeric.Name = "durationNumeric";
            this.durationNumeric.Size = new System.Drawing.Size(76, 20);
            this.durationNumeric.TabIndex = 5;
            this.durationNumeric.TextFormat = "";
            this.durationNumeric.Units = "ms";
            this.durationNumeric.Value = 0D;
            this.durationNumeric.ValueChanged += new System.EventHandler(this.durationBox_ValueChanged);
            // 
            // stateDropDown
            // 
            this.stateDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateDropDown.FormattingEnabled = true;
            this.stateDropDown.Location = new System.Drawing.Point(142, 0);
            this.stateDropDown.Name = "stateDropDown";
            this.stateDropDown.Size = new System.Drawing.Size(75, 21);
            this.stateDropDown.Sort = false;
            this.stateDropDown.TabIndex = 7;
            this.stateDropDown.ValueChanged += new System.EventHandler(this.stateList_SelectedIndexChanged);
            // 
            // opDropDown
            // 
            this.opDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opDropDown.FormattingEnabled = true;
            this.opDropDown.Location = new System.Drawing.Point(325, 0);
            this.opDropDown.Name = "opDropDown";
            this.opDropDown.Size = new System.Drawing.Size(66, 21);
            this.opDropDown.Sort = false;
            this.opDropDown.TabIndex = 8;
            this.opDropDown.ValueChanged += new System.EventHandler(this.operatorList_SelectedIndexChanged);
            // 
            // comparisonEnum
            // 
            this.comparisonEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comparisonEnum.FormattingEnabled = true;
            this.comparisonEnum.Location = new System.Drawing.Point(142, 0);
            this.comparisonEnum.Name = "comparisonEnum";
            this.comparisonEnum.Size = new System.Drawing.Size(75, 21);
            this.comparisonEnum.Sort = false;
            this.comparisonEnum.TabIndex = 9;
            this.comparisonEnum.ValueChanged += new System.EventHandler(this.comparisonEnum_ValueChanged);
            // 
            // InputCriterionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.comparisonEnum);
            this.Controls.Add(this.opDropDown);
            this.Controls.Add(this.stateDropDown);
            this.Controls.Add(this.durationNumeric);
            this.Controls.Add(this.forLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlList);
            this.Name = "InputCriterionControl";
            this.Size = new System.Drawing.Size(394, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox controlList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forLabel;
        private KLib.Controls.KNumericBox durationNumeric;
        private KLib.Controls.EnumDropDown stateDropDown;
        private KLib.Controls.EnumDropDown opDropDown;
        private KLib.Controls.EnumDropDown comparisonEnum;
    }
}
