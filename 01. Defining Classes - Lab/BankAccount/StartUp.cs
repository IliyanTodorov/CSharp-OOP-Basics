namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var clients = new Dictionary<int, BankAccount>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split();

                var currentCommand = token[0];
                int id = int.Parse(token[1]);


                if (currentCommand == "Create")
                {

                    CreateAccount(clients, id);
                }
                else if (currentCommand == "Deposit")
                {
                    if (AccountExist(clients, id))
                    {
                        clients[id].Deposit(decimal.Parse(token[2]));
                    }
                }
                else if (currentCommand == "Withdraw")
                {
                    if (AccountExist(clients, id))
                    {
                        clients[id].Withdraw(decimal.Parse(token[2]));
                    }
                }
                else
                {
                    if (AccountExist(clients, id))
                    {
                        Console.WriteLine($"Account ID{id}, balance {clients[id].Balance:f2}");
                    }
                }
            }

        }

        private static void CreateAccount(Dictionary<int, BankAccount> clients, int id)
        {
            if (clients.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var current = new BankAccount();
                current.Id = id;
                clients.Add(id, current);
            }
        }

        static bool AccountExist(Dictionary<int, BankAccount> accounts, int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return false;
            }
            return true;
        }
    }
}
