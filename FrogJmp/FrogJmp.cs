using System;

namespace FrogJmp
{
    class FrogJmp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(1, 5, 2));
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            decimal a = (decimal)(Y - X) / (decimal)D;

            var result = (int)Math.Ceiling(a);

            return result;
        }
    }
}
