using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarSalesman
{
    class Engine
    {
        public Engine(string model, decimal power):this(model, power, 0, null)
        {
        }

        public Engine(string model, decimal power, int displacement) : this(model, power, displacement, null)
        {
        }

        public Engine(string model, decimal power, string efficiency):this(model, power, 0, efficiency)
        {
        }

        public Engine(string model, decimal power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }
        public decimal Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = "n/a";

            if (this.Displacement != 0)
            {
                displacement = this.Displacement.ToString();
            }


            string engine = String.Format(" {0}: \n    Power: {1}\n    Displacement: {2}\n    Efficiency: {3}", this.Model, this.Power, displacement, this.Efficiency ?? "n/a");

            return engine;
        }
    }
}
