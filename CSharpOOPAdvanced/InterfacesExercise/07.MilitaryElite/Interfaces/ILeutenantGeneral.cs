using System.Collections;
using System.Collections.Generic;

namespace _07.MilitaryElite.Interfaces
{
    interface ILeutenantGeneral : IPrivate
    {
        ICollection<ISoldier> PrivatesCollection { get; set; } 
    }
}
