using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class OakTree : Plant
    {
        private bool _hasBark = true;
        private bool _hasTrunk = true;
        private bool _hasBranches = true;

        public void ProduceWoodyTissue()
        {
            // some logic to produce woody tissue
        }
    }
}
