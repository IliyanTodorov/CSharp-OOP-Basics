using System;
using System.Collections.Generic;
using System.Linq;
using StorageMaster.Contracts.Vehicles;
using StorageMaster.Models.Products;

namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private int capacity;
        private List<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private bool isFull;

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                if (Trunk.Sum(x => x.Weight) >= Capacity)
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
                
            }
        }

        private bool isEmpty;

        public bool IsEmpty
        {
            get { return isEmpty; }
            set
            {
                if (Trunk.Count == 0)
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }
            }
        }

        public IReadOnlyCollection<Product> Trunk
        {
            get => this.trunk.AsReadOnly();
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product lastElement = trunk.Last();
            trunk.RemoveAt(trunk.Count - 1);

            return lastElement;
        }
    }
}