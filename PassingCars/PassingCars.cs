using System;
using System.Collections.Generic;

namespace PassingCars
{
    class PassingCars
    {
        static void Main(string[] args)
        {
            int a = 0 - 1;
            int b = 0 - 3;
            int[] arr = new int[] { 0, 1, 0, 1, 1 };

            var array = new Solution().solution(arr);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;

            int onesCount = 0;
            int zeroesCount = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] == 1)
                {
                    onesCount++;

                    if(onesCount >= zeroesCount)
                    {
                        result += zeroesCount;
                    }
                    else
                    {
                        result += zeroesCount;
                    }

                    continue;
                }
                else
                {
                    zeroesCount++;
                }
            }

            if(result > 1000000000 || result < -1000000000)
            {
                result = -1;
            }

            return result;
        }
    }
}
