namespace StorageMaster.Entities.Storage
{
    using Products;
    using Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Storage
    {
        private List<Product> products;
        private Vehicle[] garage;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];

            this.FillGarageWithInitialVehicles(vehicles);
        }

        private void FillGarageWithInitialVehicles(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                garage[index] = vehicle;
                index++;
            }
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            Vehicle vehicle = this.garage[garageSlot];

            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            var deliveryGarageHasFreeSlot = deliveryLocation.Garage.Any(v => v == null);
            if (!deliveryGarageHasFreeSlot)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[garageSlot] = null;

            var addedSlot = deliveryLocation.AddVehicle(vehicle);
            return addedSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = GetVehicle(garageSlot);

            int unloadedProductCount = 0;
            while (!vehicle.IsEmpty && !this.IsFull)
            {
                var crate = vehicle.Unload();
                this.products.Add(crate);

                unloadedProductCount++;
            }

            return unloadedProductCount;
        }

        private int AddVehicle(Vehicle vehicle)
        {
            var freeGarageSlotIndex = Array.IndexOf(this.garage, null);
            this.garage[freeGarageSlotIndex] = vehicle;

            return freeGarageSlotIndex;
        }
    }
}