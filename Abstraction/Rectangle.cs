using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculatePerimeter1()
        {
            return 2 * (Length + Width);
        }

        public double CalculatePerimeter2()
        {
            return Length + Length + Width + Width;
        }
    }
}
