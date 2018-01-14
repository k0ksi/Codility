using System;

namespace NumberSolitaire
{
    class NumberSolitaire
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution()
                .solution(
                    new int[] { 1, -2, 0, 9, -1, -2 }
                ));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // N //  N is an integer within the range [2..100,000];
            // A[] // each element of array A is an integer within the range [−10,000..10,000].
            int N = A.Length;
            int[] bestResult = new int[N]; // record the current bestResult
            for (int i = 0; i < bestResult.Length; i++)
            {
                bestResult[i] = int.MinValue;
            }

            // initialize
            bestResult[0] = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                // calculate six possible results every round
                for (int j = i + 1; (j < A.Length) && (i < A.Length) && j < (i + 1) + 6; j++)
                {
                    // compare
                    int preMaxResult = bestResult[j]; // the max number so far
                    int nowMaxResult = bestResult[i] + A[j]; // the max number at bestResult[i] + A[j]
                    bestResult[j] = Math.Max(preMaxResult, nowMaxResult);
                }
            }
            return bestResult[bestResult.Length - 1];
        }
    }
}
