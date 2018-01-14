using System;

namespace CountSemiprimes
{
    class CountSemiprimes
    {
        private static void Main()
        {
            int[] P = new int[] { 1, 4, 16 };
            int[] Q = new int[] { 26, 10, 20 };
            Console.WriteLine(new Solution().solution(26, P, Q));
        }
    }

    class Solution
    {
        public int[] solution(int N, int[] P, int[] Q)
        {
            int[] F = new int[N + 1];
            for (int a = 1; a < F.Length; a++)
            {
                F[a] = 0;
            }
            int i = 2;
            while (i * i <= N)
            {
                if (F[i] == 0)
                {
                    int k = i * i;
                    while (k <= N)
                    {
                        if (F[k] == 0)
                            F[k] = i;
                        k += i;
                    }
                }
                i++;
            }

            int[] semiPrimSum = new int[N + 1];
            for (int j = 1; j <= N; j++)
            {
                semiPrimSum[j] = semiPrimSum[j - 1];
                if (IsSemiPrim(j, F))
                {
                    semiPrimSum[j] += 1;
                }
            }

            int[] ret = new int[P.Length];
            for (int j = 0; j < P.Length; j++)
            {
                ret[j] = semiPrimSum[Q[j]] - semiPrimSum[P[j] - 1];
            }

            return ret;
        }

        private bool IsSemiPrim(int num, int[] F)
        {
            if (F[num] == 0) return false;
            return F[num / F[num]] == 0;
        }


        private int SieveOfErathosthenes(int start, int n)
        {
            bool[] sieve = new bool[n + 1];

            sieve[0] = false;
            sieve[1] = false;
            int i = start;
            int result = 0;
            while (i * i <= n)
            {
                if (sieve[i])
                {
                    int k = i * i;

                    while (k <= n)
                    {
                        sieve[k] = false;

                        k += i;
                    }
                }

                double num = Math.Sqrt(i);
                if(num % 1 == 0) // check if the number is an integer
                {
                    int number = (int)num;
                    if (sieve[number])
                    {
                        result++;
                    }
                }

                i++;
            }

            return result;
        }
    }
}
