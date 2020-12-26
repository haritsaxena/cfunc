using System;
using System.Linq;
using cfunc.shared;

namespace cfunc.ch1
{
    public static class Funcfactories
    {
        ////HOF
        ////HOFs are functions that take other functions as inputs or return a function as out-put, or both.
        static Func<int, bool> isMod(int n) => i => i % n == 0;

        static Func<bool, bool> negate = (bool input) => !input;

        static Func<int, int, int> divide = (x, y) => x / y;

        static Func<T2, T1, R> SwapArgs<T1, T2, R>(this Func<T1, T2, R> f) => (t2, t1) => f(t1, t2);

        static Func<T, bool> Negate<T>(Func<T, bool> pred) => t => !pred(t);
        ///HOF
        //// 1. Functions that depend on other functions
        //// 2. Adapter function (e.g swap args in book)
        //// 3. Functions that create other functions (IsMod above)

        public static void Run()
        {
            //var range = Enumerable.Range(1, 20);
            /// isMod and Where used as HOF
            //logger.WriteLines(range.Where(isMod(3)));

            ////bool x = true;
            //var output = negate(true);

            var divideBy = divide.SwapArgs();

            Console.WriteLine(divideBy(2, 10));

        }

        public static bool isSuccess(int number){
            return false;
        }
    }
}
