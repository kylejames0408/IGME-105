using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Monster
    {
        // Fields
        private char asciiMonster;
        private int monsterXPosition;
        private int monsterYPosition;
        private ConsoleColor monsterColor;

        // Properties
        /// <summary>
        /// Gets or sets the ASCII value that represents a monster.
        /// </summary>
        public char AsciiMonster { get { return asciiMonster; } set { asciiMonster = value; } }

        /// <summary>
        /// Gets or sets the monsters position on the horizontal (x) plane between the left and right borders of the window.
        /// </summary>
        public int MonsterXPosition
        {
            get
            {
                return monsterXPosition;
            }
            set
            {
                if (value < Console.WindowWidth && value >= 0)
                {
                    monsterXPosition = value;
                }
            }
        }


        /// <summary>
        /// Gets or sets the monsters position on the vertical (y) plane between the top and bottom borders of the window.
        /// </summary>
        public int MonsterYPosition
        {
            get
            {
                return monsterYPosition;
            }
            set
            {
                if (value < Console.WindowHeight && value >= 0)
                {
                    monsterYPosition = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the color of the monster.
        /// </summary>
        public ConsoleColor MonsterColor { get { return monsterColor; } set { monsterColor = value; } }

        // Constructors
        /// <summary>
        /// Creates a new monster and sets a typical default values of a monster.
        /// </summary>
        /// <param name="asciiMonster">A character to represent a monster. The default character is 'M'</param>
        /// <param name="startingXPosition">The starting X position of the monster. The default position is 20.</param>
        /// <param name="startingYPosition">The starting Y position of the monster. The default position is 20.</param>
        /// <param name="monsterColor">The color to make the character that is representing the monster. The default color is Dark Magenta.</param>
        public Monster(char asciiMonster = 'M',  int startingXPosition = 20, int startingYPosition = 20, ConsoleColor monsterColor = ConsoleColor.DarkMagenta)
        {
            AsciiMonster = asciiMonster;
            MonsterXPosition = startingXPosition;
            MonsterYPosition = startingYPosition;
            MonsterColor = monsterColor;
        }

        // Methods
        /// <summary>
        /// Handles "drawing" monsters to the console.
        /// </summary>
        public void Draw()
        {
            // Move the Console's cursor position to match the Monster's current position
            Console.CursorLeft = monsterXPosition;
            Console.CursorTop = monsterYPosition;

            // Set Console's foreground color to Monster's color
            Console.ForegroundColor = monsterColor;

            // Write the Monster to the Console
            Console.Write(asciiMonster);

            // Reset console color
            Console.ResetColor();
        }

        /// <summary>
        /// Checks keyboard input and moves the monster.
        /// </summary>
        public virtual void Update()
        {
            // Check keyboard input
            if (KeyboardHelper.IsKeyDown(KeyCode.Key_W))
            {
                monsterYPosition--;
                if (monsterYPosition < 1)
                {
                    monsterYPosition = 1;
                }
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Key_S))
            {
                monsterYPosition++;
                if (monsterYPosition >= Console.WindowHeight)
                {
                    monsterYPosition = Console.WindowHeight - 1;
                }
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Key_A))
            {
                MonsterXPosition--;
                if (monsterXPosition < 0)
                {
                    monsterXPosition = 0;
                }
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Key_D))
            {
                monsterXPosition++;
                if (MonsterXPosition >= Console.WindowWidth)
                {
                    monsterXPosition = Console.WindowWidth - 1;
                }
            }
        }
    }
}
