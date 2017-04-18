using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;
using _01.Blobs.Models;

namespace _01.Blobs.Core.Factories
{
    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, IBehaviour behaviour, IAttack attack)
        {
            IBlob blob = new Blob(name, health, damage, behaviour, attack);

            return blob;
        }
    }
}
