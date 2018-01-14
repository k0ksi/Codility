using System;
using System.Collections.Generic;

namespace MaxDoubleSliceSum
{
    class MaxDoubleSliceSum
    {
        private static void Main()
        {
            int[] A = new int[] { 3, 2, 6, -1, 4, 5, -1, 2 };
            Console.WriteLine(new Solution().solution(A));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int[] k1 = new int[n];
            int[] k2 = new int[n];

            for (int i = 1; i < n - 1; i++)
            {
                k1[i] = Math.Max(k1[i - 1] + A[i], 0);
            }

            for (int i = n - 2; i > 0; i--)
            {
                k2[i] = Math.Max(k2[i + 1] + A[i], 0);
            }

            int max = 0;

            for (int i = 1; i < n - 1; i++)
            {
                max = Math.Max(max, k1[i - 1] + k2[i + 1]);
            }

            return max;
        }
    }
}
