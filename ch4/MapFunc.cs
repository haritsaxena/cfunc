using System;
using cfunc.shared;
using LaYumba.Functional;
using LaYumba.Functional.Option;

namespace cfunc.ch4
{
    public static class MapFunc
    {

        public static void Run()
        {
            // Map => Take a collection and a function and apply it to each element
            Func<Apple, ApplePie> makePie = apple => new ApplePie(apple);

            Option<Apple> full = F.Some(new Apple());
            Option<Apple> empty = F.None;

            var somepie =  full.Map(makePie);
            somepie.WriteLines();

            var emptypie = empty.Map(makePie);
            emptypie.WriteLines();
        }

        public class Apple
        {
        }

        public class ApplePie
        {
            public ApplePie(Apple apple)
            {

            }
        }
    }

    


}
