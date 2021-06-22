using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStacksAndQueues
{
    interface IQueue<T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Enqueue(T s);
        T Dequeue();
        T Peek();
    }
}
