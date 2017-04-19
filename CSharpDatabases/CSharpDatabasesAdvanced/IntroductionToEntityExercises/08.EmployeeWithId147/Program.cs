using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _08.EmployeeWithId147
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            Employee employee = context.Employees.Find(147);

            Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");

            employee.Projects = employee.Projects.OrderBy(x => x.Name).ToList();

            foreach (var element in employee.Projects)
            {
                Console.WriteLine($"{element.Name}");
            }

        }
    }
}
