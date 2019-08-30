namespace Myth
{
    partial class JournalForm
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
            this.JournalPictureBox = new System.Windows.Forms.PictureBox();
            this.txtJournal = new System.Windows.Forms.TextBox();
            this.cmbJournal = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JournalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // JournalPictureBox
            // 
            this.JournalPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JournalPictureBox.Location = new System.Drawing.Point(207, 11);
            this.JournalPictureBox.Name = "JournalPictureBox";
            this.JournalPictureBox.Size = new System.Drawing.Size(753, 539);
            this.JournalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JournalPictureBox.TabIndex = 0;
            this.JournalPictureBox.TabStop = false;
            // 
            // txtJournal
            // 
            this.txtJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtJournal.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJournal.Font = new System.Drawing.Font("MS Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJournal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtJournal.Location = new System.Drawing.Point(207, 648);
            this.txtJournal.Multiline = true;
            this.txtJournal.Name = "txtJournal";
            this.txtJournal.ReadOnly = true;
            this.txtJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJournal.Size = new System.Drawing.Size(753, 133);
            this.txtJournal.TabIndex = 3;
            // 
            // cmbJournal
            // 
            this.cmbJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbJournal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJournal.FormattingEnabled = true;
            this.cmbJournal.Items.AddRange(new object[] {
            "Willow Creek",
            "Salvation"});
            this.cmbJournal.Location = new System.Drawing.Point(514, 555);
            this.cmbJournal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJournal.Name = "cmbJournal";
            this.cmbJournal.Size = new System.Drawing.Size(174, 24);
            this.cmbJournal.TabIndex = 2;
            this.cmbJournal.SelectedIndexChanged += new System.EventHandler(this.CmbUnits_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Location = new System.Drawing.Point(1058, 745);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(1058, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1189, 823);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJournal);
            this.Controls.Add(this.cmbJournal);
            this.Controls.Add(this.JournalPictureBox);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JournalForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.JournalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JournalPictureBox;
        private System.Windows.Forms.TextBox txtJournal;
        private System.Windows.Forms.ComboBox cmbJournal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}