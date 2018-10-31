using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IIdentifiable> creatures;

        public Engine()
        {
            this.creatures = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    IIdentifiable robot = new Robot(model, id);
                    this.creatures.Add(robot);
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    IIdentifiable citizen = new Citizen(name, age, id);
                    this.creatures.Add(citizen);
                }
                
                input = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            foreach (var fake in this.creatures.Where(i => i.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(fake.Id);
            }

            this.creatures.RemoveAll(x => x.Id.EndsWith(fakeId));

        }
    }
}
