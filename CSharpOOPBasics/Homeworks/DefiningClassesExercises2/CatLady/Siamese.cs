using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class Siamese : Cat
    {
        public Siamese(string name, int earSize) : base(name)
        {
            this.EarSize = earSize;
        }

        public int EarSize { get; set; }

        public override string ToString()
        {
            string siamese = String.Format("{0} {1} {2}", this.GetType().Name, this.Name, this.EarSize);
            return siamese;
        }
    }
}
