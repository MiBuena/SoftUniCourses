using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class Cymric : Cat
    {
        public Cymric(string name, decimal furlength) : base(name)
        {
            this.FurLength = furlength;
        }

        public decimal FurLength { get; set; }

        public override string ToString()
        {
            string cymric = String.Format("{0} {1} {2:F2}", this.GetType().Name, this.Name, this.FurLength);
            return cymric;
        }
    }
}
