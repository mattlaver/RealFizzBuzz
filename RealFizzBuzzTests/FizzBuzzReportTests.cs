using RealFizzBuzz;
using Xunit;

namespace RealFizzBuzzTests
{
    public class FizzBuzzReportTests
    {
        [Fact]
        public void ShouldOutputTranslatedNumbersWithDelimiter()
        {
            const string expected = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz";
            var fizzbuzz = new FizzBuzz();
            var fizzBuzzOutput = new FizzBuzzReport(fizzbuzz);

            var result = fizzBuzzOutput.PrintRange(1, 20);

            Assert.Equal(expected, result);
        } 
    }
}