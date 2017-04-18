using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Box
{
    class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Box(decimal length, decimal width, decimal height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;  
                
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;

            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;

            }
        }

        public decimal GetSurfaceArea()
        {
            decimal area = 2*this.Length*this.Width + 2*this.Length*this.Height + 2*this.Width*this.Height;

            return area;
        }

        public decimal GetLateralSurfaceArea()
        {
            decimal area = 2*this.Length*this.Height + 2*this.Width*this.Height;

            return area;
        }

        public decimal GetVolume()
        {
            decimal area = this.Length*this.Height*this.Width;

            return area;
        }
    }
}
