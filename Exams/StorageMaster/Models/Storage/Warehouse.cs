using System.Collections.Generic;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storage
{
    public class Warehouse : Storage
    {
        private const int CAPACITY = 10;
        private const int GARAGE_SLOTS = 10;

        public Warehouse(string name)
            : base(name, CAPACITY, GARAGE_SLOTS, new List<Vehicle>() { new Semi(), new Semi(), new Semi() })
        {
        }
    }
}