using System;
using System.Collections;

namespace StacksQueuesCodility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, 1, 0, 1, 1 };

            var result = new Solution().solution(arr);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;
            int size = 0;
            int n = A.Length;
            
            if(n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int action = A[i];

                    if(action == 0)
                    {
                        size++;
                    }
                    else
                    {
                        size--;
                        result = Math.Max(result, -size);
                    }
                }
            }

            return result;
        }
    }
}
