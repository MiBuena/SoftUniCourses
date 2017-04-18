using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleCollection = new List<Person>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputParameters = input.Split(' ');
                string name = inputParameters[0];
                int age = int.Parse(inputParameters[1]);
                string town = inputParameters[2];

                Person newPerson = new Person()
                {
                    Age = age,
                    Name = name,
                    Town = town
                };

                peopleCollection.Add(newPerson);

            }

            int number = int.Parse(Console.ReadLine());

            if (number >= peopleCollection.Count || number < 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {


                Person personToCompare = peopleCollection[number - 1];

                int numberOfEqualPeople = peopleCollection.Where(x => x.CompareTo(personToCompare) == 0).ToList().Count;

                Console.WriteLine($"{numberOfEqualPeople} {peopleCollection.Count - numberOfEqualPeople} {peopleCollection.Count}");



            }
        }
    }
}
