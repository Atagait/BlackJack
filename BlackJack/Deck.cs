using System;
using System.Collections.Generic;

namespace BlackJack {
    class Deck {
        Random random;
        List<Card> Cards;

        public Deck(){
            random = new Random();

            //Generate a full deck of 52 cards without jokers.
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 1; i < 11; i++)
                {
                    Cards.Add(new Card(i, suit));
                }
            }

            //Shuffle the deck
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card tmp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = tmp;
            }
        }

        public Card GetCard(){
            //Draw the card ontop of the deck
            Card tmp = Cards[0];
            Cards.RemoveAt(0);
            return tmp;
        }
    }
}
