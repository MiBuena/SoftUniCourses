using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;
using _10.InfernoInfinity.Interfaces;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity.Commands
{
    class CreateCommand : ICommand
    {
        public void Execute(string[] parameters, IList<Weapon> weaponsCollection)
        {
            string[] weaponType = parameters[1].Split(' ');

            string typeName = weaponType[1];

            string weaponName = parameters[2];

            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name == typeName);

            LevelOfRarity levelOfRarity = (LevelOfRarity) Enum.Parse(typeof (LevelOfRarity), weaponType[0]);

            Weapon weapon = (Weapon)Activator.CreateInstance(sbType, new object[] { weaponName, levelOfRarity });

            weaponsCollection.Add(weapon);
        }
    }
}
