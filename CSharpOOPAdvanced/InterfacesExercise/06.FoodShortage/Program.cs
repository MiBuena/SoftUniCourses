using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IBuyer> buyersCollection = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                if (parameters.Length == 4)
                {
                    Citizen citizen = new Citizen(parameters[0]);
                    buyersCollection.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(parameters[0]);

                    buyersCollection.Add(rebel);
                }
            }

            while (true)
            {
                string command = Console.ReadLine().Trim();

                if (command == "End")
                {
                    break;
                }

                IBuyer buyer = buyersCollection.FirstOrDefault(x => x.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyersCollection.Sum(x=>x.Food));
        }
    }
}
