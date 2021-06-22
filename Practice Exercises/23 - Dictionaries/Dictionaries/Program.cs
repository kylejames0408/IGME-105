using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool keepSectionRunning;
            string userInput;
            Dictionary<String, Player> players;

            // Initialize variables
            keepSectionRunning = true;
            players = new Dictionary<string, Player>();
            players.Add("Tom", new Player("Tom", 105));
            players.Add("Pam", new Player("Pam", 116));

            // Dictionary testing
            Console.WriteLine("=== Part 1 - Using a dictionary ===\n");
            while (keepSectionRunning)
            {
                Console.Write("Enter a name: ");
                userInput = Console.ReadLine();
                if (players.ContainsKey(userInput))
                {
                    Console.WriteLine($"Player {userInput} found: {players[userInput].ToString()}\n");
                }
                else if (userInput.ToLower() == "done" || userInput.ToLower() == "quit")
                {
                    Console.WriteLine("\n");
                    keepSectionRunning = false;
                }
                else
                {
                    Console.WriteLine($"Player {userInput} not found\n");
                }
            }


            // PART 2

            Console.WriteLine("=== Part 2 - Performance testing ===");

            // Reset previous data and set up stopwatch
            Player lastPlayer;
            Random rng = new Random();
            Stopwatch timer = new Stopwatch();
            players.Clear();
            List<Player> listOfPlayers = new List<Player>();

            // Loop to build dictionary and list
            for (int i = 0; i < 100000; i++)
            {
                int score = rng.Next(0, 201);
                listOfPlayers.Add(new Player($"p{i}", score));
                players.Add($"p{i}", new Player($"p{i}", score));
            }

            // Time the dictionary search
            timer.Start();
            if (players.ContainsKey($"p{players.Count - 1}"))
            {
                lastPlayer = players[$"p{players.Count - 1}"];
            }
            timer.Stop();
            Console.WriteLine($"Searching dictionary: {timer.Elapsed.TotalMilliseconds}");

            // Time the list search
            timer.Restart();
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                if (listOfPlayers[i].Name == $"p{listOfPlayers.Count - 1}")
                {
                    Console.WriteLine("Player found in list!");
                    break;
                }
            }
            timer.Stop();
            Console.WriteLine($"Searching list: {timer.Elapsed.TotalMilliseconds}");


            // Keep the window open
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
