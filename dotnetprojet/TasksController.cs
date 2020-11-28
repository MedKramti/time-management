using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace dotnetprojet
{
    public partial class TasksController : UserControl
    {
        BunifuGradientPanel b1;
        public TasksController(BunifuGradientPanel b1)
        {
            this.b1 = b1;
            InitializeComponent();
            var use = Inscription1.projectdb.Events.Select(c => c);
            foreach (Events p in use)
                bunifuDropdown2.AddItem(p.person);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            b1.Controls.Clear();
            b1.Controls.Add(new Setting1());
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = null;
            String personname = bunifuDropdown2.selectedValue;
            var use = Inscription1.projectdb.Events.Select(c => c).Where(c => c.person == personname);
            bunifuCustomDataGrid1.DataSource = use.ToList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Events row = (bunifuCustomDataGrid1.SelectedRows[0].DataBoundItem as Events);
                MessageBox.Show(row.eventName + " " + row.person);
                try
                {
                    Events t1 = Inscription1.projectdb.Events.Single<Events>(x => x.eventName == row.eventName);
                    if (t1 == null)
                    {
                        throw new Exception("Error please select an event");
                    }
                    var lst = from x in Inscription1.projectdb.Events
                              where x.eventName == row.eventName
                              select x;

                    foreach (var item in lst)
                    {

                        Inscription1.projectdb.Events.DeleteOnSubmit(item);

                    }


                    Inscription1.projectdb.Events.DeleteOnSubmit(t1);

                    Inscription1.projectdb.SubmitChanges();
                    MessageBox.Show("Event has been deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            //  var use = Inscription1.projectdb.Events.Select(c => c).De


            catch (Exception ex)
            {
                MessageBox.Show("Please select full row");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender ,System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp = new Bitmap(this.bunifuCustomDataGrid1.Width, this.bunifuCustomDataGrid1.Height);
            bunifuCustomDataGrid1.DrawToBitmap(objbmp, new Rectangle(0, 0, this.bunifuCustomDataGrid1.Width, this.bunifuCustomDataGrid1.Height));
            e.Graphics.DrawImage(objbmp, 100, 40);
            e.Graphics.DrawString("plannig for "+bunifuDropdown2.selectedValue, new Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point());

        }
        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
