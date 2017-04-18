using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursToFinishTheProject = double.Parse(Console.ReadLine());

            int days = int.Parse(Console.ReadLine());

            int productivityPercent = int.Parse(Console.ReadLine());

            double realDays = days*0.90D;

            double realHours = Math.Floor((realDays*12*productivityPercent)/100d);

            double difference = hoursToFinishTheProject - realHours;

            if (difference > 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(realHours-hoursToFinishTheProject);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(realHours - hoursToFinishTheProject);
            }

        }
    }
}
