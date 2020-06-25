using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle() { Radius = 6 };
            var rectangle = new Rectangle() { Length = 3, Width = 4 };
            var square = new Square() { Side = 9 };

            var shapes = new List<IShape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Perimeter of {shape.ToString()}: {shape.CalculatePerimeter()}");
                Console.WriteLine($"Area of {shape.ToString()}: {shape.CalculateArea()}");
            }
        }
    }
}
