using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private BlackjackGame game = new BlackjackGame();
        private int dealerTotal;
        private int playerTotal;
        private int dealerPoints;

        public Form1()
        {
            InitializeComponent();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            pictureBoxDealer3.Image = null;

            Card card1 = game.Hit();
            Card card2 = game.Hit();
            Card card3 = game.Hit();
            Card card4 = game.Hit();

            pictureBoxDealer1.Image = Image.FromFile("Images/" + card1.Name + ".png");
            pictureBoxDealer2.Image = Image.FromFile("Images/" + card2.Name + ".png");
            pictureBox1Player.Image = Image.FromFile("Images/" + card3.Name + ".png");
            pictureBox2Player.Image = Image.FromFile("Images/" + card4.Name + ".png");

            playerTotal = card3.Value + card4.Value;
            dealerTotal = card1.Value + card2.Value;

            playerScore.Text = playerTotal.ToString();
            dealerScore.Text = dealerTotal.ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureCard_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            game.Shuffle();
            MessageBox.Show("Deck is geshuffled");
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            if (dealerTotal < 17)
            {
                MessageBox.Show("Dealer must hit until they have at least 17 points (-1 point)");
                dealerPoints -= 1;
                dealerPointsTextBox.Text = dealerPoints.ToString();
            }
            else if (dealerTotal > playerTotal)
            {
                MessageBox.Show("Dealer wins you made the correct choice (+1 point)");
                dealerPoints += 1;
                dealerPointsTextBox.Text = dealerPoints.ToString();
            }
            else if (dealerTotal < playerTotal)
            {
                MessageBox.Show("Player wins but you made the correct choice (+1 point)");
                dealerPoints += 1;
                dealerPointsTextBox.Text = dealerPoints.ToString();
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (dealerTotal < 17)
            {
                Card cardDealer3 = game.Hit();
                pictureBoxDealer3.Image = Image.FromFile("Images/" + cardDealer3.Name + ".png");
                dealerTotal = dealerTotal + cardDealer3.Value;
                dealerScore.Text = dealerTotal.ToString();

                if (dealerTotal > 21)
                {
                    MessageBox.Show("Dealer busts player wins");
                }
            }
            else
            {
                MessageBox.Show("You can't hit anymore you're above 16 points (-1 point)");
                dealerPoints -= 1;
                dealerPointsTextBox.Text = dealerPoints.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

