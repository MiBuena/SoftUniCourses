using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.WorkingWithAbstraction.Interfaces;

namespace _02.WorkingWithAbstraction.Characters
{
    class Priest : Character, IHeal
    {
        public Priest() : base(125, 200, 100)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            this.Health += (int)(0.1*(double)this.Damage);
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
