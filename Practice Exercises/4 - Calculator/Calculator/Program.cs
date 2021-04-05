/*
 * A simple calculator where users can determine what functions they want to use.
 * 
 * Author: Kyle James
 * Version: 9/4/2019
 * 
 * Notes: Could be improved with methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool isValidChoice;
            bool keepRunningProgram = true;
            bool keepSectionRunning;
            ConsoleColor error = ConsoleColor.DarkRed;
            ConsoleColor header = ConsoleColor.DarkYellow;
            ConsoleColor userEntry = ConsoleColor.White;
            string usersCalculatorChoice;
            string usersDoubleString;
            string usersSecondDoubleString;

            Console.WriteLine("Welcome to the world's most useless calculator!");

            while (keepRunningProgram)
            {
                // Output menu of choices for user to choose from
                Console.ForegroundColor = header;
                Console.WriteLine("Choose from one of the following calculator choices:");

                Console.ResetColor();
                Console.WriteLine("1 - Whole number    2 - Addition         3 - Sine");
                Console.WriteLine("4 - Cosine          5 - Absolute value   6 - Quit");

                // Get the user's input
                Console.ForegroundColor = header;
                Console.Write("Your choice: ");

                Console.ForegroundColor = userEntry;
                usersCalculatorChoice = Console.ReadLine();

                Console.ResetColor();

                // Check if user's choice is an integer
                isValidChoice = int.TryParse(usersCalculatorChoice, out int menuChoice);
                if(!isValidChoice)
                {
                    Console.ForegroundColor = error;
                    Console.WriteLine("That was not a valid entry, please enter a number.\n");
                    continue;
                }

                // Determine choice and perform calculation
                switch (menuChoice)
                {
                    case 1:
                        keepSectionRunning = true;
                        while (keepSectionRunning)
                        {
                            Console.WriteLine(" You chose absolute value.");

                            // Get user input
                            Console.Write(" Enter a decimal value: ");
                            Console.ForegroundColor = userEntry;
                            usersDoubleString = Console.ReadLine();

                            // Check if user's input is a number
                            isValidChoice = double.TryParse(usersDoubleString, out double usersDouble);
                            if (!isValidChoice)
                            {
                                Console.ForegroundColor = error;
                                Console.WriteLine(" That was not a valid entry, please enter a decimal value.\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                // Perform whole number calculation
                                Console.ResetColor();
                                Console.WriteLine($" The whole number is {(int)usersDouble}\n");
                                keepSectionRunning = false;
                            }
                        }
                        break;
                    case 2:
                        keepSectionRunning = true;
                        while (keepSectionRunning)
                        {
                            Console.WriteLine(" You chose addition.");

                            // Get user input
                            Console.Write(" Enter the first number: ");
                            Console.ForegroundColor = userEntry;
                            usersDoubleString = Console.ReadLine();
                            Console.ResetColor();

                            Console.Write(" Enter the second number: ");
                            Console.ForegroundColor = userEntry;
                            usersSecondDoubleString = Console.ReadLine();
                            Console.ResetColor();

                            // Check if user's inputs are valid
                            isValidChoice = double.TryParse(usersDoubleString, out double usersDouble);
                            bool isValidSecondChoice = double.TryParse(usersSecondDoubleString, out double usersSecondDouble);
                            if (!isValidChoice)
                            {
                                Console.ForegroundColor = error;

                                // Check if there is more than one invalid answer
                                if (!isValidSecondChoice)
                                {
                                    Console.WriteLine(" The first and second entries were invalid, please enter numbers.\n");
                                }
                                else
                                {
                                    Console.WriteLine(" The first entry was invalid, please enter a number.\n");
                                }

                                Console.ResetColor();
                                continue;
                            }
                            else if (!isValidSecondChoice)
                            {
                                Console.ForegroundColor = error;
                                Console.WriteLine(" The second entry was invalid, please enter a number.\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                // Perform addition calculation
                                Console.WriteLine($" Your answer is {usersDouble + usersSecondDouble}\n");
                                keepSectionRunning = false;
                            }
                        }
                        break;
                    case 3:
                        keepSectionRunning = true;
                        while (keepSectionRunning)
                        {
                            Console.WriteLine(" You chose sine.");

                            // Get user input
                            Console.Write(" Enter an angle in radians: ");
                            Console.ForegroundColor = userEntry;
                            usersDoubleString = Console.ReadLine();

                            // Check if user's input is a number
                            isValidChoice = double.TryParse(usersDoubleString, out double usersDouble);
                            if (!isValidChoice)
                            {
                                Console.ForegroundColor = error;
                                Console.WriteLine(" That was not a valid entry, please enter a number.\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                // Perform sine calculation
                                Console.ResetColor();
                                Console.WriteLine($" The sine is {Math.Sin(usersDouble)}\n");
                                keepSectionRunning = false;
                            }
                        }
                        break;
                    case 4:
                        keepSectionRunning = true;
                        while (keepSectionRunning)
                        {
                            Console.WriteLine(" You chose cosine.");

                            // Get user input
                            Console.Write(" Enter an angle in radians: ");
                            Console.ForegroundColor = userEntry;
                            usersDoubleString = Console.ReadLine();

                            // Check if user's input is a number
                            isValidChoice = double.TryParse(usersDoubleString, out double usersDouble);
                            if (!isValidChoice)
                            {
                                Console.ForegroundColor = error;
                                Console.WriteLine(" That was not a valid entry, please enter a number.\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                // Perform cosine calculation
                                Console.ResetColor();
                                Console.WriteLine($" The sine is {Math.Cos(usersDouble)}\n");
                                keepSectionRunning = false;
                            }
                        }
                        break;
                    case 5:
                        keepSectionRunning = true;
                        while (keepSectionRunning)
                        {
                            Console.WriteLine(" You chose absolute value.");

                            // Get user input
                            Console.Write(" Enter a number: ");
                            Console.ForegroundColor = userEntry;
                            usersDoubleString = Console.ReadLine();

                            // Check if user's input is a number
                            isValidChoice = double.TryParse(usersDoubleString, out double usersDouble);
                            if (!isValidChoice)
                            {
                                Console.ForegroundColor = error;
                                Console.WriteLine(" That was not a valid entry, please enter a number.\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                // Perform absolute value calculation
                                Console.ResetColor();
                                Console.WriteLine($" Your answer is {Math.Abs(usersDouble)}\n");
                                keepSectionRunning = false;
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine(" Goodbye!");
                        keepRunningProgram = false;
                        break;
                    default:
                        Console.ForegroundColor = error;
                        Console.WriteLine("That was not a valid entry, please enter a number from the menu.\n");
                        continue;
                }
            }

            // Keep the window open
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}