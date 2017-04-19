using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUniDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();


            //Task 1 Call a Stored Procedure
            //string[] names = Console.ReadLine().Split(' ');

            //string firstName = names[0];
            //string lastName = names[1];

            //IEnumerable<ProjectInfo> projects = context.GetProjectsByEmployee(firstName, lastName);

            //foreach (var element in projects)
            //{
            //    Console.WriteLine($"{element.Name} - {element.Description}, {element.StartDate.ToString("M/d/yyyy H:mm:ss tt", CultureInfo.InvariantCulture)}");
            //}

            //Task 2 Write a program to find the max salary for each department. Filter those which have max salaries not in the range 30000 and 70000.

            //var salaries =
            //    context.Departments.Select(x => new { MaxSalary = x.Employees.Max(y => y.Salary), Name = x.Name })
            //        .Where(z => z.MaxSalary < 30000 || z.MaxSalary > 70000);

            //foreach (var element in salaries)
            //{
            //    Console.WriteLine($"{element.Name} - {element.MaxSalary:F2}");
            //}

            //Task 3 Write a program to find the max salary for each department. Filter those which have max salaries not in the range 30000 and 70000.
            //var salaries = context.GetMaxSalaries();

            //foreach (var element in salaries)
            //{
            //    Console.WriteLine($"{element.DepartmentName} - {element.DepartmentMaxSalary:F2}");
            //}
        }
    }
}
