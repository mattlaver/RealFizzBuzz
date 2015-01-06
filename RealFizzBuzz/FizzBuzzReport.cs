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

    public class FizzBuzzReportWithStats : FizzBuzzReport
    {
        public FizzBuzzReportWithStats(IFizzBuzz fizzBuzz)
            : base(fizzBuzz)
        {
        }

        public new string PrintRange(int start, int end)
        {
            var sb = new StringBuilder();
            sb.Append(base.PrintRange(start, end));

            var fizzBuzzStats = FizzBuzz as FizzBuzzStatsDecorator;
            if (fizzBuzzStats != null)
                sb.Append(PrintStats(fizzBuzzStats));

            return sb.ToString();
        }

        private string PrintStats(FizzBuzzStatsDecorator fizzBuzzStatsDecorator)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("fizz: {0}", fizzBuzzStatsDecorator.Stats("fizz")));
            stringBuilder.AppendLine(string.Format("buzz: {0}", fizzBuzzStatsDecorator.Stats("buzz")));
            stringBuilder.AppendLine(string.Format("fizzbuzz: {0}", fizzBuzzStatsDecorator.Stats("fizzbuzz")));
            stringBuilder.AppendLine(string.Format("lucky: {0}", fizzBuzzStatsDecorator.Stats("lucky")));
            stringBuilder.AppendLine(string.Format("integer: {0}", fizzBuzzStatsDecorator.Stats("integer")));
            return stringBuilder.ToString();
        }
    }
}