using System;
using StorageMaster.Contracts.Products;

namespace StorageMaster.Models.Products
{
    public abstract class Product : IProduct
    {
        private double price;
        private double weight;

        public Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get { return price; }
            protected set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }

                price = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

    }
}