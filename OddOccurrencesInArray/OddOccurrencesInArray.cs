using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    class OddOccurrencesInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 0, 500000 }));
        }
    }

    class Solution
    {
        public int solution(int[] nums)
        {
            Dictionary<int, int> occurences = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (occurences.ContainsKey(num) == true && occurences[num] == 1)
                {
                    occurences.Remove(num);
                }
                else
                {
                    occurences.Add(num, 1);
                }
            }

            foreach (var item in occurences)
            {
                return item.Key;
            }

            return 0;
        }
    }
}
