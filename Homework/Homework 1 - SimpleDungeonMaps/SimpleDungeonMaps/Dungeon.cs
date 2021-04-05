/*
 * The purpose of this is to create a simple dungeon like object for drawing dungeons
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
    class Dungeon
    {
        // Fields
        private int height;
        private int width;

        // Constructors
        public Dungeon(int width, int height, string name)
        {
            // Assign values to fields
            if (width > 100)
            {
                width = 100;
            }

            if (height > 52)
            {
                height = 52;
            }

            this.width = width;
            this.height = height;

            // Apply variables to console
            Console.WindowWidth = width;
            Console.WindowHeight = height;
            Console.Title = name;
        }

        // Methods
        public void DrawWallVertical(int x, int y, int length, ConsoleColor color = ConsoleColor.Gray, char symbol = '║')
        {
            // Check window integrity
            if (x > width || y > height || length == 0)
            {
                return;
            }

            Console.ForegroundColor = color;

            // Check if length is negative or positive and perform printing based on result
            if (length > 0)
            {
                for (int i = y; i < length + y; i++)
                {
                    if (i > height)
                    {
                        return;
                    }
                    Console.CursorLeft = x;
                    Console.CursorTop = i;
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                for (int i = y; i > y + length; i--)
                {
                    if (i < 0)
                    {
                        return;
                    }
                    Console.CursorLeft = x;
                    Console.CursorTop = i;
                    Console.WriteLine(symbol);
                }
            }
        }
        
        public void DrawWallHorizontal(int x, int y, int length, ConsoleColor color = ConsoleColor.Gray, char symbol = '═')
        {
            // Check window integrity
            if (x > width || y > height || length == 0)
            {
                return;
            }

            Console.ForegroundColor = color;

            // Check if length is negative or positive and perform printing based on result
            if (length > 0)
            {
                for (int i = x; i < length + x; i++)
                {
                    if (i > width)
                    {
                        return;
                    }
                    Console.CursorLeft = i;
                    Console.CursorTop = y;
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                for (int i = x; i > x + length; i--)
                {
                    if (i < 0)
                    {
                        return;
                    }
                    Console.CursorLeft = i;
                    Console.CursorTop = y;
                    Console.WriteLine(symbol);
                }
            }
        }

        public void DrawObject(int x, int y, char symbol, ConsoleColor color = ConsoleColor.Gray)
        {
            // Check window integrity
            if (x > width || y > height || x < 0 || y < 0)
            {
                return;
            }

            Console.ForegroundColor = color;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.WriteLine(symbol);
        }

        // Properties (getters)
        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }
    }
}