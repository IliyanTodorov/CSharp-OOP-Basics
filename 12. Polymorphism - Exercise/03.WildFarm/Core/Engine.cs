using System;
using System.Collections.Generic;
using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        public void Run()
        {
            var animals = new List<IAnimal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split();
                var foodTokens = Console.ReadLine().Split();

                IAnimal animal = CreateAnimal(animalTokens);
                IFood food = CreateFood(foodTokens);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food, food.Quantity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                animals.Add(animal);
            }

            animals.ForEach(a => Console.WriteLine(a));

        }

        private IFood CreateFood(string[] tokens)
        {
            var foodType = tokens[0];
            switch (foodType)
            {
                case nameof(Vegetable):
                    return new Vegetable(int.Parse(tokens[1]));
                case nameof(Fruit):
                    return new Fruit(int.Parse(tokens[1]));
                case nameof(Meat):
                    return new Meat(int.Parse(tokens[1]));
                case nameof(Seeds):
                    return new Seeds(int.Parse(tokens[1]));
                default:
                    throw new NotImplementedException("Current Food Type Does Not Exist!");
            }
        }

        private IAnimal CreateAnimal(string[] tokens)
        {
            var animalType = tokens[0];
            switch (animalType)
            {
                case nameof(Cat):
                    return new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case nameof(Tiger):
                    return new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case nameof(Dog):
                    return new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case nameof(Mouse):
                    return new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case nameof(Owl):
                    return new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                case nameof(Hen):
                    return new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                default:
                    throw new NotImplementedException("Current Animal Type Does Not Exist!");
            }
        }
    }
}