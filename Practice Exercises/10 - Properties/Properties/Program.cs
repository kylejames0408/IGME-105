/*
 * The purpose of the program is to prompt the user to fill a list and perform various functions with it.
 * 
 * Author: Kyle James
 * Version: 9/23/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            bool isValidEntry;
            bool keepRunning = true;
            ConsoleColor error = ConsoleColor.DarkRed;
            ConsoleColor userEntry = ConsoleColor.White;
            CustomList customList;
            string userInput;

            // Prompt initial user input
            Console.Write("List size?: ");
            Console.ForegroundColor = userEntry;
            userInput = Console.ReadLine();

            // Check user input
            isValidEntry = int.TryParse(userInput, out int listSize);
            while (!isValidEntry || listSize <= 0)
            {
                Console.ForegroundColor = error;
                Console.Write("That was not a valid entry, please enter a number greater than 0: ");
                Console.ForegroundColor = userEntry;
                userInput = Console.ReadLine();

                isValidEntry = int.TryParse(userInput, out listSize);
            }

            // Initialize the list
            customList = new CustomList(listSize);

            // Prompt user input for list
            Console.WriteLine("Menu:");
            Console.WriteLine("   enter a word - adds that word to the list");
            Console.WriteLine("   'print' - prints the list");
            Console.WriteLine("   'count' - size of the list");
            Console.WriteLine("   'capacity' - list capacity");
            Console.WriteLine("   'done' - quit the program\n");

            while (keepRunning)
            {
                Console.Write("Enter an item: ");
                Console.ForegroundColor = userEntry;
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "print":
                        customList.Print();
                        Console.WriteLine();
                        break;
                    case "count":
                        Console.WriteLine($"The list count is {customList.Count}\n");
                        break;
                    case "capacity":
                        Console.WriteLine($"The list capacity is {customList.Capacity}\n");
                        break;
                    case "done":
                        Console.WriteLine("Goodbye!\n");
                        keepRunning = false;
                        break;
                    default:
                        customList.Add(userInput);
                        break;
                }
            }

            // Keep the window open
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
