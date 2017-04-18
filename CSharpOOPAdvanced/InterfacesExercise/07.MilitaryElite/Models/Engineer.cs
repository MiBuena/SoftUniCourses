using System.Collections.Generic;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.RepairsCollection = new List<IRepair>();
        }

        public ICollection<IRepair> RepairsCollection { get; set; }

        public override string ToString()
        {
            string printing = base.ToString();

            printing += "\nRepairs:";

            foreach (var element in this.RepairsCollection)
            {
                printing += "\n  " + element;
            }

            return printing;
        }
    }
}
