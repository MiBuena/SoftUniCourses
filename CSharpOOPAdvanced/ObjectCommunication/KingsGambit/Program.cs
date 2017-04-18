using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.KingsGambit.Core;
using _02.KingsGambit.Core.Commands;
using _02.KingsGambit.Interfaces;
using _02.KingsGambit.Models;
using _02.KingsGambit.UserInterface;

namespace _02.KingsGambit
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommandExecutor commandExecutor = new CommandExecutor();

            IWriter writer = new ConsoleWriter();

            IReader reader = new ConsoleReader();

            IEngine engine = new Engine(commandExecutor, writer,reader);

            engine.Run();
            
        }
    }
}
