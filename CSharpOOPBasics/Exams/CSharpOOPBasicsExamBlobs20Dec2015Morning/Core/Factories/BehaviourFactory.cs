using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Core.Factories
{
    public class BehaviourFactory : IBehaviourFactory
    {
        public IBehaviour CreateBehaviour(string name)
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name.Contains(name));

            IBehaviour behaviour = (IBehaviour)Activator.CreateInstance(sbType);

            return behaviour;

        }
    }
}
