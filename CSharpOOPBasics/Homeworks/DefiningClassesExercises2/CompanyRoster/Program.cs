using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            List<Employee> employeeCollection = new List<Employee>();

            List<string> departmentCollection = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParameters = Console.ReadLine().Split(' ').ToList();

                Employee newEmployee = GetEmployee(inputParameters);

                departmentCollection.Add(inputParameters[3]);


                employeeCollection.Add(newEmployee);

            }
            decimal maxSum = decimal.MinValue;

            var winnerEmployees = new List<Employee>();

            foreach (var element in departmentCollection)
            {
                var departmentEmployees = employeeCollection.Where(y => y.Department == element).ToList();

                var sum = departmentEmployees.Sum(x => x.Salary);

                if (sum > maxSum)
                {
                    winnerEmployees = departmentEmployees;
                    maxSum = sum;
                }
            }

            var winners = winnerEmployees.OrderByDescending(x => x.Salary);

            Console.WriteLine("Highest Average Salary: {0}", winners.FirstOrDefault().Department);

            foreach (var employee in winners)
            {
                Console.WriteLine(employee);
            }
        }

        private static Employee GetEmployee(List<string> inputParameters)
        {
            string name = inputParameters[0];
            decimal salary = decimal.Parse(inputParameters[1]);
            string position = inputParameters[2];
            string department = inputParameters[3];

            if (inputParameters.Count == 4)
            {
                Employee a = new Employee(name, salary, position, department);

                return a;
            }
            else if (inputParameters.Count == 5)
            {
                if (inputParameters[4].Contains("@"))
                {
                    string email = inputParameters[4];

                    Employee a = new Employee(name, salary, position, department, email);

                    return a;

                }
                else
                {
                    int age = int.Parse(inputParameters[4]);

                    Employee a = new Employee(name, salary, position, department, age);

                    return a;
                }
            }
            else if (inputParameters.Count == 6)
            {
                string email = inputParameters[4];
                int age = int.Parse(inputParameters[5]);

                Employee a = new Employee(name, salary, position, department, email, age);

                return a;
            }

            return null;
        }
    }
}
