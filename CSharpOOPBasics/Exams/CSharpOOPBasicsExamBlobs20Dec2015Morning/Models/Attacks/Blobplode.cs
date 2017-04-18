using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Models.Attacks
{
    public class Blobplode : IAttack
    {
        public void ProduceAttack(IBlob blob, IBlob enemy)
        {
            var division = (decimal)blob.CurrentHealth /2M;

            blob.CurrentHealth = (int)Math.Ceiling(division);

            if (blob.CurrentHealth < 1)
            {
                blob.CurrentHealth = 1;
            }

            enemy.CurrentHealth -= blob.Damage*2;
        }
    }
}
