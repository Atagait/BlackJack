using System;
namespace BlackJack {
    class Dealer : Player {
        public Dealer(Deck deck) : base() {
            DealCards(1, deck);
        }

        /*
         The dealer AI is fairly simple, since the BlackJack dealer rules are too.
         If the dealer is at or above 17, stay, otherwise draw
        */
        public new Hand Deal(Deck deck)
        {
            DealCards(1, deck);
            Console.WriteLine();

            bool playing = true;
            while (playing)
            {
                //If the hand total is >= 17, the dealer is either staying, or bust
                if (hand.Total >= 17)
                    break;
                else //If the dealer is below 17, draw
                    DealCards(1, deck);
            }
            return hand;
        }
    }
}
