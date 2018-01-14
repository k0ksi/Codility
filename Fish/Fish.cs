using System;
using System.Collections.Generic;
using System.Linq;

namespace Fish
{
    class Fish
    {
        static void Main(string[] args)
        {
            //int[] a = new int[] { 4, 3, 2, 1, 5 };
            //int[] b = new int[] { 0, 1, 0, 0, 0 };
            int[] a = new int[] { 8, 6, 5, 3, 2, 4, 7 };
            int[] b = new int[] { 1, 1, 1, 1, 1, 0, 0 };

            var result = new Solution().solution(a, b);

            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int size = A[i];
                int dir = B[i];

                if(s.Count == 0)
                {
                    s.Push(i);
                }
                else
                {
                    while(s.Count > 0 && dir - B[s.Peek()] == -1 && A[s.Peek()] < size)
                    {
                        s.Pop();
                    }

                    if(s.Count > 0)
                    {
                        if(dir - B[s.Peek()] != -1)
                        {
                            s.Push(i);
                        }                        
                    }
                    else
                    {
                        s.Push(i);
                    }
                }
            }

            return s.Count;
        }
    }
}
