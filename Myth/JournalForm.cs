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
using WMPLib;

namespace Myth
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }

        private void CmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            string narration = "";
            //string image1 = "";
            //string image2 = "";
            //string image3 = "";
            //string image4 = "";
            txtJournal.Visible = true;
            if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Willow Creek")
            {
                //image1 = TheCodex.WillowCreek[2];
                //image2 = TheCodex.WillowCreek[3];
                //image3 = TheCodex.WillowCreek[4];
                //image4 = TheCodex.WillowCreek[5];
                JournalPictureBox.Image = Image.FromFile(TheCodex.WillowCreek[2]);
                Timer tm = new Timer();
                tm.Interval = 1600;
                tm.Tick += changeImage;
                //tm.Tick += new EventHandler(changeImage);
                tm.Start();

                text = System.IO.File.ReadAllText(TheCodex.WillowCreek[0]);
                narration = TheCodex.WillowCreek[1];
                

                Program.PlayFile(narration);
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Salvation")
            {

            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Down A Broken Path")
            {

            }
            //JournalPictureBox.Image = Image.FromFile(image1);
            txtJournal.Text = text;
        }
        //(TheCodex.WillowCreek[2], TheCodex.WillowCreek[3], TheCodex.WillowCreek[4], TheCodex.WillowCreek[5])
        //string image1, string image2, string image3, string image4, 
        private void changeImage(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            images.Add(Image.FromFile(TheCodex.WillowCreek[2]));
            images.Add(Image.FromFile(TheCodex.WillowCreek[3]));
            images.Add(Image.FromFile(TheCodex.WillowCreek[4]));
            images.Add(Image.FromFile(TheCodex.WillowCreek[5]));
            int index = DateTime.Now.Second % images.Count;
            JournalPictureBox.Image = images[index];

        }



        private void JournalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
