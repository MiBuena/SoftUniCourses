using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Person
    {
        public Person(string name):this(name, null, null)
        {
        }

        public Person(string name, Car car, Company company)
        {
            this.Name = name;
            this.Car = car;
            this.Company = company;
            this.PokemonCollection = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public string Name { get; set; }
        public Car Car { get; set; }
        public Company Company { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }

        public override string ToString()
        {
            string person = String.Format(this.Name + "\nCompany:{0}\nCar:{1}\nPokemon:{2}\nParents:{3}\nChildren:{4}", this.Company, this.Car, string.Join("", this.PokemonCollection), string.Join("", this.Parents), string.Join("", this.Children));

            
            return person;
        }
    }
}
