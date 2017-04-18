using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Interfaces;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity.Commands
{
    class RemoveCommand : ICommand
    {
        public void Execute(string[] parameters, IList<Weapon> weaponsCollection)
        {
            string weaponName = parameters[1];

            int index = int.Parse(parameters[2]);

            var weapon = weaponsCollection.FirstOrDefault(x => x.Name == weaponName);

            weapon.Remove(index);
        }
    }
}
