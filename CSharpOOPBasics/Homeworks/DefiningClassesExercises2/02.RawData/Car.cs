using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RawData
{
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double pressureTyre1, int ageTyre1, double pressureTyre2, int ageTyre2, double pressureTyre3, int ageTyre3, double pressureTyre4, int ageTyre4)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tyres = new List<Tyre>();

            Tyre one = new Tyre(pressureTyre1, ageTyre1);
            Tyre two = new Tyre(pressureTyre2, ageTyre2);
            Tyre three = new Tyre(pressureTyre3, ageTyre3);
            Tyre four = new Tyre(pressureTyre4, ageTyre4);

            this.Tyres.Add(one);
            this.Tyres.Add(two);
            this.Tyres.Add(three);
            this.Tyres.Add(four);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tyre> Tyres { get; set; }
    }
}
