namespace Myth
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MapPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MapPictureBox.Image")));
            this.MapPictureBox.Location = new System.Drawing.Point(84, 2);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(629, 409);
            this.MapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MapPictureBox.TabIndex = 0;
            this.MapPictureBox.TabStop = false;
            // 
            // MapForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.MapPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MapForm";
            this.Text = "MapForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPictureBox;
    }
}