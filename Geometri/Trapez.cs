using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    // This class represents a trapezoid, inheriting from the Shape class.
    public class Trapez : Shape
    {
        // Private fields to store the lengths of sides B, C, and D.
        private double sideB;
        private double sideC;
        private double sideD;

        // Constructor to initialize the side lengths of the trapezoid.
        public Trapez(double a, double b, double c, double d) : base(a)
        {
            if (a < c)
            {
                sideC = a;
                sideA = c;
            }
            else { sideC = c; }
            sideB = b;
            sideD = d;
        }

        // Calculates the perimeter of the trapezoid.
        public override double Perimeter()
        {
            return sideA + sideB + sideC + sideD;
        }

        // Calculates the area of the trapezoid.
        public override double Area()
        {
            return 0.5 * (sideA + sideC) * HeightCal(SemiCal());
        }

        // Calculates the semi-perimeter (half the perimeter) for the trapezoid.
        public double SemiCal()
        {
            double s = (sideA + sideB - sideC + sideD) / 2;

            return s;
        }

        // Calculates the height of the trapezoid.
        public double HeightCal(double s)
        {
            double h = ((sideA - sideC) / 2) * Math.Sqrt(s * (s - sideA + sideC) * (s - sideB) * (s - sideD));

            return h;
        }
    }

}
