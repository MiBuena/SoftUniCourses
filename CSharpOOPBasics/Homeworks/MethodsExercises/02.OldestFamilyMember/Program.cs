using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParameters =
                    Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string personName = inputParameters[0];

                int age = int.Parse(inputParameters[1]);

                Person personToAdd = new Person(personName, age);

                family.AddMember(personToAdd);
            }

            var oldestFamilyMember = family.GetOldestMember();

            Console.WriteLine(oldestFamilyMember);
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            string person = $"{this.Name} {this.Age}";
            return person;
        }
    }

    class Family
    {
        public Family()
        {
            this.ListOfPeople = new List<Person>();
        }

        public List<Person> ListOfPeople { get; set; }


        public void AddMember(Person personToAdd)
        {
            this.ListOfPeople.Add(personToAdd);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = this.ListOfPeople.FirstOrDefault(x => x.Age == this.ListOfPeople.Max(y => y.Age));

            return oldestMember;
        }
    }
}
