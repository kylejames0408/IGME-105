using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Sword : Item
    {
        // Fields
        int durability;

        // Properties
        /// <summary>
        /// Gets the durability of the sword.
        /// </summary>
        public int Durability { get { return durability; } }

        // Constructors
        /// <summary>
        /// Constructs a sword.
        /// </summary>
        /// <param name="name">The name of the sword.</param>
        /// <param name="weight">The weight of the sword.</param>
        /// <param name="durability">The durability of the sword.</param>
        public Sword(string name, int weight, int durability) : base(name, weight, ItemCategory.Weapon)
        {
            if (durability < 0)
            {
                durability = 0;
            }

            this.durability = durability;
        }

        // Methods
        /// <summary>
        /// Swings the sword if there it is still durable. 
        /// </summary>
        public override void Use()
        {
            if (durability >= 1)
            {
                durability--;
                Console.WriteLine($"You have swung {ToString()}, Only {durability} more swings before it'll need to be repaired.");
            }
            else
            {
                Console.WriteLine($"You attemp to swing {ToString()}, but it feels so fragile from battle that you decide against it.");
            }
        }
    }
}
