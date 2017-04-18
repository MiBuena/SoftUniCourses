using _01.Blobs.Interfaces;

namespace _01.Blobs.Models.Behaviours
{
    public abstract class Behaviour : IBehaviour
    {
        public abstract void ApplyInitialEffect(IBlob blob);

        public abstract void ApplyEffectOnEveryTurn(IBlob blob);

        public bool CheckIfBehaviourShouldBeStarted(IBlob blob)
        {
            if (blob.CurrentHealth <= blob.InitialHealth / 2)
            {
                return true;
            }

            return false;

        }

        public bool CheckIfBehaviourShouldBeTerminated(IBlob blob)
        {
            if (this.BehaviourCounter >= 6)
            {
                this.BehaviourCounter = 0;
                return true;
            }

            return false;
        }

        public int BehaviourCounter { get; set; }
        public bool IsTriggered { get; set; }
        public bool HasBeenTriggered { get; set; }
    }
}
