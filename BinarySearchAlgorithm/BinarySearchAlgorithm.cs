using System;

namespace BinarySearchAlgorithm
{
    class BinarySearchAlgorithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 11));
        }
    }

    public class Solution
    {
        public int solution(int[] array, int x)
        {
            int n = array.Length;
            int begin = 0;
            int end = n - 1;
            int result = -1;

            while (begin <= end)
            {
                int mid = (begin + end) / 2;
                if(array[mid] <= x)
                {
                    begin = mid + 1;
                    result = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }
}
