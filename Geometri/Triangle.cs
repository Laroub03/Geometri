using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This class represents a triangle, inheriting from the Shape class.
    public class Triangle : Shape
    {
        // Private field to store the length of side B.
        private double sideB;

        // Constructor to initialize the side lengths of the right triangle.
        public Triangle(double a, double b) : base(a)
        {
            sideB = b;
        }

        // Calculates the perimeter of the triangle.
        public override double Perimeter()
        {
            return sideA + sideB + CCal();
        }

        // Calculates the area of the triangle.
        public override double Area()
        {
            return 0.5 * sideA * sideB;
        }

        // Calculates the length of side C (the hypotenuse) for the triangle.
        public double CCal()
        {
            double c = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return c;
        }
    }

}
