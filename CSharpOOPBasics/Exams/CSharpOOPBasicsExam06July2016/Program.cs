using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _01.KermenExam.Core;
using _01.KermenExam.Interfaces;
using _01.KermenExam.Models;
using _01.KermenExam.UI;

namespace _01.KermenExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            IReader reader = new Reader();
            IWriter writer = new Writer();
            IDatabase database = new Database.Database();
            IController controller = new Controller(database);
            ICommandHandler commandHandler = new CommandHandler(controller);

            IEngine engine = new Engine(reader, writer, commandHandler);

            engine.Run();
        }
    }
}
