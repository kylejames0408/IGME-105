/*
 * Showcase of an array filled with names by the user, performing various functions.
 * 
 * Author: Kyle James
 * Version: 9/6/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool isValid;
            bool keepRunning = true;
            bool sectionComplete;
            ConsoleColor error = ConsoleColor.DarkRed;
            ConsoleColor header = ConsoleColor.DarkYellow;
            ConsoleColor userEntry = ConsoleColor.White;
            int sizeOfArray = 0;
            string choice;
            string name;
            string[] names;
            string amountOfNames;

            // Present header
            Console.ForegroundColor = header;
            Console.WriteLine("Welcome to the character name collector!");

            // Get user input for number of names
            sectionComplete = false;
            while (!sectionComplete)
            {
                Console.Write("How many characters are you entering today?: ");
                Console.ForegroundColor = userEntry;
                amountOfNames = Console.ReadLine();

                // Make sure entry is valid
                isValid = int.TryParse(amountOfNames, out sizeOfArray);
                if (!isValid)
                {
                    Console.ForegroundColor = error;
                    Console.WriteLine("That was not a valid entry, please enter a number!\n");
                    continue;
                }

                sectionComplete = true;
            }

            // Create array size based on user's entry
            names = new string[sizeOfArray];

            // Get user input for names
            sectionComplete = false;
            while (!sectionComplete)
            {
                // Get names
                for (int index = 0; index < names.Length; index++)
                {
                    Console.ResetColor();
                    Console.Write($"Name {index + 1}: ");
                    Console.ForegroundColor = userEntry;
                    name = Console.ReadLine();
                    names[index] = name;
                }

                Console.ResetColor();
                Console.WriteLine("All names have been entered.\n");

                sectionComplete = true;
            }

            // Present menu
            while(keepRunning)
            {
                Console.ForegroundColor = header;
                Console.WriteLine("Choose from one of the following choices: ");
                Console.ResetColor();
                Console.WriteLine("1 - Print all names   2 - Name search   3 - Replace a name   4 - Find duplicates   5 - Quit");
                
                // Get user input
                Console.ForegroundColor = header;
                Console.Write("Your choice: ");
                Console.ForegroundColor = userEntry;
                choice = Console.ReadLine();

                // Make sure entry is valid
                isValid = int.TryParse(choice, out int menuChoice);
                if(!isValid)
                {
                    Console.ForegroundColor = error;
                    Console.WriteLine("That was not a valid entry, please enter a number!\n");
                    continue;
                }

                // Check entry and perform action
                switch(menuChoice)
                {
                    // Print name array
                    case 1:
                        foreach(string aName in names)
                        {
                            Console.WriteLine($" {aName}");
                        }
                        Console.WriteLine();
                        break;
                    // Search array for a name
                    case 2:
                        Console.Write(" Enter a name: ");

                        // Get user input
                        Console.ForegroundColor = userEntry;
                        name = Console.ReadLine();
                        Console.ResetColor();

                        // Check array for name
                        bool nameInArray = false;
                        foreach (string aName in names)
                        {
                            if (String.Equals(name, aName))
                            {
                                nameInArray = true;
                            }
                        }

                        // Output result of search
                        if (nameInArray)
                        {
                            Console.WriteLine($" Yes, {name} is in the array.");
                        }
                        else
                        {
                            Console.WriteLine($" No, {name} is not in the array.");
                        }
                        Console.WriteLine();
                        break;
                    // Replace a name in the array
                    case 3:
                        // Get user input
                        Console.Write($" Which index are you replacing? (Valid indices are 0 - {names.Length - 1}): ");
                        Console.ForegroundColor = userEntry;
                        choice = Console.ReadLine();

                        // Make sure entry is valid
                        sectionComplete = false;

                        while (!sectionComplete)
                        {
                            isValid = int.TryParse(choice, out int indexInteger);

                            if (!isValid)
                            {
                                Console.ForegroundColor = error;
                                Console.Write(" That was not a valid entry, please enter a number: ");
                                Console.ForegroundColor = userEntry;
                                choice = Console.ReadLine();
                                continue;
                            }
                            else if (indexInteger >= names.Length || indexInteger < 0)
                            {
                                Console.ForegroundColor = error;
                                Console.Write(" That is not a valid index. Try again: ");
                                Console.ForegroundColor = userEntry;
                                choice = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                // Output results
                                Console.ResetColor();

                                string oldName = names[indexInteger];

                                Console.Write(" Enter the new name: ");
                                Console.ForegroundColor = userEntry;
                                choice = Console.ReadLine();

                                names[indexInteger] = choice;

                                Console.ResetColor();

                                Console.WriteLine($" {oldName} has been changed to {choice}.");

                                sectionComplete = true;
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        List<string> duplicates = new List<string>();

                        // Loop through array (don't need last position since there's nothing after it)
                        for (int index = 0; index < names.Length - 1; index++)
                        {
                            // Loop through array (not including same index as first loop, doesn't count itself)
                            for (int i  = index + 1; i < names.Length; i++)
                            {
                                if (String.Equals(names[index], names[i]))
                                {
                                    // If duplicates list doesn't contain the name, add it
                                    if (!duplicates.Contains(names[index]))
                                    {
                                        duplicates.Add(names[index]);
                                    }
                                }
                            }
                        }

                        // Output the statements
                        if (duplicates.Count > 0)
                        {
                            foreach (string duplicate in duplicates)
                            {
                                Console.WriteLine($" {duplicate} appears more than once.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(" There are no duplicates.");
                        }

                        Console.WriteLine();
                        break;
                    // Quit
                    case 5:
                        Console.WriteLine(" Goodbye!");
                        keepRunning = false;
                        Console.WriteLine();
                        break;
                    // If it doesn't match a menu item
                    default:
                        Console.ForegroundColor = error;
                        Console.WriteLine("That was not a valid entry, please enter a number from the menu!\n");
                        break;
                }
            }

            // Keep the window open
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
