using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    public class Dealer
    {
        private Deck deck = new Deck();
        private Random random = new Random();

        public string DrawCard()
        {
            int index = random.Next(deck.Cards.Count);
            deck.Cards.RemoveAt(index);
            return deck.Cards[index];
        }
    }
}
