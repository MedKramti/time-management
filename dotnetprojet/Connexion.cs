using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
namespace dotnetprojet
{
    public partial class Connexion : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "go to application please" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("go to application please"))
            {
                MainMenu p1 = new MainMenu();
                p1.Show();
                this.Hide();
                recEngine.RecognizeAsyncStop();
                button1.Enabled = false;
            }
        }
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            PremierPage p1 = new PremierPage();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            
            try
            {
               var user = Inscription1.projectdb.Users.Where(p => p.email == email.Text && p.password == password.Text).Single();



                if (user!=null)
            {
                MainMenu p1 = new MainMenu();
                p1.Show();
                this.Hide();
            }
            
                }catch(Exception)
            {
                MessageBox.Show("email et passe incorrect");
            }


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
           
        }

        
    }
}
