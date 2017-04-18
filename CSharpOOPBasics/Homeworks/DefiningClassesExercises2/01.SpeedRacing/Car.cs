using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SpeedRacing
{
    class Car
    {

        public Car(string model, decimal fuelAmount, decimal fuelCostPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelCostPerKm = fuelCostPerKm;
        }


        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelCostPerKm { get; set; }
        public decimal DistanceTravelled { get; set; }

        public bool Move(decimal distance)
        {
            decimal fuelNeeded = distance*this.FuelCostPerKm;

            if (fuelNeeded <= this.FuelAmount)
            {
                this.FuelAmount -= fuelNeeded;

                this.DistanceTravelled += distance;

                return true;
            }

            return false;
        }
    }
}
