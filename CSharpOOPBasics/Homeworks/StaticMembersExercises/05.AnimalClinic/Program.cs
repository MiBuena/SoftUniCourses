using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _05.AnimalClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Animal,string> animalCollection = new Dictionary<Animal, string>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                List<string> inputParameters = inputLine.Split(' ').ToList();

                Animal a = new Animal(inputParameters[0], inputParameters[1]);


                if (inputParameters[2] == "heal")
                {
                    AnimalClinic.HealedAnimalsCount++;

                    animalCollection.Add(a, inputParameters[2]+"ed");

                }
                else
                {
                    AnimalClinic.RehabilitedAnimalsCount++;
                    animalCollection.Add(a, inputParameters[2]+"d");

                }
            }

            int index = 1;

            foreach (var element in animalCollection)
            {
                Console.WriteLine($"Patient {index}: [{element.Key.Name} ({element.Key.Breed})] has been {element.Value}!");

                index++;
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.RehabilitedAnimalsCount}");


            string key = Console.ReadLine();

            if (key == "heal")
            {
                foreach (var element in animalCollection)
                {
                    if (element.Value == key+"ed")
                    {
                        Console.WriteLine($"{element.Key.Name} {element.Key.Breed}");
                    }
                }
            }
            else
            {
                foreach (var element in animalCollection)
                {
                    if (element.Value == key + "d")
                    {
                        Console.WriteLine($"{element.Key.Name} {element.Key.Breed}");
                    }
                }
            }
        }
    }
}
