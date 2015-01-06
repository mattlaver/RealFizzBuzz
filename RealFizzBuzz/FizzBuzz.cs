using System.Globalization;

namespace RealFizzBuzz
{
    public interface IFizzBuzz
    {
        string Translate(int number);
    }

    public class FizzBuzz : IFizzBuzz
    {
        public string Translate(int number)
        {
            if ((number % 15) == 0)
                return "fizzbuzz";

            if ((number % 3) == 0)
                return "fizz";

            if ((number % 5) == 0)
                return "buzz";

            return number.ToString(CultureInfo.InvariantCulture);
        }
    }

    public abstract class FizzBuzzBase : IFizzBuzz
    {
        protected readonly IFizzBuzz FizzBuzz;

        protected FizzBuzzBase(IFizzBuzz fizzBuzz)
        {
            FizzBuzz = fizzBuzz;
        }

        public abstract string Translate(int number);
    }

    public class LuckyFizzBuzzDecorator : FizzBuzzBase
    {
        public LuckyFizzBuzzDecorator(IFizzBuzz fizzBuzz)
            : base(fizzBuzz)
        {
        }

        public override string Translate(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture).Contains("3") ? "lucky" : FizzBuzz.Translate(number);
        }
    }
}