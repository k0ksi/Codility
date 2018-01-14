using System;
using System.Collections.Generic;
using System.Linq;

namespace AbsDistinct
{
    class AbsDistinct
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { int.MinValue, -5, -3, -1, 0, 3, 6  }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            long[] array = new long[n];
            
            for (int i = 0; i < n; i++)
            {
                array[i] = Math.Abs(Convert.ToInt64(A[i]));
            }

            return array.Distinct().Count();
        }
    }
}
