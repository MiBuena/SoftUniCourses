using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _01.EmployeesFullInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            var employees = context.Employees.ToList();

            foreach (var element in employees)
            {
                Console.WriteLine($"{element.FirstName} {element.LastName} {element.MiddleName} {element.JobTitle} {element.Salary}");
            }
        }
    }
}
