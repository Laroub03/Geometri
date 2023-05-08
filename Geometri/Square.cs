using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This class represents a square, inheriting from the Shape class.
    public class Square : Shape
    {
        // Constructor to initialize the side length of the square.
        public Square(double side) : base(side)
        {
            sideA = side;
        }

        // Calculates the perimeter of the square.
        public override double Perimeter()
        {
            return sideA * 4;
        }

        // Calculates the area of the square.
        public override double Area()
        {
            return sideA * sideA;
        }
    }

}
