using System;
using System.Collections.Generic;

namespace PersonClass
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount obb = new BankAccount();
            obb.Id = 1230001;
            obb.Balance = 550.02m;
            BankAccount ktb = new BankAccount();
            ktb.Id = 40234134;
            ktb.Balance = 3m;
            List<BankAccount> accounts = new List<BankAccount> { obb, ktb };

            Person stoyan = new Person("Stoyan", 23, accounts);

            Console.WriteLine(stoyan.GetBalance());
        }
    }
}
