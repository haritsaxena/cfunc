using System;
namespace cfunc.ch2
{
    public static class Bmi {
        ///private static Func<int, int, int> bmiCal => (wt, ht) => wt/ht*ht;

        public static double CalculateBmi(double wt, double ht) => Math.Round(wt/(ht*ht),2);

        public static double Read(string msg)
        {
            Console.WriteLine(msg);
            return double.Parse(Console.ReadLine());
        }
       
        public static void Write(string msg) => Console.WriteLine(msg);

        /// passing func makes this function testable.
        public static void BmiCalc(Func<string, double> read, Action<string> write)
        {
            double wt = read("Enter weight");
            double ht = read("Enter height");

            var bmi = CalculateBmi(wt, ht);
            write("The calculated bmi is " + bmi);
        }

        public static void Run()
        {
            // Console.WriteLine("Enter weight");
            // int wt = Int32.Parse(Console.ReadLine());        
            // Console.WriteLine("Enter height");
            // int ht = Int32.Parse(Console.ReadLine());        
            // var cal = bmiCal;
            // Console.WriteLine(cal(wt,ht));

            BmiCalc(Read, Write);
        }
    }

}