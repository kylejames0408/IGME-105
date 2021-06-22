using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Character
    {
        // Fields
        protected int dexterity;
        protected int intelligence;
        protected int strength;
        protected string name;

        // Properties
        /// <summary>
        /// Get or set the dexterity of the character.
        /// </summary>
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        /// <summary>
        /// Get or set the intelligence of the character.
        /// </summary>
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        /// <summary>
        /// Get or set the strength of the character.
        /// </summary>
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        
        /// <summary>
        /// Get the name of the character.
        /// </summary>
        public string Name { get { return name; } }

        // Constructors
        /// <summary>
        /// Creates a character with default values.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="strength">The strength of the character.</param>
        /// <param name="dexterity">The dexterity of the character.</param>
        /// <param name="intelligence">The intelligence of the character.</param>
        public Character(string name, int strength, int dexterity, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        // Methods
        /// <summary>
        /// Prints basic information about the character.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence.");
        }

        /// <summary>
        /// Returns a string that represents the character object.
        /// </summary>
        /// <returns>A string that represents the character object.</returns>
        public override string ToString()
        {
            return $"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence."; 
        }

        /// <summary>
        /// Prints the special move of the character.
        /// </summary>
        public virtual void SpecialMove()
        {
            Console.Write($"{name} performs...");
        }
    }
}
