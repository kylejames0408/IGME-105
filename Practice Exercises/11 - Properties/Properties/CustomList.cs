/*
 * The purpose of the CustomList is to construct our own list class for the user to use (generic).
 * 
 * Author: Kyle James
 * Version: 9/25/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class CustomList <T>
    {
        // Fields
        ConsoleColor error = ConsoleColor.DarkRed;
        int count;
        T[] list;

        // Properties
        public int Count { get { return count; } }
        public int Capacity { get { return list.Length; } }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return list[index];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    list[index] = value;
                }
            }
        }

        // Constructors
        public CustomList() : this(4)
        {
        }
        public CustomList(int listSize)
        {
            list = new T[listSize];
            count = 0;
        }

        // Methods
        public void Add(T item)
        {
            if (count < Capacity)
            {
                list[count] = item;
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
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("   "+ list[i]);
            }
        }
    }
}
