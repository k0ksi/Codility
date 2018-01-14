using System;
using System.Collections.Generic;

namespace MissingInteger
{
    class MissingInteger
    {
        static void Main(string[] args)
        {
            int a = 0 - 1;
            int b = 0 - 3;
            int[] arr = new int[] { 1, 2, 3 };

            var array = new Solution().solution(arr);
            Console.WriteLine(array);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 1;

            HashSet<int> nums = new HashSet<int>(A);

            if(nums.Count == 1)
            {
                result = A[0] == 1 ? result = 2 : 1;
            }
            else
            {
                int lookFor = 1;
                bool found = false;

                while (true)
                {
                    if (found)
                    {
                        break;
                    }
                    
                    if (!nums.Contains(lookFor))
                    {
                        found = true;
                        result = lookFor;
                        break;
                    }

                    lookFor++;
                }
            }            

            return result;
        }
    }
}
