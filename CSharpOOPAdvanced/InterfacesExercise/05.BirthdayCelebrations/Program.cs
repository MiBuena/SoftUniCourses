using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<CityObject> cityObjects = new List<CityObject>();


            while (true)
            {
                string command = Console.ReadLine().Trim();

                if (command == "End")
                {
                    break;
                }

                string[] cityObject = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);


                if (cityObject[0] == "Citizen" || cityObject[0] == "Pet")
                {
                    DateTime birthday = new DateTime();

                    birthday = DateTime.ParseExact(cityObject[cityObject.Length - 1], "dd/MM/yyyy", CultureInfo.CurrentCulture);

                    CityObject a = new CityObject(birthday);




                    cityObjects.Add(a);
                }


            }

            string searchedYear = Console.ReadLine().Trim();

            var cityObjectsBirthdays = cityObjects.Where(x => x.Birthday.Year == int.Parse(searchedYear));

            foreach (var element in cityObjectsBirthdays)
            {
                Console.WriteLine(element.Birthday.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));

            }
        }
    }
}
