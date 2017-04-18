using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CensorYourEmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string text = Console.ReadLine();

            string[] array = email.Split('@');

            string replace = new string('*', array[0].Length);

            string replacement = replace+"@"+array[1];

            text = text.Replace(email, replacement);

            Console.WriteLine(text);
        }
    }
}
