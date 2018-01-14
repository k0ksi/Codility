using System;
using System.Collections.Generic;

namespace FibFrog
{
    class FibFrog
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(new Solution().solution(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 }));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            List<int> steps = new List<int>();
            steps.Add(1);
            steps.Add(1);
            while (true)
            {
                int nextStep = steps[steps.Count - 2]
                        + steps[steps.Count - 1];
                if (nextStep > A.Length + 1)
                {
                    break;
                }
                steps.Add(nextStep);
            }

            int[] minJumpNums = new int[A.Length + 2];
            for (int i = 0; i < minJumpNums.Length; i++)
            {
                minJumpNums[i] = int.MaxValue;
            }
            minJumpNums[0] = 0;
            for (int i = 0; i < minJumpNums.Length; i++)
            {
                if (i == 0 || i == minJumpNums.Length - 1 || A[i - 1] == 1)
                {
                    foreach (int step in steps)
                    {
                        if (step > i)
                        {
                            break;
                        }
                        minJumpNums[i] = (int)Math.Min(minJumpNums[i],
                                (long)minJumpNums[i - step] + 1);
                    }
                }
            }
            return minJumpNums[minJumpNums.Length - 1] == int.MaxValue ? -1
                    : minJumpNums[minJumpNums.Length - 1];
        }
    }
}
