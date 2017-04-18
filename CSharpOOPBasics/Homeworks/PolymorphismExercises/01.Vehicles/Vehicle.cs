using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double DistanceTravelled { get; set; }
        public double SummerConsumptionFactor { get; protected set; }

        public double TankCapacity  { get; set; }

        public virtual string Refuel(double fuel)
        {
            this.FuelQuantity += fuel;

            return null;
        }

        public string Drive(double distance)
        {
            double neededFuels = distance*(this.FuelConsumption + this.SummerConsumptionFactor);

            if (neededFuels > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= neededFuels;

            this.DistanceTravelled += distance;
            return string.Format($"{this.GetType().Name} travelled {distance} km");
        }

        public override string ToString()
        {
            string message = $"{this.GetType().Name}: {this.DistanceTravelled:F2}";
            return message;
        }
    }
}
