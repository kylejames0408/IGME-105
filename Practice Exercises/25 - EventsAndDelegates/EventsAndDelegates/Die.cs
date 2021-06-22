using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Die
    {
        // Fields
        private int rollCounter;
        private int twenties;
        private Random rng;
        public event MessageDelegate RolledATwenty;

        // Properties
        /// <summary>
        /// Gets the number of dice rolls.
        /// </summary>
        public int RollCounter { get { return rollCounter; } }
       

        // Constructors
        /// <summary>
        /// Construct a die.
        /// </summary>
        /// <param name="rng">A random number generator.</param>
        public Die(Random rng)
        {
            this.rng = rng;
            rollCounter = 0;
            twenties = 0;
        }

        // Methods
        /// <summary>
        /// Roll a dice.
        /// </summary>
        /// <returns>The number that the dice rolled.</returns>
        public int RollTheDie()
        {
            int diceNumber = rng.Next(1, 21);
            rollCounter++;

            if (diceNumber == 20 && RolledATwenty != null)
            {
                twenties++;
                RolledATwenty($"[{twenties}]Rolled a {diceNumber}", $"This was roll number {RollCounter}");
            }

            return diceNumber;
        }
    }
}
