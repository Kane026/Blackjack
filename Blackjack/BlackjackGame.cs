using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class BlackjackGame
    {
        Deck deck = new Deck();

        public string Hit()
        {
            return deck.DrawCard();
        }
    }
}
