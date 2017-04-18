using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class StreetExtraordinaire : Cat
    {
        public StreetExtraordinaire(string name, int decibelOfMeows) : base(name)
        {
            this.DecibelOfMeows = decibelOfMeows;
        }

        public int DecibelOfMeows { get; set; }

        public override string ToString()
        {
            string street = String.Format("{0} {1} {2}", this.GetType().Name, this.Name, this.DecibelOfMeows);
            return street;
        }
    }
}
