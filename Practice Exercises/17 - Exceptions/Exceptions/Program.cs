using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            BetterCustomList<string> listOfStrings;

            // Print welcome
            Console.WriteLine("Welcome to the Exception exercise!\n");

            // Initialize list
            try
            {
                listOfStrings = new BetterCustomList<string>(-10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Uh oh, error creating your list!");
                Console.WriteLine(e.Message);
                listOfStrings = new BetterCustomList<string>();
            }

            // Add names to list
            listOfStrings.Add("Mark Wahlberg");
            listOfStrings.Add("Matt Damon");
            listOfStrings.Add("Tom Cruise");

            // Print out list
            Console.WriteLine("\nPrinting names in list:");
            try
            {
                for (int i = -4; i < listOfStrings.Count + 7; i++)
                {
                    Console.WriteLine(listOfStrings[i]);
                }
            }
            catch
            {
                Console.WriteLine("Error! Stopping all code in TRY");
            }

            Console.WriteLine("\nDone!");

            // Keep the window open!
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
