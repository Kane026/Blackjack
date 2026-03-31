using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class BlackjackGame
    {
        Deck deck = new Deck();
        Dealer dealer = new Dealer();

        public string Hit()
        {
            return dealer.DrawCard();
        }
    }
}
