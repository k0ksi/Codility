using System;

namespace CountTriangles
{
    class CountTriangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 10, 2, 5, 1, 8, 12 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int ans = 0, n = A.Length;
            for (int i = 0; i < n - 2; i++)
            {
                int k = 0;  // k is init here
                for (int j = i + 1; j < n - 1; j++)
                {
                    while (k < n && A[i] + A[j] > A[k])
                    {
                        k++;
                    }
                    ans += k - j - 1;
                }
            }
            return ans;
        }
    }
}
