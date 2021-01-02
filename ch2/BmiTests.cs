using System;
using Xunit;

namespace cfunc.ch2
{
    public class BmiTest
    {
        [Theory]
        [InlineData(77, 1.80, 23.77)]
        [InlineData(77, 1.60, 30.08)]
        public void CalculateBmiTest(double weight, double height, double expected)
        {
            var result = Bmi.CalculateBmi(weight, height);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BmiCalcTest()
        {
            var str = string.Empty;
            Func<string, double> readtest = i => i == "Enter weight" ? 77 : 1.80;
            Action<string> writetest = i => str = i;

            Bmi.BmiCalc(readtest, writetest);
            Assert.Equal("The calculated bmi is 23.77", str);
        }
        
    }
}
