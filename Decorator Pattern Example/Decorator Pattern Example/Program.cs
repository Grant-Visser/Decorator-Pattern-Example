//https://www.codeproject.com/Articles/479635/UnderstandingplusandplusImplementingplusDecoratorp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//

namespace Decorator_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        { 
            HouseBlend hb = new HouseBlend();
            Console.Out.WriteLine(hb.GetDescription());
            Console.Out.WriteLine(hb.GetPrice());

            Whip hbw = new Whip(hb);
            Console.Out.WriteLine(hbw.GetDescription());
            Console.Out.WriteLine(hbw.GetPrice());

            Milk hbwm = new Milk(hbw);
            Console.Out.WriteLine(hbwm.GetDescription());
            Console.Out.WriteLine(hbwm.GetPrice());

            Caramel hbwmc = new Caramel(hbwm);
            Console.Out.WriteLine(hbwmc.GetDescription());
            Console.Out.WriteLine(hbwmc.GetPrice());

            Console.Out.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
