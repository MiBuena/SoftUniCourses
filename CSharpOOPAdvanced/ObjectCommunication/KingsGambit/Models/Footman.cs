namespace _02.KingsGambit.Models
{
    class Footman : KillablePerson
    {
        public override string RespondToAttackToTheKing()
        {
            string message = $"Footman {this.Name} is panicking!\n";

            return message;

        }
    }
}
