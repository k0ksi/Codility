using System;

namespace Ladder
{
    class Ladder
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(new Solution().solution(new int[] { 4, 4, 5, 5, 1 }, new int[] { 3, 2, 4, 3, 1 }));
        }
    }

    class Solution
    {
        public int[] solution(int[] a, int[] b)
        {
            int[] result = new int[a.Length];

            int n = getMax(a);
            int p = getMax(b);

            int[] cache = buildCache(n, p);

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = cache[a[i]] % (int)Math.Pow(2, b[i]);
            }

            return result;
            
            //int[] fib = new int[n + 2];
            //fib[1] = 1;
            //for (int i = 2; i < n + 1; i++)
            //{
            //    var prev = fib[i - 1];
            //    var beforePrev = fib[i - 2];
            //    fib[i] = prev + beforePrev;
            //}

            //return fib[n];
        }

        private int getMax(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int[] buildCache(int n, int p)
        {
            int[] cache = new int[n + 1];
            int previous = 1;
            int current = 1;

            cache[0] = 1;
            cache[1] = 1;

            int index = 3;

            while (index <= n + 1)
            {
                int temp = current;
                current = (previous + current) % (int)Math.Pow(2, p);
                previous = temp;

                cache[index - 1] = current;

                index++;
            }

            return cache;
        }
    }
}
