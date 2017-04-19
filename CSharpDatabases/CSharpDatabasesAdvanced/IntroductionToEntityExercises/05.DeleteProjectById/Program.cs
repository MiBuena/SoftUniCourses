using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoftUniContest;

namespace _05.DeleteProjectById
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SoftUniContext context = new SoftUniContext();

            var projectToDelete = context.Projects.FirstOrDefault(x=>x.ProjectID == 3);

            var employees = context.Employees.Where(x => x.Projects.Any(y=>y.ProjectID == projectToDelete.ProjectID)).ToList();

            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].Projects.Remove(projectToDelete);
            }

            context.Projects.Remove(projectToDelete);


            var projects = context.Projects.Take(10).Select(x => x.Name);

            foreach (var element in projects)
            {
                Console.WriteLine(element);
            }


            context.SaveChanges();


        }
    }
}
