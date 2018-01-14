using System;

namespace MaximumSliceProblem
{
    class MaximumSliceProblem
    {
        private static void Main()
        {
            int[] A = new int[] { 5, -7, 3, 5, -2, 4, -1 };
            Console.WriteLine(new Solution().linearSolution(A));
        }
    }

    class Solution
    {
        // O(n3)
        public int slowSolution(int[] A)
        {
            int n = A.Length;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int sum = 0;
                    for (int k = i; k < j + 1; k++)
                    {
                        sum += A[k];
                    }

                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        // O(n2)
        public int quadraticSolution(int[] A)
        {
            int n = A.Length;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += A[j];
                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        // 5, -7, 3, 5, -2, 4, -1
        // O(n)
        public int linearSolution(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int current = A[i];
                maxEnding = Math.Max(0, maxEnding + current);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
