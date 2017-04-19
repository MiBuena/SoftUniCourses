using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _13.FindEmployeesStartingWithSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            List<Employee> employeeList = context.Employees.Where(x => x.FirstName.Substring(0, 2) == "Sa").ToList();

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine($"{employeeList[i].FirstName} {employeeList[i].LastName} - {employeeList[i].JobTitle} - (${employeeList[i].Salary})");
            }
        }
    }
}
