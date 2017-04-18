using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Interfaces
{
    public interface ICommandExecutor
    {
        string Execute();

        IPerson King { get; set; }
        IList<IKillable> RoyalGuards { get; set; }
        IList<IKillable> Footmen { get; set; }
        string[] CommandParameters { get; set; }
    }
}
