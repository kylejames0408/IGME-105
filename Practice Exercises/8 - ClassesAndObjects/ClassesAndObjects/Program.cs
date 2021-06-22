using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects
            Random rng = new Random();
            NameGenerator randomNames = new NameGenerator(rng);

            // Create ten names
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine(randomNames.GenerateName());
            }

            // Output statisitcs
            randomNames.PrintStatistics();

            // Keep the window open
            Console.Write("\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
