using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Commands;
using _10.InfernoInfinity.Interfaces;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weaponsCollection = new List<Weapon>();

            ICommandExecutor commandExecutor = new CommandExecutor();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] parameters = input.Split(';');

                commandExecutor.ExecuteCommand(parameters, weaponsCollection);

            }
        }
    }
}
