using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1");
            Console.WriteLine("В класс BankAccount добавлен DumpToScreen. Использование условного атрибута, зависящего от символа условной компиляции");

            BankAccount ba2 = new BankAccount("Оксана", 15000, BankAccountType.savings);
            ba2.DumpToScreen();

            Console.WriteLine("\nУпражнение 14.2");
            Console.WriteLine("В класс RationalNumber добавлен пользовательский атрибут DeveloperInfoAttribute");

            foreach (Attribute a in typeof(RationalNumber).GetCustomAttributes(false))
            {
                if (a is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute devA = a as DeveloperInfoAttribute;
                    Console.WriteLine($"\nИмя: {devA.DeveloperName}\nДата: {devA.DevelopTime}");
                }
            }

            Console.WriteLine("\nДом. задание 14.1");
            Console.WriteLine("В класс Building добавлен пользовательский атрибут DeveloperInfo2Attribute");

            foreach (Attribute a in typeof(Building).GetCustomAttributes(false))
            {
                if (a is DeveloperInfo2Attribute)
                {
                    DeveloperInfo2Attribute devA2 = a as DeveloperInfo2Attribute;
                    Console.WriteLine($"\nИмя: {devA2.DeveloperName}\nОрганизация: {devA2.DevelopOrganization}");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
