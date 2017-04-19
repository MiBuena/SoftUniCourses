using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _07.AddressByTownName
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            var addresses = context.Addresses.OrderByDescending(x => x.Employees.Count).ThenBy(y => y.Town.Name).Take(10);

            foreach (var element in addresses)
            {
                Console.WriteLine($"{element.AddressText}, {element.Town.Name} - {element.Employees.Count} employees");
            }
        }
    }
}
