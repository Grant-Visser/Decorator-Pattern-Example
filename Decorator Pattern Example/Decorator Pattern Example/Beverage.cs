using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Example
{
    public abstract class Beverage
    {
        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}
