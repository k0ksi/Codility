using System;

namespace CountNonDivisible
{
    class CountNonDivisible
    {
        private static void Main()
        {
            int[] P = new int[] { 3, 1, 2, 3, 6 };
            Console.WriteLine(new Solution().solution(P));
        }
    }

    class Solution
    {
        public int[] solution(int[] A)
        {
            int N = A.Length << 1;
            int[] mark = new int[N + 1];
            for (int i = 0; i < A.Length; i++)
            {
                mark[A[i]]++;
            }

            int[] divisorCount = new int[N + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (mark[A[i]] > 0)
                {
                    int k = A[i];
                    while (k <= N)
                    {
                        divisorCount[k] += mark[A[i]];
                        k += A[i];
                    }
                    mark[A[i]] = 0;
                }
            }

            int[] ret = new int[A.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = A.Length - divisorCount[A[i]];
            }

            return ret;
        }
    }
}
