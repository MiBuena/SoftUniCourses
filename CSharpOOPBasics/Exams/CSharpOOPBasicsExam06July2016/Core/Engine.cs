using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;
using _01.KermenExam.UI;

namespace _01.KermenExam.Core
{
    public class Engine : IEngine
    {
        private int inputCounter;

        public Engine(IReader reader, IWriter writer, ICommandHandler commandHandler)
        {
            Reader = reader;
            Writer = writer;
            CommandHandler = commandHandler;
        }

        public void Run()
        {
            while (true)
            {
                string input = this.Reader.ReadLine();


                if (input == "Democracy")
                {
                    this.Writer.WriteLine(this.CommandHandler.ExecuteMessageCommand(input));

                    break;
                }

                if (input == "EVN")
                {
                    this.Writer.WriteLine(this.CommandHandler.ExecuteMessageCommand(input));
                }
                else if (input == "EVN bill")
                {
                    this.CommandHandler.ExecuteMessageCommand(input);
                }
                else
                {
                    string pattern = "^\\w+";

                    var name = Regex.Matches(input, pattern)[0].Value;

                    this.CommandHandler.ExecuteCreateCommand(name, input);
                }
            }
        }

        public IReader Reader { get; private set; }
        public IWriter Writer { get; private set; }
        public ICommandHandler CommandHandler { get; private set; }
    }
}
