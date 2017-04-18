using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();

            while (true)
            {

                try
                {
                    string firstLine = Console.ReadLine().Trim();

                    if (firstLine == "Beast!")
                    {
                        break;
                    }

                    string secondLine = Console.ReadLine().Trim();

                    List<string> animalParameters =
                        secondLine.Split(new char[] {' '}).ToList();

                    Animal newAnimal = null;

                    string name = animalParameters[0];

                    int age = int.Parse(animalParameters[1]);

                    if (animalParameters.Count == 3)
                    {
                        string gender = animalParameters[2];

                        newAnimal = AnimalFactory.ProduceAnimal(firstLine, name, age, gender);
                    }
                    else
                    {
                        newAnimal = AnimalFactory.ProduceAnimal(firstLine, name, age);
                    }


                    animalCollection.Add(newAnimal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            foreach (var element in animalCollection)
            {
                Console.WriteLine(element);

                Console.WriteLine(element.ProduceSound());
            }
        }
    }
}

