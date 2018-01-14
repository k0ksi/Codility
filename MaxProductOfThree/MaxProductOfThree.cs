using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxProductOfThree
{
    class MaxProductOfThree
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -5, 5, -5, 4 };

            var array = new Solution().solution(arr);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int[] numbers = A;
            int n = numbers.Length;

            Array.Sort(numbers);
            
            int maxSumStart = numbers[n - 1] * numbers[0] * numbers[1];
            int maxSumEnd = numbers[n - 1] * numbers[n - 2] * numbers[n - 3];
            int maxSum = Math.Max(maxSumEnd, maxSumStart);

            return maxSum;
        }
    }
}
