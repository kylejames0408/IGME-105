using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Sandwich : Item
    {
        // Fields
        int numberOfBitesLeft;

        // Properties
        /// <summary>
        /// Gets the number of bites left for the sandwich.
        /// </summary>
        public int NumberOfBitesLeft { get { return numberOfBitesLeft; } }

        // Constructors
        /// <summary>
        /// Constructs a sandwich.
        /// </summary>
        /// <param name="name">The name of the sandwich.</param>
        /// <param name="weight">The weight of the sandwich.</param>
        /// <param name="numberOfBitesLeft">The number of bites left in the sandwich.</param>
        public Sandwich(string name, int weight, int numberOfBitesLeft) : base(name, weight, ItemCategory.Food)
        {
            if (numberOfBitesLeft < 0)
            {
                numberOfBitesLeft = 0;
            }

            this.numberOfBitesLeft = numberOfBitesLeft;
        }

        // Methods
        /// <summary>
        /// Take a bite of the sandwich if there is still a bite left.
        /// </summary>
        public override void Use()
        {
            if (numberOfBitesLeft >= 1)
            {
                numberOfBitesLeft--;
                Console.WriteLine($"You take a bite of {ToString()}. Only {numberOfBitesLeft} more bites left before it'll be gone!");
            }
            else
            {
                Console.WriteLine($"You go to take a bite of {ToString()}, but realize that you already ate it.");
            }
        }
    }
}
