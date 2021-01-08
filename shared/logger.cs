using System;
using System.Collections.Generic;
using LaYumba.Functional;

namespace cfunc.shared
{
    public static class logger
    {
        public static void WriteLines<T> (this IEnumerable<T> @this)
        {
            foreach (T item in @this)
                Console.WriteLine(item);
        }

        public static void WriteLines<T>(this Option<T> @this)
        {
            foreach (T item in @this.AsEnumerable())
                Console.WriteLine(item);
        }
    }
}


