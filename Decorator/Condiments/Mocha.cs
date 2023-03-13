using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage Beverage { get; set; }

        public Mocha(Beverage beverage) {
            this.Beverage = beverage;   
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() +", Mocha";
        }

        public override double Cost()
        {
            return .15 + Beverage.Cost();
        }

    }
}
