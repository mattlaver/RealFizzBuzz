using System;

namespace RealFizzBuzz
{
    class Program
    {
        static void Main()
        {
            // var fizzbuzz = new FizzBuzz(); // Step 1
            var fizzbuzz = new LuckyFizzBuzzDecorator(new FizzBuzz());
            var fizzBuzzReport = new FizzBuzzReport(fizzbuzz);
            
            Console.WriteLine(fizzBuzzReport.PrintRange(1, 20));
            Console.ReadLine();

        }
    }
}
