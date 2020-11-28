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
    public partial class ChildrenForm : Form
    {
        int nbChildrenSubmited=0;
        public string action = "insert";
        public ChildrenForm(string action="insert")
        {

            InitializeComponent();
            if (action == "update")
            {
                this.action = "update";
                combobox.Visible = true;
                updatebtn.Visible = true;
                try
                {
                    var use = Inscription1.projectdb.Childrens.Select(c => c);
                    foreach(Children ch in use)
                    {
                        combobox.AddItem(ch.childrenName);
                    }
                  
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No data found");
                }
            }
        }

        private void ChildrenForm_Load(object sender, EventArgs e)
        {
           
        }
        private void ChildrenForm_Shown(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Inscription2 ins2 = new Inscription2();
            ins2.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (this.action == "update")
            {
                nextForm();
            }
            else
            {
                        if ((childrenNameTxt.Text=="")||(degreeTxt.Text=="")||(schoolDistanceTxt.Text==""))
                        {
                            MessageBox.Show("All Champs Are Required !");
                        }
                        else
                        {
                 
                        try
                        {
                            Children children = new Children();

                   
                            children.childrenName = childrenNameTxt.Text;
                            children.studyLevel = degreeTxt.Text;
                            children.schoolDistance = int.Parse(schoolDistanceTxt.Text);

                            Inscription1.projectdb.Childrens.InsertOnSubmit(children);
                 
                            this.nbChildrenSubmited++;
                            Person person = new Person();
                            person.personName = childrenNameTxt.Text;
                            person.jobstudylevel = degreeTxt.Text;
                            person.schedule = childrenschedule.Text;
                            person.type = "children";
                            Inscription1.projectdb.Persons.InsertOnSubmit(person);
                            Inscription1.projectdb.SubmitChanges();

                            if (Inscription2.user.nbChildren == this.nbChildrenSubmited)
                            {

                                nextForm();

                            }
                            else
                            {
                                childrenNameTxt.Text = "";
                                schoolDistanceTxt.Text = "";
                                degreeTxt.Text = "";

                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                     }
            }
        }

        private void combobox_onItemSelected(object sender, EventArgs e)
        {
              var ch = Inscription1.projectdb.Childrens.Select(c => c).Where(x => x.childrenName == combobox.selectedValue).First();
              childrenNameTxt.Text = ch.childrenName;
              degreeTxt.Text = ch.studyLevel;
              schoolDistanceTxt.Text = ch.schoolDistance+"";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // delete old record
            var ch = Inscription1.projectdb.Childrens.Select(c => c).Where(x => x.childrenName == combobox.selectedValue).First();
            Inscription1.projectdb.Childrens.DeleteOnSubmit(ch);
            Inscription1.projectdb.SubmitChanges();
            // insert new record
            Children children = new Children();

            children.childrenName = childrenNameTxt.Text;
            children.studyLevel = degreeTxt.Text;
            children.schoolDistance = int.Parse(schoolDistanceTxt.Text);

            Inscription1.projectdb.Childrens.InsertOnSubmit(children);
            Inscription1.projectdb.SubmitChanges();

            MessageBox.Show("Successfuly updated ");

        }
        public void nextForm()
        {
            if ((Inscription2.user.father == 1) || (Inscription2.user.mother == 1))
            {
                Parent parent = new Parent();
                parent.Show();
                this.Hide();
            }
            else if (Inscription2.user.status == 1)
            {
                SpouseName spouse = new SpouseName(this.action);
                spouse.Show();
                this.Hide();
            }
            else
            {
                MainMenu m = new MainMenu();
                m.Show();
                this.Hide();
            }
        }
    }
   
    }


