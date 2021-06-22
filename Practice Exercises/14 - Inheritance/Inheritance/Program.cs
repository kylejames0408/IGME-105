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
            // Initalize variables
            Random rng = new Random();
            Warrior warrior = new Warrior("Stanley", 19, 12, 9, 7);
            Wizard wizard = new Wizard("Taako", 10, 16, 20, 19);
            Thief thief = new Thief("Vax", 14, 20, 16, 2);

            // Print initial character stats
            Console.WriteLine("Character stats:\n");
            warrior.PrintWarrior();
            wizard.PrintWizard();
            thief.PrintThief();

            // Print character special moves
            Console.WriteLine("\nSpecial moves:\n");
            warrior.SpecialMove();
            wizard.SpecialMove(rng);
            thief.SpecialMove();

            // Change stats
            Console.WriteLine("\n<Character stats changed here>\n");
            warrior.Strength++;
            warrior.Intelligence += 3;
            warrior.DaysSinceLastBath = 1;
            wizard.Strength++;
            wizard.Dexterity++;
            wizard.HotPocketSpellFlop = 33;
            thief.NumberOfSpamCalls = 8;

            // Print changed stats
            Console.WriteLine("\nCharacter stats:\n");
            warrior.PrintWarrior();
            wizard.PrintWizard();
            thief.PrintThief();

            // Print special moves
            Console.WriteLine("\nSpecial moves:\n");
            warrior.SpecialMove();
            wizard.SpecialMove(rng);
            thief.SpecialMove();

            // Keep the window open
            Console.WriteLine("\n\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
