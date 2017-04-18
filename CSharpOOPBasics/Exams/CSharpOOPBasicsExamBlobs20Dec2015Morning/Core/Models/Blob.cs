using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Models
{
    public class Blob : IBlob
    {

        private int currentHealth;
        private IAttack attack;

        public Blob(string name, int initialHealth, int damage, IBehaviour behaviour, IAttack attack)
        {
            this.Name = name;
            this.CurrentHealth = initialHealth;
            this.InitialHealth = initialHealth;
            this.Damage = damage;
            this.Behaviour = behaviour;
            this.attack = attack;
        }

        public string Name { get; }

        public IBehaviour Behaviour { get; }

        public int CurrentHealth
        {
            get { return this.currentHealth; }
            set
            {
                if (value < 0)
                {
                    this.currentHealth = 0;

                }
                else
                {
                    this.currentHealth = value;
                }
            }
        }

        public int InitialHealth { get; }

        public int Damage { get; set; }

        public int DamageBeforeBehaviour { get; set; }

        public bool InitialEffectWasApplied { get; set; }

        public bool IsAlive
        {
            get { return this.CurrentHealth > 0; }
        }

        public void AttackBlob(IBlob target)
        {
            if (this.IsAlive && target.IsAlive)
            {
                this.attack.ProduceAttack(this, target);
            }
        }

        public void ProgressBlob()
        {
            if (this.Behaviour.IsTriggered)
            {
                this.Behaviour.ApplyEffectOnEveryTurn(this);
            }
        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.IsAlive)
            {
                sb.Append($"Blob ");

                sb.Append($"{this.Name}: {this.CurrentHealth} HP, {this.Damage} Damage");

            }
            else
            {
                sb.Append($"Blob {this.Name} KILLED");
            }

            return sb.ToString();
        }
    }
}
