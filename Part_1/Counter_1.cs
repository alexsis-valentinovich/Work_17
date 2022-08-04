using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета,
//баланса, ФИО владельца.  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен
//определять тип номера счета. Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
//Создать  несколько экземпляров класса, параметризированного различными типам. Заполнить его поля и вывести
//информацию об экземпляре класса на печать.
namespace Part_1
{
    public class Counters <T>
    {
        public T NomerCouter { get; set; }
        public int Balance { get; set; }
        public string NameOwner { get; set; }

        public Counters (T nomerCouter, int balance, string nameOwner)
        {
            NomerCouter = nomerCouter;
            Balance = balance;
            NameOwner= nameOwner;
        }
        public string GetInfo()
        {
            return $"\nНомер счета: {NomerCouter}\nБаланс: {Balance}\nВладелец счета: {NameOwner}";
        }
    }
}
