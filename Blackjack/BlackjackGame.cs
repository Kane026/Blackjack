using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class BlackjackGame
    {
        Deck deck = new Deck();
        private Dealer dealer;

        public BlackjackGame()
        {
            dealer = new Dealer(deck);
        }

        public Card Hit()
        {
            return dealer.DrawCard();
        }

        public void Shuffle()
        {
            deck.Shuffle();
        }
    }
}
