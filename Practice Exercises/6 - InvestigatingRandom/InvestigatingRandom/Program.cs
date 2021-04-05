/*
 * Generate 300 random numbers between 0 and 9 and print the results.
 * 
 * Author: Kyle James
 * Version: 9/9/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigatingRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            ConsoleColor maxValue = ConsoleColor.Blue;
            ConsoleColor minValue = ConsoleColor.Magenta;
            int[] numberCount = new int[10];
            int randomNumber;

            // Random - The Wrong Way
            for (int i = 0; i < 300; i++)
            {
                Random rng = new Random(); // Generates the same seed

                randomNumber = rng.Next(numberCount.Length);
                numberCount[randomNumber] += 1;
            }
            Console.WriteLine("Incorrectly Generated Results:");
            for (int i = 0; i < numberCount.Length; i++)
            {
                Console.WriteLine($"{i}: {numberCount[i]}");
            }

            // Reset numberCount
            numberCount = new int[10];

            // Random - The Right Way
            Random rngCorrect = new Random(); // Generates different seed (outside loop)

            for (int i = 0; i < 300; i++)
            {
                randomNumber = rngCorrect.Next(numberCount.Length);
                numberCount[randomNumber] += 1;
            }
            Console.WriteLine("\nCorrectly Generated Results:");
            for (int i = 0; i < numberCount.Length; i++)
            {
                int minimum = int.MaxValue;
                int maximum = int.MinValue;
                
                // Find max and mins
                foreach (int number in numberCount)
                {
                    if (number < minimum)
                    {
                        minimum = number;
                    }

                    if (number > maximum)
                    {
                        maximum = number;
                    }
                }

                // Output results
                if (numberCount[i] == maximum)
                {
                    Console.ForegroundColor = maxValue;
                    Console.WriteLine($"{i}: {numberCount[i]}");
                }
                else if (numberCount[i] == minimum)
                {
                    Console.ForegroundColor = minValue;
                    Console.WriteLine($"{i}: {numberCount[i]}");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine($"{i}: {numberCount[i]}");
                }
            }

            // Keep window open
            Console.ResetColor();
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
