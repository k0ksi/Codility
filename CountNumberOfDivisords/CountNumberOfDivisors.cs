using System;

namespace CountNumberOfDivisords
{
    class CountNumberOfDivisors
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversingCoins(20));
        }

        // not sure if that's the right solution
        private static int ReversingCoins(int n)
        {
            int result = 0;
            int[] coins = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                int k = i;
                while(k <= n)
                {
                    coins[k] = (coins[k] + 1) % 2;
                    k += i;
                }

                result += coins[i];
            }

            return result;
        }

        private static int CountDivisors(int n)
        {
            int i = 1;
            int result = 0;
            while(i * i < n)
            {
                if(n % i == 0)
                {
                    result += 2;
                }

                i++;
            }

            if(i * i == n)
            {
                result++;
            }

            return result;
        }

        private static bool PrimalityTest(int n)
        {
            int i = 2;

            while (i * i <= n)
            {
                if(n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }
    }
}
