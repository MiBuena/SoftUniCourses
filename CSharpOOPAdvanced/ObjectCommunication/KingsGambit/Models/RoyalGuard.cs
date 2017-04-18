namespace _02.KingsGambit.Models
{
    class RoyalGuard : KillablePerson
    {

        public override string RespondToAttackToTheKing()
        {
            string message = string.Empty;

            if (!this.IsAlive)
            {
                return message;
            }

            message = $"Royal Guard {this.Name} is defending!\n";

            return message;
        }
    }
}
