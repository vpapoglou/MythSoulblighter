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
        Timer tm = new Timer();
        List<Image> images = new List<Image>();
        public int i;
        public JournalForm()
        {
            InitializeComponent();
        }

        private void CmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            images.Clear();
            //bug sto i. Den mhdenizetai sto combobox opote an epileksw allh timh den emfanizei thn swsth eikona.

            string text = "";
            string narration = "";
            txtJournal.Visible = true;
            
            if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Willow Creek")
            {
                JournalPictureBox.Image = Image.FromFile(TheCodex.WillowCreek[2]);
                
                images.Add(Image.FromFile(TheCodex.WillowCreek[3]));
                images.Add(Image.FromFile(TheCodex.WillowCreek[4]));
                images.Add(Image.FromFile(TheCodex.WillowCreek[5]));

                i = 0;

                tm.Interval = 20000;
                tm.Tick += new EventHandler(changeImage);
                tm.Start();

                text = System.IO.File.ReadAllText(TheCodex.WillowCreek[0]);
                narration = TheCodex.WillowCreek[1];
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Salvation")
            {            
                JournalPictureBox.Image = Image.FromFile(TheCodex.Salvation[2]);
                
                images.Add(Image.FromFile(TheCodex.Salvation[3]));
                images.Add(Image.FromFile(TheCodex.Salvation[4]));
                images.Add(Image.FromFile(TheCodex.Salvation[5]));
                images.Add(Image.FromFile(TheCodex.Salvation[6]));
                images.Add(Image.FromFile(TheCodex.Salvation[7]));

                i = 0;

                tm.Interval = 12000;
                tm.Tick += new EventHandler(changeImage);
                tm.Start();

                text = System.IO.File.ReadAllText(TheCodex.Salvation[0]);
                narration = TheCodex.Salvation[1];             
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Down a Broken Path")
            {
                
            }

            Program.PlayFile(narration);
            txtJournal.Text = text;
        }
        private void changeImage(object sender, EventArgs e)
        {
            if (i < images.Count())
            {
                JournalPictureBox.Image = images[i++];
            }           
        }
        private void JournalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
