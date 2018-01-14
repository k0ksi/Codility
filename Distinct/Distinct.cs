using System;

namespace Distinct
{
    class Distinct
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 0, 0, 4, 2, 4, 5 };
            //int length = array.Length;
            //int[] counterArray = new int[length + 1];

            //for (int i = 0; i < length; i++)
            //{
            //    counterArray[array[i]]++;
            //}

            //int[] nums = new int[] { 1, 2, 3, 4 };

            //int length = nums.Length;
            //int[] sums = new int[length + 1];
            //for (int i = 1; i <= length; i++)
            //{
            //    sums[i] = nums[i - 1] + sums[i - 1];
            //}

            int[] nums = new int[] { 2, 3, 7, 5, 1, 3, 9 };


            int[] arr = new int[] { 2, 1, 1, 2, 3, 1 };

            var result = new Solution().solution(arr);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int[] numbers = A;
            Array.Sort(numbers);
            int length = numbers.Length;

            int counter = 0;

            for (int i = 1; i < length; i++)
            {
                if(numbers[i] != numbers[i - 1])
                {
                    counter++;
                }
            }

            if(length != 0)
            {
                counter += 1;
            }

            return counter;
        }
    }
}
