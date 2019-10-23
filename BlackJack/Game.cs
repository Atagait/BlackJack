using System;
namespace BlackJack {
    class Game {
        Deck deck;
        public Game() {
            deck = new Deck();
        }

        public void Play() {
            Player player = new Player();
            Dealer dealer = new Dealer(deck);

            Console.WriteLine($"Dealer's first card: {dealer.ToString()}");

            Hand playerHand = player.Deal(deck);

            if(playerHand.IsBusted){
                Console.WriteLine("Player busted.");
                return;
            }

            Console.WriteLine("Player stays at {0}", playerHand.Total);
            Console.WriteLine();
            Console.WriteLine("Dealer Playing");

            Hand dealerHand = dealer.Deal(deck);

            if(dealerHand.IsBusted){
                Console.Write("Dealer busted.");
                return;
            }

            Console.WriteLine();
            if(playerHand.Total > dealerHand.Total){
                Console.WriteLine($"Player's {playerHand.Total} beats Dealer's {dealerHand.Total}");
                Console.WriteLine("Player Wins!");
            }
            else{
                Console.WriteLine($"Dealer's {dealerHand.Total} beats Player's {playerHand.Total}");
                Console.WriteLine("Game Over!");
            }
        }
    }
}
