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
        private BlackjackGame game = new BlackjackGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Card card1 = game.Hit();
            Card card2 = game.Hit();
            Card card3 = game.Hit();

            pictureBoxDealer1.Image = Image.FromFile("Images/" + card1.Name + ".png");
            pictureBoxDealer2.Image = Image.FromFile("Images/back_of_card.png");
            pictureBox1Player.Image = Image.FromFile("Images/" + card2.Name + ".png");
            pictureBox2Player.Image = Image.FromFile("Images/" + card3.Name + ".png");

            int playerTotal = card2.Value + card3.Value;
            int dealerTotal = card1.Value;

            playerScore.Text = playerTotal.ToString();
            dealerScore.Text = dealerTotal.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureCard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            game.Shuffle();
            MessageBox.Show("Deck is geshuffled");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
