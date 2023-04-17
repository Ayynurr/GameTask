using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Exceptions
{
    internal class BulletEmptyException : Exception
    {
        public BulletEmptyException() : base("Bullet is Empty!")
        {
            
        }
    }
}
