using System;

namespace ChocolatesByNumbers
{
    class ChocolatesByNumbers
    {
        private static void Main()
        {
            Console.WriteLine(new Solution().solution(10, 4));
        }
    }

    class Solution
    {
        public int solution(int N, int M)
        {
            //int leastCommonMultiple = N * M / Gcd(N, M);

            return N / Gcd(N, M);
        }

        private int Gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return Gcd(b, a % b);
            }
        }
    }
}
