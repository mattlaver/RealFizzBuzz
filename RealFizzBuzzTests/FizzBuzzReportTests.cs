using RealFizzBuzz;
using Xunit;

namespace RealFizzBuzzTests
{
    public class FizzBuzzReportTests
    {
        private const string LuckyTranslation = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz";

        [Fact]
        public void ShouldOutputTranslatedNumbersWithDelimiter()
        {
            const string expected = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz";
            var fizzbuzz = new FizzBuzz();
            var fizzBuzzOutput = new FizzBuzzReport(fizzbuzz);

            var result = fizzBuzzOutput.PrintRange(1, 20);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldOutputTranslatedLuckyNumbersWithDelimiter()
        {
            var fizzbuzz = new LuckyFizzBuzzDecorator(new FizzBuzz());
            var fizzBuzzReport = new FizzBuzzReport(fizzbuzz);

            var result = fizzBuzzReport.PrintRange(1, 20);

            Assert.Equal(LuckyTranslation, result);
        }

        [Fact]
        public void ShouldCorrectlyAppendFormatStatistics()
        {
            const string expected = LuckyTranslation + "fizz: 4\r\nbuzz: 3\r\nfizzbuzz: 1\r\nlucky: 2\r\ninteger: 10\r\n";

            var fizzbuzz = new FizzBuzzStatsDecorator(new LuckyFizzBuzzDecorator(new FizzBuzz()));
            var fizzBuzzReport = new FizzBuzzReportWithStats(fizzbuzz);

            var result = fizzBuzzReport.PrintRange(1, 20);

            Assert.Equal(expected, result);
        }
    }
}