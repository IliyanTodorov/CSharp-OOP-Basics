using System.Collections.Generic;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int CAPACITY = 1;
        private const int GARAGE_SLOTS = 2;

        public AutomatedWarehouse(string name) : base(name, CAPACITY, GARAGE_SLOTS, new List<Vehicle>() { new Truck() })
        {
        }
    }
}