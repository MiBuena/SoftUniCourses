using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            string sound = "ROAAR!!!";

            return sound;
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Meat))
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }

            this.FoodEaten += food.Quantity;
        }
    }
}
