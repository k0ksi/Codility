using System;
using System.Collections.Generic;

namespace MaxSliceSum
{
    class MaxSliceSum
    {
        private static void Main()
        {
            int[] A = new int[] { 3, 2, -6, 4, 0 };
            Console.WriteLine(new Solution().solution(A));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int maxEnding = A[0];
            int maxSlice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                int current = A[i];
                int prev = A[i - 1];
                maxEnding = Math.Max(current, maxEnding + current);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
