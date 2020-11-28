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
    public partial class Inscription2 : Form
    { public string firstname;
        public string lastname;
        public string email;
        public string password;
        public string action = "insert";
        public static User user = new User();

        public Inscription2(String firstname, String lastname,String password, String email,string action="insert")
        {
            
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
          
            InitializeComponent();

            if (action == "update")
            {
                this.action = "update";
                try
                {
                    var u = Inscription1.projectdb.Users.Select(c => c).First();
                  
                        adresse.Text = u.address;
                        nbrchild.Text = u.nbChildren+"";
                       // userschedule.Text = 
                        if (u.genre == 0)
                        {
                        
                            female.Checked = true;
                            male.Checked = false;
                    }
                    else
                    {
                        male.Checked = true;
                        female.Checked = false;
                      
                    }
                  


                    if (u.mother == 1)
                        {
                            mother.Checked = true;
                        }

                        if (u.father == 1)
                            father.Checked = true;
                    if (u.status == 0)
                        single.Checked = true;
                    else
                        married.Checked = true;

                    var p = Inscription1.projectdb.Persons.Select(c => c).Where(x=>x.type=="user").First();
                    userschedule.Text = p.schedule;
                    job.Text = p.jobstudylevel;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No data found");
                }


            }

        }
    public Inscription2()
        {
            InitializeComponent();

        }

    private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Inscription1 p1 = new Inscription1();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
           if ((nbrchild.Text=="") || (job.Text=="") || (userschedule.Text==""))
            {
                MessageBox.Show("All Champs are required !");
            }
            else
            {


                if (this.action == "update")
                {
                    // remove old "admin" records from users and person
                    Inscription1.projectdb.Users.DeleteAllOnSubmit(Inscription1.projectdb.Users);
                    //Inscription1.projectdb.ExecuteCommand("DELETE FROM Persons where type = 'user'");
                    var use = Inscription1.projectdb.Persons.Select(c => c).Where(x => x.type=="user");
                    foreach(Person p in use.ToList())
                    {
                        Inscription1.projectdb.Persons.DeleteOnSubmit(p);
                    }
                    Inscription1.projectdb.SubmitChanges();
                }
                try
                {

                    user.firstName = firstname;


                    user.lastName = lastname;
                    user.password = password;
                    user.email = email;
                    user.birthday = datebirth.Value;
                    if (female.Checked)
                        user.genre = 0;
                    else user.genre = 1;
                    user.address = adresse.Text;
                    if (single.Checked)
                        user.status = 0;
                    else
                        user.status = 1;

                    user.nbChildren = int.Parse(nbrchild.Text);
                    if (father.Checked)
                    {
                        user.father = 1;

                    }
                    else user.father = 0;
                    if (mother.Checked)
                        user.mother = 1;
                    else user.mother = 0;

                Inscription1.projectdb.Users.InsertOnSubmit(user);
                Inscription1.projectdb.SubmitChanges();
               
                Person person = new Person();
                person.personName = firstname;
                person.jobstudylevel = job.Text;
                person.schedule = userschedule.Text;
                person.type = "user";
                Inscription1.projectdb.Persons.InsertOnSubmit(person);
                Inscription1.projectdb.SubmitChanges();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (user.nbChildren > 0)
                {
                    ChildrenForm children = new ChildrenForm(this.action);
                    children.Show();
                }
                else if ((user.father == 1) || (user.mother == 1))
                {
                    Parent parent = new Parent();
                    parent.Show();
                }
                else if (user.status == 1)
                {
                    SpouseName spouse = new SpouseName();
                    spouse.Show();
                }
                else
                {
                    MainMenu main = new MainMenu();
                    main.Show();
                }


                this.Hide();
            }

        }

        private void Inscription2_Load(object sender, EventArgs e)
        {
            if (this.action == "insert")
            {
                female.Checked = true;
                single.Checked = true;

            }

        }

        private void female_OnChange(object sender, EventArgs e)
        {
            male.Checked = false;
        }

        private void male_OnChange(object sender, EventArgs e)
        {
            female.Checked = false;
        }

        private void single_OnChange(object sender, EventArgs e)
        {
            married.Checked = false;
        }

        private void married_OnChange(object sender, EventArgs e)
        {
            single.Checked = false;
        }
    }
}
