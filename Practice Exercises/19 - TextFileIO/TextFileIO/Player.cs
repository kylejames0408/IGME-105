using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    class Player
    {
        // Fields
        private string name;
        private int health;
        private int carryWeight;

        // Properties
        /// <summary>
        /// Gets the name of the player.
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Gets and sets the health of the player.
        /// </summary>
        public int Health { get { return health; } set { if (value >= 0) { health = value; } } }

        /// <summary>
        /// Gets and sets the carry weight of the player.
        /// </summary>
        public int CarryWeight { get { return carryWeight; } set { if (value >=0) { carryWeight = value; } } }

        // Constructors
        /// <summary>
        /// Constructs a new player object.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        /// <param name="health">The health of the player.</param>
        /// <param name="carryWeight">The weight that the player can carry.</param>
        public Player(string name, int health, int carryWeight)
        {
            this.name = name;
            Health = health;
            CarryWeight = carryWeight;
        }

        // Methods
        /// <summary>
        /// Converts player information into a string.
        /// </summary>
        /// <returns>A string with information about the player.</returns>
        public override string ToString()
        {
            return $"\tPlayer: {name} has {health} health and can carry {carryWeight} weight.";
        }
    }
}
