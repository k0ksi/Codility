using System;
using System.Collections.Generic;

namespace Dominator
{
    class Dominator
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {  };
            Console.WriteLine(new Solution().solution(A));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            Stack<int> stack = new Stack<int>();
            int index = -1;
            int currentIndex = -1;

            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if (stack.Count == 0)
                {
                    stack.Push(current);
                    currentIndex = i;
                }
                else
                {
                    if (current != stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(current);
                    }
                }
            }

            int candidate = -1;

            if (stack.Count > 0)
            {
                candidate = stack.Peek();
            }

            int leader = -1;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if (current == candidate)
                {
                    count++;
                }
            }

            if (count > n / 2)
            {
                leader = candidate;
                index = currentIndex;
            }

            return index;
        }
    }
}
