using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        private int _fuelLevel;
        private int _mileage;

        public Car()
        {
            _fuelLevel = 100;
            _mileage = 0;
        }

        public void Drive()
        {
            _fuelLevel--;
            _mileage++;
        }

        public void Refuel()
        {
            _fuelLevel++;
        }
    }
}
