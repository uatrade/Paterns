using Decorator.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StarbucksCoffee
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("First Beverage");
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " = " + beverage.Cost());

            Console.WriteLine("\nSecond Beverage");
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription());
            beverage2 = new Milk(beverage2);
            Console.WriteLine(beverage2.GetDescription()+ " = " + beverage2.Cost());

            Console.WriteLine("\nThird Beverage");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new DarkRoast();
            beverage3 = new Milk(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " = " + beverage3.Cost());



            Console.ReadKey();
        }
    }
}
