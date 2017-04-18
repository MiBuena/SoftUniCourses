using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();

            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            TimeSpan difference = dateModifier.CalculateDifference(firstDate, secondDate);

            Console.WriteLine(Math.Abs(difference.Days));
        }
    }

    class DateModifier
    {
        public TimeSpan CalculateDifference(string firstDate, string secondDate)
        {
            DateTime firstDateFormat = Convert.ToDateTime(firstDate);

            DateTime secondDateFormat = Convert.ToDateTime(secondDate);

            TimeSpan integer = firstDateFormat - secondDateFormat;

            return integer;
        }
    }
}
