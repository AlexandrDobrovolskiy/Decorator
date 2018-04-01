using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend coffee";
        }
        
        public override double Cost()
        {
            return 1.99;
        }
    }
}
