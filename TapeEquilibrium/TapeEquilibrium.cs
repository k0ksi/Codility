using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    class TapeEquilibrium
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 1, 2 , 4, 3 };

            Console.WriteLine(new Solution().solution(arr));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int minSum = int.MaxValue;
            int currentMinSum = int.MaxValue;
            
            int firstSum = 0;
            int secondSum = 0;

            int allNumsSum = A.Sum();

            for (int i = 0; i < A.Length - 1; i++)
            {
                firstSum += (A[i]);
                
                secondSum = (allNumsSum - firstSum);

                int sum = Math.Abs(firstSum - secondSum);

                if (sum < currentMinSum)
                {
                    currentMinSum = sum;
                    if (currentMinSum < minSum)
                    {
                        minSum = currentMinSum;
                    }
                }
            }

            return minSum;
        }
    }
}
