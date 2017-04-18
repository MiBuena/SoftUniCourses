using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            string printing = $"{this.Name} {this.Age}";

            return printing;
        }
    }
}
