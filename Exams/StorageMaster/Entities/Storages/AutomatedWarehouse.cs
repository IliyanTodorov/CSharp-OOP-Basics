using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;

        private static Vehicle[] DefaultVehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name) 
            : base(name, AutomatedWarehouseCapacity, AutomatedWarehouseGarageSlots, DefaultVehicles) { }
    }
}