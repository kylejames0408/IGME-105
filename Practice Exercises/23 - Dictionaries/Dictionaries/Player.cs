using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Player
    {
        // Fields
        private string name;
        private int score;

        // Properties
        public string Name { get { return name; } }
        public int Score { get { return score; } }

        // Constructors
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        // Methods
        public override string ToString()
        {
            return $"{name}'s score is {score}";
        }
    }
}
