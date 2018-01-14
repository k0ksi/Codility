using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfDiscIntersections
{
    class NumberOfDiscIntersections
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 2, 1, 4, 0 };

            var array = new Solution().solution(arr);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int l = A.Length;

            long[] A1 = new long[l];
            long[] A2 = new long[l];

            for (int i = 0; i < l; i++)
            {
                A1[i] = (long)A[i] + i;
                A2[i] = -((long)A[i] - i);
            }

            Array.Sort(A1);
            Array.Sort(A2);

            long cnt = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                int pos = Array.BinarySearch(A2, A1[i]);
                if (pos >= 0)
                {
                    while (pos < A.Length && A2[pos] == A1[i])
                    {
                        pos++;
                    }
                    cnt += pos;
                }
                else
                { // element not there
                    int insertionPoint = -(pos + 1);
                    cnt += insertionPoint;
                }

            }

            long sub = (long)l * ((long)l + 1) / 2;
            cnt = cnt - sub;

            if (cnt > 1e7) return -1;

            return (int)cnt;
        }
    }
}
