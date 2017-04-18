using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodSayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = Console.ReadLine();
            Person person = new Person(personName);

            Console.WriteLine(person.SayHello());
        }
    }

    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string SayHello()
        {
            string greeting = $"{this.Name} says \"Hello\"!";

            return greeting;
        }
    }
}
