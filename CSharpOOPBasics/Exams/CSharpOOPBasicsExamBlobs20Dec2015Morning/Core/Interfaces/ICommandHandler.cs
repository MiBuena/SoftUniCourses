using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blobs.Interfaces
{
    public interface ICommandHandler
    {
        IController Controller { get; }

        string ExecuteCommand(string name, string[] parameters);

        void Progress();

    }
}
