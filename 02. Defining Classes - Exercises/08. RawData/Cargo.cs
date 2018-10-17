using System;
using System.Collections.Generic;
using System.Text;

namespace _08._RawData
{
    class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public int CargoWeight
        {
            get { return cargoWeight; }
            set { this.cargoWeight = value; }
        }

        public string CargoType
        {
            get { return cargoType; }
            set { this.cargoType = value; }
        }
    }
}
