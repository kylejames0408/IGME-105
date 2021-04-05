using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndEnums
{
    class Dragon : Monster
    {
        // Fields
        Random rng;

        // Constructors
        public Dragon(string name, int health, Random rng)
            : base(name, health, Damage.Fire, rng)
        {
            this.rng = rng;
        }

        // Methods
        public override int Attack()
        {
            return rng.Next(10, 21);
        }

        public override string ToString()
        {
            return $"The Dragon {Name} has {Health} health and breathes fire.";
        }
    }
}
