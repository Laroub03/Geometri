using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This is the abstract Shape class, which defines common properties and methods for all geometric shapes.
    public abstract class Shape
    {
        // Protected field to store the length of side A.
        protected double sideA;

        // Constructor to initialize side A.
        public Shape(double a)
        {
            sideA = a;
        }

        // Abstract method to calculate the perimeter of the shape.
        public abstract double Perimeter();

        // Abstract method to calculate the area of the shape.
        public abstract double Area();
    }
}
