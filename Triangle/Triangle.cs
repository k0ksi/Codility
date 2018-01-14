using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 2, 5, 1, 8, 12 };

            //Console.WriteLine((long)int.MaxValue + int.MaxValue);
            Console.WriteLine(new Solution().solution(arr));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int[] numbers = A;

            Array.Sort(numbers);

            int n = numbers.Length;

            int result = 0;

            if(n >= 3)
            {
                int p;
                int q;
                int r;

                for (int i = 2; i < n; i++)
                {
                    r = numbers[i];
                    q = numbers[i - 1];
                    p = numbers[i - 2];

                    long pq = (long)p + (long)q;
                    long qr = (long)q + (long)r;
                    long rp = (long)r + (long)p;

                    bool isTriangle = pq > r &&
                                      qr > p &&
                                      rp > q;
                    
                    if(isTriangle)
                    {
                        result = 1;
                        //break;
                    }
                }
            }
            
            return result;
        }
    }
}
