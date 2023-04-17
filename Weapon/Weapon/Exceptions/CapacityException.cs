using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Exceptions
{
    internal class CapacityException : Exception
    {
        public CapacityException() :base("Capacity is Full")
        {
            
        }
    }
}
