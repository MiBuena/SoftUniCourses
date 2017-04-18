using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            List<Animal> animals = new List<Animal>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] animalInputparameters = input.Split(' ').ToArray();

                var animalToAdd = CreateAnAnimal(animalInputparameters);

                animals.Add(animalToAdd);


                    string[] foodInputparameters = Console.ReadLine().Split(' ').ToArray();

                    var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

                    var sbType = assemblyTypes.FirstOrDefault(x => x.Name == foodInputparameters[0]);

                    object[] animalObjectParameters = new object[1];

                    animalObjectParameters[0] = int.Parse(foodInputparameters[1]);

                    Food foodToFeed = (Food)Activator.CreateInstance(sbType, animalObjectParameters);

                    string message = animalToAdd.MakeSound();

                    Console.WriteLine(message);

                try
                {
                    animalToAdd.Eat(foodToFeed);


                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(animalToAdd);


            }


        }

        private static Animal CreateAnAnimal(string[] animalInputparameters)
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name == animalInputparameters[0]);

            object[] animalObjectParameters = new object[animalInputparameters.Length];

            for (int i = 0; i < animalObjectParameters.Length; i++)
            {
                if (i == 2)
                {
                    double weight = double.Parse(animalInputparameters[i]);

                    animalObjectParameters[i] = weight;
                }
                else
                {
                    animalObjectParameters[i] = animalInputparameters[i];
                }
            }

            Animal animalToAdd = (Animal)Activator.CreateInstance(sbType, animalObjectParameters);
            return animalToAdd;
        }
    }
}
