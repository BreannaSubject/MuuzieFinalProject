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

            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {

                }
                else if (language == "A"|| language == "a")
                {

                }
            }
        }

        public void Pop()
        {
            if (words == "N" || words == "n")
            {

            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {

                }
                else if (language == "A" || language == "a")
                {

                }
            }
        }

        public void EDM()
        {
            if (words == "N" || words == "n")
            {

            }
            else if (words == "Y" || words == "y")
            {
                if (language == "E" || language == "e")
                {

                }
                else if (language == "A" || language == "a")
                {

                }
            }
        }

        
    }
}
