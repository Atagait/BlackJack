using System;

namespace BlackJack {
    class MainClass {
        public static void Main (string[] args) {
            Console.WriteLine ("Welcome to C# BlackJack");
            while (true)
            {
                Game game = new Game();
                game.Play();
                Console.WriteLine("Play again? (Y/N): ");

                ExitQuery:
                switch (Console.ReadLine().ToUpper())
                {
                    case "Y":
                        break;
                    case "N":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        goto ExitQuery;
                }
            }
        }
    }
}
