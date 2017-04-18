using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RawData
{
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
