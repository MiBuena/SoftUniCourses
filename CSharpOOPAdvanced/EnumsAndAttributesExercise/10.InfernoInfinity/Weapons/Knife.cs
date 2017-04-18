using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Weapons
{
    class Knife : Weapon
    {
        public const int MinimumDamage = 3;
        public const int MaximumDamage = 4;
        public const int NumberOfSockets = 2;

        public Knife(string name, LevelOfRarity levelOfRarity) : base(name, MinimumDamage*(int)levelOfRarity, MaximumDamage*(int)levelOfRarity, NumberOfSockets, levelOfRarity)
        {
        }
    }
}
