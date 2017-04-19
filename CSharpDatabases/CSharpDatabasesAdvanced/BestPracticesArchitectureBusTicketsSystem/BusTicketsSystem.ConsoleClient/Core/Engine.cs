using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusTicketsSystem.ConsoleClient.Interfaces;

namespace BusTicketsSystem.ConsoleClient.Core
{
    class Engine : IRunnable
    {
        private ICommandDispatcher commandDispatcher;
        private IReader reader;
        private IWriter writer;

        public Engine(ICommandDispatcher commandDispatcher, IReader reader, IWriter writer)
        {
            this.commandDispatcher = commandDispatcher;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Program started");
            while (true)
            {
                try
                {
                    string input = reader.ReadLine();

                    if (input == "exit")
                    {
                        break;
                    }
                    string[] data = input.Split();
                        string commandName = data[0];
                        string result = this.commandDispatcher
                            .DispatchCommand(commandName, data)
                            .Execute();
                        Console.WriteLine(result);

                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }
            }
        }
    }
}
