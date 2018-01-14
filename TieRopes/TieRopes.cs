using System;

namespace TieRopes
{
    class TieRopes
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution()
                .solution(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }));
        }
    }

    class Solution
    {
        public int solution(int K, int[] A)
        {
            int count = 0;

            int length = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int rope = A[i];
                length += rope;

                if (length >= K)
                {
                    count++;
                    length = 0;
                }
            }

            return count;
        }
    }
}
