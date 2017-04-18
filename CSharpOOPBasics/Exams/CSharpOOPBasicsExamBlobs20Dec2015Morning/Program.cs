using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Core;
using _01.Blobs.Core.Factories;
using _01.Blobs.Interfaces;
using _01.Blobs.UI;

namespace _01.Blobs
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new Database.Database();

            IAttackFactory attackFactory = new AttackFactory();

            IBehaviourFactory behaviourFactory = new BehaviourFactory();

            IBlobFactory blobFactory = new BlobFactory();

            IController controller = new Controller(database, blobFactory, attackFactory, behaviourFactory);

            ICommandHandler commandHandler = new CommandHandler(controller);

            IReader reader = new Reader();
            IWriter writer = new Writer();

            IEngine engine = new Engine(commandHandler, reader, writer);

            engine.Run();
        }
    }
}
