using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    public class Dealer
    {
        private Random random = new Random();
        private Deck deck;

        public Dealer(Deck deck)
        {
            this.deck = deck;
        }

        public Card DrawCard()
        {
            int index = random.Next(deck.Cards.Count);
            Card card = deck.Cards[index];
            deck.Cards.RemoveAt(index);
            return card;
        }
    }
}