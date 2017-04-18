using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity.Interfaces
{
    interface ICommand
    {
        void Execute(string[] parameters, IList<Weapon> weaponsCollection);
    }
}
