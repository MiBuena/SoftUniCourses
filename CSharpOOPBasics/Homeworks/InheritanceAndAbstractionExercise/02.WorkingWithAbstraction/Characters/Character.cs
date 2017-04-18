using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.WorkingWithAbstraction.Interfaces;

namespace _02.WorkingWithAbstraction.Characters
{
    abstract class Character : IAttack
    {
        private int health;
        private int mana;
        private int damage;

        protected Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public int Mana { get; set; }

        public int Health { get; set; }

        public abstract void Attack(Character target);
    }
}
