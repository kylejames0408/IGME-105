using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    enum CardinalDirections { NW, SW, SE, NE}
    class Bouncer : Monster
    {
        // Fields
        CardinalDirections previousDirection;
        CardinalDirections direction;

        // Constructor
        public Bouncer(int xPosition = 10, int yPosition = 10) : base('B', xPosition, yPosition, ConsoleColor.Blue)
        {
            direction = CardinalDirections.NE;
        }

        // Methods
        public override void Update()
        {
            previousDirection = direction;

            if (direction == CardinalDirections.NE)
            {
                MonsterXPosition++;
                MonsterYPosition--;
            }
            else if (direction == CardinalDirections.SE)
            {
                MonsterXPosition++;
                MonsterYPosition++;
            }
            else if (direction == CardinalDirections.SW)
            {
                MonsterXPosition--;
                MonsterYPosition++;
            }
            else
            {
                MonsterXPosition--;
                MonsterYPosition--;
            }

            // Check if it hits the corner (like the DVD sign in The Office)
            if (MonsterXPosition < 1 && MonsterYPosition < 1)
            {
                MonsterXPosition = 1;
                MonsterYPosition = 1;
                direction = CardinalDirections.SW;
                return;
            }
            if (MonsterXPosition >= Console.WindowWidth - 1 && MonsterYPosition >= Console.WindowHeight - 1)
            {
                MonsterXPosition = Console.WindowWidth - 1;
                MonsterYPosition = Console.WindowHeight - 1;
                direction = CardinalDirections.NW;
                return;
            }
            if (MonsterXPosition >= Console.WindowWidth - 1 && MonsterYPosition < 1)
            {
                MonsterXPosition = Console.WindowWidth - 1;
                MonsterYPosition = 1;
                direction = CardinalDirections.SW;
                return;
            }
            if (MonsterXPosition < 1 && MonsterYPosition >= Console.WindowHeight - 1)
            {
                MonsterXPosition = 1;
                MonsterYPosition = Console.WindowHeight - 1;
                direction = CardinalDirections.NE;
                return;
            }

            // Change direction on collision with walls
            if (MonsterXPosition < 1)
            {
                MonsterXPosition = 1;
                if (previousDirection == CardinalDirections.NW)
                {
                    direction = CardinalDirections.NE;
                }
                else
                {
                    direction = CardinalDirections.SE;
                }
            }
            if (MonsterXPosition >= Console.WindowWidth - 1)
            {
                MonsterXPosition = Console.WindowWidth - 1;
                if (previousDirection == CardinalDirections.NE)
                {
                    direction = CardinalDirections.NW;
                }
                else
                {
                    direction = CardinalDirections.SW;
                }
            }
            if (MonsterYPosition < 1)
            {
                MonsterYPosition = 2;
                if (previousDirection == CardinalDirections.NE)
                {
                    direction = CardinalDirections.SE;
                }
                else
                {
                    MonsterXPosition++;
                    direction = CardinalDirections.SW;
                }
            }
            if (MonsterYPosition >= Console.WindowHeight - 1)
            {
                MonsterYPosition = Console.WindowHeight - 1;
                if (previousDirection == CardinalDirections.SE)
                {
                    direction = CardinalDirections.NE;
                }
                else
                {
                    direction = CardinalDirections.NW;
                }
            }
        }
    }
}
