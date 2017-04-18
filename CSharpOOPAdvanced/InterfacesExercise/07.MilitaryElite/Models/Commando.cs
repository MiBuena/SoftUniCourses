using System.Collections.Generic;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.MissionsCollection = new List<IMission>();
        }

        public ICollection<IMission> MissionsCollection { get; set; }

        public override string ToString()
        {
            string printing = base.ToString() + "\nMissions:";

            foreach (var element in this.MissionsCollection)
            {
                printing += "\n" + "  " + element;
            }

            return printing;
        }
    }
}
