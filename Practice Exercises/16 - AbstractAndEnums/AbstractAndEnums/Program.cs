using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare & Initialize Variables
            Random rng = new Random();
            Dragon dragon = new Dragon("Jimmy", 115, rng);
            Beholder beholder = new Beholder("Carl", 90, rng);

            // Start fight
            Console.WriteLine("Welcome to the fight!\n");

            while(dragon.Health > 0 && beholder.Health > 0)
            {
                Console.WriteLine(dragon);
                Console.WriteLine(beholder + "\n");

                int dragonAttack = dragon.Attack();
                int beholderAttack = beholder.Attack();

                Console.WriteLine($"{dragon.Name} attacks for {dragonAttack} damage.");
                Console.WriteLine($"{beholder.Name} attacks for {beholderAttack} damage.\n");

                dragon.Health -= beholderAttack;
                beholder.Health -= dragonAttack;
            }

            if (dragon.Health > 0)
            {
                Console.WriteLine($"{dragon.Name} has emerged victorious!\n");
            }
            else if (beholder.Health > 0)
            {
                Console.WriteLine($"{beholder.Name} has emerged victorious!\n");
            }
            else
            {
                Console.WriteLine("The battle resulted in a tie!\n");
            }

            // Keep window open
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
