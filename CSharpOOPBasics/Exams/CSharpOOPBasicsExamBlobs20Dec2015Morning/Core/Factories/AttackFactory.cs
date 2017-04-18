using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Core.Factories
{
    public class AttackFactory : IAttackFactory
    {
        public IAttack CreateAttack(string name)
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            var sbType = assemblyTypes.FirstOrDefault(x => x.Name.Contains(name));

            IAttack attack = (IAttack)Activator.CreateInstance(sbType);

            return attack;
        }
    }
}
