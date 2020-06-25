using System;

namespace Polymorphism
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
