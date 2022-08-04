using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя владельца счета");
            string nameOwner = Console.ReadLine();
            Console.WriteLine("Введите числовое значение номере счета");
            int nomerCouterInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счета");
            int balance = Convert.ToInt32(Console.ReadLine());
            Counters<int> counters_1 = new Counters<int>(nomerCouterInt, balance, nameOwner);
            Console.WriteLine(counters_1.GetInfo());

            Console.WriteLine();
            Console.WriteLine("Введите имя владельца счета");
            nameOwner = Console.ReadLine();
            Console.WriteLine("Введите строковое значение номере счета");
            string nomerCouterString = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            balance = Convert.ToInt32(Console.ReadLine());

            Counters<string> counters_2 = new Counters<string>(nomerCouterString, balance, nameOwner);
            Console.WriteLine(counters_2.GetInfo());
            Console.ReadKey();
        }
    }
}
