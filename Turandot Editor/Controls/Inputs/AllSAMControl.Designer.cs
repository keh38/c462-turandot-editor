namespace Turandot_Editor.Controls
{
    partial class AllSAMControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.valenceControl = new Turandot_Editor.Controls.SAMControl();
            this.arousalControl = new Turandot_Editor.Controls.SAMControl();
            this.dominanceControl = new Turandot_Editor.Controls.SAMControl();
            this.loudnessControl = new Turandot_Editor.Controls.SAMControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.loudnessControl);
            this.flowLayoutPanel1.Controls.Add(this.valenceControl);
            this.flowLayoutPanel1.Controls.Add(this.arousalControl);
            this.flowLayoutPanel1.Controls.Add(this.dominanceControl);
            this.flowLayoutPanel1.Controls.Add(this.appearancePanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 184);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 17);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min label";
            // 
            // appearancePanel
            // 
            this.appearancePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appearancePanel.AutoSize = true;
            this.appearancePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appearancePanel.Controls.Add(this.label3);
            this.appearancePanel.Controls.Add(this.colorBox);
            this.appearancePanel.Location = new System.Drawing.Point(81, 154);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(258, 27);
            this.appearancePanel.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Color";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Yellow;
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.Location = new System.Drawing.Point(47, 3);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(208, 21);
            this.colorBox.TabIndex = 33;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // valenceControl
            // 
            this.valenceControl.AutoSize = true;
            this.valenceControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valenceControl.Location = new System.Drawing.Point(3, 58);
            this.valenceControl.Name = "valenceControl";
            this.valenceControl.Size = new System.Drawing.Size(336, 26);
            this.valenceControl.TabIndex = 0;
            this.valenceControl.Title = "Valence";
            this.valenceControl.Value = null;
            this.valenceControl.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // arousalControl
            // 
            this.arousalControl.AutoSize = true;
            this.arousalControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.arousalControl.Location = new System.Drawing.Point(3, 90);
            this.arousalControl.Name = "arousalControl";
            this.arousalControl.Size = new System.Drawing.Size(336, 26);
            this.arousalControl.TabIndex = 2;
            this.arousalControl.Title = "Arousal";
            this.arousalControl.Value = null;
            this.arousalControl.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // dominanceControl
            // 
            this.dominanceControl.AutoSize = true;
            this.dominanceControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dominanceControl.Location = new System.Drawing.Point(3, 122);
            this.dominanceControl.Name = "dominanceControl";
            this.dominanceControl.Size = new System.Drawing.Size(336, 26);
            this.dominanceControl.TabIndex = 2;
            this.dominanceControl.Title = "Dominance";
            this.dominanceControl.Value = null;
            this.dominanceControl.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // loudnessControl
            // 
            this.loudnessControl.AutoSize = true;
            this.loudnessControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loudnessControl.Location = new System.Drawing.Point(3, 26);
            this.loudnessControl.Name = "loudnessControl";
            this.loudnessControl.Size = new System.Drawing.Size(336, 26);
            this.loudnessControl.TabIndex = 53;
            this.loudnessControl.Title = "Loudness";
            this.loudnessControl.Value = null;
            // 
            // AllSAMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AllSAMControl";
            this.Size = new System.Drawing.Size(348, 190);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.appearancePanel.ResumeLayout(false);
            this.appearancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAMControl valenceControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SAMControl arousalControl;
        private SAMControl dominanceControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel appearancePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox colorBox;
        private SAMControl loudnessControl;
    }
}
