using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<decimal> inputParameters =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToList();

            decimal speed = inputParameters[0];
            decimal fuel = inputParameters[1];

            decimal fuelEconomy = inputParameters[2];

            Car car = new Car(speed, fuel, fuelEconomy);

            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "END")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Travel":
                        Travel(decimal.Parse(command[1]), car);
                        break;
                    case "Distance":
                        Console.WriteLine("Total distance: {0:F1} kilometers", car.TraveledDistance);
                        break;
                    case "Time":
                        List<decimal> time = car.CalculateTime(car.TimeTraveled);
                        Console.WriteLine($"Total time: {time[1]} hours and {time[0]} minutes");
                        break;
                    case "Fuel":
                        Console.WriteLine("Fuel left: {0:F1} liters", car.Fuel);
                        break;
                    case "Refuel":
                        car.Refuel(decimal.Parse(command[1]), car);
                        break;

                }
            }
        }


        private static void Travel(decimal distance, Car car)
        {
            decimal fuelDemand = (distance/100)*car.FuelEconomy;

            if (car.Fuel < fuelDemand)
            {
                decimal possibleDistance = (car.Fuel/(car.FuelEconomy/100));

                car.TraveledDistance += possibleDistance;
                car.Fuel = 0;

                decimal time = possibleDistance/car.Speed;

                car.TimeTraveled += time;
            }
            else
            {
                car.TraveledDistance += distance;
                car.Fuel -= fuelDemand;

                decimal time = distance/car.Speed;

                car.TimeTraveled += time;
            }

        }
    }

    class Car
    {

        public Car(decimal speed, decimal fuel, decimal fuelEconomy)
        {
            this.Speed = speed;
            this.Fuel = fuel;
            this.FuelEconomy = fuelEconomy;
        }

        public decimal Speed { get; set; }

        public decimal Fuel { get; set; }

        public decimal FuelEconomy { get; set; }

        public decimal TraveledDistance { get; set; }

        public decimal TimeTraveled { get; set; }

        public List<decimal> CalculateTime(decimal minutes)
        {
            decimal hours = minutes / 60;
            decimal minutesHour = minutes % 60;

            hours = Math.Floor(hours);

            List<decimal> timeList = new List<decimal>();

            timeList.Add(hours);

            timeList.Add(minutesHour);

            return timeList;
        }


        public void Refuel(decimal fuelToAdd, Car car)
        {
            car.Fuel += fuelToAdd;
        }
    }
}
