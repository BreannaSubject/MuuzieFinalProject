using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MuuzieFinalProject
{
    public partial class Form1 : Form
    {
        #region global variables
        int genre, random, start;
        string words, language;
        List<string> songs = new List<string>();
        Random randGen = new Random();

        #endregion

        public Form1()
        {
            start = randGen.Next(1, 9);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region inputs

        private void genreInput_TextChanged(object sender, EventArgs e)
        {// input to find genre preference
            try
            {
                genre = Convert.ToInt32(genreInput.Text);
            }
            catch
            {
                outputLabel.Text = "You must enter a valid answer.";
            }

        }
        

        private void languageInput_TextChanged(object sender, EventArgs e)
        {// input to find out if they have a language preference
            try
            {
                language = languageInput.Text;
            }
            catch
            {
                outputLabel.Text = "You must enter a valid answer.";
            }
        }

        private void wordsInput_TextChanged(object sender, EventArgs e)
        {// input to find out whether they want words in their song or not
            try
            {
                words = wordsInput.Text; 
            }
            catch
            {
                outputLabel.Text = "You must enter a valid answer.";
            }
        }
        #endregion

        private void generateButton_Click(object sender, EventArgs e)
        { //when the button is pushed, the program reads the users inputs and sends them to the genre method they chose
            if (genre > 0 || genre < 4 )
            {
                random = randGen.Next(1, 9);

                while (random == start)
                {
                    random = randGen.Next(1, 9);
                    break;
                }

                start = random;

                switch (genre)
                {
                    case 1:
                        Rock();
                        break;
                    case 2:
                        HipHop();
                        break;
                    case 3:
                        Pop();
                        break;
                    case 4:
                        EDM();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                outputLabel.Text = "You must input a valid anwser.";
            }

            
        }

        #region genre methods
        public void Rock()
        {//fills the list with 8 rock songs based on word and language inputs
            if (words == "N" || words == "n")
            {
                string[] rockNW = { "Epic Swing: Miyavi", "Music: Nightwish", "The Movie: Aerosmith", "Eruption: Van Halen", "Cecilla Ann: Pixies", "Truck: The Fierce and The Dead", "Stressfest: Steve Morse", "Energy: Joe Satriani"};
                songs.AddRange(rockNW);
                ChooseSong();
            }
            else if (words == "Y" || words == "y" )
            {
                if (language == "E" || language == "e")
                {
                    string[] rockE = {"Rusted from the Rain: Billy Talent", "Back in Black: ACDC", "Viking Death March: Billy Talent", "Paranoid: Black Sabbath", "Eden: Battle Beast", "Eye of the Storm: One Ok Rock", "Zombie- English Version: Day6"};
                    songs.AddRange(rockE);
                    ChooseSong();
                }
                else if (language == "A" || language == "a")
                {
                    string[] rockA = { "Torture: Miyavi", "Chase Me: Dreamcatcher", "Shoot Me: Day6", "Day1: Miyavi", "I Wait: Day6", "Ha Na Bi: Miyavi", "Don't Don: Super Junior", "Piri: Dreamcatcher" };
                    songs.AddRange(rockA);
                    ChooseSong();
                }
                else
                {
                    outputLabel.Text = "You must input a valid anwser.";
                }
            }
            
            
        }

        public void HipHop()
        {//fills the list with 8 hiphop songs based on word and language inputs
            if (words == "N"|| words == "n") 
            {
                string[] hipHopNW = { "Control-Interlude: Ravi", "In the Shadows: Blank Moody", "Fly Music: Morning Lightmusic", "Make Love: twuan", "Thrones: Chuki Bealse", "Milmo: Homebody", "Samurai: Toby Tranter", "Intro- Escape: A.C.E."};
                songs.AddRange(hipHopNW);
                ChooseSong();
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] hipHopE = { "Lose Yourself: Eminem", "Circles: Post Malone", "Old Town Road: Lil' Nas X ft. RM", "End Like That: Kodie Shane", "Lose Control: Missy Elliot ft. Ciara and Fat Man Scoop", "tokyo tea: Shawn Wasabi ft. Spacegirl Gemmy", "Namanana: Lay", "Burnt Rice: Shawn Wasabi ft. Yung Gemmy" };
                    songs.AddRange(hipHopE);
                    ChooseSong();
                }
                else if (language == "A"|| language == "a")
                {
                    string[] hipHopA = { "TML: Cold Bay ft. Ravi", "Still Nirvana: Ravi ft. Xydo + HAON", "Ghost: VIXX LR", "Outro: Tear: BTS", "Tian Di: Kris Wu", "N/S: Stray Kids", "Chypher 4: BTS", "El Dorado: Ravi" };
                    songs.AddRange(hipHopA);
                    ChooseSong();
                }
                else
                {
                    outputLabel.Text = "You must input a valid anwser.";
                }
            }
        }

        public void Pop()
        {//fills the list with 8 pop songs based on word and language inputs
            if (words == "N" || words == "n")
            {
                string[] popNW = { "Back Again- Instrumental: KNK", "Can't Hold Us: Piano Tribute Players", "Daydream: Float 11", "Yin and Yang: Uyama Hiroto", "Sink to Chair: Stones Taro", "Sol Levante: Tri4th", "Spiritual State: Nujabes ft. Uyama Hiroto", "Chained Up-Insturmental: VIXX" };
                songs.AddRange(popNW);
                ChooseSong();
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] popE = { "100 ways: Jackson Wang", "What Do You Mean: Justin Bieber", "Shut Up And Dance: Jason Derulo ft. Lay and NCT 127", "Dj Got Us Falling In Love: Usher", "Give Me Everything: Pitbull ft. Neyo, Nayer and Afrojack", "On the Floor: Jennifer Lopez ft. Pitbull", "Scream: Usher", "Price Tag: Jessie J ft. B.O.B" };
                    songs.AddRange(popE);
                    ChooseSong();
                }
                else if (language == "A" || language == "a")
                {
                    string[] popA = { "Follow Me: E-Girls", "Trap: Henry ft. Taemin and Kyuhyun", "Miroh: Stray Kids", "#OOTD: Xydo ft. Coogie", "Rock Your Body: VIXX", "Why So Serious: SHINee", "G-Energy: Generations from Exile Tribe", "Jealous: TVXQ" };
                    songs.AddRange(popA);
                    ChooseSong();
                }
                else
                {
                    outputLabel.Text = "You must input a valid anwser.";
                }
            }
           
        }

        public void EDM()
        {//fills the list with 8 edm songs based on word and language inputs
            if (words == "N" || words == "n")
            {
                string[] edmNW = { "Tron Legacy (End Title) : Daft Punk", "Running Away: Farius","Maia: Kamito Sanclemante, Dabeat", "Nightwalk: Spencer Brown", "End of Line: Daft Punk", "Kino: Dirty South", "Coffee Black: Feed Me", "Full Train: Stones Taro" };
                songs.AddRange(edmNW);
                ChooseSong();
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] edmE = { "Run for your life: Tiffany Young", "That Power: William ft. Justin Beiber", "Bad Guy: Billie Eillish", "Rock Your Body: Black Eyed Peas", "Clarity: Zedd ft. Foxes", "Harder Better Faster Stronger: Daft Punk", "Pump it: Black Eyed Peas", "Hey Mama: David Guetta ft. Nicki Minaj, Bebe Rexha, Afrojack" };
                    songs.AddRange(edmE);
                    ChooseSong();
                }
                else if (language == "A" || language == "a")
                {
                    string[] edmA = { "Road Not Taken: Stray Kids", "Around: Hitchhiker & Taeyong", "Time: Hitchhiker ft. Taeyong, Sunny and Hyoyeon", "Punk Right Now: Hyoyeon ft. 3LAU", "Entrance: Stray Kids", "Take Off: WayV", "Badster: Hyoyeon", "Punch: NCT 127" };
                    songs.AddRange(edmA);
                    ChooseSong();
                }
                else
                {
                    outputLabel.Text = "You must input a valid anwser.";
                }

            }

        }
        #endregion

        public void ChooseSong()
        { //chooses a song from the list created for the user and inputs it to the screen
            infoLabel3.Visible = false;
            rockLabel.Visible = false;
            hipHopLabel.Visible = false;
            popLabel.Visible = false;
            edmLabel.Visible = false;
            genreInput.Visible = false;
            languageInput.Visible = false;
            wordsInput.Visible = false;

            infoLabel2.Font = new Font("Gill Sans MT", 20, FontStyle.Bold);
            infoLabel2.ForeColor = Color.RoyalBlue;
            infoLabel2.BackColor = SystemColors.ControlText;

            infoLabel1.Text = "Your Song is:";
            outputLabel.Text = "Would you like to generate another?";

            for (int i = 0; i < songs.Count(); i++ )
            {
                if (i == random)
                {
                    infoLabel2.Text = songs[i];
                    break;
                }
            }
        }

        
    }
}
