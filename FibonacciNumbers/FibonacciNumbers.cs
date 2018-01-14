using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(new Solution().solution(41));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int[] fib = new int[n + 2];
            fib[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                var prev = fib[i - 1];
                var beforePrev = fib[i - 2];
                fib[i] = prev + beforePrev;
            }

            return fib[n];
        }
    }
}
