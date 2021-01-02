using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfunc.ch1
{
    static class Composition
    {
        // Listing 2.3 Compose function in C#
        static Func<A, C> Compose<A, B, C>(this Func<A, B> f, Func<B, C> g) => (n) => g(f(n));

        static Func<CoffeeBeans, CoffeeGround> grindCoffee = coffeeBeans => new CoffeeGround(coffeeBeans);
        static Func<CoffeeGround, Espresso> brewCoffee = coffeeGround => new Espresso(coffeeGround);


        public static void Run()
        {
            CoffeeBeans coffeeBeans = new CoffeeBeans();
            
            ////CoffeeGround coffeeGround = grindCoffee(coffeeBeans);
            ////Espresso espresso = brewCoffee(coffeeGround);

            //// Shows the bad function composition that reads inside out
            Espresso espresso = brewCoffee(grindCoffee(coffeeBeans));

            Func<CoffeeBeans, Espresso> makeEspresso = grindCoffee.Compose(brewCoffee);
            Espresso espresso_new = makeEspresso(coffeeBeans);
        }
    }

    internal class Espresso
    {
        public Espresso(CoffeeGround ground)
        {
            
        }
    }

    internal class CoffeeGround
    {
        public CoffeeGround(CoffeeBeans beans)
        {
            
        }
    }

    internal class CoffeeBeans
    {
    }
}