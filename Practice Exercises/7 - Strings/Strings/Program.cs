/*
 * Using the Math class' built-in methods and manipulating string objects
 * 
 * Author: Kyle James
 * Version: 9/12/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool isValid;
            bool keepSectionRunning;
            double firstNumber = 0;
            double numberPrice = 0;
            double secondNumber = 0;
            String name;
            String price;
            String reverse = "";
            String userInput;
            string[] priceSplit;
            string[] sentenceSplit;

            // Get user's name
            Console.Write("Hi there, I'd like to analyze your name. Please enter it: ");
            name = Console.ReadLine();

            // Print variations of user's name
            Console.WriteLine(" Thanks {0}", name.ToUpper());
            Console.WriteLine(" The first letter of your name is {0}", name.Substring(0,1));
            Console.WriteLine(" The last letter of your name is {0}", name.Substring(name.Length - 1,1));
            Console.WriteLine(" The length of your name is {0}", name.Length);

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine(" The name in reverse is {0}\n", reverse);

            // Get a price from the user
            Console.Write("Now I'm going to analyze some numbers. Enter a price: ");
            price = Console.ReadLine();

            keepSectionRunning = true;
            while (keepSectionRunning)
            {
                isValid = double.TryParse(price, out numberPrice);
                if (!isValid)
                {
                    Console.Write(" The number you entered was not a valid price, please enter a number: ");
                    price = Console.ReadLine();
                }
                else
                {
                    keepSectionRunning = false;
                }
            }

            // Print variations of the price
            Console.WriteLine(" You entered {0:C2}", numberPrice);

            numberPrice = numberPrice + numberPrice * 0.08;
            Console.WriteLine(" Total with tax: {0:C2}", numberPrice);

            price = numberPrice.ToString();
            priceSplit = price.Split('.');
            Console.WriteLine(" The dollar portion: {0}", price[0]);
            Console.WriteLine(" The cents portion: 0.{0}\n", priceSplit[1]);

            // Get two numbers from user
            Console.WriteLine("Next, we'll compare two numbers.");
            Console.Write(" Enter the first number: ");
            userInput = Console.ReadLine();
            keepSectionRunning = true;
            while (keepSectionRunning)
            {
                isValid = double.TryParse(userInput, out firstNumber);
                if (!isValid)
                {
                    Console.Write(" The number you entered was not a valid price, please enter a number: ");
                    userInput = Console.ReadLine();
                }
                else
                {
                    keepSectionRunning = false;
                }
            }
            Console.Write(" Enter the second number: ");
            userInput = Console.ReadLine();
            keepSectionRunning = true;
            while (keepSectionRunning)
            {
                isValid = double.TryParse(userInput, out secondNumber);
                if (!isValid)
                {
                    Console.Write(" The number you entered was not a valid price, please enter a number: ");
                    userInput = Console.ReadLine();
                }
                else
                {
                    keepSectionRunning = false;
                }
            }

            // Compare numbers using math methods
            Console.WriteLine(" The large number is: {0}\n", Math.Max(firstNumber, secondNumber));

            // Get a sentence from the user
            Console.WriteLine("Let's alter a larger sentence (no punctuation necessary)");
            Console.Write(" Enter a sentence: ");
            userInput = Console.ReadLine();

            // Reverse the sentence
            sentenceSplit = userInput.Split(' ');
            reverse = "";

            for (int i = sentenceSplit.Length - 1; i >= 0; i--)
            {
                reverse += sentenceSplit[i] + " ";
            }

            reverse = reverse.ToLower();

            reverse = reverse.Substring(0, 1).ToUpper() + reverse.Substring(1,reverse.Length-1);

            // Print the sentence in reverse
            Console.WriteLine(" Sentence reversed: {0}\n", reverse);

            // Keep the window open!
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
