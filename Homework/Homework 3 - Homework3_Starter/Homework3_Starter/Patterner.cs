using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    enum Directions { right, down, left, up };
    class Patterner : Monster
    {
        // Fields
        private int distance;
        private int squareDistance;
        private Directions direction;

        // Constructor
        /// <summary>
        /// Creates a "patterner" monster type.
        /// </summary>
        /// <param name="xPosition">The starting X position of the monster. The default position is 15.</param>
        /// <param name="yPosition">The starting Y position of the monster. The default position is 15.</param>
        public Patterner(int squareDistance, Directions startDirection = Directions.right, int xPosition = 15, int yPosition = 15) : base('P', xPosition, yPosition, ConsoleColor.Cyan)
        {
            distance = squareDistance;
            this.squareDistance = squareDistance;
            this.direction = startDirection;
        }

        // Methods
        /// <summary>
        /// Moves the monster in a square pattern.
        /// </summary>
        public override void Update()
        {
            // Check direction and move monster in that direction
            if (direction == Directions.right)
            {
                MonsterXPosition++;
                if (MonsterXPosition >= Console.WindowWidth)
                {
                    MonsterXPosition = Console.WindowWidth - 1;
                }
            }
            else if (direction == Directions.down)
            {
                MonsterYPosition++;
                if (MonsterYPosition >= Console.WindowHeight)
                {
                    MonsterYPosition = Console.WindowHeight - 1;
                }
            }
            else if (direction == Directions.left)
            {
                MonsterXPosition--;
                if (MonsterXPosition < 0)
                {
                    MonsterXPosition = 0;
                }
            }
            else
            {
                MonsterYPosition--;
                if (MonsterYPosition < 0)
                {
                    MonsterYPosition = 0;
                }
            }

            // Check if the monster has moved the distance, if it has, change it's direction
            squareDistance--;
            if (squareDistance <= 0)
            {
                squareDistance = distance;
                if ((int)direction + 1 > 3)
                {
                    direction = 0;
                }
                else
                {
                    direction = (Directions)((int)direction + 1);
                }
            }
        }
    }
}
