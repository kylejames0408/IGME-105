using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndEnums
{
    enum Damage { Storm, Fire, Ice, Earth, Death }
    abstract class Monster
    {
        // Fields
        private int health;
        private string name;
        private Damage dmgType;
        private Random rng;

        // Properties
        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }

        public Damage DmgType { get { return dmgType; } set { dmgType = value; } }

        public string Name { get { return name; } }

        // Constructors
        public Monster(string name, int health, Damage dmgType, Random rng)
        {
            this.name = name;
            this.health = health;
            this.dmgType = dmgType;
            this.rng = rng;
        }

        // Methods
        public abstract int Attack();
        public override string ToString()
        {
            return $"{name} has {health} health";
        }
    }
}
