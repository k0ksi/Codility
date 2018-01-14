using System;

namespace CoinChangingProblem
{
    class CoinChangingProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 1, 3, 4 }, 6));
        }
    }

    class Solution
    {
        public int solution(int[] C, int k)
        {
            return DynamicCoinChanging(C, k);
        }

        private int DynamicCoinChanging(int[] C, int k)
        {
            int n = C.Length;
            int[] dp = new int[k + 1];
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = C[i - 1]; j < k + 1; j++)
                {
                    dp[j] = Math.Min(dp[j - C[i - 1]] + 1, dp[j]);
                }
            }

            return 0;
        }
    }
}
