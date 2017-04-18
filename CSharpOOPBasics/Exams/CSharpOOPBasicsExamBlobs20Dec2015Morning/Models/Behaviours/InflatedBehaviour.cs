using _01.Blobs.Interfaces;

namespace _01.Blobs.Models.Behaviours
{
    public class InflatedBehaviour : Behaviour
    {
        public override void ApplyInitialEffect(IBlob blob)
        {
            blob.CurrentHealth += 50;
        }

        public override void ApplyEffectOnEveryTurn(IBlob blob)
        {
            blob.CurrentHealth -= 10;
        }
    }
}
