using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaYumba.Functional;
using Unit = System.ValueTuple;
using static System.Console;


namespace cfunc.ch4
{
    public static class Functor
    {
        public static IEnumerable<Unit> ForEach<T>
            (this IEnumerable<T> ts, Action<T> action)
            => ts.Map(action.ToFunc()).ToImmutableList();

        public static Option<Unit> ForEach<T>
            (this Option<T> opt, Action<T> action)
            => opt.Map(action.ToFunc());

        public static void Run()
        {
            new List<int> { 1, 2, 3 }.ForEach(Write);
            // prints: 123

            Enumerable.Range(1, 5).ForEach(Write);
        }
    }

}
