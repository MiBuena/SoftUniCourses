using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Core
{
    public class CommandHandler : ICommandHandler
    {
        public CommandHandler(IController controller)
        {
            this.Controller = controller;
        }

        public string ExecuteCommand(string name, string[] parameters)
        {
            var command = this.Controller.GetType().GetMethods().FirstOrDefault(x => x.Name.ToLower() == name);

            string result = null;

            if (command.ReturnType == typeof(void))
            {
                command.Invoke(this.Controller, new object[] { parameters });
            }
            else
            {
                result = (string)command.Invoke(this.Controller, null);
            }

            return result;
        }

        public void Progress()
        {
            this.Controller.Progress();
        }


        public IController Controller { get; }

    }
}
