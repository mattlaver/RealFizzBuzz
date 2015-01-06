using System;

namespace RealFizzBuzz
{
    class Program
    {
        static void Main()
        {
            // var fizzbuzz = new FizzBuzz(); // Step 1
            // var fizzbuzz = new LuckyFizzBuzzDecorator(new FizzBuzz()); // Step 2
            // var fizzBuzzReport = new FizzBuzzReport(fizzbuzz); // Step 1 & Step 2

            var fizzbuzz = new FizzBuzzStatsDecorator(new LuckyFizzBuzzDecorator(new FizzBuzz()));
            var fizzBuzzReport = new FizzBuzzReportWithStats(fizzbuzz);

            Console.WriteLine(fizzBuzzReport.PrintRange(1, 20));
            Console.ReadLine();
        }
    }
}
