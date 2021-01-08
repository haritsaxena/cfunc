using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using cfunc.shared;
using LaYumba.Functional;

namespace cfunc.ch3
{
    public static class ListLookup
    {
        static bool isOdd(int i) => i % 2 == 1;

        public static Option<T> Lookup<T>(this IEnumerable<T> items, Func<T, bool> condPredicate) 
        {
            try
            {
                var value = items.First(condPredicate);
                return F.Some(value);
            }
            catch (InvalidOperationException)
            {
                return F.None;
            }
        }

        public static void Run()
        {
            var nonelist = new List<int>().Lookup(isOdd);  // => None
            var somelist = new List<int> {1}.Lookup(isOdd);  // => Some(1)

            Console.WriteLine(nonelist.ToString());
            Console.WriteLine(somelist.ToString());
        }

    }
}
