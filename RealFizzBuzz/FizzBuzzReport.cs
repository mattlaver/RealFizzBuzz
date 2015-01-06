using System.Text;

namespace RealFizzBuzz
{
    public class FizzBuzzReport
    {
        protected readonly IFizzBuzz FizzBuzz;

        public FizzBuzzReport(IFizzBuzz fizzBuzz)
        {
            FizzBuzz = fizzBuzz;
        }

        public virtual string PrintRange(int start, int end)
        {
            var stringBuilder = new StringBuilder();
            var delimiter = string.Empty;
            for (var i = start; i <= end; i++)
            {
                stringBuilder.Append(delimiter);
                stringBuilder.Append(FizzBuzz.Translate(i));
                delimiter = " ";
            }
            return stringBuilder.ToString();
        }
    }
}