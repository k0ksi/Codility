using System;

namespace MaxCounters
{
    class MaxCounters
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }));
        }
    }

    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] counter = new int[N];
            int max = -1;
            int currentMin = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] >= 1 && A[i] <= N)
                {
                    if (counter[A[i] - 1] < currentMin)
                        counter[A[i] - 1] = currentMin;

                    counter[A[i] - 1] = counter[A[i] - 1] + 1;

                    if (counter[A[i] - 1] > max)
                        max = counter[A[i] - 1];
                }
                else if (A[i] == N + 1)
                {
                    currentMin = max;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (counter[i] < currentMin)
                    counter[i] = currentMin;
            }

            return counter;
        }

        //public int[] solution(int N, int[] A)
        //{
        //    int iterationsCount = N;

        //    int[] nums = new int[iterationsCount];

        //    int currentMaxCounter = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        int num = A[i];

        //        if (num > N)
        //        {
        //            for (int j = 0; j < nums.Length; j++)
        //            {
        //                nums[j] = currentMaxCounter;
        //            }
        //        }
        //        else
        //        {
        //            int currentValue = nums[num - 1] + 1;
        //            if (currentValue > currentMaxCounter)
        //            {
        //                currentMaxCounter = currentValue;
        //            }

        //            nums[num - 1]++;
        //        }
        //    }

        //    return nums;
        //}
    }
}
