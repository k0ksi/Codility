using System;
using System.Collections.Generic;

namespace Leader
{
    class Leader
    {
        private static void Main()
        {
            int[] A = new int[] { 6, 6, 6, 6, 1, 1 };
            Console.WriteLine(FastestLeader(A));
        }

        // O(n)
        private static int FastestLeader(int[] A)
        {
            int n = A.Length;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if(stack.Count == 0)
                {
                    stack.Push(current);
                }
                else
                {
                    if(current != stack.Peek())
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

            if(stack.Count > 0)
            {
                candidate = stack.Peek();
            }

            int leader = -1;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if(current == candidate)
                {
                    count++;
                }
            }

            if(count > n / 2)
            {
                leader = candidate;
            }

            return leader;
        }

        // O(nlogn)
        private static int FasterLeader(int[] A)
        {
            int n = A.Length;
            int leader = -1;
            Array.Sort(A);
            int candidate = A[n / 2];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int current = A[i];
                if(current == candidate)
                {
                    count++;
                }
            }

            if(count > n / 2)
            {
                leader = candidate;
            }

            return leader;
        }

        // O(n2)
        private static int SlowLeader(int[] A)
        {
            int n = A.Length;
            int leader = -1;

            for (int i = 0; i < n; i++)
            {
                int candidate = A[i];
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    int current = A[j];
                    if (current == candidate)
                    {
                        count += 1;
                    }
                }

                if(count > n / 2)
                {
                    leader = candidate;

                    break;
                }
            }

            return leader;
        }
    }
}
