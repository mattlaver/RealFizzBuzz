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

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "lucky")]
        [InlineData(5, "buzz")]
        [InlineData(13, "lucky")]
        [InlineData(15, "fizzbuzz")]
        public void ShouldOverrideMultiplesOf3WithLucky(int number, string expected)
        {
            var fizzbuzz = new LuckyFizzBuzzDecorator(new FizzBuzz());

            var result = fizzbuzz.Translate(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldCorrectlyCalculateStatisticalSpread()
        {
            var fizzbuzz = new FizzBuzzStatsDecorator(new LuckyFizzBuzzDecorator(new FizzBuzz()));

            for (var i = 1; i <= 20; i++)
                fizzbuzz.Translate(i);

            var fizzCount = fizzbuzz.Stats("fizz");
            var buzzCount = fizzbuzz.Stats("buzz");
            var fizzbuzzCount = fizzbuzz.Stats("fizzbuzz");
            var luckyCount = fizzbuzz.Stats("lucky");
            var integerCount = fizzbuzz.Stats("integer");

            Assert.Equal(4, fizzCount);
            Assert.Equal(3, buzzCount);
            Assert.Equal(1, fizzbuzzCount);
            Assert.Equal(2, luckyCount);
            Assert.Equal(10, integerCount);
        }   
    }
}
