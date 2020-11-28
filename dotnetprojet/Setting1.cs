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
    public partial class Setting1 : UserControl
    {
        public Setting1()
        {
            InitializeComponent();
            var use = Inscription1.projectdb.Persons.Select(c => c);
            foreach (Person p in use)
                bunifuDropdown2.AddItem(p.personName);
            bunifuDropdown1.AddItem("Rendez-vous Travail");
            bunifuDropdown1.AddItem("Rendez-vous Médical");
            bunifuDropdown1.AddItem("Rendez-vous Amical");

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((bunifuMaterialTextbox1.Text=="") ||(bunifuMaterialTextbox2.Text=="")||(txt_name.Text==""))
            {
                MessageBox.Show("All Champs Are Required !");
            }
            else {
                Events e1 = new Events();
                e1.person = bunifuDropdown2.selectedValue;
                e1.eventName = txt_name.Text;
                e1.startDate = bunifuDatepicker1.Value;
                e1.finishDate = bunifuDatepicker2.Value;
                e1.location = bunifuMaterialTextbox1.Text;
                e1.type = bunifuDropdown1.selectedValue;
                e1.description = bunifuMaterialTextbox2.Text;
                if (yes.Checked)
                    e1.important = 1;
                else
                    e1.important = 0;
                
                Inscription1.projectdb.Events.InsertOnSubmit(e1);
                Inscription1.projectdb.SubmitChanges();
                MessageBox.Show("Successfuly Added");
            }
           
            
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
