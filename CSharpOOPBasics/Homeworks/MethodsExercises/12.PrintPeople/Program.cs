using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintPeople
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> peopleCollection = new List<Person>();

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand == "END")
                {
                     break;
                }

                List<string> inputParameters = inputCommand.Split(' ').ToList();

                Person personToAdd = new Person(inputParameters[0], int.Parse(inputParameters[1]), inputParameters[2]);
                peopleCollection.Add(personToAdd);
            }

            peopleCollection.Sort();

            foreach (var person in peopleCollection)
            {
                Console.WriteLine($"{person.Name} - age: {person.Age}, occupation: {person.Occupation}");
            }
        }
    }

    class Person : IComparable<Person>
    {

        public Person(string name, int age, string occupation)
        {
            this.Name = name;
            this.Age = age;
            this.Occupation = occupation;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }


        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
