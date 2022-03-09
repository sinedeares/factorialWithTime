using System;
using System.Diagnostics;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var n = 10000;

            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                factorial *= i;
            Console.WriteLine("Факториал числа " + n + " = " + factorial);

            stopwatch.Stop();
            Console.WriteLine("Время работы программы в миллисекундах: " + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
