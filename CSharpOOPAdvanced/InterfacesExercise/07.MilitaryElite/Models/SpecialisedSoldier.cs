using System.Security.Authentication;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; set; }


        public override string ToString()
        {
            string printing = base.ToString() + "\n" + "Corps: " + this.Corps;

            return printing;
        }
    }
}
