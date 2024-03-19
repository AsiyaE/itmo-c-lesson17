using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class BankAccount<T>
    {
        T num;
        double balance;
        string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Balance
        {
            get => name;
            set => name = value;
        }

        public string GetInfo()
        {
            return $"{num} {name} {balance}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            this.num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите имя");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            this.balance = Convert.ToDouble(Console.ReadLine());
        }
    }


}
