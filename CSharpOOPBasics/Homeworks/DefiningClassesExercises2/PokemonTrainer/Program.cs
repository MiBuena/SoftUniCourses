using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Trainer> trainersCollection = new List<Trainer>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Tournament")
                {
                    break;
                }

                List<string> inputParameters = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string trainerName = inputParameters[0];
                string pokemonName = inputParameters[1];
                string pokemonElement = inputParameters[2];
                int pokemonHealth = int.Parse(inputParameters[3]);

                Pokemon b = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainersCollection.Any(x => x.Name == trainerName))
                {
                    Trainer t = trainersCollection.First(x => x.Name == trainerName);

                    t.PokemonCollection.Add(b);
                }
                else
                {
                    Trainer a = new Trainer(trainerName);
                    a.PokemonCollection.Add(b);
                    trainersCollection.Add(a);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                for (int i = 0; i < trainersCollection.Count; i++)
                {
                    if (trainersCollection[i].PokemonCollection.Any(x => x.Element == command))
                    {
                        trainersCollection[i].NumberOfBadges++;
                    }
                    else
                    {
                        for (int j = 0; j < trainersCollection[i].PokemonCollection.Count; j++)
                        {
                            trainersCollection[i].PokemonCollection[j].Health -= 10;

                            if (trainersCollection[i].PokemonCollection[j].Health <= 0)
                            {
                                trainersCollection[i].PokemonCollection.RemoveAt(j);
                                j--;
                            }
                        }
                    }
                }
            }

            var sortedCollection = trainersCollection.OrderByDescending(x => x.NumberOfBadges);

            foreach (var element in sortedCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
