using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.ShapesVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                List<string> inputParameters = inputLine.Split(' ').ToList();

                string name = inputParameters[0];

                object [] numbers = new object[inputParameters.Count-1];

                for (int i = 1; i < inputParameters.Count; i++)
                {
                    numbers[i-1] = double.Parse(inputParameters[i]);
                }

                var macroClasses = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == "VolumeCalculator");

                string methodName = "Calculate" + name + "Volume";

                Console.WriteLine("{0:F3}", macroClasses.GetMethod(methodName).Invoke(null, numbers));
            }
        }
    }
}
