using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan
{
    class FoodFactory
    {
        public static Food ProduceFood(string foodName)
        {
            Food newFood = null;

            switch (foodName.ToLower())
            {
                case "cram":
                    newFood = new Food(foodName, 2);
                    break;
                case "lembas":
                    newFood = new Food(foodName, 3);
                    break;
                case "apple":
                case "melon":
                    newFood = new Food(foodName, 1);
                    break;
                case "honeycake":
                    newFood = new Food(foodName, 5);
                    break;
                case "mushrooms":
                    newFood = new Food(foodName, -10);
                    break;
                default:
                    newFood = new Food(foodName, -1);
                    break;
            }

            return newFood;
        }
    }
}
