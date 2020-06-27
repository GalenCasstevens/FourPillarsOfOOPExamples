using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectanlge = new Rectangle() { Length = 2, Width = 7 };
            rectanlge.CalculatePerimeter();
        }
    }
}
