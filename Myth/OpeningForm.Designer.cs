namespace Myth
{
    partial class OpeningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpening = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnOpening
            // 
            this.btnOpening.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOpening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpening.BackColor = System.Drawing.Color.Black;
            this.btnOpening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpening.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpening.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpening.Location = new System.Drawing.Point(517, 421);
            this.btnOpening.Name = "btnOpening";
            this.btnOpening.Size = new System.Drawing.Size(201, 49);
            this.btnOpening.TabIndex = 1;
            this.btnOpening.Text = "Continue";
            this.btnOpening.UseVisualStyleBackColor = false;
            this.btnOpening.Click += new System.EventHandler(this.BtnOpening_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCredits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCredits.BackColor = System.Drawing.Color.Black;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCredits.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCredits.Location = new System.Drawing.Point(517, 554);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(201, 51);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            this.btnMap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMap.BackColor = System.Drawing.Color.Black;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMap.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMap.Location = new System.Drawing.Point(517, 485);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(201, 51);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.Location = new System.Drawing.Point(517, 734);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 51);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1240, 797);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnOpening);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OpeningForm";
            this.Text = "Myth 2: Soulbligther";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpeningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpening;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnExit;
    }
}