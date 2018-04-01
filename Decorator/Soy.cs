using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Soy : CondimentDecorator
    {
        private Beverage beverage;
        
        public Soy(Beverage beverage)
        {
            Description = beverage.Description + ", Soy";
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .50;
        }
    }
}
