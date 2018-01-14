using System;
using System.Collections.Generic;

namespace Flags
{
    class Flags
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(new Solution().solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            List<int> array = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    array.Add(i);
                }
            }
            if (array.Count == 1 || array.Count == 0)
            {
                return array.Count;
            }

            int flag = 1;
            int result = 1;
            while (flag <= array.Count)
            {
                bool success = false;
                int used = 0;
                int mark = array[0];
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] >= mark)
                    {
                        used++;
                        mark = array[i] + flag;

                        if (used == flag)
                        {
                            success = true;
                            break;
                        }
                    }
                }

                if (success)
                {
                    result = flag;
                    flag++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
