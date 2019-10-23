using System.Linq;
using System.Collections.Generic;
namespace BlackJack {
    class Hand {
        List<Card> cards;
        public Hand() {
            cards = new List<Card>();
        }

        public void AddCard(Card card){
            cards.Add(card);
        }

        //TODO: have the total factor in Aces being either 1s or 11s
        public int Total {
            get
            {
                return cards.Sum(c => c.Value);
            }
        }

        public bool IsBusted
        {
            get
            {
                return Total > 21;
            }
        }

        public override string ToString() {
            string s = "Hand: ";
            foreach (Card card in cards)
                s += $"{card} ";
            s += $"\nTotal: {Total}";
            return s;
        }
    }
}
