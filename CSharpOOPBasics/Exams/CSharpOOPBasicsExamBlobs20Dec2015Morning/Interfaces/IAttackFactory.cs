using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blobs.Interfaces
{
    public interface IAttackFactory
    {
        IAttack CreateAttack(string name);
    }
}
