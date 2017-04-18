using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; }

        int CurrentHealth { get; set; }

        int InitialHealth { get; }

        int Damage { get; set; }

        int DamageBeforeBehaviour { get; set; }

        bool InitialEffectWasApplied { get; set; }

        bool IsAlive { get; }

        IBehaviour Behaviour { get; }

        void AttackBlob(IBlob target);
        
        void ProgressBlob();


    }
}
