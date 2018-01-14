using System;
using System.Linq;

namespace BinaryGap
{
    class BinaryGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(1041));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            string binary = Convert.ToString(n, 2);

            int result = binary
                .Trim('0')
                .Split(new[] { '1' })
                .Max(x => x.Length);

            return result;
        }
    }
}
