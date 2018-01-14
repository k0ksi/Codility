using System;

namespace MaxProfit
{
    class MaxProfit
    {
        private static void Main()
        {
            int[] A = new int[] { 23171, 21011, 21123, 21366, 21367, 21013 };
            Console.WriteLine(new Solution().solution(A));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int minPossible = int.MaxValue;
            int currentMin = 0;
            int currentProfit = 0;
            int maxProfit = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int current = A[i];
                currentMin = Math.Max(0, current);

                if (i != 0)
                {
                    currentProfit = currentMin - minPossible;
                }
                                
                if(currentMin < minPossible)
                {
                    minPossible = currentMin;
                }

                if (currentMin > minPossible)
                {
                    currentProfit = currentMin - minPossible;

                    if(currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
