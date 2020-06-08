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
                    break;
                case 3:
                    break;
                case 4:
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
        }

        
    }
}
