using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of various shapes.
            Square square1 = new Square(8);
            Rectangle rectangle1 = new Rectangle(3, 6);
            Trapez trapez1 = new Trapez(14, 13, 12, 13);
            Paralleogram parallelogram1 = new Paralleogram(6, 8, 23);
            Triangle triangle1 = new Triangle(7, 9);

            // Create a list of shapes and add the instances.
            List<Shape> shapelist = new List<Shape>();
            shapelist.Add(square1);
            shapelist.Add(rectangle1);
            shapelist.Add(trapez1);
            shapelist.Add(parallelogram1);
            shapelist.Add(triangle1);

            // Iterate through the list of shapes and output their type, perimeter, and area.
            foreach (Shape i in shapelist)
            {
                Console.WriteLine("\n");
                Console.WriteLine(i.GetType().Name);
                Console.WriteLine(i.Perimeter().ToString("F2"));
                Console.WriteLine(i.Area().ToString("F2"));
            }
        }
    }
}
