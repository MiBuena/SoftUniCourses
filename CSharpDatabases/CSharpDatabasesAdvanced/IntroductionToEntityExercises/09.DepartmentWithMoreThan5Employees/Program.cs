using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;
using SoftUniContest.Models;

namespace _09.DepartmentWithMoreThan5Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            List<Department> departments =
                context.Departments.Where(x => x.Employees.Count > 5).OrderBy(y => y.Employees.Count).ToList();

            foreach (var department in departments)
            {
                Console.WriteLine($"{department.Name} {department.Employee.FirstName}");

                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
                }
            }

        }
    }
}
