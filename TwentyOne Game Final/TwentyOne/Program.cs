using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name. ");
            string PlayerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? (Yes/No)", PlayerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "Yes" || answer == "yes" || answer == "Yeah" || answer == "y")
            {
                Player player = new Player(PlayerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;

                while(player.isActivePlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casio. Bye for now.");
            Console.Read();
        }
    }
}
