using System.Collections.Generic;

namespace _07.MilitaryElite.Interfaces
{
    interface IEngineer: ISoldier
    {
        ICollection<IRepair> RepairsCollection { get; set; } 
    }
}
