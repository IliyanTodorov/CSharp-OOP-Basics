using System.Collections.Generic;
using System.Linq;

namespace CarsSalesman
{
    using System;

    public class Program
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                var engineSpec = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                engines.Add(GetEngine(engineSpec));
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                cars.Add(GetCar(token, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static Car GetCar(string[] token, List<Engine> engines)
        {
            string model = token[0];
            string engineModel = token[1];
            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);
            int weight = -1;

            if (token.Length == 3)
            {
                if (int.TryParse(token[2], out weight))
                {
                    return new Car(model, engine, weight);
                }
                return new Car(model, engine, token[2]);
            }
            else if (token.Length == 4)
            {
                return new Car(model, engine, int.Parse(token[2]), token[3]);
            }
            return new Car(model, engine);
        }

        private static Engine GetEngine(string[] tokens)
        {
            var model = tokens[0];
            var power = int.Parse(tokens[1]);
            var displacement = -1;

            if (tokens.Length == 3)
            {
                if (int.TryParse(tokens[2], out displacement))
                {
                    return new Engine(model, power, displacement);
                }
                return new Engine(model, power, tokens[2]);
            }
            else if (tokens.Length == 4)
            {
                return new Engine(model, power, int.Parse(tokens[2]), tokens[3]);
            }
            return new Engine(model, power);
        }
    }
}
