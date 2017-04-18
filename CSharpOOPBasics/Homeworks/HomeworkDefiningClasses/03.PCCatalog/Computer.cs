using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private Component mouse;
        private Component keyboard;
        private Component processor;
        private Component motherboard;
        private decimal price;

        public Computer(string name, Component mouse, Component keyboard, Component processor, 
            Component motherboard)
        {
            this.Name = name;
            this.Price = price;
            this.Mouse = mouse;
            this.Keyboard = keyboard;
            this.Processor = processor;
            this.Motherboard = motherboard;
        }

        public Computer(string name, Component processor, Component motherboard) : this(name,null,null, processor, motherboard)
        {  
        }

        public Component Motherboard { get; set; }

        public Component Processor { get; set; }

        public Component Keyboard { get; set; }

        public Component Mouse { get; set; }

        public decimal Price
        {
            get
            {
                decimal totalPrice = 0;

                if (this.Motherboard != null)
                {
                    totalPrice += this.Motherboard.Price;
                }

                if (this.Mouse != null)
                {
                    totalPrice += this.Mouse.Price;
                }

                if (this.Keyboard != null)
                {
                    totalPrice += this.Keyboard.Price;
                }

                if (this.Processor != null)
                {
                    totalPrice += this.Processor.Price;
                }

               return totalPrice;
            }
            private set { this.price = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name + "\n");

            if (this.Keyboard != null)
            {
                sb.Append(this.Keyboard.Name+ ": ");
                sb.Append(this.Keyboard.Price+ "\n");
            }

            if (this.Mouse != null)
            {
                sb.Append(this.Mouse.Name + ": ");
                sb.Append(this.Mouse.Price + "\n");
            }

            if (this.Processor != null)
            {
                sb.Append(this.Processor.Name + ": ");
                sb.Append(this.Processor.Price + "\n");
            }

            if (this.Motherboard != null)
            {
                sb.Append(this.Motherboard.Name + ": ");
                sb.Append(this.Motherboard.Price + "\n");
            }

            sb.Append(String.Format("Total price: {0:C}", this.Price));

            return sb.ToString();
        }
    }
}
