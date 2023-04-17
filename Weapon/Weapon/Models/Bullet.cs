using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Enum;

namespace Task.Models
{
    internal class Bullet
    {
        private static int _id;
        public int Id { get; }
        
        public BulletType BulletType { get; }  

        public Bullet(BulletType bullettype)
        {
            BulletType = bullettype;    
            Id = ++_id;
        }

        
    }
}
