using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;
        public Whip(Beverage beverage)
        {
            Description = beverage.Description + ", Whip";
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.35;
        }
    }
}
