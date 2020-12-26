using System;
using System.Collections.Generic;

namespace cfunc.shared
{
    public static class logger
    {
        public static void WriteLines<T> (this IEnumerable<T> @this)
        {
            foreach (T item in @this)
                Console.WriteLine(item);
        }
    }
}


