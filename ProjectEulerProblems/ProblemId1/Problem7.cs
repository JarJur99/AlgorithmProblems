using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems
{
    public static class Problem7
    {
        /*
         *  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         *  What is the 10 001st prime number?
         */

        public static void Solve()
        {
            int count = 10_001;

            var primes = new List<int>();
            int i = 2;

            while (primes.Count != count)
            {
                if (IsPrime(primes, i))
                    primes.Add(i);
                i++;
            }

            Console.WriteLine($"The prime of number: {count} is {primes[count - 1]}");
            Console.ReadKey();
        }

        public static bool IsPrime(List<int> primes, int numberToCheck)
        {
            return !primes.Any(x => numberToCheck % x == 0);
        }
    }
}