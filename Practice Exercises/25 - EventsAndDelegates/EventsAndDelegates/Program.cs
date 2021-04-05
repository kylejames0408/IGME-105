using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    delegate void MessageDelegate(string label, string message);
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            Random rng;
            MessageLog messageLog;
            Die die;

            // Initialize variables
            rng = new Random();
            messageLog = new MessageLog();
            die = new Die(rng);
            die.RolledATwenty += messageLog.Save;

            // Header
            Console.WriteLine("Welcome to the die roller!\n");

            // Roll 100 dice
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(die.RollTheDie());
            }

            // Print the message log
            Console.WriteLine("\nPrinting Message Log:");
            messageLog.Print();

            // Keep the window open
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
