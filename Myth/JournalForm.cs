using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Myth
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }
        void PlayFile(String url)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = url;
            player.Play();
        }

        private void CmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            string narration = "";
            string image1 = "";
            string image2 = "";
            string image3 = "";
            string image4 = "";
            txtJournal.Visible = true;
            if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Willow Creek")
            {
                text = System.IO.File.ReadAllText(TheCodex.WillowCreek[0]);
                narration = TheCodex.WillowCreek[1];
                image1 = TheCodex.WillowCreek[2];
                image2 = TheCodex.WillowCreek[3];
                image3 = TheCodex.WillowCreek[4];
                image4 = TheCodex.WillowCreek[5];

                PlayFile(narration);
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Salvation")
            {

            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Down A Broken Path")
            {

            }
            JournalPictureBox.Image = Image.FromFile(image1);
            txtJournal.Text = text;
        }
    }
}
