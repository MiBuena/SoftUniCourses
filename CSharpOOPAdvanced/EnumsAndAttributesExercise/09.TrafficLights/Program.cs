using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TrafficLights
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string>lights = Console.ReadLine().Split(' ').ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                lights.Insert(0, lights[lights.Count-1]);

                lights.RemoveAt(lights.Count-1);

                Console.WriteLine(string.Join(" ", lights));
            }


        }
    }
}
