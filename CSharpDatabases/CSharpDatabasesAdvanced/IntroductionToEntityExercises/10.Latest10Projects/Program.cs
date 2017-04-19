using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _10.Latest10Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).OrderBy(y => y.Name);

            foreach (var element in projects)
            {
                Console.WriteLine($"{element.Name} {element.Description} {string.Format("{0:M/d/yyyy h:mm:ss tt}", element.StartDate)} {string.Format("{0:M/d/yyyy h:mm:ss tt}", element.EndDate)}");
            }
        }
    }
}
