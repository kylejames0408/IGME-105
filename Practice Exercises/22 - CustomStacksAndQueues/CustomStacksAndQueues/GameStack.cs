using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStacksAndQueues
{
    class GameStack<T> : IStack<T>
    {
        // Fields
        List<T> stack;

        // Properties
        public bool IsEmpty
        {
            get
            {
                if (stack.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int Count { get { return stack.Count; } }

        // Constructors
        public GameStack(int stackSize = 4)
        {
            stack = new List<T>(stackSize);
        }

        // Methods
        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                T removedItem = stack[Count - 1];
                stack.RemoveAt(Count - 1);
                return removedItem;
            }
            else
            {
                throw new IndexOutOfRangeException("Error: Stack does not contain any data to pop off.");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return stack[Count - 1];
            }
            else
            {
                throw new IndexOutOfRangeException("Error: Stack does not contain any data to view.");
            }
        }
    }
}
