using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Deck
    {
        private Random random = new Random();

        public List<Card> Cards = new List<Card>()
{
            new Card("2_of_hearts", 2),
            new Card("2_of_spades", 2),
            new Card("2_of_clubs", 2),
            new Card("2_of_diamonds", 2),

            new Card("3_of_hearts", 3),
            new Card("3_of_spades", 3),
            new Card("3_of_clubs", 3),
            new Card("3_of_diamonds", 3),

            new Card("4_of_hearts", 4),
            new Card("4_of_spades", 4),
            new Card("4_of_clubs", 4),
            new Card("4_of_diamonds", 4),

            new Card("5_of_hearts", 5),
            new Card("5_of_spades", 5),
            new Card("5_of_clubs", 5),
            new Card("5_of_diamonds", 5),

            new Card("6_of_hearts", 6),
            new Card("6_of_spades", 6),
            new Card("6_of_clubs", 6),
            new Card("6_of_diamonds", 6),

            new Card("7_of_hearts", 7),
            new Card("7_of_spades", 7),
            new Card("7_of_clubs", 7),
            new Card("7_of_diamonds", 7),

            new Card("8_of_hearts", 8),
            new Card("8_of_spades", 8),
            new Card("8_of_clubs", 8),
            new Card("8_of_diamonds", 8),

            new Card("9_of_hearts", 9),
            new Card("9_of_spades", 9),
            new Card("9_of_clubs", 9),
            new Card("9_of_diamonds", 9),

            new Card("10_of_hearts", 10),
            new Card("10_of_spades", 10),
            new Card("10_of_clubs", 10),
            new Card("10_of_diamonds", 10),

            new Card("jack_of_hearts", 10),
            new Card("jack_of_spades", 10),
            new Card("jack_of_clubs", 10),
            new Card("jack_of_diamonds", 10),

            new Card("queen_of_hearts", 10),
            new Card("queen_of_spades", 10),
            new Card("queen_of_clubs", 10),
            new Card("queen_of_diamonds", 10),

            new Card("king_of_hearts", 10),
            new Card("king_of_spades", 10),
            new Card("king_of_clubs", 10),
            new Card("king_of_diamonds", 10),

            new Card("ace_of_hearts", 11),
            new Card("ace_of_spades", 11),
            new Card("ace_of_clubs", 11),
            new Card("ace_of_diamonds", 11),
};
        public void Shuffle()
        {
            Cards = Cards.OrderBy(_ => random.Next()).ToList();
        }
    }
}