using System;
using System.Collections.Generic;

namespace Peaks
{
    class Peaks
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(new Solution().solution(new int[0]));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int N = A.Length;

            // Find all the peaks
            List<int> peaks = new List<int>();
            for (int i = 1; i < N - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) peaks.Add(i);
            }

            for (int size = 1; size <= N; size++)
            {
                if (N % size != 0) continue; // skip if non-divisible
                int find = 0;
                int groups = N / size;
                bool ok = true;
                // Find whether every group has a peak
                foreach(var peakIdx in peaks)
                {
                    if (peakIdx / size > find)
                    {
                        ok = false;
                        break;
                    }
                    if (peakIdx / size == find) find++;
                }
                if (find != groups) ok = false;
                if (ok) return groups;
            }
            return 0;
        }
    }
}
