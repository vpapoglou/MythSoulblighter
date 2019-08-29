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
        int i;
        public JournalForm()
        {
            InitializeComponent();
        }

        private void CmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            images.Clear();
            
            //to problima einai sto i. Den mhdenizetai an den allakseis epilogh sto combobox. Prepei na dokimasw alla events se syndyasmo me auto opws to dropdown closed.

            string text = "";
            string narration = "";
            txtJournal.Visible = true;
            
            if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Willow Creek")
            {
                tm.Dispose();
                JournalPictureBox.Image = Image.FromFile(TheCodex.WillowCreek[2]);
                
                images.Add(Image.FromFile(TheCodex.WillowCreek[3]));
                images.Add(Image.FromFile(TheCodex.WillowCreek[4]));
                images.Add(Image.FromFile(TheCodex.WillowCreek[5]));

                
                tm.Interval = 20000;
                tm.Tick += new EventHandler(changeImage);
                tm.Start();

                text = System.IO.File.ReadAllText(TheCodex.WillowCreek[0]);
                narration = TheCodex.WillowCreek[1];
                

                Program.PlayFile(narration);
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Salvation")
            {
                tm.Dispose();               
                JournalPictureBox.Image = Image.FromFile(TheCodex.Salvation[2]);
                
                images.Add(Image.FromFile(TheCodex.Salvation[3]));
                images.Add(Image.FromFile(TheCodex.Salvation[4]));
                images.Add(Image.FromFile(TheCodex.Salvation[5]));
                images.Add(Image.FromFile(TheCodex.Salvation[6]));
                images.Add(Image.FromFile(TheCodex.Salvation[7]));
                
                tm.Interval = 12000;
                tm.Tick += new EventHandler(changeImage);
                tm.Start();

                text = System.IO.File.ReadAllText(TheCodex.Salvation[0]);
                narration = TheCodex.Salvation[1];


                Program.PlayFile(narration);
            }
            else if (cmbJournal.GetItemText(this.cmbJournal.SelectedItem) == "Down a Broken Path")
            {

            }
            txtJournal.Text = text;
        }
        //int i=0;
        private void changeImage(object sender, EventArgs e)
        {

        }



        private void JournalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CmbJournal_DropDownClosed(object sender, EventArgs e)
        {
            i = 0;
        }
    }
}
