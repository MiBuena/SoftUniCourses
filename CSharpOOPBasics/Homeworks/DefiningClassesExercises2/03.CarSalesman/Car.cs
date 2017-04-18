using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarSalesman
{
    class Car
    {

        public Car(string model, Engine engine) : this(model, engine, 0, null)
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, 0, color)
        {
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, null)
        {
        }

        public Car(string model, Engine engine, int weight, string colour)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Colour = colour;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {


            string weight = null;

            if (this.Weight != 0)
            {
                weight = this.Weight.ToString();
            }

            
            string car = String.Format("{0}: \n {1} \n Weight: {2} \n Color: {3}", this.Model, this.Engine, weight?? "n/a", this.Colour ?? "n/a");

            return car;
        }
    }
}
