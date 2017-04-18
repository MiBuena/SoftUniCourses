using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReflectionLab
{
    class Water : ILiquid
    {
        private int a;

        public Water(int a)
        {
            this.a = a;
        }
        public string Color { get; set; }
    }
}
