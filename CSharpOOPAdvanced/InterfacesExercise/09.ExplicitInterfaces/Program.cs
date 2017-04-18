using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.ExplicitInterfaces.Interfaces;

namespace _09.ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine().Trim();

                if (command == "End")
                {
                    break;
                }

                string[] parameters = command.Split(' ');

                string name = parameters[0];
                string country = parameters[1];
                int age = int.Parse(parameters[2]);


                IResident a = new Citizen(name, age, country);

                IPerson b = new Citizen(name, age, country);

                Console.WriteLine(b.GetName());
                Console.WriteLine(a.GetName());
            }


        }
    }
}
