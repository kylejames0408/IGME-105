using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Invisibility : Item
    {
        // Fields
        int sipsRemaining;

        // Properties
        /// <summary>
        /// Gets the number of sips remaining from the potion.
        /// </summary>
        public int SipsRemaining { get { return sipsRemaining; } }

        // Constructors
        /// <summary>
        /// Constructs a potion of invisibility.
        /// </summary>
        /// <param name="name">The invisibility potion's name.</param>
        /// <param name="weight">The weight of the invisibility potion.</param>
        /// <param name="sipsRemaining">The number of the sips remaining for the potion.</param>
        public Invisibility(string name, int weight, int sipsRemaining) : base(name, weight, ItemCategory.Potion)
        {
            if (sipsRemaining < 0)
            {
                sipsRemaining = 0;
            }

            this.sipsRemaining = sipsRemaining;
        }

        // Methods
        /// <summary>
        /// Drink the potion if there are any sips remaining.
        /// </summary>
        public override void Use()
        {
            if (sipsRemaining >= 1)
            {
                sipsRemaining--;
                Console.WriteLine($"You take a swig of {ToString()}. Only {sipsRemaining} more sips remaining before it'll be gone.");
            }
            else
            {
                Console.WriteLine($"You go to drink {ToString()}, but you realize you already drank all of it.");
            }
        }
    }
}
