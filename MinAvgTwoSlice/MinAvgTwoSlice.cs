using System;
using System.Collections.Generic;

namespace MinAvgTwoSlice
{
    class MinAvgTwoSlice
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 4, 2, 2, 5, 1, 5, 8 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if(A.Length == 2)
            {
                return 0;
            }

            int minSliceTwo = A[0] + A[1];
            int minTwoIndex = 0;

            int minSliceThree = int.MaxValue;
            int minThreeIndex = 0;

            for (int i = 2; i < A.Length; i++)
            {
                int sliceTwo = A[i - 1] + A[i];
                if(sliceTwo < minSliceTwo)
                {
                    minSliceTwo = sliceTwo;
                    minTwoIndex = i - 1;
                }

                int sliceThree = sliceTwo + A[i - 2];
                if(sliceThree < minSliceThree)
                {
                    minSliceThree = sliceThree;
                    minThreeIndex = i - 2;
                }
            }

            int averageMinTwo = minSliceTwo * 3;
            int averageMinThree = minSliceThree * 2;

            if(averageMinTwo == averageMinThree)
            {
                return Math.Min(minTwoIndex, minThreeIndex);
            }
            else
            {
                return averageMinTwo < averageMinThree ? minTwoIndex : minThreeIndex;
            }
        }

        private double CalculateAvg(int sum, int divider)
        {
            double result = (double)sum / (double)divider;

            return result;
        }
    }
}
