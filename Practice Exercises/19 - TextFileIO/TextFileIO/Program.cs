using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decalare variables
            bool keepSectionRunning;
            string userInput;
            PlayerManager playerManager;
            Random rng;

            // Initialize variables
            keepSectionRunning = true;
            rng = new Random();
            playerManager = new PlayerManager(rng);

            // Loop until user is done
            while (keepSectionRunning)
            {
                // Print menu
                Console.WriteLine("Choose one of the following options:");
                Console.Write("Create. Print. Save. Load. Quit. >> ");

                // Get user input
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                // Determine user's input
                switch (userInput)
                {
                    case "create":
                        Console.Write("\n\tWhat is the player's name?: ");
                        userInput = Console.ReadLine();
                        playerManager.CreatePlayer(userInput);
                        Console.WriteLine($"\tAdded {userInput} to the list.\n");
                        break;
                    case "print":
                        Console.WriteLine();
                        playerManager.Print();
                        Console.WriteLine();
                        break;
                    case "save":
                        Console.WriteLine();
                        playerManager.Save();
                        Console.WriteLine();
                        break;
                    case "load":
                        Console.WriteLine();
                        playerManager.Load();
                        Console.WriteLine();
                        break;
                    case "quit":
                        Console.WriteLine("\tGoodbye!");
                        keepSectionRunning = false;
                        break;
                    default:
                        Console.WriteLine("That was an invalid selection, please choose a valid option.\n");
                        break;
                }
            }

            // Keep the window open
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
