using System;

namespace MinAbsSum
{
    class MinAbsSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution()
                .solution(
                    new int[] { 1, 5, 2, -2 }
                ));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int max = 0;
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Math.Abs(A[i]);
                max = Math.Max(max, A[i]);
                total += A[i];
            }
            int[] counts = new int[max + 1];
            foreach (int number in A)
            {
                counts[number]++;
            }
            bool[] reaches = new bool[total / 2 + 1];
            reaches[0] = true;
            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    int[] remains = new int[reaches.Length];
                    for (int j = 0; j < remains.Length; j++)
                    {
                        if (reaches[j])
                        {
                            remains[j] = counts[i];
                        }
                        else
                        {
                            remains[j] = -1;
                        }
                    }
                    for (int j = 0; j < remains.Length; j++)
                    {
                        if (remains[j] > 0 && j + i < remains.Length)
                        {
                            remains[j + i] = Math.Max(remains[j + i],
                                    remains[j] - 1);
                        }
                    }
                    for (int j = 0; j < remains.Length; j++)
                    {
                        if (remains[j] >= 0)
                        {
                            reaches[j] = true;
                        }
                    }
                }
            }
            for (int i = reaches.Length - 1; ; i--)
            {
                if (reaches[i])
                {
                    return total - i - i;
                }
            }
        }
    }
}
