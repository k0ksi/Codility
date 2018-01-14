using System;

namespace MinPerimeterRectangle
{
    class MinPerimeterRectangle
    {
        static void Main(string[] args)
        {
            int n = 30;
            Console.WriteLine(new Solution().solution(n));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int minPerimeter = int.MaxValue;

            for (int i = 1; i * i <= n; i++)
            {
                if(n % i == 0)
                {
                    minPerimeter = Math.Min(minPerimeter, 2 * (n / i + i));
                }
            }

            return minPerimeter;
        }
    }
}
