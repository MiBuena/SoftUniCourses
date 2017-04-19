using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _04.AddingANewAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();


            Address newAddress = new Address() { AddressText = "Vitoshka 15", TownID = 4 };

            Employee employeeToUpdate = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");

            employeeToUpdate.Address = newAddress;

            context.SaveChanges();


            List<string> employees =
                context.Employees.OrderByDescending(x => x.AddressID)
                    .Take(10)
                    .Select(y => y.Address.AddressText)
                    .ToList();

            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }
        }
    }
}
