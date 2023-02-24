using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroGame
{
    

    public partial class Form1 : Form
    {
        string username;
        string difficulty;
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            difficulty = "Easy";
            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            difficulty = "Medium";
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.White;
                
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            difficulty = "Hard";
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = $"hello {username} welcome to the {difficulty} path";
        }

       
    }
}
