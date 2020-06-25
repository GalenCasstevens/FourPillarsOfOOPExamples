using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
