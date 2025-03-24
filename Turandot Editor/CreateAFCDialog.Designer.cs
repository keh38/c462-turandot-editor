namespace Turandot_Editor
{
    partial class CreateAFCDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAFCDialog));
            this.numintNumeric = new KLib.Controls.KNumericBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isiNumeric = new KLib.Controls.KNumericBox();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numintNumeric
            // 
            this.numintNumeric.AutoSize = true;
            this.numintNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.numintNumeric.FloatValue = 0F;
            this.numintNumeric.IntValue = 0;
            this.numintNumeric.IsInteger = true;
            this.numintNumeric.Location = new System.Drawing.Point(116, 22);
            this.numintNumeric.MaxCoerce = false;
            this.numintNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.numintNumeric.MaxValue = 3D;
            this.numintNumeric.MinCoerce = false;
            this.numintNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.numintNumeric.MinValue = 2D;
            this.numintNumeric.Name = "numintNumeric";
            this.numintNumeric.Size = new System.Drawing.Size(100, 20);
            this.numintNumeric.TabIndex = 0;
            this.numintNumeric.TextFormat = "K4";
            this.numintNumeric.Units = "";
            this.numintNumeric.Value = 0D;
            this.numintNumeric.ValueChanged += new System.EventHandler(this.numintNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of intervals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISI";
            // 
            // isiNumeric
            // 
            this.isiNumeric.AutoSize = true;
            this.isiNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.isiNumeric.FloatValue = 0F;
            this.isiNumeric.IntValue = 0;
            this.isiNumeric.IsInteger = false;
            this.isiNumeric.Location = new System.Drawing.Point(116, 48);
            this.isiNumeric.MaxCoerce = false;
            this.isiNumeric.MaximumSize = new System.Drawing.Size(20000, 20);
            this.isiNumeric.MaxValue = 10000D;
            this.isiNumeric.MinCoerce = false;
            this.isiNumeric.MinimumSize = new System.Drawing.Size(10, 20);
            this.isiNumeric.MinValue = 0D;
            this.isiNumeric.Name = "isiNumeric";
            this.isiNumeric.Size = new System.Drawing.Size(100, 20);
            this.isiNumeric.TabIndex = 2;
            this.isiNumeric.TextFormat = "K4";
            this.isiNumeric.Units = "ms";
            this.isiNumeric.Value = 0D;
            this.isiNumeric.ValueChanged += new System.EventHandler(this.isiNumeric_ValueChanged);
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.msgBox.Enabled = false;
            this.msgBox.Location = new System.Drawing.Point(18, 83);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(198, 81);
            this.msgBox.TabIndex = 6;
            this.msgBox.Text = "This will make extensive changes to the configuration to create a %dAFC stimulus " +
    "paradigm centered around this state.\r\n\r\nAre you sure you want to to continue?\r\n";
            this.msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "OK v2.png");
            this.imageList.Images.SetKeyName(1, "Cancel.png");
            // 
            // createButton
            // 
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createButton.ImageIndex = 0;
            this.createButton.ImageList = this.imageList;
            this.createButton.Location = new System.Drawing.Point(18, 188);
            this.createButton.Name = "createButton";
            this.createButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.createButton.Size = new System.Drawing.Size(95, 40);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.ImageIndex = 1;
            this.cancelButton.ImageList = this.imageList;
            this.cancelButton.Location = new System.Drawing.Point(121, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cancelButton.Size = new System.Drawing.Size(95, 40);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateAFCDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 246);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isiNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numintNumeric);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAFCDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create mAFC...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLib.Controls.KNumericBox numintNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KLib.Controls.KNumericBox isiNumeric;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
    }
}