using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables/objects
            bool keepSectionRunning;
            bool valid;
            string userInput;
            string[] itemCategories;
            Item removedItem;
            Inventory inventory;
            Random rng;
            ItemCategory category;

            // Initialize variables/objects
            keepSectionRunning = true;
            itemCategories = Enum.GetNames(typeof(ItemCategory));
            rng = new Random();
            inventory = new Inventory(rng, 10);

            // Create new items and add them to the inventory
            inventory.Add(new Sword("The Sword of Bored Hordes", 5, 10));
            inventory.Add(new Sword("Bumper Sword", 12, 1495));
            inventory.Add(new Sword("Blade of the East", 12, 3995));
            inventory.Add(new Sword("Katana", 3, 995));
            inventory.Add(new Sandwich("The Baconator", 2, 93));
            inventory.Add(new Sandwich("Mikey's Hoagie", 2, 56));
            inventory.Add(new Sandwich("Meatball Spuckie", 2, 78));
            inventory.Add(new Invisibility("Potion of Brief Invisibility", 1, 20));
            inventory.Add(new Invisibility("Potion of Enduring Invisibility", 1, 40));
            inventory.Add(new Invisibility("Potion of Prolonged Invisibility", 1, 50));

            while (keepSectionRunning)
            {
                // Output menu
                Console.WriteLine($"Your inventory currently has {inventory.Count} items.");
                Console.Write($"What kind of item would you like to use: Random");
                for (int i = 0; i < itemCategories.Length; i++)
                {
                    Console.Write($", {itemCategories[i]}");
                }
                Console.Write(": ");

                // Get user input
                userInput = Console.ReadLine().ToLower();

                if (userInput.Length > 0)
                {
                    userInput = userInput[0].ToString().ToUpper() + userInput.Substring(1);
                }

                // Act on user input
                if (userInput.Equals("Random"))
                {
                    try
                    {
                        // Remove a random item
                        removedItem = inventory.RemoveRandomItem();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        continue;
                    }
                }
                else
                {
                    try
                    {
                        category = (ItemCategory)Enum.Parse(typeof(ItemCategory), userInput);

                        // Remove a random item of specification
                        removedItem = inventory.RemoveRandomItem(category);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        continue;
                    }
                }

                try
                {
                    // Use the item
                    Console.WriteLine();
                    removedItem.Use();

                    // Add it back?
                    Console.Write($"Would you like to put {removedItem.ToString()} back? [Y/N]: ");
                    userInput = Console.ReadLine().ToLower();

                    valid = false;

                    while (!valid)
                    {
                        if (userInput.Equals("y"))
                        {
                            inventory.Add(removedItem);
                            Console.WriteLine($"You put {removedItem.ToString()} back in your inventory.");
                            valid = true;
                        }
                        else if (userInput.Equals("n"))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.Write("Please enter a valid answer [Y/N]: ");
                            userInput = Console.ReadLine().ToLower();
                        }
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

                // Keep looking through inventory?
                Console.Write("Would you like to keep searching through your inventory? [Y/N]: ");
                userInput = Console.ReadLine().ToLower();

                valid = false;

                while (!valid)
                {
                    if (userInput.Equals("y"))
                    {
                        valid = true;
                        Console.Clear();
                    }
                    else if (userInput.Equals("n"))
                    {
                        valid = true;
                        keepSectionRunning = false;
                    }
                    else
                    {
                        Console.Write("Please enter a valid answer [Y/N]: ");
                        userInput = Console.ReadLine().ToLower();
                    }
                }
            }

            // Keep the window open
            Console.WriteLine("\nGoodbye!");
            Console.Write("\nPress any key to continue. . .");
            Console.ReadLine();
        }
    }
}
