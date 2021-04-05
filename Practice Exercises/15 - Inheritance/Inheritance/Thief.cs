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
            set
            {
                if (numberOfSpamCalls >= 0)
                {
                    numberOfSpamCalls = value;
                }
            }
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
        /// Returns basic information about the thief.
        /// </summary>
        /// <returns>A string that represents the thief object.</returns>
        public override string ToString()
        {
            return $"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence.\n" +
                $"{name}, a Thief, has a cell phone that inappropriately rings {numberOfSpamCalls} times per day.\n";
        }

        /// <summary>
        /// Print information about the thief's special move.
        /// </summary>
        public override void SpecialMove()
        {
            base.SpecialMove();

            Console.Write($"\"browses for new cell phone providers\".");
            if (numberOfSpamCalls < 8)
            {
                Console.WriteLine("(what even is this game?), but ultimately decides his current plan is fine.\n");
            }
            else
            {
                Console.WriteLine(", and is fed up with his cell phone ruining his carefully laid sneak attacks, and finally changes to a new cell phone provider in the hopes of blocking spam calls.\n");
                numberOfSpamCalls -= 3;
            }
        }

        /// <summary>
        /// Reduces spam calls to zero because the phone is off.
        /// </summary>
        public void ShutOffPhone()
        {
            Console.WriteLine($"\n{name} uses his boots of haste which allows him to turn off his cell phone before it rings.\n");
            numberOfSpamCalls = 0;
        }
    }
}
