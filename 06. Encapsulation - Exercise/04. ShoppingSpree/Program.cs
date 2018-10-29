using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                string[] personData = peopleInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personData[0];
                double money = double.Parse(personData[1]);

                try
                {
                    Person person = new Person(name, money);

                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }

            string[] productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < productsInput.Length; i++)
            {
                string[] productData = productsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string name = productData[0];
                double cost = double.Parse(productData[1]);

                try
                {
                    Product product = new Product(name, cost);

                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] token = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string person = token[0];
                string productName = token[1];

                Product product = products.First(p => p.Name == productName);

                people.First(p => p.Name == person).Add(product);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
