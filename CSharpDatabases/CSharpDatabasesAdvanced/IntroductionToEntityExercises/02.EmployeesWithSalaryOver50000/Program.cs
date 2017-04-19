using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _02.EmployeesWithSalaryOver50000
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            List<string> firstNames = context.Employees.Where(y => y.Salary > 50000).Select(x => x.FirstName).ToList();

            foreach (var element in firstNames)
            {
                Console.WriteLine(element);
            }
        }
    }
}
