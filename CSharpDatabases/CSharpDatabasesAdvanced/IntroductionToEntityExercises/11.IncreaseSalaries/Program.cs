using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _11.IncreaseSalaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            string[] departmentNames =
            {
                "Engineering", "Tool Design", "Marketing", "Information Services"
            };

            List<Employee> employees = context.Employees.Where(x => departmentNames.Contains(x.Department.Name)).ToList();


            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].Salary *= 1.12M;
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].FirstName} {employees[i].LastName} (${employees[i].Salary})");
            }

            context.SaveChanges();
        }
    }
}
