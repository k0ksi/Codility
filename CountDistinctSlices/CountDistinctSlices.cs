using System;
using System.Collections.Generic;
using System.Linq;

namespace CountDistinctSlices
{
    class CountDistinctSlices
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(1, new int[] { int.MinValue, -5, -3, -1, 0, 3, 6 }));
        }
    }

    class Solution
    {
        public int solution(int M, int[] A)
        {
            int N = A.Length;
            // the counter array for every element in the array A
            int[] counters = new int[M + 1];
            int head = 0;
            int tail = 0;
            int result = 0;
            while (tail < N)
            {
                // find the most right end of the array for each tail
                while (head < N && counters[A[head]] != 2)
                {
                    counters[A[head]]++;
                    if (counters[A[head]] == 2)
                        break;
                    head++;
                }
                result += head - tail;
                if (result > 1000000000)
                    return 1000000000;
                // set the counter of the element before tail to be 0
                counters[A[tail]] = 0;
                tail++;
            }
            return result;
        }
    }
}
