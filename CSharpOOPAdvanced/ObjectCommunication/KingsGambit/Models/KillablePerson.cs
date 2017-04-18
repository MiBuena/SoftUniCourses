using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.KingsGambit.Interfaces;

namespace _02.KingsGambit.Models
{
    abstract class KillablePerson : IKillable
    {
        protected KillablePerson()
        {
            this.IsAlive = true;
        }

        public string Name { get; set; }

        public bool IsAlive { get; set; }


        public void Die()
        {
            this.IsAlive = true;
        }

        public abstract string RespondToAttackToTheKing();
    }
}
