namespace DefiningClasses
{
    using People;
    using System;

    public class StartUp
    {
        static void Main()
        {
            People people = new People();

            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personDetails = Console.ReadLine().Split();

                Person person = new Person(personDetails[0], Int32.Parse(personDetails[1]));

                people.AddPerson(person);
            }

            var forPrint = people.GetPeopleMoreThan30YearsOld();

            foreach (var person in forPrint)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
