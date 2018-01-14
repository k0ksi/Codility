using System;

namespace MinAbsSumOfTwo
{
    class MinAbsSumOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { -8, 4, 5, -10, 3 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            Array.Sort(A);
            int tail = 0;
            int head = n - 1;
            int minAbsSum = Math.Abs(A[tail] + A[head]);
            while (tail <= head)
            {
                int currentSum = A[tail] + A[head];
                minAbsSum = Math.Min(minAbsSum, Math.Abs(currentSum));

                if(currentSum <= 0)
                {
                    tail++;
                }
                else
                {
                    head--;
                }
            }

            return minAbsSum;
        }
    }
}
