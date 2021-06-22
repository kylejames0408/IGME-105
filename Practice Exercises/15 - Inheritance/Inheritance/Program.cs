using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            List<Character> character;
            Random rng;

            // Initialize variables
            character = new List<Character>();
            rng = new Random();

            // Fill List
            character.Add(new Warrior("Stanley", 19, 12, 9, 7));
            character.Add(new Wizard("Taako", 10, 16, 20, 19, rng));
            character.Add(new Thief("Vax", 14, 20, 16, 2));

            // Randomly print out 10 characters
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\n--- Random character ---");
                int index = rng.Next(0, character.Count);
                Console.WriteLine(character[index].ToString());
                character[index].SpecialMove();

                // Check character values and call unique moves
                if (character[index] is Warrior)
                {
                    Warrior aWarrior = (Warrior)character[index];
                    aWarrior.TakeBath();
                }
                else if (character[index] is Wizard)
                {
                    Wizard aWizard = (Wizard)character[index];
                    aWizard.NewSpell();
                }
                else if (character[index] is Thief)
                {
                    Thief aThief = (Thief)character[index];
                    aThief.ShutOffPhone();
                }
                else
                {
                    Console.WriteLine("Character has no special moves.\n");
                }
            }

            // Keep window open
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
