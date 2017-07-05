using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Example
{
    public abstract class Decorator:Beverage
    {
        Beverage baseBeverage = null;
        protected string description = "Undefined decorator";
        protected double cost = 0.00;

        protected Decorator(Beverage input)
        {
            baseBeverage = input;
        }
        
        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", " + description;
        }

        public override double GetPrice()
        {
            return cost + baseBeverage.GetPrice();
        }
    }
}
