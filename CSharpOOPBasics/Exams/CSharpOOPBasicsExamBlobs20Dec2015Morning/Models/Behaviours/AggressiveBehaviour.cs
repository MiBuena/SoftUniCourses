using _01.Blobs.Interfaces;

namespace _01.Blobs.Models.Behaviours
{
    public class AggressiveBehaviour : Behaviour
    {
        public override void ApplyInitialEffect(IBlob blob)
        {
            blob.Damage *= 2;
        }

        public override void ApplyEffectOnEveryTurn(IBlob blob)
        {
            if (blob.Damage - 5 >= blob.DamageBeforeBehaviour)
            {
                blob.Damage -= 5;
            }
            else
            {
                blob.Damage = blob.DamageBeforeBehaviour;
            }
        }
    }
}
