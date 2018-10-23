using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);

                var person = new Person(firstName, lastName, age, salary);

                people.Add(person);
            }

            var bonus = decimal.Parse(Console.ReadLine());
            people.ForEach(p => p.IncreaseSalary(bonus));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
