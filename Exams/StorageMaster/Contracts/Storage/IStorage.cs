using StorageMaster.Models.Products;
using StorageMaster.Models.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Contracts.Storage
{
    public interface IStorage
    {
        string Name { get; }

        int Capacity { get; }

        int GarageSlots { get; }

        bool IsFull { get; }

        IReadOnlyCollection<Vehicle> Garage { get; }

        IReadOnlyCollection<Product> Products { get; }

        Vehicle GetVehicle(int garageSlot);

        int SendVehicleTo(int garageSlot, Models.Storage.Storage deliveryLocation);

        int UnloadVehicle(int garageSlot);
    }
}