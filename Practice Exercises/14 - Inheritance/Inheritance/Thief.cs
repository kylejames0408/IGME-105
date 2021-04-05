using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Thief : Character
    {
        // Fields
        private int numberOfSpamCalls;

        // Properties
        /// <summary>
        /// Get or set the number of spam calls the thief gets per day.
        /// </summary>
        public int NumberOfSpamCalls
        {
            get { return numberOfSpamCalls; }
            set { numberOfSpamCalls = value; }
        }

        // Constructor
        /// <summary>
        /// Creates a thief character.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="strength">The strength of the character.</param>
        /// <param name="dexterity">The dexterity of the character.</param>
        /// <param name="intelligence">The intelligence of the character.</param>
        /// <param name="numberOfSpamCalls">The number of spam phone calls the thief receives per day.</param>
        public Thief(string name, int strength, int dexterity, int intelligence, int numberOfSpamCalls) : base(name, strength, dexterity, intelligence)
        {
            this.numberOfSpamCalls = numberOfSpamCalls;
        }

        // Methods
        /// <summary>
        /// Print basic information about the thief.
        /// </summary>
        public void PrintThief()
        {
            Print();
            Console.WriteLine($"{name}, a Thief, has a cell phone that inappropriately rings {numberOfSpamCalls} times per day.\n");
        }

        /// <summary>
        /// Print information about the thief's special move.
        /// </summary>
        public void SpecialMove()
        {
            if (numberOfSpamCalls < 8)
            {
                Console.WriteLine($"{name} browses for new cell phone providers (what even is this game?), but ultimately decides his current plan is fine.\n");
            }
            else
            {
                Console.WriteLine($"{name} is fed up with his cell phone ruining his carefully laid sneak attacks, and finally changes to a new cell phone provider in the hopes of blocking spam calls.\n");
                numberOfSpamCalls -= 3;
            }
        }
    }
}
