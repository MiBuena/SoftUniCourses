using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    class Bus : OverflowingVehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.SummerConsumptionFactor = 1.4;
        }

        public string DriveEmpty(double distance)
        {
            double neededFuels = distance * (this.FuelConsumption);

            if (neededFuels > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= neededFuels;

            this.DistanceTravelled += distance;
            return string.Format($"{this.GetType().Name} travelled {distance} km");
        }

    }
}
