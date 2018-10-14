using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRep
{
    class QueueUnderflowException : SystemException
    {
        public QueueUnderflowException():base()
        {}

        public QueueUnderflowException(string message) : base(message)
        {}
    }
}
