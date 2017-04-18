using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Models.Attacks
{
    public class PutridFart : IAttack
    {
        public void ProduceAttack(IBlob blob, IBlob enemy)
        {
            enemy.CurrentHealth -= blob.Damage;
        }
    }
}
