using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            protected set
            {
                fuelConsumption = value;
            }
        }

        public string Drive(double distance)
        {
            var consumption = this.FuelConsumption;
            var msg = $"{this.GetType().Name} needs refueling";

            if (distance * consumption <= this.FuelQuantity)
            {
                msg = $"{this.GetType().Name} travelled {distance} km";
                this.FuelQuantity -= distance * consumption;
            }
            return msg;
        }

        public virtual void Refuel(double fuelAmount)
        {
            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}