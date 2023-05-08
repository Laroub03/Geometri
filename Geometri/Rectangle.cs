using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This class represents a rectangle, inheriting from the Shape class.
    public class Rectangle : Shape
    {
        // Private field to store the length of side B.
        private double sideB;

        // Constructor to initialize the side lengths of the rectangle.
        public Rectangle(double sideA, double b) : base(sideA)
        {
            sideB = b;
        }

        // Calculates the perimeter of the rectangle.
        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        // Calculates the area of the rectangle.
        public override double Area()
        {
            return sideA * sideB;
        }
    }

}
