using System;
using System.Linq;

namespace MinMaxDivision
{
    class MinMaxDivision
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(3, 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }));
        }
    }

    public class Solution
    {
        public int solution(int k, int m, int[] A)
        {
            return BinarySearch(A, k, m);
        }

        private int BinarySearch(int[] A, int k, int m)
        {
            int lowerBound = A.Max();
            int upperBound = A.Sum();

            if (k == 1) return upperBound;
            if (k >= A.Length) return lowerBound;

            while(lowerBound <= upperBound)
            {
                int midCandidate = (lowerBound + upperBound) / 2;
                if(BlockSizeIsValid(A, k, midCandidate))
                {
                    upperBound = midCandidate - 1;
                }
                else
                {
                    lowerBound = midCandidate + 1;
                }
            }

            return lowerBound;
        }

        private bool BlockSizeIsValid(int[] a, int maxBlockCount, int maxBlockSize)
        {
            int blockSum = 0;
            int blockCount = 0;

            foreach (var element in a)
            {
                if(blockSum + element > maxBlockSize)
                {
                    blockSum = element;
                    blockCount++;
                }
                else
                {
                    blockSum += element;
                }

                if(blockCount >= maxBlockCount)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
