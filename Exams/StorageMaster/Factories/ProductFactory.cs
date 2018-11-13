﻿namespace StorageMaster.Factories
{
    using Entities.Products;
    using System;

    public class ProductFactory
    {
        public Product CreateProduct(string type, double price)
        {
            Product product = null;
            switch (type)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default: throw new InvalidOperationException("Invalid product type!");
            }

            return product;
        }
    }
}