/*
 * The purpose of the program is to prompt the user to fill a list and perform various functions with it (generic).
 * 
 * Author: Kyle James
 * Version: 9/25/2019
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
            CustomList<string> customList;
            CustomList<int> customIntegerList;
            int index;
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
                Console.ResetColor();
            }

            // Initialize the list
            customList = new CustomList<string>(listSize);
            Console.WriteLine($"List with a size of {listSize} has been created.\n");

            // Prompt user input for list
            Console.WriteLine("Menu:");
            Console.WriteLine("   enter a word - adds that word to the list");
            Console.WriteLine("   'print' - prints the list");
            Console.WriteLine("   'count' - size of the list");
            Console.WriteLine("   'capacity' - list capacity");
            Console.WriteLine("   'get' - retrieve the element at an index");
            Console.WriteLine("   'set - change the element at and index'");
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
                    case "get":
                        Console.Write("Which index?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        isValidEntry = int.TryParse(userInput, out index);
                        while (!isValidEntry || index < 0)
                        {
                            Console.ForegroundColor = error;
                            Console.Write("That was not a valid entry, please enter a number >= 0: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();

                            isValidEntry = int.TryParse(userInput, out index);
                            Console.ResetColor();
                        }
                        
                        Console.WriteLine($"The item at index {index} is {customList[index]}.\n");
                        break;
                    case "set":
                        Console.Write("Which index?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        isValidEntry = int.TryParse(userInput, out index);
                        while (!isValidEntry || index < 0)
                        {
                            Console.ForegroundColor = error;
                            Console.Write("That was not a valid entry, please enter a number >= 0: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();

                            isValidEntry = int.TryParse(userInput, out index);
                            Console.ResetColor();
                        }

                        Console.Write("Which word?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        customList[index] = userInput;
                        Console.WriteLine();
                        break;
                    case "done":
                        keepRunning = false;
                        break;
                    default:
                        customList.Add(userInput);
                        Console.WriteLine($"{userInput} has been added to the list.\n");
                        break;
                }
            }

            // Integer List
            Console.WriteLine("\nInteger list");
            customIntegerList = new CustomList<int>(3);
            customIntegerList.Add(35);
            customIntegerList.Add(775);
            customIntegerList.Add(53);
            Console.WriteLine("List contents:");
            customIntegerList.Print();
            Console.WriteLine("\nGoodbye!\n");

            // Keep the window open
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
