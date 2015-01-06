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
}