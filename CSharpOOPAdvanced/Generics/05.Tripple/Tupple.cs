using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tripple
{
    class Tupple<firstType, secondType, thirdType>
    {

        public Tupple(firstType item1, secondType item2, thirdType item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public firstType Item1 { get; set; }

        public secondType Item2 { get; set; }

        public thirdType Item3 { get; set; }


        public override string ToString()
        {
            string result = $"{this.Item1:G29} -> {this.Item2:G29} -> {this.Item3:G29}";

            return result;
        }
    }
}
