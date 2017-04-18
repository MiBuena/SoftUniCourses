using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RawData
{
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
