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
        private Random rng;

        // Properties
        /// <summary>
        /// Get or set the likelihood that the wizard's spell flops.
        /// </summary>
        public double HotPocketSpellFlop
        {
            get { return hotPocketSpellFlop; }
            set
            {
                if (hotPocketSpellFlop >= 0)
                {
                    hotPocketSpellFlop = value;
                }
            }
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
        /// <param name="rng">Random number generator</param>
        public Wizard(string name, int strength, int dexterity, int intelligence, double hotPocketSpellFlop, Random rng) : base(name, strength, dexterity, intelligence)
        {
            this.hotPocketSpellFlop = hotPocketSpellFlop;
            this.rng = rng;
        }

        // Methods
        /// <summary>
        /// Returns basic information about the wizard.
        /// </summary>
        /// <returns>A string that represents the wizard object.</returns>
        public override string ToString()
        {
            return $"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence.\n" +
                $"{name}, a Wizard, creates Hot Pockets (tm) {hotPocketSpellFlop:P2} percent of the time.\n";
        }

        /// <summary>
        /// Print information about the wizard's special move.
        /// </summary>
        /// <param name="rng">A random object to generate a random number.</param>
        public override void SpecialMove()
        {
            base.SpecialMove();

            double rollTheDie = rng.NextDouble();
            hotPocketSpellFlop /= 100;

            Console.Write($"\"cast a spell\".");

            if (rollTheDie <= hotPocketSpellFlop)
            {
                Console.WriteLine(" Instead, a Hot Pocket (tm) falls to the ground with a thud.\n");
            }
            else
            {
                Console.WriteLine(" The spell succeeds! (...this time)\n");
            }
        }

        /// <summary>
        /// Reduces likelihood of a spell flop.
        /// </summary>
        public void NewSpell()
        {
            Console.WriteLine($"{name} discovers a new taco topping which reduces his Hot Pocket percentage.\n");
            hotPocketSpellFlop *= 100;
            hotPocketSpellFlop -= 5;
        }
    }
}
