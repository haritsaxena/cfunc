using System;
using LaYumba.Functional;
using static LaYumba.Functional.F;

namespace cfunc.ch4
{
    public static class Person
    {

        public class Profile
        {
            public Option<Age> PersonAge { get; set; }

            public string Name { get; set; }

        }

        public struct Age
        {
            private int Value { get; }
            private Age(int value)
            {
                if (!IsValid(value))
                    throw new ArgumentException($"{value} is not a valid age");

                Value = value;
            }

            private static bool IsValid(int age)
                => 0 <= age && age < 120;

            public static Option<Age> Of(int age)
                => IsValid(age) ? Some(new Age(age)) : None;

            public static bool operator <(Age l, Age r) => l.Value < r.Value;
            public static bool operator >(Age l, Age r) => l.Value > r.Value;

            public static bool operator <(Age l, int r) => l < new Age(r);
            public static bool operator >(Age l, int r) => l > new Age(r);

            public override string ToString() => Value.ToString();
        }



        public static void Run()
        {
            //var sixteen = new Age(16);
            //var twentyfive = new Age(25);
            //Console.WriteLine(sixteen > twentyfive);

            Profile personProfile = new Profile {PersonAge = Age.Of(16), Name = "John"};




        }
    }
}
