using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blobs.Interfaces
{
    public interface IAttack
    {
        void ProduceAttack(IBlob blob, IBlob enemy);
    }
}
