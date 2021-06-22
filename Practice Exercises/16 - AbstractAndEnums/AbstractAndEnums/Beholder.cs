using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndEnums
{
    class Beholder : Monster
    {
        // Fields
        Random rng;

        // Constructor
        public Beholder(string name, int health, Random rng)
            : base(name, health, Damage.Storm, rng)
        {
            this.rng = rng;
        }

        // Methods
        public override int Attack()
        {
            return rng.Next(5, 26);
        }

        public override string ToString()
        {
            return $"The Beholder {Name} has {Health} health and shocks enemies.";
        }
    }
}
