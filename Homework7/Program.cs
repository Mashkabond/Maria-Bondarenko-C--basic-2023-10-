using System.Diagnostics;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                5, 10, 20
            };

            foreach (var number in numbers)
            {
                Start(number);
            }
        }

        static void Start(int number)
        {
            var watch = Stopwatch.StartNew();
            watch.Start();
            var result = FibonacciRecursive(number);
            watch.Stop();
            Console.WriteLine($"FibonacciRecursive({number}) = {result}, time = {watch.Elapsed}");

            watch.Restart();
            result = FibonacciLoop(number);
            watch.Stop();
            Console.WriteLine($"FibonacciLoop({number}) = {result}, time = {watch.Elapsed}");
        }

        static int FibonacciRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }

        static int FibonacciLoop(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            int previousValue = 0;
            int nextValue = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = previousValue + nextValue;
                previousValue = nextValue;
                nextValue = result;
            }

            return result;
        }
    }
}