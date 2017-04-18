using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage
{
    interface IBuyer
    {
        void BuyFood();
        int Food { get; set; }
        string Name { get; set; }
    }
}
