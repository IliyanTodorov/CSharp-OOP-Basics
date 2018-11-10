using StorageMaster.Factory;
using StorageMaster.Models.Products;
using StorageMaster.Models.Storage;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster
{
    public class StorageMaster
    {
        private ICollection<Product> productPool;
        private ICollection<Storage> storageRegistry;
        private Vehicle selectedVehicle;

        public StorageMaster()
        {
            this.productPool = new List<Product>();
            this.storageRegistry = new List<Storage>();
            this.selectedVehicle = null;
        }

        public string AddProduct(string type, double price)
        {
            ProductFactory factory = new ProductFactory();
            var product = factory.CreateProduct(type, price);

            this.productPool.Add(product);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            StorageFactory factory = new StorageFactory();
            var storage = factory.CreateStorage(type, name);

            this.storageRegistry.Add(storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            return "";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            return "";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage startStore = this.storageRegistry.FirstOrDefault(x => x.Name == sourceName);
            Storage targetStore = this.storageRegistry.FirstOrDefault(x => x.Name == destinationName);
            ExeptionTracker.DoesSourceExists(startStore);
            ExeptionTracker.DoesDestinationExists(targetStore);

            var vehicle = startStore.GetVehicle(sourceGarageSlot);
            var slot = startStore.SendVehicleTo(sourceGarageSlot, targetStore);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {slot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }

        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
