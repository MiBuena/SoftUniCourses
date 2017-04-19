using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _03.EmployeesFromResearchDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            List<Employee> employees =
                context.Employees.Where(x => x.Department.Name == "Research and Development")
                    .OrderBy(y => y.Salary)
                    .ThenByDescending(z => z.FirstName)
                    .ToList();

            foreach (var element in employees)
            {
                Console.WriteLine($"{element.FirstName} {element.LastName} " + $"from {element.Department.Name} - ${element.Salary:F2}");
            }
        }
    }
}
