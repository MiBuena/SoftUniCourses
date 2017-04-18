using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 0; i < 3; i++)
            {
                string[] inputParameters = Console.ReadLine().Split(' ').ToArray();

                var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

                var sbType = assemblyTypes.FirstOrDefault(x => x.Name == inputParameters[0]);

                Vehicle emergencyCenterToAdd = (Vehicle)Activator.CreateInstance(sbType, new object[] { double.Parse(inputParameters[1]), double.Parse(inputParameters[2]), double.Parse(inputParameters[3]) });

                vehicles.Add(emergencyCenterToAdd);
            }

            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string[] commandParameters = Console.ReadLine().Split(' ').ToArray();

                var vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == commandParameters[1]);

                MethodInfo method = vehicle.GetType().GetMethod(commandParameters[0]);

                object[] invokeParams = new object[1];

                invokeParams[0] = double.Parse(commandParameters[2]);

                string message = (string)method.Invoke(vehicle, invokeParams);

                if (message != null)
                {
                    Console.WriteLine(message);
                }
            }


            foreach (var element in vehicles)
            {
                Console.WriteLine($"{element.GetType().Name}: {element.FuelQuantity:F2}");
            }
        }
    }
}
