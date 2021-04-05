/*
 * The purpose of the CustomList is to construct our own list class for the user to use
 * 
 * Author: Kyle James
 * Version: 9/23/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class CustomList
    {
        // Fields
        ConsoleColor error = ConsoleColor.DarkRed;
        int count;
        string[] list;

        // Properties
        public int Count { get { return count; } }
        public int Capacity { get { return list.Length; } }

        // Constructors
        public CustomList()
        {
            list = new string[4];
            count = 0;
        }
        public CustomList(int listSize)
        {
            list = new string[listSize];
            count = 0;
            Console.WriteLine($"List with a size of {listSize} has been created.\n");
        }

        // Methods
        public void Add(string item)
        {
            if (count < list.Length)
            {
                list[count] = item;
                Console.WriteLine($"{item} has been added to the list.\n");
                count++;
            }
            else
            {
                Console.ForegroundColor = error;
                Console.WriteLine("The list is full.\n");
                Console.ResetColor();
            }
        }
        public void Print()
        {
            foreach (string val in list)
            {
                if (val != null)
                {
                    Console.WriteLine("  " + val);
                }
            }
        }
    }
}
