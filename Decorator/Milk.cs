using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Milk : CondimentDecorator
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            Description = beverage.Description + ", Milk";
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .33;
        }
    }
}
