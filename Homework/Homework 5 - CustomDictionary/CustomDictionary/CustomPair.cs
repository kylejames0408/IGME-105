using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionary
{
    class CustomPair<K, V>
    {
        // Fields
        private K key;
        private V value;

        // Properties
        /// <summary>
        /// Gets and sets the key that represents the data stored.
        /// </summary>
        public K Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        /// <summary>
        /// Gets and sets the value that the dictionary stores.
        /// </summary>
        public V Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        // Constructors
        public CustomPair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
