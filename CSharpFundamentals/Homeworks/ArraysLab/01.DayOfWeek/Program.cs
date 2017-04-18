using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 7 || number <= 0)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                number--;

                string[] daysOfWeek = new string[7];

                daysOfWeek[0] = "Monday";
                daysOfWeek[1] = "Tuesday";
                daysOfWeek[2] = "Wednesday";
                daysOfWeek[3] = "Thursday";
                daysOfWeek[4] = "Friday";
                daysOfWeek[5] = "Saturday";
                daysOfWeek[6] = "Sunday";

                Console.WriteLine(daysOfWeek[number]);

            }

        }
    }
}
