using System;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SieveOfErathosthenes(26));
        }

        static int SieveOfErathosthenes(int n)
        {
            bool[] sieve = new bool[n + 1];

            sieve[0] = false;
            sieve[1] = false;
            int i = 2;
            while (i * i <= n)
            {
                if(sieve[i])
                {
                    int k = i * i;

                    while(k <= n)
                    {
                        sieve[k] = false;

                        k += i;
                    }
                }

                i++;
            }

            return i;
        }
    }
}
