using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    enum ItemCategory { Food, Weapon, Potion }
    abstract class Item
    {
        // Fields
        int weight;
        string name;
        ItemCategory itemCategory;

        // Properties
        /// <summary>
        /// Gets the item's weight.
        /// </summary>
        public int Weight { get { return weight; } }

        /// <summary>
        /// Gets the item's name.
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Gets the item's category.
        /// </summary>
        public ItemCategory ItemCategory { get { return itemCategory; } }

        // Constructors
        /// <summary>
        /// Constructs a basic item.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="weight">The weight of the item.</param>
        /// <param name="itemCategory">The category of the item.</param>
        public Item(string name, int weight, ItemCategory itemCategory)
        {
            if (weight < 0)
            {
                weight = 0;
            }

            this.name = name;
            this.weight = weight;
            this.itemCategory = itemCategory;
        }

        // Methods
        /// <summary>
        /// Abstractly makes each item useable.
        /// </summary>
        public abstract void Use();

        /// <summary>
        /// Contructs basic information about the item into a string.
        /// </summary>
        /// <returns>A string of information about the item.</returns>
        public override string ToString()
        {
            return $"{name}, a {itemCategory}-type item with {weight} weight";
        }
    }
}
