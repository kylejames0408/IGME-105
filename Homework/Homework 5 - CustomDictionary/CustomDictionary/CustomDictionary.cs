using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionary
{
    class CustomDictionary<K, V>
    {
        // Fields
        private CustomPair<K, V>[] data;
        private int count;
        
        // Hash Function
        /// <summary>
        /// Generates the hash code for a given key.
        /// </summary>
        /// <param name="key">The key that represents the data.</param>
        /// <returns>The hash code that represents the key input.</returns>
        private int HashFunction(K key)
        {
            // Get the original hash code
            int hashCode = key.GetHashCode();

            // If hash code is invalid, fix it
            while (hashCode < 0 || hashCode >= data.Length)
            {
                if (hashCode < 0)
                {
                    hashCode *= -1;
                }
                else
                {
                    hashCode %= data.Length;
                }
            }

            // Check the valid hash code against the array
            if (data[hashCode] == null || data[hashCode].Key.Equals(key))
            {
                return hashCode;
            }
            else
            {
                bool invalidHash = true;

                // Iterate through data to see if the hash code is already in use
                int count = 0;
                while (invalidHash)
                {
                    if (hashCode < data.Length - 1)
                    {
                        hashCode++;
                        if (data[hashCode] != null || data[hashCode].Key.Equals(key))
                        {
                            invalidHash = false;
                        }
                    }
                    else
                    {
                        hashCode = 0;
                        if (data[hashCode] != null || data[hashCode].Key.Equals(key))
                        {
                            invalidHash = false;
                        }
                    }

                    // Throw an error if it iterates through the whole dictionary
                    //  without finding a position for the key
                    count++;
                    if (count >= data.Length)
                    {
                        throw new IndexOutOfRangeException("Error: There is no existing hash code for the key, or there is no room for it.");
                    }
                }

                return hashCode;
            }
        }

        // Properties
        /// <summary>
        /// Get the current count of actual data in the dictionary.
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Indexer which will allow you to get or set individual values in the dictionary.
        /// </summary>
        /// <param name="key">The key of the value you want to get or set.</param>
        /// <returns>The value stored at the key if there is one.</returns>
        public V this[K key]
        {
            get
            {
                if (data[HashFunction(key)] != null && data[HashFunction(key)].Key.Equals(key))
                {
                    return data[HashFunction(key)].Value;
                }
                else
                {
                    throw new KeyNotFoundException("That key does not exist.");
                }
            }
            set
            {
                if (data[HashFunction(key)] == null)
                {
                    data[HashFunction(key)] = new CustomPair<K, V>(key, value);
                    count++;
                }
                else if (data[HashFunction(key)].Key.Equals(key))
                {
                    data[HashFunction(key)] = new CustomPair<K, V>(key, value);
                }
            }
        }

        // Constructors
        /// <summary>
        /// Creates a custom dictionary.
        /// </summary>
        public CustomDictionary() : this(100)
        {
        }

        /// <summary>
        /// Creates a custom dictionary.
        /// </summary>
        /// <param name="arraySize">The size of the array.</param>
        public CustomDictionary(int arraySize)
        {
            data = new CustomPair<K, V>[arraySize];
        }

        // Methods
        /// <summary>
        /// Determine if the specified key exists in the data array.
        /// </summary>
        /// <param name="key">The key to access the data in the array.</param>
        /// <returns>Whether or not the array contains the key.</returns>
        public bool ContainsKey(K key)
        {
            if (data[HashFunction(key)] != null && data[HashFunction(key)].Key.Equals(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the specified key and value to the array unless it collides with another key.
        /// </summary>
        /// <param name="key">The key to access the data in the array.</param>
        /// <param name="value">The value to add to the array.</param>
        public void Add(K key, V value)
        {
            if (data[HashFunction(key)] != null && data[HashFunction(key)].Key.Equals(key))
            {
                throw new ArgumentException("That key already exists.");
            }
            else
            {
                data[HashFunction(key)] = new CustomPair<K, V>(key, value);
                count++;
            }
        }

        /// <summary>
        /// The data to remove using the key access
        /// </summary>
        /// <param name="key">The key to access the data in the array.</param>
        /// <returns>The removed data.</returns>
        public bool Remove(K key)
        {
            if (data[HashFunction(key)] != null && data[HashFunction(key)].Key.Equals(key))
            {
                data[HashFunction(key)] = null;
                count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Replace all values with null and set count to zero.
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = null;
            }
            count = 0;
        }
    }
}