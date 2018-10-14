using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRep
{
    interface QueueInterface<T>
    {
        T push(T element);

        T pop() /*throw QueueuUnderflowException()*/;

        Boolean isEmpty();
    }
}