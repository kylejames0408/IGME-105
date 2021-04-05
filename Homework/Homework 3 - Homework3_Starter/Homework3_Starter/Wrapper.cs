using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Wrapper : Monster
    {
        // Constructors
        /// <summary>
        /// Creates a "wrapper" monster type.
        /// </summary>
        /// <param name="xPosition">The starting X position of the monster. The default position is 30.</param>
        /// <param name="yPosition">The starting Y position of the monster. The default position is 30.</param>
        public Wrapper(int xPosition = 1, int yPosition = 1) : base('W', xPosition, yPosition, ConsoleColor.Green)
        {
        }

        // Methods
        /// <summary>
        /// Moves the wrapper monster from left to right and wraps around the screen.
        /// </summary>
        public override void Update()
        {
            MonsterXPosition++;
            if (MonsterXPosition >= Console.WindowWidth - 1)
            {
                MonsterXPosition = 0;
                MonsterYPosition++;
                if (MonsterYPosition >= Console.WindowHeight)
                {
                    MonsterYPosition = 1;
                }
            }
        }
    }
}
