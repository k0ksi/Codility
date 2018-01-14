using System;
using System.Collections.Generic;

namespace CatterpillarMethod
{
    class CatterpillarMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 6, 2, 3, 6, 7, 4, 1 }, 12));
        }
    }

    class Solution
    {
        public bool solution(int[] A, int s)
        {
            int n = A.Length;
            int front = 0;

            for (int i = 0; i < n; i++)
            {
                int total = 0;
                int back = A[i];

                while (front < n && total + A[front] <= s)
                {
                    total += A[front];
                    front += 1;
                }

                if(total == s)
                {
                    return true;
                }

                total -= A[back];
            }

            return false;
        }
    }
}
