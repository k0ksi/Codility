using System;
using System.Collections;
using System.Collections.Generic;

namespace StoneWall
{
    class StoneWall
    {
        static void Main(string[] args)
        {
            var result = new Solution().solution(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });

            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int[] N)
        {
            Stack<int> stack = new Stack<int>();
            int blockCount = 0;
            for (int i = 0; i < N.Length; i++)
            {
                var elem = N[i];

                while(stack.Count != 0 && elem < stack.Peek())
                {
                    stack.Pop();
                    blockCount++;
                }

                if(stack.Count == 0 || elem > stack.Peek())
                {
                    stack.Push(elem);
                }
            }

            blockCount += stack.Count;

            return blockCount;
        }
    }
}
