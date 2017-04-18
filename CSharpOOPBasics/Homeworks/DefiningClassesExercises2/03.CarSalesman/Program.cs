using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engineCollection = new List<Engine>();

            List<Car> carCollection = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParameters = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string model = inputParameters[0];
                decimal power = decimal.Parse(inputParameters[1]);

                Engine a = null;

                if (inputParameters.Count == 2)
                {
                    a = new Engine(model, power);
                }
                else if (inputParameters.Count == 3)
                {
                    if (inputParameters[2].ToCharArray().Any(x => char.IsLetter(x)))
                    {
                        string efficiency = inputParameters[2];

                        a = new Engine(model, power, efficiency);
                    }
                    else
                    {
                        int displacement = int.Parse(inputParameters[2]);

                        a = new Engine(model, power, displacement);
                    }
                }
                else
                {
                    int displacement = int.Parse(inputParameters[2]);

                    string efficiency = inputParameters[3];

                    a = new Engine(model, power, displacement, efficiency);
                }

                engineCollection.Add(a);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                List<string> inputParameters = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                Car b = null;

                string model = inputParameters[0];

                string engine = inputParameters[1];

                Engine engineToUse = engineCollection.First(x => x.Model == engine);

                if (inputParameters.Count == 2)
                {
                    b = new Car(model, engineToUse);
                }
                else if (inputParameters.Count == 3)
                {
                    if (inputParameters[2].ToCharArray().Any(x => char.IsLetter(x)))
                    {
                        string colour = inputParameters[2];

                        b = new Car(model, engineToUse, colour);

                    }
                    else
                    {
                        int weight = int.Parse(inputParameters[2]);

                        b = new Car(model, engineToUse, weight);

                    }
                }
                else
                {
                    int weight = int.Parse(inputParameters[2]);

                    string colour = inputParameters[3];

                    b = new Car(model, engineToUse, weight, colour);

                }

                carCollection.Add(b);

            }

            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine(carCollection[i]);
            }
        }
    }
}
