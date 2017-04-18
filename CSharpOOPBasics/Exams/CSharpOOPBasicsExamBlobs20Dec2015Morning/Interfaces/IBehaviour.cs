using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blobs.Interfaces
{
    public interface IBehaviour
    {
        int BehaviourCounter { get; }
        bool IsTriggered { get; set; }
        bool HasBeenTriggered { get; set; }

        void ApplyInitialEffect(IBlob blob);
        void ApplyEffectOnEveryTurn(IBlob blob);

        bool CheckIfBehaviourShouldBeStarted(IBlob blob);

        bool CheckIfBehaviourShouldBeTerminated(IBlob blob);

    }
}
