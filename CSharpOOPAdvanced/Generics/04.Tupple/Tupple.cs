using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tupple
{
    class Tupple<firstType, secondType>
    {

        public Tupple(firstType item1, secondType item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public firstType Item1 { get; set; }

        public secondType Item2 { get; set; }


    }
}
