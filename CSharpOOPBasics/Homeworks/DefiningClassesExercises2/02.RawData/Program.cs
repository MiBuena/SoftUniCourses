using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.RawData
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
                List<string> inputParameters = Console.ReadLine().Split(' ').ToList();

                string model = inputParameters[0];
                int engineSpeed = int.Parse(inputParameters[1]);
                int enginePower = int.Parse(inputParameters[2]);
                int cargoWeight = int.Parse(inputParameters[3]);
                string cargoType = inputParameters[4];
                double pressureTyre1 = double.Parse(inputParameters[5]);
                int ageTyre1 = int.Parse(inputParameters[6]);
                double pressureTyre2 = double.Parse(inputParameters[7]);
                int ageTyre2 = int.Parse(inputParameters[8]);
                double pressureTyre3 = double.Parse(inputParameters[9]);
                int ageTyre3 = int.Parse(inputParameters[10]);
                double pressureTyre4 = double.Parse(inputParameters[11]);
                int ageTyre4 = int.Parse(inputParameters[12]);

                Car newCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, pressureTyre1, ageTyre1, pressureTyre2, ageTyre2, pressureTyre3, ageTyre3, pressureTyre4, ageTyre4);

                carCollection.Add(newCar);
            }

            string command = Console.ReadLine();

            IEnumerable<Car> c = new List<Car>();

            if (command == "fragile")
            {
                c = carCollection.Where(x => x.Cargo.CargoType == command && x.Tyres.Any(y => y.Pressure < 1));
            }

            if (command == "flamable")
            {
               c = carCollection.Where(x => x.Cargo.CargoType == command && x.Engine.EnginePower>250);
            }

            foreach (var element in c)
            {
                Console.WriteLine(element.Model);
            }
        }
    }
}
