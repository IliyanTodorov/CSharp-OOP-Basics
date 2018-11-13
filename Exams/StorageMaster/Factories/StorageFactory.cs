namespace StorageMaster.Factories
{
    using System;
    using Entities.Storage;

    public class StorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            Storage storage = null;
            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default: throw new InvalidOperationException("Invalid storage type!");
            }

            return storage;
        }
    }
}