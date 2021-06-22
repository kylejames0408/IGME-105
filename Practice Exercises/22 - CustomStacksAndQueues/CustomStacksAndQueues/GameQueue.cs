using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStacksAndQueues
{
    class GameQueue<T> : IQueue<T>
    {
        // Fields
        List<T> queue;

        // Properties
        public bool IsEmpty
        {
            get
            {
                if (queue.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int Count { get { return queue.Count; } }

        // Constructors
        public GameQueue(int queueSize = 4)
        {
            queue = new List<T>(queueSize);
        }

        // Methods
        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        public T Dequeue()
        {
            if (!IsEmpty)
            {
                T removedItem = queue[0];
                queue.RemoveAt(0);
                return removedItem;
            }
            else
            {
                throw new IndexOutOfRangeException("Error: Queue does not contain any data to dequeue.");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return queue[0];
            }
            else
            {
                throw new IndexOutOfRangeException("Error: Queue does not contain any data to view.");
            }
        }
    }
}
