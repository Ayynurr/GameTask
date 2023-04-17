using Task.Enum;
using Task.Exceptions;
using Task.Models;

List<Weapon> weapons = new List<Weapon>();

while(true)
{
    Console.WriteLine("1.Create Weapon");
    Console.WriteLine("2.Remove Weapon");
    Console.WriteLine("3.Get Weapon By Capacity");
    Console.WriteLine("4.Get Weapons ");
    Console.WriteLine("5.Select Weapon ");
    Console.Write("\nSelect number:  ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("\n--------");
    int capacity = 0;
    switch (n)
    {

        case 1:
            Console.WriteLine("enter id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            string Name = Console.ReadLine().Trim();
            Console.WriteLine("Enter Capacity");
            capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Bullet type: Tekli,Ikili,Hamsi ");
            BulletType bulletType = (BulletType)Enum.Parse(typeof(BulletType), Console.ReadLine(), true);

            Weapon weapon = new Weapon(Name, capacity, (BulletType)bulletType);
            weapons.Add(weapon);
            Console.WriteLine($"Weapon {id} created.");
            break;

        case 2:
            Console.WriteLine("Enter weapon id:");
            int idToRemove = int.Parse(Console.ReadLine());

            Weapon weaponToRemove = weapons.Find(w => w.Id == idToRemove);
            if (weaponToRemove != null)
            {
                weapons.Remove(weaponToRemove);
                Console.WriteLine($"Removed weapon {idToRemove}...");
            }
            else
            {
                Console.WriteLine($"Weapon {idToRemove} not found...");
            }
            break;
        case 3:


            List<Weapon> Weapons = weapons.FindAll(w => w.Capacity > 40);

            foreach (Weapon item in Weapons)
            {
                Console.WriteLine($"{item.Id}: {item.Name} ({item.Capacity}, {item.BulletType})");
            }
            break;
        case 4:
            foreach (Weapon weapon1 in weapons)
            {
                Console.WriteLine($"{weapon1.Id}: {weapon1.Name} ({weapon1.Capacity}, {weapon1.BulletType})");
            }
            break;
        //case 5:
        //    Console.WriteLine("Enter the weapon ID:");
        //    int idd = int.Parse(Console.ReadLine());

        //    Weapon selectedWeapon = weapons.Find(w => w.Id == idd);

        //    if (selectedWeapon == null)
        //    {
        //        Console.WriteLine("Weapon not found.");
        //        return;
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine("Enter a command (1: Fire, 2: PullTrigger, 3: Fill):");
        //        string command = Console.ReadLine();
        //        switch (command)
        //        {
        //            case "1":
        //                break;
        //        }

        //    }
        //    break;
        //default:
        //    Console.WriteLine("invalid command");
        //    break;
        default:
            Console.WriteLine("invalid choice!,Please try again...");
            break;
    } 
}





