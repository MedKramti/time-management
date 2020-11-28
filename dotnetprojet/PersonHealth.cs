using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetprojet
{
    public partial class PersonHealth : UserControl
    {
        public PersonHealth()
        {
            InitializeComponent();
            var use = Inscription1.projectdb.Persons.Select(c => c);
            foreach (Person p in use)
                bunifuDropdown2.AddItem(p.personName);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Health h = new Health();
            h.personName = bunifuDropdown2.selectedValue.ToString();
            h.date = DateTime.Now.ToString();
            if (bunifuCheckbox1.Checked)
                h.state = "Everything is fine";
            else if (bunifuCheckbox2.Checked)
                h.state = "Tired";
            else if (bunifuCheckbox3.Checked)
                h.state = "Stress";
            else if (bunifuCheckbox3.Checked)
                h.state = "Sick";

            if (bunifuCheckbox8.Checked)
                h.activity = "No activity";
            else if (bunifuCheckbox7.Checked)
                h.activity = "Cycling";
            else if (bunifuCheckbox6.Checked)
                h.activity = "Gymnastic";
            else if (bunifuCheckbox5.Checked)
                h.activity = "Swimming";
            else if (bunifuCheckbox12.Checked)
                h.activity = "Race";
            else if (bunifuCheckbox11.Checked)
                h.activity = "Football";
            else if (bunifuCheckbox10.Checked)
                h.activity = "Handball";
            else if (bunifuCheckbox9.Checked)
                h.activity = "Team-Sport";
            Inscription1.projectdb.Healths.InsertOnSubmit(h);
            Inscription1.projectdb.SubmitChanges();
            MessageBox.Show("Successfully added ");
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            checkbox(bunifuCheckbox1);
        }

        public void checkbox(Bunifu.Framework.UI.BunifuCheckbox chechkbox)
        {
            bunifuCheckbox1.Checked = false;
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox3.Checked = false;
            bunifuCheckbox4.Checked = false;

            chechkbox.Checked = true;
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            checkbox(bunifuCheckbox2);
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            checkbox(bunifuCheckbox3);
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            checkbox(bunifuCheckbox4);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
