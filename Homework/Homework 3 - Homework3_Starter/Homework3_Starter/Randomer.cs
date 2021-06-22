using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Randomer : Monster
    {
        // Fields
        Random rng;

        // Constructors
        /// <summary>
        /// Creaters a "randomer" monster type.
        /// </summary>
        /// <param name="rng">A random number generator.</param>
        /// <param name="xPosition">The starting X position of the monster. The default position is 25.</param>
        /// <param name="yPosition">The starting Y position of the monster. The default position is 25.</param>
        public Randomer(Random rng, int xPosition = 25, int yPosition = 25) : base('R', xPosition, yPosition, ConsoleColor.DarkBlue)
        {
            this.rng = rng;
        }

        // Methods
        /// <summary>
        /// Randomly updates the monsters position.
        /// </summary>
        public override void Update()
        {
            int cardinalDirection = rng.Next(0, 8);

            switch(cardinalDirection)
            {
                // Move up one space and left one space
                case 0:
                    MonsterXPosition--;
                    if (MonsterXPosition < 0)
                    {
                        MonsterXPosition = 0;
                    }

                    MonsterYPosition--;
                    if (MonsterYPosition < 1)
                    {
                        MonsterYPosition = 1;
                    }

                    break;
                // Move up one space
                case 1:
                    MonsterYPosition--;
                    if (MonsterYPosition < 1)
                    {
                        MonsterYPosition = 1;
                    }

                    break;
                // Move up one space and right one space
                case 2:
                    MonsterXPosition++;
                    if (MonsterXPosition >= Console.WindowWidth)
                    {
                        MonsterXPosition = Console.WindowWidth - 1;
                    }

                    MonsterYPosition--;
                    if (MonsterYPosition < 1)
                    {
                        MonsterYPosition = 1;
                    }

                    break;
                // Move left one space
                case 3:
                    MonsterXPosition--;
                    if (MonsterXPosition < 0)
                    {
                        MonsterXPosition = 0;
                    }

                    break;
                // Move right one space
                case 4:
                    MonsterXPosition++;
                    if (MonsterXPosition >= Console.WindowWidth)
                    {
                        MonsterXPosition = Console.WindowWidth - 1;
                    }

                    break;
                // Move down one space and left one space
                case 5:
                    MonsterXPosition--;
                    if (MonsterXPosition < 0)
                    {
                        MonsterXPosition = 0;
                    }

                    MonsterYPosition++;
                    if (MonsterYPosition > Console.WindowHeight)
                    {
                        MonsterYPosition = Console.WindowHeight - 1;
                    }

                    break;
                // Move down one space
                case 6:
                    MonsterYPosition++;
                    if (MonsterYPosition > Console.WindowHeight)
                    {
                        MonsterYPosition = Console.WindowHeight - 1;
                    }

                    break;
                // Move down one space and right one space
                case 7:
                    MonsterXPosition++;
                    if (MonsterXPosition >= Console.WindowWidth)
                    {
                        MonsterXPosition = Console.WindowWidth - 1;
                    }

                    MonsterYPosition++;
                    if (MonsterYPosition > Console.WindowHeight)
                    {
                        MonsterYPosition = Console.WindowHeight - 1;
                    }

                    break;
            }
        }
    }
}
