using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> allCars = new List<Car>();

            int n = Int32.Parse(Console.ReadLine());

            // “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = Int32.Parse(input[1]);
                int enginePower = Int32.Parse(input[2]);
                int cargoWeight = Int32.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tires = GetTires(input);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car currentCar = new Car(model, engine, cargo, tires);
                allCars.Add(currentCar);
            }

            PrintCars(allCars);
        }

        private static void PrintCars(List<Car> allCars)
        {
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in allCars.Where(x => x.Cargo.CargoType == "fragile"))
                {
                    foreach (var tire in car.Tire)
                    {
                        if (tire.TirePressure < 1)
                        {
                            Console.WriteLine(car.Model);
                        }
                        break;
                    }
                }
            }
            else
            {
                foreach (var car in allCars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        private static List<Tire> GetTires(string[] input)
        {
            List<Tire> tires = new List<Tire>();

            for (int i = 5; i < input.Length; i += 2)
            {
                var pressure = double.Parse(input[i]);
                var age = int.Parse(input[i + 1]);
                tires.Add(new Tire(pressure, age));
            }
            return tires;
        }
    }
}
