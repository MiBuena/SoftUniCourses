using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Weapons
{
    class Sword : Weapon
    {
        public const int MinimumDamage = 4;
        public const int MaximumDamage = 6;
        public const int NumberOfSockets = 3;

        public Sword(string name, LevelOfRarity levelOfRarity) : base(name, MinimumDamage*(int)levelOfRarity, MaximumDamage*(int)levelOfRarity, NumberOfSockets, levelOfRarity)
        {
        }
    }
}
