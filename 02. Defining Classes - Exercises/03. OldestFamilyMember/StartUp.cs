namespace DefiningClasses
{
    using Family;
    using System;

    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();

            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split();

                Person member = new Person(person[0], Int32.Parse(person[1]));

                family.AddMember(member);
            }

            Person olderst = family.GetOldestMember();
            Console.WriteLine($"{olderst.Name} {olderst.Age}");
        }
    }
}
