using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private int _energyLevel;
        private int _hungerLevel;
        private int _moodLevel;

        public Person()
        {
            _energyLevel = 30;
            _hungerLevel = 30;
            _moodLevel = 30;
        }

        public void Eat()
        {
            _energyLevel++;
            _hungerLevel--;
            _moodLevel++;
        }

        public void Run()
        {
            _energyLevel--;
            _hungerLevel++;
            _moodLevel++;
        }

        public void Sleep()
        {
            _energyLevel++;
            _hungerLevel++;
        }
    }
}
