using System;
using LaYumba.Functional;
using LaYumba.Functional.Option;

namespace cfunc.ch3
{
    public static class DowEnum {

        private static Option<T> Parse<T>(this string day) where T : struct
        {
            return Enum.TryParse(day, out T result) ? F.Some(result) : F.None;
        }
        
        public static void Run() {
            
            var friday = "Frid11ay".Parse<DayOfWeek>();
            Console.WriteLine(friday);

        }

        
    }

    
}

