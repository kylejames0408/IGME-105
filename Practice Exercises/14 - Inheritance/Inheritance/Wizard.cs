using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Wizard : Character
    {
        // Fields
        private double hotPocketSpellFlop;

        // Properties
        /// <summary>
        /// Get or set the likelihood that the wizard's spell flops.
        /// </summary>
        public double HotPocketSpellFlop
        {
            get { return hotPocketSpellFlop; }
            set { hotPocketSpellFlop = value / 100; }
        }

        // Constructor
        /// <summary>
        /// Creates a wizard character.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="strength">The strength of the character.</param>
        /// <param name="dexterity">The dexterity of the character.</param>
        /// <param name="intelligence">The intelligence of the character.</param>
        /// <param name="hotPocketSpellFlop">Likelihood that the wizard's spell flops.</param>
        public Wizard(string name, int strength, int dexterity, int intelligence, double hotPocketSpellFlop) : base(name, strength, dexterity, intelligence)
        {
            this.hotPocketSpellFlop = hotPocketSpellFlop / 100;
        }

        // Methods
        /// <summary>
        /// Print basic information about the wizard.
        /// </summary>
        public void PrintWizard()
        {
            Print();
            Console.WriteLine($"{name}, a Wizard, creates Hot Pockets (tm) {hotPocketSpellFlop:P2} percent of the time.\n");
        }

        /// <summary>
        /// Print information about the wizard's special move.
        /// </summary>
        /// <param name="rng">A random object to generate a random number.</param>
        public void SpecialMove(Random rng)
        {
            double rollTheDie = rng.NextDouble();

            Console.Write($"{name} attempts to cast a spell.");

            if (rollTheDie <= hotPocketSpellFlop)
            {
                Console.WriteLine(" Instead, a Hot Pocket (tm) falls to the ground with a thud.\n");
            }
            else
            {
                Console.WriteLine(" The spell succeeds! (...this time)\n");
            }
        }
    }
}
