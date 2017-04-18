using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Gems
{
    class Amethyst : Gem
    {
        public const int StrengthConstant = 2;
        public const int AgilityConstant = 8;
        public const int VitalityConstant = 4;


        public Amethyst(LevelOfClarity levelOfClarity) : base(StrengthConstant+(int)levelOfClarity, AgilityConstant+(int)levelOfClarity, VitalityConstant+(int)levelOfClarity, levelOfClarity)
        {
        }
    }
}
