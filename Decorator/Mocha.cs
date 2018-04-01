using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            Description = beverage.Description + ", Mocha";
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .21;
        }
    }
}
