using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReflectionLab
{
    class Dog : IAnimal
    {
        private ILiquid liquid;

        public Dog(ILiquid liquid)
        {
            this.liquid = liquid;
        }

        public string Name { get; set; }
    }
}
