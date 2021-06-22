/*
 * The purpose of this is to draw a dungeon using the dungeon class
 * 
 * Author: Kyle James
 * Version: 20 September 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDungeonMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare object
            ConsoleColor roomName = ConsoleColor.Magenta;
            Dungeon dungeon;

            // Initialize object
            dungeon = new Dungeon(100, 52, "A Simple Dungeon");

            // Header
            Console.WriteLine("This is a basic outline for a dungeon.");

            // Draw the dungeon - first room
            Console.ForegroundColor = roomName;
            Console.CursorLeft = 1;
            Console.CursorTop = 2;
            Console.Write("spawn");

                // Walls
            dungeon.DrawWallVertical(0, 2, 4);
            dungeon.DrawWallVertical(10, 2, 1);
            dungeon.DrawWallHorizontal(1, 1, 9);
            dungeon.DrawWallHorizontal(1, 6, 9);

                // Corners and objects
            dungeon.DrawObject(0, 1, '╔');
            dungeon.DrawObject(10, 1, '╗');
            dungeon.DrawObject(0, 6, '╚');
            dungeon.DrawObject(10, 6, '╝');
            dungeon.DrawObject(5, 4, '@', ConsoleColor.Cyan);
            dungeon.DrawObject(8, 5, 'W', ConsoleColor.Green);

            // Draw the dungeon - first hallway
                // Walls
            dungeon.DrawWallHorizontal(11, 3, 4);
            dungeon.DrawWallHorizontal(11, 5, 2);
            dungeon.DrawWallVertical(15, 8, -5);
            dungeon.DrawWallVertical(13, 8, -3);
            
                // Corners and objects
            dungeon.DrawObject(10, 3, '╚');
            dungeon.DrawObject(10, 5, '╔');
            dungeon.DrawObject(13, 9, '╝');
            dungeon.DrawObject(15, 9, '╚');
            dungeon.DrawObject(13, 5, '╗');
            dungeon.DrawObject(15, 3, '╗');
            dungeon.DrawWallHorizontal(10, 4, 5, ConsoleColor.Yellow, '*');
            dungeon.DrawObject(11, 4, ' ');
            dungeon.DrawObject(13, 4, ' ');
            dungeon.DrawWallVertical(14, 9, -5, ConsoleColor.Yellow, '*');
            

            // Draw the dungeon - second room
            Console.ForegroundColor = roomName;
            Console.CursorLeft = 1;
            Console.CursorTop = 10;
            Console.Write("first room");

                // Walls
            dungeon.DrawWallHorizontal(12, 9, -12);
            dungeon.DrawWallHorizontal(16, 9, 12);
            dungeon.DrawWallVertical(0, 10, 6);
            dungeon.DrawWallVertical(28, 10, 6);
            dungeon.DrawWallHorizontal(1, 16, 27);
                // Corners and objects
            dungeon.DrawObject(0, 9, '╔');
            dungeon.DrawObject(28, 9, '╗');
            dungeon.DrawObject(0, 16, '╚');
            dungeon.DrawObject(28, 16, '╝');
            dungeon.DrawObject(13, 14, 'P', ConsoleColor.DarkCyan);
            dungeon.DrawObject(12, 15, 'M', ConsoleColor.Red);
            dungeon.DrawObject(10, 12, 'M', ConsoleColor.Red);
            dungeon.DrawObject(14, 12, 'M', ConsoleColor.Red);
            dungeon.DrawObject(16, 14, 'M', ConsoleColor.Red);

            // Draw the dungeon - second hallway
                // Walls
            dungeon.DrawWallVertical(25, 17, 4);
            dungeon.DrawWallVertical(27, 17, 2);
            dungeon.DrawWallHorizontal(26, 21, 7);
            dungeon.DrawWallHorizontal(28, 19, 5);
            

                // Corners and objects
            dungeon.DrawWallVertical(26, 16, 5, ConsoleColor.Yellow, '*');
            dungeon.DrawWallHorizontal(28, 20, 5, ConsoleColor.Yellow, '*');
            dungeon.DrawObject(27, 16, '╔');
            dungeon.DrawObject(25, 16, '╗');
            dungeon.DrawObject(27, 19, '╚');
            dungeon.DrawObject(25, 21, '╚');
            dungeon.DrawObject(29, 20, ' ');
            dungeon.DrawObject(31, 20, ' ');
            dungeon.DrawObject(33, 19, '╝');
            dungeon.DrawObject(33, 21, '╗');

            // Draw the dungeon - third room (treasure room)
            Console.ForegroundColor = roomName;
            Console.CursorLeft = 34;
            Console.CursorTop = 16;
            Console.Write("treasure");

                // Walls
            dungeon.DrawWallVertical(33, 18, -3);
            dungeon.DrawWallVertical(33, 22, 3);
            dungeon.DrawWallHorizontal(34, 15, 8);
            dungeon.DrawWallHorizontal(34, 25, 8);
            dungeon.DrawWallVertical(42, 16, 9);
            dungeon.DrawWallVertical(42, 19, 3, ConsoleColor.Blue);

                // Corners and objects
            dungeon.DrawObject(33, 15, '╔');
            dungeon.DrawObject(33, 25, '╚');
            dungeon.DrawObject(42, 15, '╗');
            dungeon.DrawObject(42, 25, '╝');
            dungeon.DrawWallVertical(34, 17, 8, ConsoleColor.Yellow, '*');
            dungeon.DrawWallVertical(36, 17, 8, ConsoleColor.Yellow, '*');
            dungeon.DrawWallVertical(38, 17, 8, ConsoleColor.Yellow, '*');
            dungeon.DrawWallVertical(40, 17, 8, ConsoleColor.Yellow, '*');

            // Keep the window open
            Console.ResetColor();
            Console.CursorLeft = 0;
            Console.CursorTop = dungeon.Height;
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
