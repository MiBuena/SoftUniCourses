using System.Collections.Generic;
using System.Linq;
using _02.KingsGambit.Interfaces;
using _02.KingsGambit.Models;

namespace _02.KingsGambit.Core.Commands
{
    class CommandExecutor : ICommandExecutor
    {


        public IPerson King { get; set; }
        public IList<IKillable> RoyalGuards { get; set; }
        public IList<IKillable> Footmen { get; set; }
        public string[] CommandParameters { get; set; }

        public string Execute()
        {
            var command = typeof (CommandExecutor).GetMethods().FirstOrDefault(x => x.Name == this.CommandParameters[0]);

            string message = (string)command.Invoke(this, null);

            return message;
        }

        public string Kill()
        {
            var killables = new List<IKillable>();

            killables.AddRange(this.RoyalGuards);
            killables.AddRange(this.Footmen);

            IKillable personToKill = killables.FirstOrDefault(x => x.Name == this.CommandParameters[1]);

            killables.Remove(personToKill);

            personToKill.IsAlive = false;

            return "";

        }

        public string Attack()
        {

            string message = null;
            var respondinPeople = new List<IPerson>();

            respondinPeople.Add(this.King);
            respondinPeople.AddRange(this.RoyalGuards);
            respondinPeople.AddRange(this.Footmen);

            foreach (var element in respondinPeople)
            {
                message += element.RespondToAttackToTheKing();
            }


            return message;
        }
    }


}
