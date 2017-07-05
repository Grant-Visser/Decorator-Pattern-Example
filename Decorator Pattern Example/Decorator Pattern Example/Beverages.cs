using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Example
{
    class Decaf: Beverage
    {
        private string description = "Decaf";
        private double cost = 19.95;

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return cost;
        }
    }

    class HouseBlend : Beverage
    {
        private string description = "House Blend";
        private double cost = 16.95;

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return cost;
        }
    }

    class Espresso : Beverage
    {
        private string description = "Espresso";
        private double cost = 21.95;

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return cost;
        }
    }
}
