using System;

namespace DelegateAverage
{
    class Program
    {
        delegate int RandomDelegate();

        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => new Random().Next(1, 11);
            }

            Func<RandomDelegate[], double> avg = delegate (RandomDelegate[] arr)
            {
                double sum = 0;
                foreach (RandomDelegate del in arr)
                {
                    sum += del.Invoke();
                }
                return sum / arr.Length;
            };

            Console.WriteLine($"В середньому: {avg(delegates)}");

            Console.ReadLine();
        }
    }
}