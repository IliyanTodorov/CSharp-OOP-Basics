using System.Collections.Generic;
using StorageMaster.Models.Products;

namespace StorageMaster.Contracts.Vehicles
{
    public interface IVehicle
    {
        int Capacity { get; }

        IReadOnlyCollection<Product> Trunk { get; }

        bool IsFull { get; }

        bool IsEmpty { get; }

        void LoadProduct(Product product);

        Product Unload();
    }
}