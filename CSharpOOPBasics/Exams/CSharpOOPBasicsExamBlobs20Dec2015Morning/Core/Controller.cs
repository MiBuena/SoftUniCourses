using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Core
{
    public class Controller : IController
    {
        public Controller(IDatabase database, IBlobFactory blobFactory, IAttackFactory attackFactory, IBehaviourFactory behaviourFactory)
        {
            this.BehaviourFactory = behaviourFactory;
            this.AttackFactory = attackFactory;
            this.BlobFactory = blobFactory;
            this.Database = database;
        }

        public IDatabase Database { get; set; }

        public IAttackFactory AttackFactory { get; set; }

        public IBehaviourFactory BehaviourFactory { get; set; }

        public IBlobFactory BlobFactory { get; set; }

        public void Progress()
        {
            foreach (var blob in this.Database.BlobsCollection)
            {
                if (blob.Behaviour.CheckIfBehaviourShouldBeStarted(blob) && !blob.Behaviour.HasBeenTriggered)
                {
                    blob.Behaviour.IsTriggered = true;
                    blob.Behaviour.HasBeenTriggered = true;
                    blob.DamageBeforeBehaviour = blob.Damage;
                    blob.Behaviour.ApplyInitialEffect(blob);
                    blob.InitialEffectWasApplied = true;
                }
                else if (blob.Behaviour.IsTriggered)
                {
                    var checkIfShouldBeRemoved = blob.Behaviour.CheckIfBehaviourShouldBeTerminated(blob);

                    if (checkIfShouldBeRemoved)
                    {
                        blob.Behaviour.IsTriggered = false;
                    }
                    else
                    {
                        blob.Behaviour.ApplyEffectOnEveryTurn(blob);
                    }
                }
            }
        }


        public void Create(string[] parameters)
        {
            string blobName = parameters[0];

            int health = int.Parse(parameters[1]);

            int damage = int.Parse(parameters[2]);

            string behaviourName = parameters[3];

            string attackName = parameters[4];

            IBehaviour behaviour = this.BehaviourFactory.CreateBehaviour(behaviourName);

            IAttack attack = this.AttackFactory.CreateAttack(attackName);

            IBlob blob = this.BlobFactory.CreateBlob(blobName, health, damage, behaviour, attack);


            this.Database.BlobsCollection.Add(blob);

        }

        public void Attack(string[] parameters)
        {
            string attackersName = parameters[0];

            string targetsName = parameters[1];

            IBlob attacker = this.Database.BlobsCollection.FirstOrDefault(x => x.Name == attackersName);

            IBlob target = this.Database.BlobsCollection.FirstOrDefault(x => x.Name == targetsName);

            attacker.AttackBlob(target);

        }

        public string Status()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in this.Database.BlobsCollection)
            {
                sb.AppendLine(element.ToString());
            }

            return sb.ToString();
        }
    }
}
