using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.ConsoleClient.Interfaces
{
    public interface ICommandDispatcher
    {
        IExecutable DispatchCommand(string commandName, string[] commandParameters);
    }
}
