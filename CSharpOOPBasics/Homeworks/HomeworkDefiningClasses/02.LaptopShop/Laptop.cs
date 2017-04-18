using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard, string hdd,
    string screen, Battery battery, double batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }

        public Laptop(string model, decimal price, string graphicsCard, string hdd,
string screen, Battery battery, double batteryLife)
            : this(model, price, null, null, null, graphicsCard, hdd, screen, battery, batteryLife)
        {
        }


        public Laptop(string model, decimal price) : this(model, price, null, null, null, null, 0.0d)
        {

        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price can not be less than 0");
                }

                this.price = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Life", "Battery life can not be less than 0");
                }

                this.batteryLife = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Screen can not be empty");
                }

                this.screen = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("HDD can not be empty");
                }

                this.hdd = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Graphics card can not be empty");
                }

                this.graphicsCard = value;
            }
        }

        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("RAM can not be empty");
                }

                this.ram = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Processor can not be empty");
                }

                this.processor = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Manufacturer can not be empty");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        { 
            get { return this.model; }
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Model can not be empty");
                }

                this.model = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("{0, -15}|{1, -60}|\n", "model", this.model));

            if (this.manufacturer != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "manufacturer", this.manufacturer));
            }

            if (this.processor != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "processor", this.processor));
            }

            if (this.ram != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "RAM", this.ram));
            }

            if (this.graphicsCard != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "graphics card", this.graphicsCard));
            }

            if (this.hdd != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "HDD", this.hdd));
            }

            if (this.screen != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "screen", this.screen));
            }

            if (this.battery != null)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "battery", this.battery));
            }

            if (this.batteryLife != 0)
            {
                sb.Append(String.Format("{0, -15}|{1, -60}|\n", "battery life", this.batteryLife + "hours"));
            }

            if (this.price != 0)
            {
                sb.Append(String.Format("{0, -15}|{1,-60:F2}|\n", "price", this.price + "lv."));
            }

            return sb.ToString();
        }
    }
}
