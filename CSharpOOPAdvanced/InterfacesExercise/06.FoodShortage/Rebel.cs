using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage
{
    class Rebel : IBuyer
    {

        public Rebel(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }

        public int Food { get; set; }
    }
}
