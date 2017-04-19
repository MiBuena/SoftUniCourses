using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _12.RemoveTowns
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            string townName = Console.ReadLine();

            List<Address> addressesToRemove = context.Addresses.Where(x => x.Town.Name == townName).ToList();

            List<int> numbers = addressesToRemove.Select(x => x.AddressID).ToList();

            Console.WriteLine(addressesToRemove.Count);


            List<Employee> employeesOnTheseAddresses =
                context.Employees.Include(x => x.Address).Where(x => numbers.Contains(x.Address.AddressID)).ToList();

            for (int i = 0; i < employeesOnTheseAddresses.Count; i++)
            {
                employeesOnTheseAddresses[i].Address = null;
            }

            context.Addresses.RemoveRange(addressesToRemove);

            Town townToRemove = context.Towns.FirstOrDefault(x => x.Name == townName);

            context.Towns.Remove(townToRemove);

            context.SaveChanges();

        }
    }
}
