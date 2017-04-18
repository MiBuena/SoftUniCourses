using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Person> peopleCollection = new List<Person>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                List<string> commandParameters =
                    command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string instruction = commandParameters[1];
                Person personToAdd = peopleCollection.FirstOrDefault(x => x.Name == commandParameters[0]);

                if (personToAdd == null)
                {
                    Person a = new Person(commandParameters[0]);
                    peopleCollection.Add(a);
                }

                switch (instruction)
                {
                    case "company":
                        AddCompany(commandParameters, peopleCollection);
                        break;
                    case "pokemon":
                        AddPokemon(commandParameters, peopleCollection);
                        break;
                    case "parents":
                        AddParent(commandParameters, peopleCollection);
                        break;
                    case "children":
                        AddChild(commandParameters, peopleCollection);
                        break;
                    case "car":
                        AddCar(commandParameters, peopleCollection);
                        break;

                }
            }

            string name = Console.ReadLine();

            Person personToPrint = peopleCollection.First(x => x.Name == name);

            Console.WriteLine(personToPrint);



        }

        private static void AddCar(List<string> commandParameters, List<Person> peopleCollection)
        {
            Person personToAdd = peopleCollection.First(x => x.Name == commandParameters[0]);

            string model = commandParameters[2];
            int speed = int.Parse(commandParameters[3]);

            Car a = new Car(model, speed);

            personToAdd.Car = a;
        }

        private static void AddChild(List<string> commandParameters, List<Person> peopleCollection)
        {
            Person personToAdd = peopleCollection.First(x => x.Name == commandParameters[0]);

            string name = commandParameters[2];

            string birthday = commandParameters[3];

            Child a = new Child(name, birthday);

            personToAdd.Children.Add(a);
        }

        private static void AddParent(List<string> commandParameters, List<Person> peopleCollection)
        {
            Person personToAdd = peopleCollection.First(x => x.Name == commandParameters[0]);

            string name = commandParameters[2];
            string birthday = commandParameters[3];

            Parent a = new Parent(name, birthday);

            personToAdd.Parents.Add(a);
        }

        private static void AddPokemon(List<string> commandParameters, List<Person> peopleCollection)
        {
            string pokemonName = commandParameters[2];
            string pokemonType = commandParameters[3];

            Pokemon b = new Pokemon(pokemonName, pokemonType);

            Person personToAdd = peopleCollection.First(x => x.Name == commandParameters[0]);

            personToAdd.PokemonCollection.Add(b);
        }

        private static void AddCompany(List<string> commandParameters, List<Person> peopleCollection)
        {
            Person personToAdd = peopleCollection.First(x => x.Name == commandParameters[0]);

            string companyName = commandParameters[2];
            string department = commandParameters[3];
            decimal salary = decimal.Parse(commandParameters[4]);


            Company a = new Company(companyName, department, salary);

            personToAdd.Company = a;
        }
    }
}
