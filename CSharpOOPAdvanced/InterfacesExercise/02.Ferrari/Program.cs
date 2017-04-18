using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();

            Ferrari car = new Ferrari(driversName);

            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/{car.PushGasPedal()}/{car.Driver}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
