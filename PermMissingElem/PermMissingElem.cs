using System;

namespace PermMissingElem
{
    class PermMissingElem
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2 };

            Console.WriteLine(new Solution().solution(array));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            int result = -1;

            if (A.Length == 0)
            {
                return 1;
            }

            if(A.Length == 1)
            {
                return A[0] == 1 ? 2 : 1;
            }
            
            for (int i = 0; i < A.Length; i++)
            {
                int num = i + 1;

                if(num != A[i])
                {
                    result = num;
                    break;
                }
            }          

            if(result == -1)
            {
                result = A[A.Length - 1] + 1;
            }

            return result;
        }
    }
}
