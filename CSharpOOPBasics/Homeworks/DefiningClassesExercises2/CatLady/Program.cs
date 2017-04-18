using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatLady
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Cat> cats = new List<Cat>();

            while (true)
            {
                string information = Console.ReadLine();

                if (information == "End")
                {
                    break;
                }

                List<string> inputParams = information.Split(' ').ToList();

                if (inputParams[0] == "Siamese")
                {
                    Siamese a = new Siamese(inputParams[1], int.Parse(inputParams[2]));
                    cats.Add(a);
                }
                else if (inputParams[0] == "Cymric")
                {
                    Cymric a = new Cymric(inputParams[1], decimal.Parse(inputParams[2]));
                    cats.Add(a);
                }
                else if (inputParams[0] == "StreetExtraordinaire")
                {
                    StreetExtraordinaire a = new StreetExtraordinaire(inputParams[1], int.Parse(inputParams[2]));
                    cats.Add(a);
                }
            }

            string catName = Console.ReadLine();

            var b = cats.FirstOrDefault(x => x.Name == catName);

            Console.WriteLine(b);
        }
    }
}
