using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace dotnetprojet
{
    public partial class MainMenu : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public MainMenu()
        {
            
            InitializeComponent();
           

        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PersonHealth h1 = new PersonHealth();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(h1);
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tasks_Click(object sender, EventArgs e)
        {

            TasksController t = new TasksController(myPanel);
            myPanel.Controls.Clear();
            myPanel.Controls.Add(t);

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Inscription1 ins = new Inscription1("update");
            ins.Show();
            this.Hide();
          
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            StatisticController s1 = new StatisticController();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(s1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            button2.Enabled = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)

        {
            String ch = "";
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.xDD;
            var use = from x in Inscription1.projectdb.Events
                      where x.important == 1
                      select new
                      {
                        x.person
                      };
            foreach (var item in use)
            {
                ch = ch + item.ToString();
                ch = ch + ", ";
            }
            popup.ContentText = ch + " ont des evenements importants";

            popup.Popup();
            Choices commands = new Choices();
            commands.Add(new string[] { "go to health","go to task","go to statistique","go to setting" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

         void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("go to health"))
            {
                PersonHealth h1 = new PersonHealth();
                myPanel.Controls.Clear();
                myPanel.Controls.Add(h1);
                recEngine.RecognizeAsyncStop();
               // button1.Enabled = false;
            }
            if (e.Result.Text.Equals("go to task"))
            {
                TasksController t = new TasksController(myPanel);
                myPanel.Controls.Clear();
                myPanel.Controls.Add(t);
                recEngine.RecognizeAsyncStop();
                // button1.Enabled = false;
            }
            if (e.Result.Text.Equals("go to statistique"))
            {
                StatisticController s1 = new StatisticController();
                myPanel.Controls.Clear();
                myPanel.Controls.Add(s1);
                recEngine.RecognizeAsyncStop();
                // button1.Enabled = false;
            }
            if (e.Result.Text.Equals("go to setting"))
            {
                Inscription1 ins = new Inscription1("update");
                ins.Show();
                this.Hide();
                recEngine.RecognizeAsyncStop();
                // button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            button2.Enabled = false;
        }
    }
}
