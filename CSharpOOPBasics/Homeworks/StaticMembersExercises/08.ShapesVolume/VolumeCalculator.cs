using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ShapesVolume
{
    class VolumeCalculator
    {
        public static double CalculateTrianglePrismVolume(double baseSide, double height, double length)
        {
            double volume = 0.5*length*baseSide*height;

            return volume;
        }

        public static double CalculateCubeVolume(double sideLength)
        {
            double volume = Math.Pow(sideLength, 3);

            return volume;
        }

        public static double CalculateCylinderVolume(double radius, double height)
        {
            double volume = Math.PI*Math.Pow(radius, 2)*height;

            return volume;
        }

    }
}
