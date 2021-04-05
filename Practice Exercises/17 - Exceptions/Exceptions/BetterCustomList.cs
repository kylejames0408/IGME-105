using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class BetterCustomList<T>
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
                    throw new IndexOutOfRangeException();
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

        // Constructor
        /// <summary>
        /// Initializes a new instance of the CustomList class that is empty and the default initial capacity.
        /// </summary>
        public BetterCustomList() : this(4)
        {
        }
        /// <summary>
        /// Initializes a new instance of the CustomList class that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name="initialSize">The number of elements that the new list can initially store.</param>
        public BetterCustomList(int initialSize)
        {
            if (initialSize < 0)
            {
                throw new ArgumentException("Non-negative number required.\nParameter name: capacity");
            }
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
    }
}
