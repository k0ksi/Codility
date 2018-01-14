using System;

namespace FrogRiverOne
{
    class FrogRiverOne
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 1, 3, 2, 1, 3 };

            Console.WriteLine(new Solution().solution(3, array));
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            bool[] leavesInPosition = new bool[X + 1];

            int occupiedPositions = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i];
                if(position <= X && !leavesInPosition[position])
                {
                    leavesInPosition[position] = true;
                    occupiedPositions++;
                }

                if(occupiedPositions == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
