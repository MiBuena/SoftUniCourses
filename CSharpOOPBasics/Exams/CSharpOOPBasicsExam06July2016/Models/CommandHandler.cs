using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class CommandHandler : ICommandHandler
    {
        private int inputCounter;

        public CommandHandler(IController controller)
        {
            Controller = controller;
        }

        public IController Controller { get; private set; }


        public void ExecuteCreateCommand(string name, string parameters)
        {
            name = "Create" + name + "Household";

            MethodInfo method = this.Controller.GetType().GetMethods().FirstOrDefault(x=>x.Name == name);

            method.Invoke(this.Controller, new object[] { parameters});

            CheckToPaySalaries();
        }

        private void CheckToPaySalaries()
        {
            this.inputCounter++;

            if (inputCounter == 3)
            {
                this.Controller.PaySalaries();
                this.inputCounter = 0;
            }
        }

        public string ExecuteMessageCommand(string parameters)
        {
            CheckToPaySalaries();

            string commandName = Regex.Replace(parameters, @"\s+", "");


            MethodInfo method = this.Controller.GetType().GetMethods().FirstOrDefault(x => x.Name.ToLower() == commandName.ToLower());

            var result = (string)method.Invoke(this.Controller, null);

            return result;
        }
    }
}
