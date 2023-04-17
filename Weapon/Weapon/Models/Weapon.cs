using Task.Enum;
using Task.Exceptions;

namespace Task.Models
{
    internal class Weapon
    {
        public int Capacity { get;}
        public int Id { get; }
        private static int _id;
        private string? type;

        public BulletType BulletType { get; }
        public string Name { get; }
        public Stack<Bullet> Bullets { get; } = new Stack<Bullet>();    

        public Weapon(string name,int capacity, BulletType bullettype)
        {
           
            Id = ++_id;
            Capacity = capacity;
            BulletType = bullettype;
            Name = name;
            
            

        }

        public Weapon(string? type, int capacity, string bullettype)
        {
            this.type = type;
            Capacity = capacity;
        }

        public (int count, Bullet bullet) Fire()
        {
            if (Bullets.TryPop(out Bullet? result))
            {
                return (Bullets.Count, result);
            }
            throw new BulletEmptyException();
        }
        public void PullTrigger()
        {
            if (Bullets.Count == 0)
            {
                throw new Exception("The weapon is empty.");
            }

            Bullet bullet = Bullets.Peek();
            Console.WriteLine($"Next bullet is a {BulletType} bullet.");
        }
        public void Fill()
        {
            if (Capacity == Bullets.Count)
            {
                throw new CapacityException();
            }
            for (int i = Bullets.Count; i < Capacity; i++)
            {
                Bullets.Push(new Bullet(BulletType));
            }
        }
    }
}
