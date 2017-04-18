using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Models;

namespace _08.CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();

            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();

            MyList myList = new MyList();

            string[] inputStrings = Console.ReadLine().Split(' ');

            int numberOfRemoves = int.Parse(Console.ReadLine());

            foreach (var element in inputStrings)
            {
                Console.Write($"{addCollection.AddToTheEnd(element)} ");
            }

            Console.WriteLine();

            foreach (var element in inputStrings)
            {
                Console.Write($"{addRemoveCollection.AddToTheBeginning(element)} ");
            }

            Console.WriteLine();

            foreach (var element in inputStrings)
            {
                Console.Write($"{myList.AddToTheBeginning(element)} ");
            }


            Console.WriteLine();


            for (int i = 0; i < numberOfRemoves; i++)
            {
                Console.Write($"{addRemoveCollection.RemoveLastItem()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfRemoves; i++)
            {
                Console.Write($"{myList.RemoveFirstItem()} ");
            }
        }
    }
}
