using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Something
{
    class Program
    {
        static void Main(string[] args)
        {
            var savings = new Account(0, "Savings", 100m, true);
            var checking = new Account(1, "Checking", 0m, false);
            var alice = new Customer(savings, checking);
            Console.WriteLine(alice);
            alice.Transfer(savings, checking, 25m);
            Console.WriteLine(alice);
            Console.ReadLine();
        }



    }
}
