using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.ExplicitInterfaces.Interfaces;

namespace _09.ExplicitInterfaces
{
    class Citizen : IResident, IPerson
    {

        public Citizen(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }


        string IResident.GetName()
        {
            string printing = "Mr/Ms/Mrs " + this.Name;

            return printing;
        }


        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
