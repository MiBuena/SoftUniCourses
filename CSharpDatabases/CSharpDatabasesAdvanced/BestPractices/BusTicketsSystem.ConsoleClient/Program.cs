using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.ConsoleClient.Core;
using BusTicketsSystem.ConsoleClient.Interfaces;
using BusTicketsSystem.ConsoleClient.IO;
using BusTicketsSystem.Data;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Repositories;
using BusTicketsSystem.Data.Services;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();

            ICommandDispatcher commandDispatcher = new CommandDispatcher(unitOfWork);
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IRunnable engine = new Engine(commandDispatcher, reader, writer);
            engine.Run();
        }
    }
}
