using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
