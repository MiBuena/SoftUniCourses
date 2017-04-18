using System.Collections.Generic;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.PrivatesCollection = new List<ISoldier>();
        }

        public ICollection<ISoldier> PrivatesCollection { get; set; }

        public override string ToString()
        {
            string printing = base.ToString();

            printing += "\n" + "Privates:" + "\n";

            foreach (var element in this.PrivatesCollection)
            {
                printing += "  " + element + "\n";
            }

            return printing;
        }
    }
}
