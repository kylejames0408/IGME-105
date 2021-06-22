using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Warrior : Character
    {
        // Fields
        private int daysSinceLastBath;

        // Properties
        /// <summary>
        /// Get or set the number of days since the warrior last bathed.
        /// </summary>
        public int DaysSinceLastBath
        {
            get { return daysSinceLastBath; }
            set
            {
                if (daysSinceLastBath >= 0)
                {
                    daysSinceLastBath = value;
                }
            }
        }

        // Constructors
        /// <summary>
        /// Creates a warrior character.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="strength">The strength of the character.</param>
        /// <param name="dexterity">The dexterity of the character.</param>
        /// <param name="intelligence">The intelligence of the character.</param>
        /// <param name="daysSinceLastBath">The number of days since the character last bathed.</param>
        public Warrior(string name, int strength, int dexterity, int intelligence, int daysSinceLastBath) : base(name, strength, dexterity, intelligence)
        {
            this.daysSinceLastBath = daysSinceLastBath;
        }

        // Methods
        /// <summary>
        /// Return basic information about the warrior.
        /// </summary>
        /// <returns>A string that represents the warrior object.</returns>
        public override string ToString()
        {
            return $"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence.\n" +
                $"{name}, a Warrior, hasn't bathed in {daysSinceLastBath} day(s).\n";
        }

        /// <summary>
        /// Print information about the warrior's special move.
        /// </summary>
        public override void SpecialMove()
        {
            base.SpecialMove();

            Console.Write($"\"make friends\",");
            if (daysSinceLastBath >= 4)
            {
                Console.WriteLine("but the odor is unbearable. No new friends have been found.\n");
            }
            else
            {
                Console.WriteLine(" and has made new friends!\n");
            }
        }

        /// <summary>
        /// Resets daysSinceLastBath to zero because the warrior takes a bath.
        /// </summary>
        public void TakeBath()
        {
            Console.WriteLine($"\n{name}'s stench becomes unbearable and he decides its finally time to take a bath (and wash his clothes too).\n");
            daysSinceLastBath = 0;
        }
    }
}
