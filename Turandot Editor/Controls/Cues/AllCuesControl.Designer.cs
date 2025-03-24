namespace Turandot_Editor.Controls
{
    partial class AllCuesControl
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
            Turandot.Cues.Help help1 = new Turandot.Cues.Help();
            Turandot.Cues.Image cue1 = new Turandot.Cues.Image();
            Turandot.Cues.Cue cue2 = new Turandot.Cues.Cue();
            Turandot.Cues.Cue cue3 = new Turandot.Cues.Cue();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.cueTabs = new System.Windows.Forms.TabControl();
            this.counterPage = new System.Windows.Forms.TabPage();
            this.counterActionControl = new Turandot_Editor.Controls.Cues.CounterActionControl();
            this.fixationPage = new System.Windows.Forms.TabPage();
            this.fixationPointActionCtl = new Turandot_Editor.Controls.FixationPointActionCtl();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.helpControl = new Turandot_Editor.Controls.HelpControl();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.imageControl = new Turandot_Editor.Controls.ImageControl();
            this.ledPage = new System.Windows.Forms.TabPage();
            this.ledControl = new Turandot_Editor.Controls.CueControl();
            this.messagePage = new System.Windows.Forms.TabPage();
            this.messageControl = new Turandot_Editor.Controls.CueControl();
            this.progressPage = new System.Windows.Forms.TabPage();
            this.progressBarActionCtl = new Turandot_Editor.Controls.ProgressBarActionCtl();
            this.scoreboardPage = new System.Windows.Forms.TabPage();
            this.scoreboardActionControl = new Turandot_Editor.Controls.Cues.ScoreboardActionControl();
            this.cueTabs.SuspendLayout();
            this.counterPage.SuspendLayout();
            this.fixationPage.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.imagePage.SuspendLayout();
            this.ledPage.SuspendLayout();
            this.messagePage.SuspendLayout();
            this.progressPage.SuspendLayout();
            this.scoreboardPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.IntegralHeight = false;
            this.listBox.Items.AddRange(new object[] {
            "Counter",
            "Fixation point",
            "Help",
            "Image",
            "LED",
            "Message",
            "Progress bar",
            "Scoreboard"});
            this.listBox.Location = new System.Drawing.Point(13, 23);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(152, 162);
            this.listBox.TabIndex = 46;
            this.listBox.ThreeDCheckBoxes = true;
            this.listBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_ItemCheck);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // cueTabs
            // 
            this.cueTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.cueTabs.Controls.Add(this.counterPage);
            this.cueTabs.Controls.Add(this.fixationPage);
            this.cueTabs.Controls.Add(this.helpPage);
            this.cueTabs.Controls.Add(this.imagePage);
            this.cueTabs.Controls.Add(this.ledPage);
            this.cueTabs.Controls.Add(this.messagePage);
            this.cueTabs.Controls.Add(this.progressPage);
            this.cueTabs.Controls.Add(this.scoreboardPage);
            this.cueTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.cueTabs.Location = new System.Drawing.Point(182, 18);
            this.cueTabs.Name = "cueTabs";
            this.cueTabs.SelectedIndex = 0;
            this.cueTabs.Size = new System.Drawing.Size(258, 444);
            this.cueTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.cueTabs.TabIndex = 47;
            // 
            // counterPage
            // 
            this.counterPage.Controls.Add(this.counterActionControl);
            this.counterPage.Location = new System.Drawing.Point(4, 5);
            this.counterPage.Name = "counterPage";
            this.counterPage.Size = new System.Drawing.Size(250, 435);
            this.counterPage.TabIndex = 5;
            this.counterPage.Text = "counter";
            this.counterPage.UseVisualStyleBackColor = true;
            // 
            // counterActionControl
            // 
            this.counterActionControl.AutoSize = true;
            this.counterActionControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.counterActionControl.Location = new System.Drawing.Point(3, 3);
            this.counterActionControl.Name = "counterActionControl";
            this.counterActionControl.Size = new System.Drawing.Size(204, 290);
            this.counterActionControl.TabIndex = 0;
            this.counterActionControl.Value = null;
            this.counterActionControl.ValueChanged += new System.EventHandler(this.counterActionControl_ValueChanged);
            // 
            // fixationPage
            // 
            this.fixationPage.BackColor = System.Drawing.SystemColors.Control;
            this.fixationPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fixationPage.Controls.Add(this.fixationPointActionCtl);
            this.fixationPage.Location = new System.Drawing.Point(4, 5);
            this.fixationPage.Name = "fixationPage";
            this.fixationPage.Padding = new System.Windows.Forms.Padding(3);
            this.fixationPage.Size = new System.Drawing.Size(250, 435);
            this.fixationPage.TabIndex = 0;
            this.fixationPage.Text = "fixation point";
            // 
            // fixationPointActionCtl
            // 
            this.fixationPointActionCtl.AutoSize = true;
            this.fixationPointActionCtl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fixationPointActionCtl.Location = new System.Drawing.Point(43, 6);
            this.fixationPointActionCtl.Name = "fixationPointActionCtl";
            this.fixationPointActionCtl.Size = new System.Drawing.Size(167, 89);
            this.fixationPointActionCtl.TabIndex = 2;
            this.fixationPointActionCtl.Value = null;
            this.fixationPointActionCtl.ValueChanged += new System.EventHandler(this.fixationPointActionCtl_ValueChanged);
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.helpControl);
            this.helpPage.Location = new System.Drawing.Point(4, 5);
            this.helpPage.Name = "helpPage";
            this.helpPage.Padding = new System.Windows.Forms.Padding(3);
            this.helpPage.Size = new System.Drawing.Size(250, 435);
            this.helpPage.TabIndex = 4;
            this.helpPage.Text = "help";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // helpControl
            // 
            this.helpControl.AutoSize = true;
            this.helpControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpControl.Location = new System.Drawing.Point(10, 6);
            this.helpControl.Name = "helpControl";
            this.helpControl.Size = new System.Drawing.Size(220, 252);
            this.helpControl.TabIndex = 0;
            this.helpControl.Value = help1;
            this.helpControl.ValueChanged += new System.EventHandler(this.helpControl_ValueChanged);
            // 
            // imagePage
            // 
            this.imagePage.Controls.Add(this.imageControl);
            this.imagePage.Location = new System.Drawing.Point(4, 5);
            this.imagePage.Name = "imagePage";
            this.imagePage.Size = new System.Drawing.Size(250, 435);
            this.imagePage.TabIndex = 7;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // imageControl
            // 
            this.imageControl.AutoSize = true;
            this.imageControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageControl.Location = new System.Drawing.Point(16, 13);
            this.imageControl.Name = "imageControl";
            this.imageControl.Size = new System.Drawing.Size(220, 364);
            this.imageControl.TabIndex = 0;
            this.imageControl.Value = cue1;
            this.imageControl.ValueChanged += new System.EventHandler(this.imageControl_ValueChanged);
            // 
            // ledPage
            // 
            this.ledPage.BackColor = System.Drawing.SystemColors.Control;
            this.ledPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ledPage.Controls.Add(this.ledControl);
            this.ledPage.Location = new System.Drawing.Point(4, 5);
            this.ledPage.Name = "ledPage";
            this.ledPage.Padding = new System.Windows.Forms.Padding(3);
            this.ledPage.Size = new System.Drawing.Size(250, 435);
            this.ledPage.TabIndex = 1;
            this.ledPage.Text = "led";
            // 
            // ledControl
            // 
            this.ledControl.AutoSize = true;
            this.ledControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledControl.IsMessage = false;
            this.ledControl.Location = new System.Drawing.Point(35, 6);
            this.ledControl.Name = "ledControl";
            this.ledControl.Size = new System.Drawing.Size(183, 138);
            this.ledControl.TabIndex = 0;
            this.ledControl.Value = cue2;
            this.ledControl.ValueChanged += new System.EventHandler(this.ledControl_ValueChanged);
            // 
            // messagePage
            // 
            this.messagePage.BackColor = System.Drawing.SystemColors.Control;
            this.messagePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagePage.Controls.Add(this.messageControl);
            this.messagePage.Location = new System.Drawing.Point(4, 5);
            this.messagePage.Name = "messagePage";
            this.messagePage.Padding = new System.Windows.Forms.Padding(3);
            this.messagePage.Size = new System.Drawing.Size(250, 435);
            this.messagePage.TabIndex = 2;
            this.messagePage.Text = "Message";
            // 
            // messageControl
            // 
            this.messageControl.AutoSize = true;
            this.messageControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messageControl.IsMessage = true;
            this.messageControl.Location = new System.Drawing.Point(34, 2);
            this.messageControl.Name = "messageControl";
            this.messageControl.Size = new System.Drawing.Size(183, 261);
            this.messageControl.TabIndex = 0;
            this.messageControl.Value = cue3;
            this.messageControl.ValueChanged += new System.EventHandler(this.messageControl_ValueChanged);
            // 
            // progressPage
            // 
            this.progressPage.BackColor = System.Drawing.SystemColors.Control;
            this.progressPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressPage.Controls.Add(this.progressBarActionCtl);
            this.progressPage.Location = new System.Drawing.Point(4, 5);
            this.progressPage.Name = "progressPage";
            this.progressPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressPage.Size = new System.Drawing.Size(250, 435);
            this.progressPage.TabIndex = 3;
            this.progressPage.Text = "Progress bar";
            // 
            // progressBarActionCtl
            // 
            this.progressBarActionCtl.AutoSize = true;
            this.progressBarActionCtl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.progressBarActionCtl.Location = new System.Drawing.Point(37, 6);
            this.progressBarActionCtl.Name = "progressBarActionCtl";
            this.progressBarActionCtl.Size = new System.Drawing.Size(178, 58);
            this.progressBarActionCtl.TabIndex = 0;
            this.progressBarActionCtl.Value = null;
            this.progressBarActionCtl.ValueChanged += new System.EventHandler(this.progressBarActionCtl_ValueChanged);
            // 
            // scoreboardPage
            // 
            this.scoreboardPage.Controls.Add(this.scoreboardActionControl);
            this.scoreboardPage.Location = new System.Drawing.Point(4, 5);
            this.scoreboardPage.Name = "scoreboardPage";
            this.scoreboardPage.Size = new System.Drawing.Size(250, 435);
            this.scoreboardPage.TabIndex = 6;
            this.scoreboardPage.Text = "scoreboard";
            this.scoreboardPage.UseVisualStyleBackColor = true;
            // 
            // scoreboardActionControl
            // 
            this.scoreboardActionControl.AutoSize = true;
            this.scoreboardActionControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreboardActionControl.Location = new System.Drawing.Point(3, 3);
            this.scoreboardActionControl.Name = "scoreboardActionControl";
            this.scoreboardActionControl.Size = new System.Drawing.Size(182, 214);
            this.scoreboardActionControl.TabIndex = 0;
            this.scoreboardActionControl.Value = null;
            this.scoreboardActionControl.ValueChanged += new System.EventHandler(this.scoreboardActionControl_ValueChanged);
            // 
            // AllCuesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cueTabs);
            this.Controls.Add(this.listBox);
            this.Name = "AllCuesControl";
            this.Size = new System.Drawing.Size(442, 482);
            this.cueTabs.ResumeLayout(false);
            this.counterPage.ResumeLayout(false);
            this.counterPage.PerformLayout();
            this.fixationPage.ResumeLayout(false);
            this.fixationPage.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.imagePage.ResumeLayout(false);
            this.imagePage.PerformLayout();
            this.ledPage.ResumeLayout(false);
            this.ledPage.PerformLayout();
            this.messagePage.ResumeLayout(false);
            this.messagePage.PerformLayout();
            this.progressPage.ResumeLayout(false);
            this.progressPage.PerformLayout();
            this.scoreboardPage.ResumeLayout(false);
            this.scoreboardPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listBox;
        private System.Windows.Forms.TabControl cueTabs;
        private System.Windows.Forms.TabPage fixationPage;
        private System.Windows.Forms.TabPage ledPage;
        private System.Windows.Forms.TabPage messagePage;
        private System.Windows.Forms.TabPage progressPage;
        private CueControl ledControl;
        private CueControl messageControl;
        private FixationPointActionCtl fixationPointActionCtl;
        private ProgressBarActionCtl progressBarActionCtl;
        private System.Windows.Forms.TabPage helpPage;
        private HelpControl helpControl;
        private System.Windows.Forms.TabPage counterPage;
        private Cues.CounterActionControl counterActionControl;
        private System.Windows.Forms.TabPage scoreboardPage;
        private Cues.ScoreboardActionControl scoreboardActionControl;
        private System.Windows.Forms.TabPage imagePage;
        private ImageControl imageControl;
    }
}
