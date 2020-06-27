using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Plant
    {
        public void Photosynthesize()
        {
            GatherEnergyFromSun();
            ConvertEnergyToFood();
        }

        public void GatherEnergyFromSun()
        {
            // some logic to gather the sun's energy
        }

        public void ConvertEnergyToFood()
        {
            // some logic to convert the sun's energy into food
        }

        public void Reproduce()
        {
            // some logic for plant reproduction
        }
    }
}
