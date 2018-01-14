using System;

namespace PermCheck
{
    class PermCheck
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 3 };

            Console.WriteLine(new Solution().solution(arr));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 1;

            Array.Sort(A);

            if (A.Length == 0)
            {
                result = 1;
            }
            else if(A.Length == 1 && A[0] > 1)
            {
                result = 0;
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    int num = i + 1;

                    if (num != A[i])
                    {
                        result = 0;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
