using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Example
{
    class Milk:Decorator
    {
        public Milk(Beverage inputBeverage) : base(inputBeverage)
        {
            this.description = "Milk";
            this.cost = 5.00;
        }
    }

    class Whip : Decorator
    {
        public Whip(Beverage inputBeverage) : base(inputBeverage)
        {
            this.description = "Whip";
            this.cost = 8.00;
        }
    }

    class Caramel : Decorator
    {
        public Caramel(Beverage inputBeverage) : base(inputBeverage)
        {
            this.description = "Caramel";
            this.cost = 12.00;
        }
    }
}
