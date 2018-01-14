using System;

namespace CountDiv
{
    class CountDiv
    {
        static void Main(string[] args)
        {
            int result = new Solution().solution(11, 345, 17);

            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int A, int B, int K)
        {
            int offsetForLeftRange = 0;

            if(A % K == 0)
            {
                ++offsetForLeftRange;
            }

            return B / K - A / K + offsetForLeftRange;
        }
    }
}
