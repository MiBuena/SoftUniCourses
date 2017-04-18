using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstComparer firstComparer = new FirstComparer();
            SecondComparer secondComparer = new SecondComparer();

            SortedSet<Person> firstSortedSet = new SortedSet<Person>(firstComparer);

            SortedSet<Person> secondSortedSet = new SortedSet<Person>(secondComparer);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputParameters = Console.ReadLine().Split(' ');

                string name = inputParameters[0];
                int age = int.Parse(inputParameters[1]);

                Person newPerson = new Person()
                {
                    Age = age,
                    Name = name
                };

                secondSortedSet.Add(newPerson);

                firstSortedSet.Add(newPerson);






            }

            Console.WriteLine();
            foreach (var element in firstSortedSet)
            {
                Console.WriteLine(element);
            }

            foreach (var element in secondSortedSet)
            {
                Console.WriteLine(element);
            }
        }
    }
}
