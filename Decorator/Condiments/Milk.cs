using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        Beverage Beverage { get; set; }

        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;   
        }

        public override double Cost()
        {
           return 0.28 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }
    }
}
