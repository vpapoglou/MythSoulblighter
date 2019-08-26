using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDescription.Visible = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = "";
            string unitDescription = "";
            txtDescription.Visible = true;
            if (cmbUnits.GetItemText(this.cmbUnits.SelectedItem) == "Myrkridia")
            {                
                unitDescription = TheCodex.Myrkridia[0];
                item = TheCodex.Myrkridia[1];
            }
            else if (cmbUnits.GetItemText(this.cmbUnits.SelectedItem) == "Soulless")
            {
                unitDescription = TheCodex.Soulless[0];
                item = TheCodex.Soulless[1];
            }
            else if (cmbUnits.GetItemText(this.cmbUnits.SelectedItem) == "Maul")
            {
                unitDescription = TheCodex.Maul[0];
                item = TheCodex.Maul[1];
            }
            pictureBox1.Image = Image.FromFile(item);
            txtDescription.Text = unitDescription;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/Papoglou/source/repos/Myth/images/intro.jpg");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CmbForces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbForces.GetItemText(this.cmbForces.SelectedItem) == "Light")
            {
                cmbUnits.Items.Clear();
                cmbUnits.Items.Add("Warrior");
                cmbUnits.Items.Add("Archer");
                cmbUnits.Items.Add("Dwarf");
            }
            else
            {
                cmbUnits.Items.Clear();
                cmbUnits.Items.Add("Myrkridia");
                cmbUnits.Items.Add("Soulless");
                cmbUnits.Items.Add("Maul");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpeningForm menu = new OpeningForm();
            menu.Show();
        }
    }
}
