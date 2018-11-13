using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class DistributionCenter : Storage
    {
        private const int DistributionCenterCapacity = 2;
        private const int DistributionCenterGarageSlots = 5;

        private static Vehicle[] DefaultVehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name) 
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlots, DefaultVehicles) { }
    }
}