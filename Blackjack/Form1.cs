using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        BlackjackGame game = new BlackjackGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string card1 = game.Hit();
                string card2 = game.Hit();
                string card3 = game.Hit();

                pictureBoxDealer1.Image = Image.FromFile("Images/" + card1 + ".png");
                pictureBoxDealer2.Image = Image.FromFile("Images/back_of_card.png");
                pictureBox1Player.Image = Image.FromFile("Images/" + card2 + ".png");
                pictureBox2Player.Image = Image.FromFile("Images/" + card3 + ".png");
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureCard_Click(object sender, EventArgs e)
        {

        }
    }
}
