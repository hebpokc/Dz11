using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 13.1, 13.2");
            Console.WriteLine("Программа реализует класс банковский аккаунт. Добавлены свойства и индексатор");

            BankAccount ba = new BankAccount("Владимир", 100000, BankAccountType.current);
            ba.AddBalance(1000);

            Console.WriteLine("\nТранзакции:");
            for (int i = 0; i < ba.Transactions.Count; i++)
            {
                Console.WriteLine(ba[i]);
            }

            Console.WriteLine("\nДом. задание 13.1, 13.2");
            Console.WriteLine("Программа реализует класс здание и класс для нескольких зданий. Добавлены свойства и индексатор");

            Building b1 = new Building(300, 7, 24, 2);
            Building b2 = new Building(500, 10, 50, 3);
            Building b3 = new Building(250, 5, 15, 1);
            Building b4 = new Building(300, 7, 24, 2);
            Building b5 = new Building(500, 10, 50, 3);
            Building b6 = new Building(300, 7, 24, 2);
            Building b7 = new Building(500, 10, 50, 3);
            Building b8 = new Building(250, 5, 15, 1);
            Building b9 = new Building(300, 7, 24, 2);
            Building b10 = new Building(500, 10, 50, 3);

            BuildingCollection bc = new BuildingCollection();
            bc.Add(b1);
            bc.Add(b2);
            bc.Add(b3);
            bc.Add(b4);
            bc.Add(b5);
            bc.Add(b6);
            bc.Add(b7);
            bc.Add(b8);
            bc.Add(b9);
            bc.Add(b10);

            for (int i = 0; i < bc.Buildings.Length; i++)
            {
                Console.WriteLine(bc[i]);
            }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
