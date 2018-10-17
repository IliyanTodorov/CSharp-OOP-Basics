using System;
using System.Collections.Generic;
using System.Text;

namespace _07._SpeedRacing
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.TraveledDistance = 0;
        }

        public string Model
        {
            get { return model;}
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public double TraveledDistance
        {
            get { return traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public void isFuelEnough(int amountOfKm)
        {
            var wasted = amountOfKm * this.FuelConsumption;
            if (wasted <= this.fuelAmount)
            {
                this.fuelAmount -= wasted;
                this.TraveledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }
}
