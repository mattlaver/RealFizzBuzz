using System;

namespace RealFizzBuzz
{
    class Program
    {
        static void Main()
        {
            var fizzbuzz = new FizzBuzz();
            var fizzBuzzReport = new FizzBuzzReport(fizzbuzz);

            Console.WriteLine(fizzBuzzReport.PrintRange(1, 20));
            Console.ReadLine();

        }
    }
}
