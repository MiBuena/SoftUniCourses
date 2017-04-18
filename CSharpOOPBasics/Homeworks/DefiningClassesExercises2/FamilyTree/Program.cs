using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchInformation = Console.ReadLine();

            List<Person> peopleCollection = new List<Person>();

            while (true)
            {
                string information = Console.ReadLine();

                if (information == "End")
                {
                    break;
                }

                if (information.Contains("-"))
                {
                    List<string> inputParameters =
                        information.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    Person parent = GetPerson(inputParameters[0].Trim());

                    Person child = GetPerson(inputParameters[1].Trim());


                    child = CheckIfPersonExists(peopleCollection, child);

                    parent = CheckIfPersonExists(peopleCollection, parent);

                    child.Parents.Add(parent);

                    parent.Children.Add(child);
                }
                else
                {
                    ConnectThePerson(information.Trim(), peopleCollection);
                }
            }

            Person personToPrint = null;

            if (searchInformation.Contains("/"))
            {

                DateTime searchedBirthday = GetBirthday(searchInformation.Trim());

                personToPrint = peopleCollection.FirstOrDefault(x => x.Birthday == searchedBirthday);
            }
            else
            {
                List<string> inputParameters =
                    searchInformation.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string searchedName = inputParameters[0] + " " + inputParameters[1];

                personToPrint = peopleCollection.FirstOrDefault(x => x.Name == searchedName);

                personToPrint = CheckForDataTransfer(peopleCollection, personToPrint);
            }

            Console.WriteLine(personToPrint);
        }

        private static Person GetPerson(string inputParameter)
        {
            Person person = null;
            if (!inputParameter.Contains("/"))
            {
                string personName = inputParameter.Trim();

                person = new Person(personName);
            }
            else
            {
                var personBirthday = GetBirthday(inputParameter);

                person = new Person(personBirthday);
            }
            return person;
        }

        private static DateTime GetBirthday(string inputParameter)
        {
            List<int> dateTimeInput = inputParameter.Split('/').Select(int.Parse).ToList();

            DateTime personBirthday = new DateTime(dateTimeInput[2], dateTimeInput[1], dateTimeInput[0]);
            return personBirthday;
        }

        private static Person CheckForDataTransfer(List<Person> peopleCollection, Person personToPrint)
        {
            var identicalPeopleCollection = peopleCollection.Where(x => x.Name == personToPrint.Name || x.Birthday == personToPrint.Birthday).ToList();

            if (identicalPeopleCollection.Count() > 1)
            {
                for (int i = 0; i < identicalPeopleCollection.Count; i++)
                {
                    if (identicalPeopleCollection[i] != personToPrint)
                    {
                        if (identicalPeopleCollection[i].Birthday != DateTime.MinValue)
                        {
                            personToPrint.Birthday = identicalPeopleCollection[i].Birthday;
                        }

                        if (identicalPeopleCollection[i].Name != null)
                        {
                            personToPrint.Name = identicalPeopleCollection[i].Name;
                        }

                        if (identicalPeopleCollection[i].Children.Count != 0)
                        {
                            for (int j = 0; j < identicalPeopleCollection[i].Children.Count; j++)
                            {
                                personToPrint.Children.Add(new Person(identicalPeopleCollection[i].Children[j].Name));
                                personToPrint.Children[j].Birthday = identicalPeopleCollection[i].Children[j].Birthday;
                            }
                        }

                        if (identicalPeopleCollection[i].Parents.Count != 0)
                        {
                            for (int j = 0; j < identicalPeopleCollection[i].Parents.Count; j++)
                            {
                                personToPrint.Parents.Add(new Person(identicalPeopleCollection[i].Parents[j].Name));
                                personToPrint.Parents[j].Birthday = identicalPeopleCollection[i].Parents[j].Birthday;
                            }
                        }
                    }
                }
            }

            return personToPrint;
        }

        private static Person CheckIfPersonExists(List<Person> peopleCollection, Person person)
        {
            if (peopleCollection.Any(y => y.Name == person.Name) && person.Name != null)
            {
                 person = peopleCollection.FirstOrDefault(y => y.Name == person.Name);
            }
            else if (peopleCollection.Any(x => x.Birthday == person.Birthday) && person.Birthday != DateTime.MinValue)
            {
                 person = peopleCollection.FirstOrDefault(x => x.Birthday == person.Birthday);
            }
            else
            {
                peopleCollection.Add(person);
            }

            return person;
        }

        private static void ConnectThePerson(string information, List<Person> peopleCollection)
        {
            List<string> inputParameters =
                information.Split(new char[] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            string name = inputParameters[0] + " " + inputParameters[1];
            DateTime personBirthday = new DateTime(int.Parse(inputParameters[4]), int.Parse(inputParameters[3]),
                int.Parse(inputParameters[2]));

            bool found1 = false;

            bool found2 = false;
        
            if (peopleCollection.Any(x => x.Name == name))
            {
                found1 = true;
                Person personConnect = peopleCollection.FirstOrDefault(x => x.Name == name);

                personConnect.Birthday = personBirthday;
            }

            if(peopleCollection.Any(x=>x.Birthday == personBirthday))
            {
                found2 = true;
                Person personConnect = peopleCollection.FirstOrDefault(x => x.Birthday == personBirthday);
                personConnect.Name = name;
            }

            if(!(found1 && found2))
            {
                peopleCollection.Add(new Person(name, personBirthday));
            }
        }
    }
}
