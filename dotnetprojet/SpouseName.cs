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
    public partial class SpouseName : Form
    {
        public string action = "insert";
        public SpouseName(string action="insert")
        {
            InitializeComponent();
            if (action == "update")
            {
                this.action = "update";
                updateBtn.Visible = true;
                var p = Inscription1.projectdb.Persons.Select(c => c).Where(x => x.type == "partner").First();
                spouseNametxt.Text = p.personName;
                spouseJobTxt.Text = p.jobstudylevel;
                spouseschedule.Text = p.schedule;

            }
            if (Inscription2.user.status==0)
            {
                this.Hide();
                MainMenu m = new MainMenu();
                m.Show();


            }
           
        }

        private void NivEtude_OnTextChange(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Parent p = new Parent();
            p.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (this.action == "insert")
            {
                insertPartner();
            }

            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // delete old record
            var p = Inscription1.projectdb.Persons.Select(c => c).Where(x => x.type == "partner").First();
            Inscription1.projectdb.Persons.DeleteOnSubmit(p);
            Inscription1.projectdb.SubmitChanges();
            // insert new record
            insertPartner();

            MessageBox.Show("Successfuly updated ");
        }

        public void insertPartner()
        {
            Person spouse = new Person();
            spouse.personName = spouseNametxt.Text;
            spouse.jobstudylevel = spouseJobTxt.Text;
            spouse.schedule = spouseschedule.Text;
            // to do
            // add type col to database 
            spouse.type = "partner";
            Inscription1.projectdb.Persons.InsertOnSubmit(spouse);
            Inscription1.projectdb.SubmitChanges();
        }
    }
}
