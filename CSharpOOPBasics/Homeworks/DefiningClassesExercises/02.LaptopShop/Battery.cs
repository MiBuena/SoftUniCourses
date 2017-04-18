using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string type;
        private int numberOfCells;
        private int mAh;

        public Battery(string type, int numberOfCells, int mAh)
        {
            this.Type = type;
            this.NumberOfCells = numberOfCells;
            this.MAh = mAh;
        }

        public int MAh
        {
            get { return this.mAh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Milliampere-hours can not be negative");
                }

                this.mAh = value;
            }
        }

        public int NumberOfCells
        { 
            get { return this.numberOfCells; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of cells can not be negative");
                }

                this.numberOfCells = value;
            } 
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                List<string> a = new List<string>() {"Ni-Cd", "Ni-MH", "Li-Ion"};

                if (!a.Contains(value))
                {
                    throw new ArgumentException("Invalid battery type");
                }

                this.type = value;
            }
        }

        public override string ToString()
        {
            string battery = string.Format("{0}, {1}-cells, {2} mAh", type, NumberOfCells, MAh);
            return battery;
        }
    }
}
