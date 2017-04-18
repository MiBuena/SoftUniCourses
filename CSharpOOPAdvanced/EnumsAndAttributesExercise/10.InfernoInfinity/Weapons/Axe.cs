using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Weapons
{
    class Axe : Weapon
    {
        public const int MinimumDamage = 5;
        public const int MaximumDamage = 10;
        public const int NumberOfSockets = 4;

        public Axe(string name, LevelOfRarity levelOfRarity) : base(name, MinimumDamage*(int)levelOfRarity, MaximumDamage*(int)levelOfRarity, NumberOfSockets, levelOfRarity)
        {
        }
    }
}
