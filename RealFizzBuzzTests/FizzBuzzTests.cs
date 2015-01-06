using RealFizzBuzz;
using Xunit;
using Xunit.Extensions;

namespace RealFizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "fizz")]
        [InlineData(5, "buzz")]
        [InlineData(15, "fizzbuzz")]
        public void ShouldTranslateAGivenPositiveNumberCorrectly(int number, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Translate(number);

            Assert.Equal(expected, result);
        }
    }
}
