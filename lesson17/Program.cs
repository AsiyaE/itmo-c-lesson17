using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> person1 = new BankAccount<int> ();

            BankAccount<string> person2 = new BankAccount<string>();
            person1.Input();
            person2.Input();

            Console.WriteLine($"Аккаунт1: {person1.GetInfo()}");
            Console.WriteLine($"Аккаунт2: {person2.GetInfo()}");
            Console.ReadKey();
        }
    }
}
