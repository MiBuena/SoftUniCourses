using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.InfernoInfinity.Enumerations;

namespace _10.InfernoInfinity.Gems
{
    class Gem
    {

        public Gem(int strengthBonus, int agilityBonus, int vitalityBonus, LevelOfClarity levelOfClarity)
        {
            this.StrengthBonus = strengthBonus;
            this.AgilityBonus = agilityBonus;
            this.VitalityBonus = vitalityBonus;
            this.LevelOfClarity = levelOfClarity;
        }

        public int StrengthBonus { get; set; }

        public int AgilityBonus { get; set; }

        public int VitalityBonus { get; set; }

        public LevelOfClarity LevelOfClarity { get; set; }


    }
}
