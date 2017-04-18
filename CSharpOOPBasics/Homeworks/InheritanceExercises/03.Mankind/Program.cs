using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<string> studentParameters = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            string studentFirstName = studentParameters[0];

            string studentLastName = studentParameters[1];

            string facultyNumber = studentParameters[2];


            try
            {
                Student a = new Student(studentFirstName, studentLastName, facultyNumber);

                List<string> workerParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string workerFirstName = workerParameters[0];

                string workerLastName = workerParameters[1];

                decimal workerSalary = decimal.Parse(workerParameters[2]);

                int workHoursPerDay = int.Parse(workerParameters[3]);


                Worker b = new Worker(workerFirstName, workerLastName, workerSalary, workHoursPerDay);


                Console.WriteLine(a);

                Console.WriteLine();

                Console.WriteLine(b);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
