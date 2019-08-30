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
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnits.BackColor = System.Drawing.Color.Black;
            this.btnUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnits.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUnits.Location = new System.Drawing.Point(458, 493);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(201, 49);
            this.btnUnits.TabIndex = 1;
            this.btnUnits.Text = "Units";
            this.btnUnits.UseVisualStyleBackColor = false;
            this.btnUnits.Click += new System.EventHandler(this.BtnUnits_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnJournal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJournal.BackColor = System.Drawing.Color.Black;
            this.btnJournal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJournal.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJournal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnJournal.Location = new System.Drawing.Point(458, 427);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(201, 51);
            this.btnJournal.TabIndex = 3;
            this.btnJournal.Text = "Journal";
            this.btnJournal.UseVisualStyleBackColor = false;
            this.btnJournal.Click += new System.EventHandler(this.BtnJournal_Click);
            // 
            // btnMap
            // 
            this.btnMap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMap.BackColor = System.Drawing.Color.Black;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMap.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMap.Location = new System.Drawing.Point(458, 548);
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
            this.btnExit.Location = new System.Drawing.Point(458, 733);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 51);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1123, 794);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.btnUnits);
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
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnExit;
    }
}