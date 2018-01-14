using System;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gcd(10, 4));
        }

        private static int Gcd(int a, int b)
        {
            if(a % b == 0)
            {
                return b;
            }
            else
            {
                return Gcd(b, a % b);
            }            
        }
    }
}
