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
        int genre, random;
        string words, language;
        List<string> songs = new List<string>();
        Random randGen = new Random();

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genreInput_TextChanged(object sender, EventArgs e)
        {
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
        {
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
        {
            try
            {
                words = wordsInput.Text; 
            }
            catch
            {
                outputLabel.Text = "You must enter a valid answer.";
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
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

        public void Rock()
        {
            if (words == "N" || words == "n")
            {
                string[] rockNW = { "Epic Swing: Miyavi", "Music: Nightwish", "The Movie: Aerosmith", "Eruption: Van Halen", "Cecilla Ann: Pixies", "Truck: The Fierce and The Dead", "Stressfest: Steve Morse", "Energy: Joe Satriani"};
                songs.AddRange(rockNW); 
            }
            else if (words == "Y" || words == "y" )
            {
                if (language == "E" || language == "e")
                {
                    string[] rockE = {"Rusted from the Rain: Billy Talent", "Back in Black: ACDC", "Viking Death March: Billy Talent", "Paranoid: Black Sabbath", "Eden: Battle Beast", "Eye of the Storm: One Ok Rock", "Zombie- English Version: Day6"};
                    songs.AddRange(rockE);
                }
                else if (language == "A" || language == "a")
                {
                    string[] rockA = { "Torture: Miyavi", "Chase Me: Dreamcatcher", "Shoot Me: Day6", "Day1: Miyavi", "I Wait: Day6", "Ha Na Bi: Miyavi", "Don't Don: Super Junior", "Piri: Dreamcatcher" };
                    songs.AddRange(rockA);
                }
            }
        }

        public void HipHop()
        {
            if (words == "N"|| words == "n") 
            {
                string[] hipHopNW = { "Control-Interlude: Ravi", "In the Shadows: Blank Moody", "Fly Music: Morning Lightmusic", "Make Love: twuan", "Thrones: Chuki Bealse", "Milmo: Homebody", "Samurai: Toby Tranter", "Intro- Escape: A.C.E."};
                songs.AddRange(hipHopNW);
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] hipHopE = { "Lose Yourself: Eminem", "Circles: Post Malone", "Old Town Road: Lil' Nas X ft. RM", "End Like That: Kodie Shane", "Lose Control: Missy Elliot ft. Ciara and Fat Man Scoop", "tokyo tea: Shawn Wasabi ft. Spacegirl Gemmy", "Namanana: Lay", "Burnt Rice: Shawn Wasabi ft. Yung Gemmy" };
                    songs.AddRange(hipHopE);
                }
                else if (language == "A"|| language == "a")
                {
                    string[] hipHopA = { "TML: Cold Bay ft. Ravi", "Still Nirvana: Ravi ft. Xydo + HAON", "Ghost: VIXX LR", "Outro: Tear: BTS", "Tian Di: Kris Wu", "N/S Stray Kids", "Chypher 4: BTS", "El Dorado: Ravi" };
                    songs.AddRange(hipHopA);
                }
            }
        }

        public void Pop()
        {
            if (words == "N" || words == "n")
            {
                string[] popNW = { "Back Again- Instrumental: KNK", "Can't Hold Us: Piano Tribute Players", "Daydream: Float 11", "Yin and Yang: Uyama Hiroto", "Sink to Chair: Stones Taro", "Sol Levante: Tri4th", "Spiritual State: Nujabes ft. Uyama Hiroto", "Chained Up-Insturmental: VIXX" };
                songs.AddRange(popNW);
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] popE = { "100 ways: Jackson Wang", "What Do You Mean: Justin Bieber", "Shut Up And Dance: Jason Derulo ft. Lay and NCT 127", "Dj Got Us Falling In Love: Usher", "Give Me Everything: Pitbull ft. Neyo, Nayer and Afrojack", "On the Floor: Jennifer Lopez ft. Pitbull", "Scream: Usher", "Price Tag: Jessie J ft. B.O.B" };
                    songs.AddRange(popE);
                }
                else if (language == "A" || language == "a")
                {
                    string[] popA = { "" };
                    songs.AddRange(popA);
                }
            }
        }

        public void EDM()
        {
            if (words == "N" || words == "n")
            {
                string[] edmNW = { " " };
                songs.AddRange(edmNW);
            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {
                    string[] edmE = { " " };
                    songs.AddRange(edmE);
                }
                else if (language == "A" || language == "a")
                {
                    string[] edmA = { " " };
                    songs.AddRange(edmA);
                }
            }
        }

        
    }
}
