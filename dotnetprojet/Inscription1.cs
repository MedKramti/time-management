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
    public partial class Inscription1 : Form
    {
        internal static DBDataContext projectdb = new DBDataContext();
        Inscription2 ins2;
        public string action = "insert";
        public Inscription1(string text) {
            InitializeComponent();
            if (text == "update")
            {
                this.action = "update";
                try
                {
                    var use = Inscription1.projectdb.Users.Select(c => c);
                    foreach (User u in use)
                    {
                        firstname.Text = u.firstName;
                        lastname.Text = u.lastName;
                        email.Text = u.email;
                        password.Text = u.password;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("No data found");
                }
             
            
            }
        }
        public Inscription1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            PremierPage p1 = new PremierPage();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {

            if ((firstname.Text == "") || (lastname.Text == "") || (email.Text == "") || (password.Text == ""))
            {
                MessageBox.Show("All Champs Are Required !");
            }
            else
            {
                Inscription2 p2 = new Inscription2(firstname.Text, lastname.Text, password.Text, email.Text,this.action);

                p2.Show();
                this.Hide();
            }
        }

        private void bunifuTextbox3_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void Inscription1_Load(object sender, EventArgs e)
        {

        }
    }
}
