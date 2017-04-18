using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06.CustomEnumAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var enumeration = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name.Contains(input));

            var attribute = enumeration.GetCustomAttributes();

            foreach (var element in attribute)
            {
                Console.WriteLine(element);
            }
        }
    }
}
