using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.ConsoleClient.Core.Commands;
using BusTicketsSystem.ConsoleClient.Interfaces;
using BusTicketsSystem.Data.Interfaces;

namespace BusTicketsSystem.ConsoleClient.Core
{
    public class CommandDispatcher:ICommandDispatcher
    {
        private IUnitOfWork unitOfWork;


        public CommandDispatcher(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IExecutable DispatchCommand(string commandName, string[] commandParameters)
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name.ToLower().Contains(commandName.ToLower().Replace("-", "")));


            object[] parameters = new object[] { commandParameters, this.unitOfWork };

            IExecutable command = null;
            try
            {
                command = (Command)Activator.CreateInstance(sbType, parameters);
            }
            catch
            {
                throw new InvalidOperationException("Invalid command!");
            }

            return command;
        }
    }
}
