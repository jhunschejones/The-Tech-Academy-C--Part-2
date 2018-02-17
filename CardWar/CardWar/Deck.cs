using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardWar
{
    public class Deck
    {
        private List<Card> _deck;
        private Random _random;

        public Deck() // constructor
        {
            _random = new Random();
            // 2-A, Diamonds, Spades, Hearts, Clubs
            _deck = new List<Card>() {
                new Card { Kind = "2", Suit = "Clubs" },
                new Card { Kind = "3", Suit = "Clubs" },
                new Card { Kind = "4", Suit = "Clubs" },
                new Card { Kind = "5", Suit = "Clubs" },
                new Card { Kind = "6", Suit = "Clubs" },
                new Card { Kind = "7", Suit = "Clubs" },
                new Card { Kind = "8", Suit = "Clubs" },
                new Card { Kind = "9", Suit = "Clubs" },
                new Card { Kind = "10", Suit = "Clubs" },
                new Card { Kind = "Jack", Suit = "Clubs" },
                new Card { Kind = "Queen", Suit = "Clubs" },
                new Card { Kind = "King", Suit = "Clubs" },
                new Card { Kind = "Ace", Suit = "Clubs" },

                new Card { Kind = "2", Suit = "Hearts" },
                new Card { Kind = "3", Suit = "Hearts" },
                new Card { Kind = "4", Suit = "Hearts" },
                new Card { Kind = "5", Suit = "Hearts" },
                new Card { Kind = "6", Suit = "Hearts" },
                new Card { Kind = "7", Suit = "Hearts" },
                new Card { Kind = "8", Suit = "Hearts" },
                new Card { Kind = "9", Suit = "Hearts" },
                new Card { Kind = "10", Suit = "Hearts" },
                new Card { Kind = "Jack", Suit = "Hearts" },
                new Card { Kind = "Queen", Suit = "Hearts" },
                new Card { Kind = "King", Suit = "Hearts" },
                new Card { Kind = "Ace", Suit = "Hearts" },

                new Card { Kind = "2", Suit = "Spades" },
                new Card { Kind = "3", Suit = "Spades" },
                new Card { Kind = "4", Suit = "Spades" },
                new Card { Kind = "5", Suit = "Spades" },
                new Card { Kind = "6", Suit = "Spades" },
                new Card { Kind = "7", Suit = "Spades" },
                new Card { Kind = "8", Suit = "Spades" },
                new Card { Kind = "9", Suit = "Spades" },
                new Card { Kind = "10", Suit = "Spades" },
                new Card { Kind = "Jack", Suit = "Spades" },
                new Card { Kind = "Queen", Suit = "Spades" },
                new Card { Kind = "King", Suit = "Spades" },
                new Card { Kind = "Ace", Suit = "Spades" },

                new Card { Kind = "2", Suit = "Diamonds" },
                new Card { Kind = "3", Suit = "Diamonds" },
                new Card { Kind = "4", Suit = "Diamonds" },
                new Card { Kind = "5", Suit = "Diamonds" },
                new Card { Kind = "6", Suit = "Diamonds" },
                new Card { Kind = "7", Suit = "Diamonds" },
                new Card { Kind = "8", Suit = "Diamonds" },
                new Card { Kind = "9", Suit = "Diamonds" },
                new Card { Kind = "10", Suit = "Diamonds" },
                new Card { Kind = "Jack", Suit = "Diamonds" },
                new Card { Kind = "Queen", Suit = "Diamonds" },
                new Card { Kind = "King", Suit = "Diamonds" },
                new Card { Kind = "Ace", Suit = "Diamonds" }
            };

        }

        public void Deal(Player player1, Player player2)
        {
            while (_deck.Count > 0)
            {

            }
        }

    }
}