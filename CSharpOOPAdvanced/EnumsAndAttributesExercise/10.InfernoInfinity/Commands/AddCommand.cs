using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using _10.InfernoInfinity.Enumerations;
using _10.InfernoInfinity.Gems;
using _10.InfernoInfinity.Weapons;
using ICommand = _10.InfernoInfinity.Interfaces.ICommand;

namespace _10.InfernoInfinity.Commands
{
    class AddCommand :ICommand
    {
        public void Execute(string[] parameters, IList<Weapon> weaponsCollection)
        {
            string name = parameters[1];

            int index = int.Parse(parameters[2]);

            string []gem = parameters[3].Split(' ');

            string gemType = gem[0];

            string gemName = gem[1];

            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name.Contains(gemName));

            LevelOfClarity levelOfClarity = (LevelOfClarity) Enum.Parse(typeof (LevelOfClarity), gemType);

            Gem gemToAdd = (Gem)Activator.CreateInstance(sbType, new object[] { levelOfClarity });

            Weapon weapon = weaponsCollection.FirstOrDefault(x => x.Name == name);

            weapon.AddGem(gemToAdd, index);
        }
    }
}
