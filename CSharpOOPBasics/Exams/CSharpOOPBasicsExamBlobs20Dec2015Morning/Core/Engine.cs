using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Core
{
    public class Engine : IEngine
    {

        public Engine(ICommandHandler commandHandler, IReader reader, IWriter writer)
        {
            this.CommandHandler = commandHandler;
            this.Reader = reader;
            this.Writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string input = this.Reader.ReadLine();

                if (input == "drop")
                {
                    break;
                }

                if (input == "pass")
                {
                    this.CommandHandler.Progress();
                    continue;
                }

                string[] parameters = input.Split(' ');

                string commandName = parameters[0];

                string[] commandParameters = parameters.Skip(1).ToArray();

                var result = this.CommandHandler.ExecuteCommand(commandName, commandParameters);

                if (result != null)
                {
                    this.Writer.WriteLine(this.CommandHandler.ExecuteCommand(commandName, commandParameters));
                }


                this.CommandHandler.Progress();


            }
        }

        public ICommandHandler CommandHandler { get; set; }

        public IReader Reader { get; set; }

        public IWriter Writer { get; set; }


    }
}
