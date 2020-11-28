using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetprojet
{
    public partial class PremierPage : Form
    {
        public PremierPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Commencer_Click(object sender, EventArgs e)
        {
            Inscription1 ins1 = new Inscription1();
            ins1.Show();
            this.Hide();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        private void toolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        private void CreationCompte_Click(object sender, EventArgs e)
        {
            Connexion cnx = new Connexion();
            cnx.Show();
            this.Hide();
        }
    }
}
