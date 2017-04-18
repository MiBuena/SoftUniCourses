using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Box
{
    class Program
    {
        static void Main(string[] args)
        {
 

          

            try
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                decimal length = decimal.Parse(Console.ReadLine());

                decimal width = decimal.Parse(Console.ReadLine());

                decimal height = decimal.Parse(Console.ReadLine());




                Type boxType = typeof(Box);
                FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(fields.Count());

                Box a = new Box(length, width, height);

                decimal surfaceArea = a.GetSurfaceArea();

                decimal lateralSurface = a.GetLateralSurfaceArea();

                decimal volume = a.GetVolume();

                Console.WriteLine("Surface Area - {0:F2}", surfaceArea);
                Console.WriteLine("Lateral Surface Area - {0:F2}", lateralSurface);
                Console.WriteLine("Volume - {0:F2}", volume);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
