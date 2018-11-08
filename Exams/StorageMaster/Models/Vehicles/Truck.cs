﻿namespace StorageMaster.Models.Vehicles
{
    public class Truck : Vehicle
    {
        private const int CAPACITY = 5;

        public Truck(int capacity) : base(CAPACITY)
        {
        }
    }
}