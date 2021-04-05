using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        // Fields
        List<Item> items;
        Random rng;

        // Properties
        /// <summary>
        /// Gets the number of items in the inventory.
        /// </summary>
        public int Count { get { return items.Count; } }

        // Constructors
        /// <summary>
        /// Constructs the inventory.
        /// </summary>
        /// <param name="rng">A random number generator.</param>
        /// <param name="inventorySize">The initial size of the inventory - default size is 10.</param>
        public Inventory(Random rng, int inventorySize = 10)
        {
            items = new List<Item>(inventorySize);
            this.rng = rng;
        }

        // Methods
        /// <summary>
        /// Add an item to the inventory.
        /// </summary>
        /// <param name="item">The item to add to the inventory.</param>
        public void Add(Item item)
        {
            if (item != null)
            {
                items.Add(item);
            }
            else
            {
                throw new ArgumentNullException("item", "The item that was trying to be added to your inventory is null (does not exist)!");
            }
        }

        /// <summary>
        /// Remove a random item.
        /// </summary>
        /// <returns>The item that was removed from the inventory.</returns>
        public Item RemoveRandomItem()
        {
            if (Count > 0)
            {
                int itemNumber = rng.Next(0, Count);
                Item item = items[itemNumber];
                items.RemoveAt(itemNumber);

                return item;
            }
            else
            {
                throw new InvalidOperationException("There are no items to remove from your inventory!");
            }
        }

        /// <summary>
        /// Remove a random item of a certain type.
        /// </summary>
        /// <param name="category">The category of the item to remove.</param>
        /// <returns>The item that was removed from the inventory.</returns>
        public Item RemoveRandomItem(ItemCategory category)
        {
            List<Item> categoryItems = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemCategory == category)
                {
                    categoryItems.Add(items[i]);
                }
            }

            if (categoryItems.Count > 0)
            {
                int itemNumber = rng.Next(0, categoryItems.Count);
                Item item = categoryItems[itemNumber];
                items.Remove(item);

                return item;
            }
            else
            {
                throw new InvalidOperationException("There are no items with the specified type left in your inventory!");
            }
        }
    }
}
