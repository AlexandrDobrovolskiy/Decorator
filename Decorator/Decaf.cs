using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
