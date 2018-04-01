using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Beverage
    {
        public string Description { get; set; }

        public abstract double Cost();
    }
}
