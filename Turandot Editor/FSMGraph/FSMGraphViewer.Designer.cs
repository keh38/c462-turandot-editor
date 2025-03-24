namespace KLib.Controls
{
    partial class FSMGraphViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSMGraphViewer));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ZoomIn");
            this.imageList.Images.SetKeyName(1, "AutoSize");
            this.imageList.Images.SetKeyName(2, "ZoomOut");
            // 
            // FSMGraphViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FSMGraphViewer";
            this.Size = new System.Drawing.Size(277, 220);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FSMGraphViewer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FSMGraphViewer_KeyUp);
            this.MouseLeave += new System.EventHandler(this.FSMGraphViewer_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
    }
}
