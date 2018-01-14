using System;
using System.Collections.Generic;

namespace EquiLeader
{
    class EquiLeader
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 4, 3, 4, 4, 4, 2 };
            Console.WriteLine(new Solution().solution(A));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            Stack<int> stack = new Stack<int>();
                            
            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if (stack.Count == 0)
                {
                    stack.Push(current);
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
            }

            // 4, 3, 4, 4, 4, 2
            int equileadersCounter = 0;
            int leadersCountSoFar = 0;
            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if (current == leader)
                {
                    leadersCountSoFar++;
                }

                if(leadersCountSoFar > (i + 1) / 2 &&
                   count - leadersCountSoFar > (n - i - 1) / 2)
                {
                    equileadersCounter++;
                }
            }

            return equileadersCounter;
        }
    }
}
