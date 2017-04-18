using _02.KingsGambit.Interfaces;

namespace _02.KingsGambit.Models
{
    class King : IPerson
    {
        public string Name { get; set; }

        public string RespondToAttackToTheKing()
        {
            string message = $"King {this.Name} is under attack!\n";

            return message;
        }
    }
}
