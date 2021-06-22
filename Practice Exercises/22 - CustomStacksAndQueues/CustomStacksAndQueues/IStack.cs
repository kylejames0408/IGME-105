using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStacksAndQueues
{
    interface IStack <T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(T s);
        T Pop();
        T Peek();
    }
}
