using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            Gandalf gandalf = new Gandalf();

            foreach (var element in food)
            {
                Food foodToEat = FoodFactory.ProduceFood(element);

                gandalf.Eat(foodToEat);

                gandalf.CalculateMood();
            }

            Console.WriteLine(gandalf.TotalHappinessPoints);
            Console.WriteLine(gandalf.Mood);
        }
    }
}
