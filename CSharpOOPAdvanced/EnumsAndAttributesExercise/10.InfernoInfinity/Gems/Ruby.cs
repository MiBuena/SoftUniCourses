using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;
using _10.InfernoInfinity.Weapons;

namespace _10.InfernoInfinity.Gems
{
    class Ruby : Gem
    {
        public const int StrengthConstant = 7;
        public const int AgilityConstant = 2;
        public const int VitalityConstant = 5;


        public Ruby(LevelOfClarity levelOfClarity) : base(StrengthConstant+(int)levelOfClarity, AgilityConstant+(int)levelOfClarity, VitalityConstant+(int)levelOfClarity, levelOfClarity)
        {
        }
    }
}
