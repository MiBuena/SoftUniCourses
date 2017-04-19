using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _06.FindProjectInPeriod
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();


            var employees =
                context.Employees.Where(x => x.Projects.Any(y => y.StartDate.Year >= 2001 && y.StartDate.Year <= 2003)).Take(30);

            foreach (var element in employees)
            {
                Console.WriteLine($"{element.FirstName} {element.LastName} {element.Manager.FirstName}");

                foreach (var project in element.Projects)
                {
                    Console.WriteLine($"--{project.Name} {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} {string.Format("{0:M/d/yyyy}", project.EndDate)}");
                }
            }
        }
    }
}
