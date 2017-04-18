using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Gems
{
    class Emerald : Gem
    {
        public const int StrengthConstant = 1;
        public const int AgilityConstant = 4;
        public const int VitalityConstant = 9;


        public Emerald(LevelOfClarity levelOfClarity) : base(StrengthConstant+(int)levelOfClarity, AgilityConstant+(int)levelOfClarity, VitalityConstant+(int)levelOfClarity, levelOfClarity)
        {
        }
    }
}
