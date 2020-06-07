using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void languageInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                language = languageInput.Text;
            }
            catch
            {

            }
        }

        private void genreInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                genre = Convert.ToInt32(genreInput.Text);
            }
            catch
            {

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

            }
        }


    }
}
