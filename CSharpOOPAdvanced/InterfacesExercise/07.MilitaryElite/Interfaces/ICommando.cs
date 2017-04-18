using System.Collections.Generic;

namespace _07.MilitaryElite.Interfaces
{
    interface ICommando: ISpecialisedSoldier
    {
        ICollection<IMission> MissionsCollection { get; set; } 
    }
}
