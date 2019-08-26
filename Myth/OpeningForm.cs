﻿using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myth
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpeningForm_Load(object sender, EventArgs e)
        {
            PlayFile(@"C:/Users/Papoglou/source/repos/Myth/images/MainMenu.wav");
        }

        void PlayFile(String url)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = url;
            player.PlayLooping();
            player.Play();
        }

        private void BtnOpening_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapForm mapForm = new MapForm();
            mapForm.Show();
        }
    }
}