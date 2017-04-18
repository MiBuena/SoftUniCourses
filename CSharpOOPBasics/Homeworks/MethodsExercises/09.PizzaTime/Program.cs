using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Pizza a = new Pizza();

            SortedDictionary<int, List<string>> dictionaryToPrint = a.MakeSortedCollection(input);

            foreach (var element in dictionaryToPrint)
            {
                Console.WriteLine($"{element.Key} - {string.Join(", ", element.Value)}");
            }
        }
    }

    class Pizza
    {
        public string Name { get; set; }
        public int Group { get; set; }

        public SortedDictionary<int, List<string>> MakeSortedCollection(params string[] pizzas)
        {
            SortedDictionary<int, List<string>> sortedCollection = new SortedDictionary<int, List<string>>();

            foreach (var element in pizzas)
            {
                string text = element;
                string pattern = @"(\d+)(\w+)";
                Regex regex = new Regex(pattern);
                Match matches = regex.Match(text);

                int group = int.Parse(matches.Groups[1].ToString());

                string pizzaName = matches.Groups[2].ToString();

                if (!sortedCollection.ContainsKey(group))
                {
                    sortedCollection.Add(group, new List<string>());
                }

                sortedCollection[group].Add(pizzaName);


            }

            return sortedCollection;
        }
    }
}
