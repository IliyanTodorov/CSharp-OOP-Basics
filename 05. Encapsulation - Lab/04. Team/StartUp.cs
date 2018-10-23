using System;

namespace PersonsInfo
{
    class StartUp
    {
        static void Main()
        {
            Team team = new Team("SoftUni");
           
            int players = int.Parse(Console.ReadLine());

            for (int i = 0; i < players; i++)
            {
                var input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);

                try
                {
                    var person = new Person(firstName, lastName, age, salary);
                    team.AddPlayer(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReverseTeam.Count} players.");
        }
    }
}
