/*
 * The purpose is to set up a number guessing game using OOP.
 * 
 * Author: Kyle James
 * Version: 9/18/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            Random rng = new Random();
            Game game;

            // Start the game
            game = new Game(rng);
            game.PlayGame();

            // Keep the window open
            Console.WriteLine("Press and key to continue. . .");
            Console.ReadKey();
        }
    }
}
