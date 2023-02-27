using System;

namespace ArithmeticLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> sub = (a, b) => a - b;
            Func<int, int, int> mul = (a, b) => a * b;
            Func<int, int, double> div = (a, b) => b == 0 ? throw new DivideByZeroException() : (double)a / b;

            Console.WriteLine("Введіть два числа:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {add(num1, num2)}");
            Console.WriteLine($"Subtraction: {sub(num1, num2)}");
            Console.WriteLine($"Multiplication: {mul(num1, num2)}");
            Console.WriteLine($"Division: {div(num1, num2)}");

            Console.ReadLine();
        }
    }
}
