namespace _07._SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = Double.Parse(carInfo[1]);
                double fuelConsumption = Double.Parse(carInfo[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currentCar);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var drive = input.Split();
                var model = drive[1];
                var amoutOfKm = int.Parse(drive[2]);

                cars.Where(car => car.Model == model).ToList().ForEach(car => car.isFuelEnough(amoutOfKm));
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", cars));
        }
    }
}
