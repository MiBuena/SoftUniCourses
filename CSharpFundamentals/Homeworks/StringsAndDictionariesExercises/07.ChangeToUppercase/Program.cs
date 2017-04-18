using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChangeToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int startIndex = 0;

            int endIndex = 0;

            while (true)
            {
                startIndex = text.IndexOf("<upcase>", startIndex);


                if (startIndex == -1)
                {
                    break;
                }

                endIndex = text.IndexOf("</upcase>", startIndex);

                string lowerCase = text.Substring(startIndex, endIndex - startIndex+9);

                string replacement = lowerCase.Substring(8, lowerCase.Length - 17).ToUpper();

                text = text.Replace(lowerCase, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
