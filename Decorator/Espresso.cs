using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso coffee";
        }

        public override double Cost()
        {
            return 1.25;
        }
    }
}
