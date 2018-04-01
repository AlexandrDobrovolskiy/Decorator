using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast coffee";
        }

        public override double Cost()
        {
            return 1.50;
        }
    }
}
