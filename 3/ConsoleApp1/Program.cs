using System;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, double> avg = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3.0;
            };

            Console.WriteLine($"В середньому: {avg(4, 8, 12)}");

            Console.ReadLine();
        }
    }
}