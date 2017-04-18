using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CityObject> cityObjects = new List<CityObject>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] cityObject = command.Split(' ');

                string id = cityObject[cityObject.Length - 1];

                CityObject a = new CityObject(id);

                cityObjects.Add(a);
            }

            string fake = Console.ReadLine();

            int length = fake.Length;


            for (int i = 0; i < cityObjects.Count; i++)
            {
                int cityObjectLength = cityObjects[i].Id.Length;
                string substringCityObject = cityObjects[i].Id.Substring(cityObjectLength - length);

                if (fake == substringCityObject)
                {
                    Console.WriteLine(cityObjects[i].Id);
                }
            }
        }
    }
}
