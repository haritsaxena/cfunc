using System;
namespace cfunc.ch3
{
    public static class DayWeek {


        public static void Run() {
            
            var friday = Enum.Parse<DayOfWeek>("Friday");
            Console.WriteLine(friday);
        }

        
    }

    
}

namespace Option
   {
      public struct None
      {
         internal static readonly None Default = new None();
      }

      public struct Some<T>
      {
         internal T Value { get; }

         internal Some(T value)
         {
            if (value == null)
               throw new ArgumentNullException(nameof(value)
                  , "Cannot wrap a null value in a 'Some'; use 'None' instead");
            Value = value;
         }
      }
   }
