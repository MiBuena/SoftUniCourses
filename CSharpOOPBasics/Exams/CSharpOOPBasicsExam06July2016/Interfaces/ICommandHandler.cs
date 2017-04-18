using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KermenExam.Interfaces
{
    public interface ICommandHandler
    {
        IController Controller { get; }

        void ExecuteCreateCommand(string name, string parameters);

        string ExecuteMessageCommand(string parameters);


    }
}
