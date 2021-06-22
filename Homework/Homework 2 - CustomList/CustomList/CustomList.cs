/*
 * The purpose of the CustomList is to construct our own list class for the user to use (generic).
 * 
 * Author: Kyle James
 * Version: 9/29/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    /// <summary>
    /// A list of objects that can be accessed by index and provides methods to search, sort, and manipulate lists.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    class CustomList <T>
    {
        // Fields
        private int count;
        private T[] list;

        // Properties
        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Gets the total number of elements that the list can hold.
        /// </summary>
        public int Capacity { get { return list.Length; } }
        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Initializes a new instance of the CustomList class that is empty and the default initial capacity.
        /// </summary>
        public CustomList() : this(4)
        {
        }
        /// <summary>
        /// Initializes a new instance of the CustomList class that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name="initialSize">The number of elements that the new list can initially store.</param>
        public CustomList(int initialSize)
        {
            count = 0;
            list = new T[initialSize];
        }

        // Methods
        /// <summary>
        /// Adds an object to the end of the CustomList
        /// </summary>
        /// <param name="item">The object to be added to the end of the CustomList.</param>
        public void Add(T item)
        {
            if (count < Capacity)
            {
                list[count] = item;
                count++;
            }
            else
            {
                // Create temporary list to store items for transfer and increase list size
                T[] transferList = new T[Capacity * 2];

                // Copy contents to the transfer
                for (int i = 0; i < Capacity; i++)
                {
                    transferList[i] = list[i];
                }

                // Write the list to refer to the new array
                list = transferList;

                // Place the new item in the count and increment count
                list[count] = item;
                count++;
            }
        }
        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first occurence in the CustomList.
        /// </summary>
        /// <param name="item">The object to locate in the CustomList.</param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            // Iterate through list and see if the item is in it and return it's index
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Determines whether an element is in the CustomList.
        /// </summary>
        /// <param name="item">The object to locate in the CustomList.</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            // Iterate through list and see if the item is in it and return if it's there
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Removes the element at the specified index of the CustomList.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        public void RemoveAt(int index)
        {
            // Don't do anything if the index is out of bounds
            if (index < 0 || index >= count)
            {
                return;
            }

            // Create transfer list and separate count
            int separateCount = 0;
            T[] transferList = new T[Capacity];

            // Fill transfer list
            for (int i = 0; i < index; i++)
            {
                transferList[separateCount] = list[i];
                separateCount++;
            }
            for (int i = index + 1; i < count; i++)
            {
                transferList[separateCount] = list[i];
                separateCount++;
            }

            // Set list to refer to new transfer list and subtract count
            list = transferList;
            count--;
        }
        /// <summary>
        /// Remove the first occurrence of a specific object from the CustomList.
        /// </summary>
        /// <param name="item">The object to remove from the CustomList.</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            // If the list contains the item, remove it
            if (Contains(item))
            {
                RemoveAt(IndexOf(item));
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Inserts an element into the CustomList at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        public void Insert(int index, T item)
        {
            if (index < 0)
            {
                return;
            }

            // Set up transfer list & separate count
            int separateCount = 0;
            T[] transferList;

            if (count >= Capacity - 1)
            {
                transferList = new T[Capacity * 2];
            }
            else
            {
                transferList = new T[Capacity];
            }

            // Copy list to transfer list and add new item
            for (int i = 0; i < index; i++)
            {
                transferList[separateCount] = list[i];
                separateCount++;
            }

            transferList[separateCount] = item;
            separateCount++;
            count++;

            for (int i = index; i < count; i++)
            {
                transferList[separateCount] = list[i];
                separateCount++;
            }

            // Reassign list to the edited list
            list = transferList;
        }
        /// <summary>
        /// Removes all elements from the CustomList.
        /// </summary>
        public void Clear()
        {
            list = new T[Capacity];
            count = 0;
        }
        /// <summary>
        /// Prints the list
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("   " + list[i]);
            }
        }
    }
}
