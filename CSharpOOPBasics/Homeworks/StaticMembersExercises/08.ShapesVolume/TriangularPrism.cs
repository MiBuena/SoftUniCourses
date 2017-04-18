using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ShapesVolume
{
    class TriangularPrism
    {

        public TriangularPrism(double baseSide, double heightFromBaseSide, double length)
        {
            this.BaseSide = baseSide;
            this.HeightFromBaseSide = heightFromBaseSide;
            this.Length = length;
        }

        public double BaseSide { get; set; }
        public double HeightFromBaseSide { get; set; }
        public double Length { get; set; }

    }
}
