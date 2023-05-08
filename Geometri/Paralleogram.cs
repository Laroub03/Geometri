using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This class represents a parallelogram, inheriting from the Shape class.
    public class Paralleogram : Shape
    {
        // Private fields to store the length of side B and the angle between sides A and B.
        private double sideB;
        private double angle;

        // Constructor to initialize the side lengths and angle of the parallelogram.
        public Paralleogram(double a, double b, double v) : base(a)
        {
            sideB = b;
            angle = v;
        }

        // Calculates the perimeter of the parallelogram.
        public override double Perimeter()
        {
            return (sideA + sideB) * 2;
        }

        // Calculates the area of the parallelogram.
        public override double Area()
        {
            return sideA * sideB * Math.Sin(angle);
        }
    }

}

