using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Interfaces;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity.Commands
{
    class CommandExecutor :ICommandExecutor
    {
        public void ExecuteCommand(string[] parameters, IList<Weapon> weapons)
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name.Contains(parameters[0]));

            ICommand command = (ICommand)Activator.CreateInstance(sbType);

            command.Execute(parameters, weapons);

        }
    }
}
