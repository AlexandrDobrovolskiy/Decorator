using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Espresso();
            coffee = new Milk(coffee);
            coffee = new Mocha(coffee);
            coffee = new Whip(coffee);

            Console.WriteLine($"The beverage is {coffee.Description} it's cost is : {coffee.Cost()}$");
            Console.ReadKey();
        }
    }
}
