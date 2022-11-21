using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.TreatControlCAsInput = false;
            Console.WriteLine("Welcome to Online Poker game");
            Console.WriteLine("Press Enter to proceed.....");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Enter to Name of Player");
                string playerName = Console.ReadLine();
                Player player = new Player(playerName); // Creates Player object with the player name

                Console.WriteLine("Press Ctrl-c to exit the game");
                Game game = new Game(player); //Creates Game object which starts the game.
                Deck deckOfcards = game.GetDeckOfcards(); // get cards
                Console.WriteLine(game.GreetPlayer());

                Console.WriteLine("Please select any valid option : ");
                Console.WriteLine("1. Shuffle the deck");
                Console.WriteLine("2. Deal a card");                    
                Console.WriteLine("3. Restart the game");

                while (true)
                {
                    string optionValue = Console.ReadLine(); //Reading Option input from User
                    int option = 0;
                    try
                    {
                        option = Convert.ToInt32(optionValue) ;
                    }
                    catch {
                        Console.WriteLine("Please provide valid option");
                        throw;
                    }

                    if (option == 1)
                    {
                        deckOfcards.ShuffleCards(); // Shuffle the cards
                        Console.WriteLine("Cards are well Shuffled");
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine(deckOfcards.dealOneCard()); //Gives the top card on the deck of cards.
                    }
                    else if (option == 3)
                    {
                        deckOfcards.RestartTheGame(); //Restart the game
                        Console.WriteLine("Started a new Game");
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine(deckOfcards.NoOfCardsLeft()); // No of left in the game
                    }
                    else
                    {
                        Console.WriteLine("Select a valid option");
                    }
                }
            }
        }
    }
}
