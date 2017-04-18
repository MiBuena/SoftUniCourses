using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price) : this(name, price, null)
        {
        }

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Details { get; set; }


        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can not be negative");
                }

                this.price = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Name can not be empty");
                }

                this.name = value;
            }
        }
    }
}
