using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            List<Car> carCollection = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                List<string> carParameters = Console.ReadLine().Split(' ').ToList();

                string model = carParameters[0];
                decimal fuelAmount = decimal.Parse(carParameters[1]);
                decimal fuelCostPerKm = decimal.Parse(carParameters[2]);

                Car newCar = new Car(model, fuelAmount, fuelCostPerKm);

                carCollection.Add(newCar);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandCollection = command.Split(' ');

                string model = commandCollection[1];

                decimal distance = decimal.Parse(commandCollection[2]);

                var carToMove = carCollection.First(x => x.Model == model);

                bool carMoved = carToMove.Move(distance);

                if (!carMoved)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in carCollection)
            {
                Console.WriteLine(string.Format("{0} {1:F2} {2}", car.Model, car.FuelAmount, car.DistanceTravelled));
            }
        }
    }
}
