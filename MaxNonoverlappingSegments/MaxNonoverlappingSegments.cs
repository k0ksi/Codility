using System;

namespace MaxNonoverlappingSegments
{
    class MaxNonoverlappingSegments
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution()
                .solution(new int[] { 1, 3, 7, 9, 9 }, new int[] { 5, 6, 8, 9, 10 }));
        }
    }

    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            int n = A.Length;
            if(n < 1)
            {
                return 0;
            }

            int count = 1;
            int lastFinish = B[0];

            for (int i = 1; i < n; i++)
            {
                int currentStart = A[i];
                if(currentStart > lastFinish)
                {
                    count++;
                    lastFinish = B[i];
                }
            }

            return count;
        }
    }
}
