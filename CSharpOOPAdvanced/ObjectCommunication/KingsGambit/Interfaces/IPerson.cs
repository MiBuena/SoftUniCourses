using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        string RespondToAttackToTheKing();

    }
}
