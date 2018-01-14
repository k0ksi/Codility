using System;

namespace CountFactors
{
    class CountFactors
    {
        static void Main(string[] args)
        {
            // 2147483646
            int n = 24;
            Console.WriteLine(new Solution().solution(24));
            Console.WriteLine(2147395600);
            Console.WriteLine(int.MaxValue);
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            int numFactors = 0;
            for (int i = 1; i <= (double)Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i != N)
                    {
                        numFactors = numFactors + 2;
                    }
                    else if (i * i == N)
                    {
                        numFactors = numFactors + 1;
                    }
                }
            }
            return numFactors;
        }
    }
}
