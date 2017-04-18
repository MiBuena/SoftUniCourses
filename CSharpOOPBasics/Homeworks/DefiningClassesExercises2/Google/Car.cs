using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            string car = String.Format("\n{0} {1}", this.Model, this.Speed);
            return car;
        }
    }
}
