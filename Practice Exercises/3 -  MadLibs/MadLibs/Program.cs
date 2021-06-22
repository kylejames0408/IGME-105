/*
 * The purpose of the program is to showcase some simple tasks that C# can handle by creating a user-built mad lib.
 * 
 * Author: Kyle James
 * Version: 9/3/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for user entries for Mad Libs
            string adjective1;
            string food1;
            string kitchenAppliance;
            string number;
            string foodThatMelts;
            string adjective2;
            string adjective3;
            string adjective4;
            string verb1;
            string food2;
            string adverbEndingInLy;
            string food3;
            string kitchenTool;
            string verb2;
            string adjective5;
            string food4;
            string usersName;

            // Variables to keep writing
            bool writeMadLibs = true;
            string keepWritingString;
            char keepWritingChar;

            // Get the user's name
            Console.Write("What's your name?: ");
            usersName = Console.ReadLine();

            // Welcome the user
            Console.WriteLine($"Hello {usersName}! Welcome to Mad Libs!\n");

            do
            {
                // Get user entries for Mad Libs
                Console.Write("Enter an adjective: ");
                adjective1 = Console.ReadLine();
                Console.Write("Enter a food: ");
                food1 = Console.ReadLine();
                Console.Write("Enter a kitchen appliance: ");
                kitchenAppliance = Console.ReadLine();
                Console.Write("Enter a number: ");
                number = Console.ReadLine();
                Console.Write("Enter a food that melts: ");
                foodThatMelts = Console.ReadLine();
                Console.Write("Enter another adjective: ");
                adjective2 = Console.ReadLine();
                Console.Write("Enter another adjective: ");
                adjective3 = Console.ReadLine();
                Console.Write("Enter another adjective: ");
                adjective4 = Console.ReadLine();
                Console.Write("Enter a verb: ");
                verb1 = Console.ReadLine();
                Console.Write("Enter another food: ");
                food2 = Console.ReadLine();
                Console.Write("Enter an adverb ending in -ly: ");
                adverbEndingInLy = Console.ReadLine();
                Console.Write("Enter another food: ");
                food3 = Console.ReadLine();
                Console.Write("Enter a kitchen tool: ");
                kitchenTool = Console.ReadLine();
                Console.Write("Enter another verb: ");
                verb2 = Console.ReadLine();
                Console.Write("Enter another adjective: ");
                adjective5 = Console.ReadLine();
                Console.Write("Enter another food: ");
                food4 = Console.ReadLine();

                // Print the story
                Console.WriteLine("\n[Mad Lib]");
                Console.WriteLine($"Here is a {adjective1} recipe for an Upside-Down {food1}.");
                Console.WriteLine($"First, you preheat your {kitchenAppliance} to {Double.Parse(number) * 10} degrees.");
                Console.WriteLine($"Next, melt a stick of {foodThatMelts} in a ten-inch {adjective2} skillet over a very {adjective3} flame.");
                Console.WriteLine($"In a {adjective4} bowl {verb1} granulated {food2} and flour, stirring the mixture {adverbEndingInLy}");
                Console.WriteLine($"Add milk and {food3} and beat rapidly with an electric {kitchenTool}.");
                Console.WriteLine($"Bake until your {food1} is ready.");
                Console.WriteLine($"After the {food1} cools, {verb2} it from the {kitchenAppliance} and turn it upside-down.");
                Console.WriteLine($"Serve the {food1} warm with {adjective5} cram or small spoonfuls of {food4} on top.");

                // Check if the user wants to write another Mad Lib
                Console.Write("\nWould you like to write the Mad Lib again? [y/n]: ");
                keepWritingString = Console.ReadLine();
                keepWritingChar = Char.Parse(keepWritingString);
                switch(keepWritingChar)
                {
                    case 'y':
                        Console.WriteLine("Reloading questions...\n");
                        break;
                    case 'n':
                        Console.WriteLine("Goodbye!\n");
                        writeMadLibs = false;
                        break;
                }
            }
            while (writeMadLibs);

            // Keep the window open!
            Console.WriteLine("Press any key to close the window.");
            Console.ReadKey();
        }
    }
}
