using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffe = new Espresso();
            coffe = new Milk(coffe);
            coffe = new Mocha(coffe);
            coffe = new Whip(coffe);

            Console.WriteLine($"The beverage is {coffe.Description} it's cost is : {coffe.Cost()}$");
            Console.ReadKey();
        }
    }
}
