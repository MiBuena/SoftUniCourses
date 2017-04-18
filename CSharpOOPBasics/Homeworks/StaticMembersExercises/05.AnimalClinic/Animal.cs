using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AnimalClinic
{
    class Animal
    {
        public Animal(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }

        public string Breed { get; set; }
    }
}
