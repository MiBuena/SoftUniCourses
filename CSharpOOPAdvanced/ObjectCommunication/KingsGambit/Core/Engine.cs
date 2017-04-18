using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.KingsGambit.Interfaces;
using _02.KingsGambit.Models;

namespace _02.KingsGambit.Core
{
    public class Engine : IEngine
    {
        public Engine(ICommandExecutor commandExecutor, IWriter writer, IReader reader)
        {
            this.CommandExecutor = commandExecutor;
            this.Writer = writer;
            this.Reader = reader;
        }

        public void Run()
        {
            string kingName = this.Reader.Read();

            string[] royalGuardsNames = this.Reader.Read().Split(' ');

            string[] footMenNames = this.Reader.Read().Split(' ');

            IPerson king = new King()
            {
                Name = kingName
            };

            var royalGuards = GetRoyalGuards(royalGuardsNames);

            var footMen = GetFootMen(footMenNames);


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                this.CommandExecutor.King = king;
                this.CommandExecutor.RoyalGuards = royalGuards;
                this.CommandExecutor.Footmen = footMen;
                this.CommandExecutor.CommandParameters = command.Split(' ');

                this.Writer.Write(this.CommandExecutor.Execute());

            }
        }

        private static IList<IKillable> GetFootMen(string[] footMenNames)
        {
            IList<IKillable> footMen = new List<IKillable>();

            foreach (var element in footMenNames)
            {
                IKillable footMan = new Footman()
                {
                    Name = element
                };

                footMen.Add(footMan);
            }
            return footMen;
        }

        private static IList<IKillable> GetRoyalGuards(string[] royalGuardsNames)
        {
            IList<IKillable> royalGuards = new List<IKillable>();

            foreach (var element in royalGuardsNames)
            {
                IKillable newRoyalGuard = new RoyalGuard()
                {
                    Name = element
                };

                royalGuards.Add(newRoyalGuard);
            }
            return royalGuards;
        }

        public ICommandExecutor CommandExecutor { get; set; }

        public IWriter Writer { get; set; }

        public IReader Reader { get; set; }
    }
}
