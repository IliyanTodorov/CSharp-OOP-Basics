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

                var person = new Person(firstName, lastName, age);

                people.Add(person);
            }

            people
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
